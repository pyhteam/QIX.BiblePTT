using System.Diagnostics;
using System.Reflection;
using Newtonsoft.Json;
using QIX.BiblePTT.Common;
using QIX.BiblePTT.ControlViews;
using QIX.BiblePTT.Services.Interface;

namespace QIX.BiblePTT
{
    public partial class fmMain : Form
    {
        private readonly IBibleService _bibleService;
        private readonly IBookService _bookService;
        private readonly IVerseService _verseService;
        private readonly IHymnBookService _hymnBookService;

        public fmMain(IBibleService bibleService, IBookService bookService, IVerseService verseService, IHymnBookService hymnBookService)
        {
            InitializeComponent();
            _bibleService = bibleService;
            _bookService = bookService;
            _verseService = verseService;
            _hymnBookService = hymnBookService;
        }

        private void fmMain_Load(object sender, EventArgs e)
        {
            CheckUpdate();
            
            var bibleControlView = new BibleControlView(_bibleService, _bookService, _verseService);
            bibleControlView.Dock = DockStyle.Fill;
            panelMain.Controls.Add(bibleControlView);
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fmAbout = new fmAbout();
            fmAbout.ShowDialog();
            // dispose about form when closed
            fmAbout.Dispose();
        }

        private void vajLusKubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // clear panelMain
            panelMain.Controls.Clear();
            // load new BibleControlView
            var bibleControlView = new BibleControlView(_bibleService, _bookService, _verseService);
            bibleControlView.Dock = DockStyle.Fill;
            panelMain.Controls.Add(bibleControlView);
        }

        private void phooNkaujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            var hymnsControlView = new HymnsControlView(_hymnBookService);
            hymnsControlView.Dock = DockStyle.Fill;
            panelMain.Controls.Add(hymnsControlView);

        }

        private void lusSibDhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Qhov no tseem tshim tshiab (Coming soon!)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void updateToolStripMenuItemCheckUpdate_Click(object sender, EventArgs e)
        {
            CheckUpdate();
        }

        private void docToolStripMenuItemTutorial_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sau ntawb facebook mus rau: facebook.com/senms9x", "Ua tsaug!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void CheckUpdate()
        {
            // check connect internet
            if (!Helper.IsConnectedToInternet())
            {
                MessageBox.Show("Koj lub PC tsi muaj internet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // download the version.json file from GitHub API
            // get the current version
            var currentVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync("https://raw.githubusercontent.com/pyhteam/QIX.BiblePTT/master/version.json");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var appVersions = JsonConvert.DeserializeObject<List<AppVersion>>(content);
                    var latestVersion = appVersions.OrderByDescending(x => x.Id).FirstOrDefault();
                    if (currentVersion != latestVersion.Version)
                    {
                        var result = MessageBox.Show("Muaj lwm lub Phầm mềm tshiab! Koj puas xav download", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes && latestVersion?.Url != null)
                        {
                            Process.Start(new ProcessStartInfo(latestVersion.Url) { UseShellExecute = true });
                            Application.Exit();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tsi muaj tshiab", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
        }
    }
}
