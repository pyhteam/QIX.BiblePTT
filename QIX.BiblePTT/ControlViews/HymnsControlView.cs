
using System.Data;
using System.Diagnostics;
using AntdUI;
using Newtonsoft.Json;
using QIX.BiblePTT.Common;
using QIX.BiblePTT.Models;
using QIX.BiblePTT.Services.Interface;

namespace QIX.BiblePTT.ControlViews
{
    public partial class HymnsControlView : UserControl
    {
        private readonly IHymnBookService _hymnBookService;
        private List<HymnBook> HymnBooks { get; set; }
        private List<Hymn> Hymns { get; set; }
        private Hymn Hymn { get; set; }
        private string PathConfig { get; set; } = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config_hymns.json");
        public HymnsControlView(IHymnBookService hymnBookService)
        {
            InitializeComponent();
            _hymnBookService = hymnBookService;
        }

        private void HymnsControlView_Load(object sender, EventArgs e)
        {
            LoadBookHymn();
            LoadMenuHymn(HymnBooks[0].Hymns);
            LoadFont();
            LoadConfig();
        }

        #region  Method
        private async void LoadBookHymn()
        {
            HymnBooks = await _hymnBookService.GetAll();
            var dataSelect = HymnBooks.Select(x => x.Id + " - " + x.Name).ToArray();
            selectHymn.Items.AddRange(dataSelect);
            selectHymn.SelectedIndex = 0;
        }

        private void LoadMenuHymn(List<Hymn> hymns)
        {
            menuHymns.Items.Clear();
            foreach (var hymn in hymns)
            {
                var item = new AntdUI.MenuItem(hymn.Id + " - " + hymn.Name);
                item.Tag = JsonConvert.SerializeObject(hymn);
                menuHymns.Items.Add(item);
            }
        }

        private void LoadHymnVerses(Hymn? hymn)
        {
            if (hymn != null)
            {
                richTextBoxContentSection.Text = $"{hymn.Label} {hymn.Name} \n \n";
                for (int i = 0; i < hymn.Verses.Count; i++)
                {
                    richTextBoxContentSection.Text += hymn.Verses[i].Content + "\n \n";
                }
            }
            txtVerbFrom.Value = hymn.Verses.First().Id;
            txtVerbTo.Value = hymn.Verses.Last().Id;

            Hymn = hymn;
        }


