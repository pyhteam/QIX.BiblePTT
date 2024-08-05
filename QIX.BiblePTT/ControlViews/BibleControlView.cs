
using QIX.BiblePTT.Common;
using QIX.BiblePTT.Models;
using QIX.BiblePTT.Services;
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
            richTextBoxContentSection.Text = $"{_book.Name}:{_chapter.Id}  {verses.First().Label}-{verses.Last().Label}\n";
            richTextBoxContentSection.AppendText(string.Join("\n", verses.Select(x => x.Label + ". " + x.Content)));

            // backColor to btn
            foreach (var item in flowLayoutPanelSection.Controls)
            {
                if (item is Button button && button.TabIndex >= from && button.TabIndex <= to)
                {
                    button.BackColor = Color.LightBlue;
                }
                else if (item is Button otherButton)
                {
                    otherButton.BackColor = Color.White;
                }

            }
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
            selectBible.SelectedIndex = 0;
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
            if (book != null)
            {
                LoadChapter(book);
                // load all verses for the first chapter
                LoadChapterContent(book.Chapters.First());
            }
            _book = book;
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
            richTextBoxContentSection.Text = $"{_book.Name}:{chapter.Id}  {verse.First().Label}-{verse.Last().Label}\n";
            richTextBoxContentSection.AppendText(string.Join("\n", verse.Select(x => x.Label + ". " + x.Content)));
            _chapter = chapter;
        }

        private void btnShowPTT_Click(object sender, EventArgs e)
        {

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
            richTextBoxContentSection.Font = new Font("Arial", 12);

            // FontSize
            txtFontSize.Value = 12;
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
            richTextBoxContentSection.Font = new Font(selectFont.SelectedValue.ToString(), fontSize == 0 ? 12 : fontSize);
        }

        private void txtFontSize_ValueChanged(object sender, decimal value)
        {
            float fontSize = float.Parse(txtFontSize.Value.ToString());
            richTextBoxContentSection.Font = new Font(selectFont.SelectedValue.ToString(), fontSize == 0 ? 12 : fontSize);
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
            string imageBase64 = null;
            if (linkLabelChooseImage.Text != "Choose Image")
            {
                using (var ms = new MemoryStream())
                {
                    pictureBoxBackground.Image.Save(ms, pictureBoxBackground.Image.RawFormat);
                    imageBase64 = Convert.ToBase64String(ms.ToArray());
                }
            }

            var config = new ConfigView
            {
                FontFamily = richTextBoxContentSection.Font.FontFamily.Name,
                FontSize = richTextBoxContentSection.Font.Size,
                FontStyle = UpdateFontStyle(),
                Color = colorPickerTextColor.Value,
                HorizontalAlignment = richTextBoxContentSection.SelectionAlignment,
                ImageBase64 = imageBase64
            };
            var json = System.Text.Json.JsonSerializer.Serialize(config);
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
                var config = System.Text.Json.JsonSerializer.Deserialize<ConfigView>(json);
                if (config != null)
                {
                    richTextBoxContentSection.Font = new Font(config.FontFamily, config.FontSize, config.FontStyle);
                    richTextBoxContentSection.ForeColor = config.Color;
                    richTextBoxContentSection.SelectionAlignment = config.HorizontalAlignment;
                    txtFontSize.Value = (decimal)config.FontSize;
                    colorPickerTextColor.Value = config.Color;
                    selectTextAlign.SelectedIndex = config.HorizontalAlignment == HorizontalAlignment.Left ? 0 : 
                    config.HorizontalAlignment == HorizontalAlignment.Center ? 1 : 2;
                    
                    // check bold, italic, underline
                    if (config.FontStyle.HasFlag(FontStyle.Bold))
                    {
                        checkboxBold.Checked = true;
                    }
                    if (config.FontStyle.HasFlag(FontStyle.Italic))
                    {
                        checkboxItalic.Checked = true;
                    }
                    if (config.FontStyle.HasFlag(FontStyle.Underline))
                    {
                        checkboxUnderline.Checked = true;
                    }

                    if (!string.IsNullOrEmpty(config.ImageBase64))
                    {
                        var imageBytes = Convert.FromBase64String(config.ImageBase64);
                        using (var ms = new MemoryStream(imageBytes))
                        {
                            pictureBoxBackground.Image = Image.FromStream(ms);
                            pictureBoxBackground.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }
                }
            }
        }
    }
}
