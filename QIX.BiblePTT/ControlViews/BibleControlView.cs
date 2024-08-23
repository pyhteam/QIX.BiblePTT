
using QIX.BiblePTT.Common;
using QIX.BiblePTT.Models;
using QIX.BiblePTT.Services.Interface;

namespace QIX.BiblePTT.ControlViews
{
    public partial class BibleControlView : UserControl
    {
        private readonly IBibleService _bibleService;
        private readonly IBookService _bookService;
        private readonly IVerseService _verseService;
        private Chapter _chapter = new Chapter();
        private Book _book = new Book();
        private Bible _bible = new Bible();
        public BibleControlView(IBibleService bibleService, IBookService bookService, IVerseService verseService)
        {
            InitializeComponent();
            _bibleService = bibleService;
            _bookService = bookService;
            _verseService = verseService;
            // load all books


        }

        private async void LoadBooks(string bibleCode)
        {
            var books = await _bookService.GetAll(bibleCode, txtSearchBook.Text);
            _book = books.First();
            InitMenuBooks(books);
        }

        private async void btnFilterVerb_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtVerbFrom.Text) || string.IsNullOrEmpty(txtVerbTo.Text))
            {
                MessageBox.Show("Yuav tsum sau nqi", "Thoob Pom", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int from = int.Parse(txtVerbFrom.Text);
            int to = int.Parse(txtVerbTo.Text);
            if (from > to)
            {
                MessageBox.Show("Tsi pub nqi tsi tshem", "Thoob Pom", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var verses = await _verseService.GetFromTo(_chapter.BibleId.ToString(), _chapter.Code, from, to);
            if (verses.Count == 0)
            {
                MessageBox.Show("Nrhiav tsi pum", "Thoob Pom", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            richTextBoxContentSection.Text = $"{_book.Name} {_chapter.Id}:{verses.First().Label}-{verses.Last().Label}\n";
            richTextBoxContentSection.AppendText(string.Join("\n", verses.Select(x => x.Label + ". " + x.Content)));
            ChangeStyleRichTextBox();


        }

        private void ChangeStyleRichTextBox()
        {
            richTextBoxContentSection.Font = new Font(richTextBoxContentSection.Font.FontFamily, richTextBoxContentSection.Font.Size, UpdateFontStyle());
            richTextBoxContentSection.ForeColor = colorPickerTextColor.Value;
            richTextBoxContentSection.SelectAll();
            richTextBoxContentSection.SelectionAlignment = selectTextAlign.Text switch
            {
                "Left" => HorizontalAlignment.Left,
                "Center" => HorizontalAlignment.Center,
                "Right" => HorizontalAlignment.Right,
                _ => HorizontalAlignment.Left,
            };
        }

        private async void LoadBiBle(string filter)
        {
            selectBible.Items.Clear();
            var result = await _bibleService.GetAll(filter);
            // convert the result to a list of objects
            var bibleItems = result
                .Select(x => x.Code + " - " + x.Name)
                .ToArray();
            selectBible.Items.AddRange(bibleItems);
        }

        private async void selectBible_SelectedValueChanged(object sender, object value)
        {
            var selectedBible = selectBible.SelectedValue.ToString();
            var bibleCode = selectedBible.Split('-')[0].Trim();
            _bible = await _bibleService.GetByCode(bibleCode);
            var books = await _bookService.GetAll(bibleCode, txtSearchBook.Text);
            // update the book list with the new filtered books
            InitMenuBooks(books);
        }

        private void BibleControlView_Load(object sender, EventArgs e)
        {
            LoadDefault();
        }

        private void LoadDefault()
        {
            this.LoadBiBle(txtSearchBook.Text);
            selectBible.SelectedIndex = 1;
            this.LoadBooks(_bible.Code);
            this.menuBooks.SelectIndex(0);
            this.LoadChapter(_book);
            foreach (var item in flowLayoutPanelSection.Controls)
            {
                if (item is Button button)
                {
                    button.BackColor = Color.LightBlue;
                    break;
                }
            }
            this.LoadChapterContent(_book.Chapters.First());
            this.LoadFont();
            // load config
            if (File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json")))
            {
                LoadConfig();
            }
        }

        private void selectBible_MouseHover(object sender, EventArgs e)
        {
            // tooltip full text
            var tooltip = new ToolTip();
            tooltip.SetToolTip(selectBible, selectBible.Text);
        }

        private async void menuBooks_SelectChanged(object sender, AntdUI.MenuItem item)
        {

            var book = System.Text.Json.JsonSerializer.Deserialize<Book>(item.Tag.ToString());
            _book = book;
            if (book != null)
            {
                LoadChapter(book);
                // load all verses for the first chapter
                richTextBoxContentSection.Text = "";
            }
        }

        private void LoadChapter(Book book)
        {
            flowLayoutPanelSection.Controls.Clear();
            int position = 0;
            foreach (var chapter in book.Chapters)
            {
                var btn = new Button();
                btn.Name = "btnChapter" + chapter.Id;
                btn.Text = chapter.Id.ToString();
                btn.Tag = chapter;
                btn.TabIndex = chapter.Id;
                btn.Click += btnChapter_Click;
                btn.Location = new Point(3, 3);
                btn.Size = new Size(35, 33);
                flowLayoutPanelSection.Controls.Add(btn);
                position += 3;
            }
        }

        private void btnChapter_Click(object? sender, EventArgs e)
        {
            var btn = (Button)sender;
            txtVerbFrom.Text = "1";
            txtVerbTo.Text = "2";
            txtVerbFrom.Value = 1;
            txtVerbTo.Value = 2;
            // find btn in panel
            foreach (var item in flowLayoutPanelSection.Controls)
            {
                if (item is Button button && button.Name == btn.Name)
                {
                    button.BackColor = Color.LightBlue;
                }
                else if (item is Button otherButton)
                {
                    otherButton.BackColor = Color.White;
                }
            }
            var chapter = (Chapter)btn.Tag;
            // load the chapter content
            LoadChapterContent(chapter);
        }

        private async void LoadChapterContent(Chapter chapter)
        {
            var verse = await _verseService.GetByChapter(_bible.Id, chapter.Code);
            if (verse.Count == 0)
            {
                MessageBox.Show("Nrhiav tsi pum", "Thoob Pom", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            richTextBoxContentSection.Text = $"{_book.Name} {chapter.Id}:{verse.First().Label}-{verse.Last().Label}\n";
            richTextBoxContentSection.AppendText(string.Join("\n", verse.Select(x => x.Label + ". " + x.Content)));
            _chapter = chapter;
            txtVerbFrom.Value = 1;
            txtVerbTo.Value = verse.Count;

            ChangeStyleRichTextBox();

        }

        private async void btnShowPTT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtVerbFrom.Text) || string.IsNullOrEmpty(txtVerbTo.Text))
            {
                MessageBox.Show("Yuav tsum sau nqi", "Thoob Pom", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int from = int.Parse(txtVerbFrom.Text);
            int to = int.Parse(txtVerbTo.Text);
            // temp path to save the powerpoint file
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "outputs", _bible.Code + "_" + _book.Code + "_" + _chapter.Code + $"-{from}-{to}_" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pptx");
            if (!Directory.Exists(Path.GetDirectoryName(path)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(path));
            }
            var config = new ConfigView
            {
                FontFamily = richTextBoxContentSection.Font.FontFamily.Name,
                FontSize = richTextBoxContentSection.Font.Size,
                FontStyle = UpdateFontStyle(),
                Color = colorPickerTextColor.Value,
                TextAlign = selectTextAlign.Text,
                ImageBase64 = Convert.ToBase64String((byte[])new ImageConverter().ConvertTo(pictureBoxBackground.Image, typeof(byte[]))),
                TypeShow = 0
            };



            var verses = await _verseService.GetFromTo(_chapter.BibleId.ToString(), _chapter.Code, from, to);
            foreach (var verse in verses.ToList())
            {
                verse.Content = verse.Content.Replace("\n", " ");
                verse.Content = verse.Content.Replace("\t", " ");
            }

            var showPTTX = new ShowPPTX
            {
                FilePath = path,
                BibleName = _bible.Name,
                BookName = _book.Name,
                ChapterNumber = _chapter.Id,
                Verses = verses,
                Config = config
            };

            string jsonData = System.Text.Json.JsonSerializer.Serialize(showPTTX);
            // PowerPointHelper.ExportPPT(jsonData);
            PowerPointHelper.ExportWithApplication(jsonData);
        }

        // load all font in the system
        private void LoadFont()
        {
            var fonts = FontFamily.Families;
            selectFont.Items.Clear();
            selectFont.ListAutoWidth = true;
            foreach (var font in fonts)
            {
                selectFont.Items.Add(font.Name);
            }
            selectFont.SelectedIndex = 0;
            // set default font
            richTextBoxContentSection.Font = new Font("Arial", 30);

            // FontSize
            txtFontSize.Value = 30;
            colorPickerTextColor.Value = Color.Black;
            selectTextAlign.SelectedIndex = 0;
        }

        private void InitMenuBooks(List<Book> books)
        {
            menuBooks.Items.Clear();
            foreach (var book in books)
            {
                var item = new AntdUI.MenuItem(book.Code + " - " + book.Name);
                item.Tag = System.Text.Json.JsonSerializer.Serialize(book).ToString();
                menuBooks.Items.Add(item);
            }
        }

        private async void txtSearchBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            string filter = txtSearchBook.Text;
            if (filter.Length > 3 || e.KeyChar == (char)Keys.Enter)
            {
                var books = await _bookService.GetAll(_bible.Code, filter);
                InitMenuBooks(books);
            }
        }

        private void selectFont_SelectedValueChanged(object sender, object value)
        {
            float fontSize = float.Parse(txtFontSize.Value.ToString());
            richTextBoxContentSection.Font = new Font(selectFont.SelectedValue.ToString(), fontSize == 0 ? 30 : fontSize, UpdateFontStyle());
        }

        private void txtFontSize_ValueChanged(object sender, decimal value)
        {
            float fontSize = float.Parse(txtFontSize.Value.ToString());
            if (richTextBoxContentSection.Font != null)
            {
                if (richTextBoxContentSection.InvokeRequired)
                {
                    richTextBoxContentSection.Invoke(new Action(() =>
                    {
                        richTextBoxContentSection.Font = new Font(richTextBoxContentSection.Font.FontFamily, fontSize, UpdateFontStyle());
                    }));
                }
                else
                {
                    richTextBoxContentSection.Font = new Font(richTextBoxContentSection.Font.FontFamily, fontSize, UpdateFontStyle());
                }
            }
        }

        private void checkboxUnderline_CheckedChanged(object sender, bool value)
        {
            UpdateFontStyle();
        }

        private void checkboxItalic_CheckedChanged(object sender, bool value)
        {
            UpdateFontStyle();
        }

        private void checkboxBold_CheckedChanged(object sender, bool value)
        {
            UpdateFontStyle();
        }

        private FontStyle UpdateFontStyle()
        {
            FontStyle style = FontStyle.Regular;
            if (checkboxUnderline.Checked)
            {
                style |= FontStyle.Underline;
            }
            if (checkboxItalic.Checked)
            {
                style |= FontStyle.Italic;
            }
            if (checkboxBold.Checked)
            {
                style |= FontStyle.Bold;
            }
            richTextBoxContentSection.Font = new Font(richTextBoxContentSection.Font, style);
            return style;
        }

        private void colorPickerTextColor_ValueChanged(object sender, Color value)
        {
            richTextBoxContentSection.ForeColor = value;
        }

        private void selectTextAlign_SelectedIndexChanged(object sender, int value)
        {
            string align = selectTextAlign.Text;
            richTextBoxContentSection.SelectAll();
            richTextBoxContentSection.SelectionAlignment = align switch
            {
                "Left" => HorizontalAlignment.Left,
                "Center" => HorizontalAlignment.Center,
                "Right" => HorizontalAlignment.Right,
                _ => HorizontalAlignment.Left,
            };
        }

        private void linkLabelChooseImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var image = Image.FromFile(openFileDialog.FileName);
                Clipboard.SetImage(image);
                pictureBoxBackground.Image = image;
                pictureBoxBackground.SizeMode = PictureBoxSizeMode.StretchImage;
                linkLabelChooseImage.Text = openFileDialog.FileName;
            }
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            var config = new ConfigView
            {
                FontFamily = richTextBoxContentSection.Font.FontFamily.Name,
                FontSize = richTextBoxContentSection.Font.Size,
                FontStyle = UpdateFontStyle(),
                Color = colorPickerTextColor.Value,
                TextAlign = selectTextAlign.Text,
                ImageBase64 = Convert.ToBase64String((byte[])new ImageConverter().ConvertTo(pictureBoxBackground.Image, typeof(byte[]))),
            };
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(config);
            // path to save config
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json");
            File.WriteAllText(path, json);
            MessageBox.Show("Saved config successfully", "Thoob Pom", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadConfig()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json");
            if (File.Exists(path))
            {
                var json = File.ReadAllText(path);
                var config = Newtonsoft.Json.JsonConvert.DeserializeObject<ConfigView>(json);
                if (config != null)
                {
                    richTextBoxContentSection.Font = new Font(new FontFamily(config.FontFamily), config.FontSize ?? 20, config.FontStyle.Value);
                    richTextBoxContentSection.ForeColor = config.Color.Value;
                    richTextBoxContentSection.SelectAll();
                    richTextBoxContentSection.SelectionAlignment = config.TextAlign switch
                    {
                        "Left" => HorizontalAlignment.Left,
                        "Center" => HorizontalAlignment.Center,
                        "Right" => HorizontalAlignment.Right,
                        _ => HorizontalAlignment.Left,
                    };
                    txtFontSize.Value = (decimal)(config.FontSize ?? 12);
                    colorPickerTextColor.Text = config.Color.Value.Name;
                    colorPickerTextColor.Value = config.Color.Value;
                    selectTextAlign.SelectedIndex = config.TextAlign switch
                    {
                        "Left" => 0,
                        "Center" => 1,
                        "Right" => 2,
                        _ => 0,
                    };
                    selectFont.SelectedIndex = selectFont.Items.IndexOf(config.FontFamily);

                    // check bold, italic, underline
                    if (config.FontStyle.Value.HasFlag(FontStyle.Bold))
                    {
                        checkboxBold.Checked = true;
                    }
                    if (config.FontStyle.Value.HasFlag(FontStyle.Italic))
                    {
                        checkboxItalic.Checked = true;
                    }
                    if (config.FontStyle.Value.HasFlag(FontStyle.Underline))
                    {
                        checkboxUnderline.Checked = true;
                    }

                    if (!string.IsNullOrEmpty(config.ImageBase64))
                    {
                        linkLabelChooseImage.Text = config.ImageBase64;
                        pictureBoxBackground.Image = Image.FromStream(new MemoryStream(Convert.FromBase64String(config.ImageBase64)));
                        pictureBoxBackground.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
            }
        }

        private void btnRemoveBackground_Click(object sender, EventArgs e)
        {
            linkLabelChooseImage.Text = "Choose Image";
            pictureBoxBackground.Image = null;
            selectFont.SelectedValue = "Arial";
            selectTextAlign.SelectedValue = "Left";
            checkboxBold.Checked = false;
            checkboxItalic.Checked = false;
            checkboxUnderline.Checked = false;
            colorPickerTextColor.Value = Color.Black;
            richTextBoxContentSection.Font = new Font("Arial", 20);
            txtFontSize.Value = 20;
            // remove file config
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json");
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            MessageBox.Show("Reset config successfully", "Thoob Pom", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