        private void LoadFont()
        {
            var fonts = FontFamily.Families;
            selectFont.Items.Clear();
            selectFont.ListAutoWidth = true;
            foreach (var font in fonts)
            {
                selectFont.Items.Add(font.Name);
            }
            selectFont.SelectedValue = "Arial";
            // set default font
            // FontSize
            txtFontSize.Value = 20;
            colorPickerTextColor.Value = Color.Black;
            selectTextAlign.SelectedIndex = 0;
            // display
            richTextBoxContentSection.Font = new Font(selectFont.Text, 20);
            richTextBoxContentSection.SelectionAlignment = HorizontalAlignment.Left;
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

        private void LoadConfig()
        {
            if (File.Exists(PathConfig))
            {
                var json = File.ReadAllText(PathConfig);
                var config = System.Text.Json.JsonSerializer.Deserialize<ConfigView>(json);
                if (config != null)
                {
                    richTextBoxContentSection.Font = new Font(new FontFamily(config.FontFamily), config.FontSize ?? 20, config.FontStyle);
                    richTextBoxContentSection.ForeColor = config.Color;
                    richTextBoxContentSection.SelectAll();
                    richTextBoxContentSection.SelectionAlignment = config.TextAlign switch
                    {
                        "Left" => HorizontalAlignment.Left,
                        "Center" => HorizontalAlignment.Center,
                        "Right" => HorizontalAlignment.Right,
                        _ => HorizontalAlignment.Left,
                    };
                    txtFontSize.Value = (decimal)(config.FontSize ?? 12);
                    colorPickerTextColor.Text = config.Color.Name;
                    colorPickerTextColor.Value = Color.FromArgb(config.Color.R, config.Color.G, config.Color.B);
                    selectTextAlign.SelectedIndex = config.TextAlign switch
                    {
                        "Left" => 0,
                        "Center" => 1,
                        "Right" => 2,
                        _ => 0,
                    };
                    selectFont.SelectedIndex = selectFont.Items.IndexOf(config.FontFamily);

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

                    if (!string.IsNullOrEmpty(config.ImagePath) && File.Exists(config.ImagePath))
                    {
                        linkLabelChooseImage.Text = config.ImagePath;
                        pictureBoxBackground.Image = Image.FromFile(config.ImagePath);
                        pictureBoxBackground.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
            }
        }

        #endregion End Method

        private void selectFont_SelectedValueChanged(object sender, object value)
        {
            float fontSize = float.Parse(txtFontSize.Value.ToString());
            richTextBoxContentSection.Font = new Font(selectFont.SelectedValue.ToString(), fontSize == 0 ? 20 : fontSize);
        }

        private void selectHymn_SelectedValueChanged(object sender, object value)
        {
            int hymnBookId = Convert.ToInt32(selectHymn.SelectedValue.ToString().Split(" - ")[0]);
            Hymns = HymnBooks.FirstOrDefault(x => x.Id == hymnBookId)?.Hymns;
            if (Hymns != null)
            {
                LoadMenuHymn(Hymns);
            }
        }

        private void menuHymns_SelectChanged(object sender, MenuItem item)
        {
            var hymn = JsonConvert.DeserializeObject<Hymn>(item.Tag.ToString());
            LoadHymnVerses(hymn);
        }



        private void txtSearchHymn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // check txtSearchHymn.Text not is number
                if (!int.TryParse(txtSearchHymn.Text, out _) && !string.IsNullOrEmpty(txtSearchHymn.Text))
                {
                    MessageBox.Show("Sau zaj nkauj lub xub xwb.", "Thoob Pom", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // search by id hymn in list hymns and load menu hymn
                if (!string.IsNullOrEmpty(txtSearchHymn.Text))
                {

                    var search = int.Parse(txtSearchHymn.Text);
                    var hymns = Hymns.Where(x => x.Id == search).ToList();
                    LoadMenuHymn(hymns);
                }
                else
                {
                    LoadMenuHymn(Hymns);
                }
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
                ImagePath = linkLabelChooseImage.Text
            };
            var json = System.Text.Json.JsonSerializer.Serialize(config);
            // path to save config
            File.WriteAllText(PathConfig, json);
            MessageBox.Show("Saved config successfully", "Thoob Pom", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRemoveBackground_Click(object sender, EventArgs e)
        {
            linkLabelChooseImage.Text = "Choose Image";
            pictureBoxBackground.Image = null;
            selectFont.SelectedValue = "Arial";
            selectTextAlign.SelectedIndex = 0;
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

        private void selectTextAlign_SelectedValueChanged(object sender, object value)
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

        private void linkLabelChooseImage_Click(object sender, EventArgs e)
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

        private void colorPickerTextColor_ValueChanged(object sender, Color value)
        {
            richTextBoxContentSection.ForeColor = value;
        }

        private void btnFilterVerb_Click(object sender, EventArgs e)
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
            var verses = Hymn.Verses.Where(x => x.Id >= from && x.Id <= to).ToList();
            if (verses.Count == 0)
            {
                MessageBox.Show("Nrhiav tsi pum", "Thoob Pom", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            richTextBoxContentSection.Text = $"{Hymn.Id} {Hymn.Name}\n \n";
            richTextBoxContentSection.AppendText(string.Join("\n \n", verses.Select(x => x.Content)));
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
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "outputs", "hymns", Hymn.Id + "_" + Hymn.Name + $"_{from}_{to}_" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pptx");
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
                ImagePath = linkLabelChooseImage.Text,
                TypeShow = 1
            };



            var verses = Hymn.Verses.Where(x => x.Id >= from && x.Id <= to).Select(x => new Verse()
            {
                BibleId = "",
                ChapterCode = "",
                Label = x.Id.ToString(),
                VerseCode = x.Id.ToString(),
                Content = x.Content
            }).ToList();

            var showPTTX = new ShowPPTX
            {
                FilePath = path,
                BibleName = selectHymn.Text,
                BookName = Hymn.Name,
                ChapterNumber = Hymn.Label,
                Verses = verses,
                Config = config,
            };
            //PowerPointHelper.CreatePresentation(showPTTX);
            string jsonData = System.Text.Json.JsonSerializer.Serialize(showPTTX);
            string path_create_pptx = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "create_pptx.exe");
            // check exe file exists
            if (!File.Exists(path_create_pptx))
            {
                MessageBox.Show("Tsis muaj create_pptx.exe", "Thoob Pom", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = path_create_pptx,
                    RedirectStandardInput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            process.Start();
            using (var writer = process.StandardInput)
            {
                if (writer.BaseStream.CanWrite)
                {
                    await writer.WriteLineAsync(jsonData);
                }
            }

            process.WaitForExit();
        }
    }
}
