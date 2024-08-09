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
            MessageBox.Show("This feature is not yet implemented. (Coming soon!)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void updateToolStripMenuItemCheckUpdate_Click(object sender, EventArgs e)
        {
            // get the current version
            var currentVersion =  Assembly.GetAssembly(typeof(fmMain)).GetName().Version.ToString();
            using( var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync("https://raw.githubusercontent.com/pyhteam/QIX.BiblePTT/master/version.json");
                if(response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var latestVersion = JsonConvert.DeserializeObject<List<AppVersion>>(content);
                    if(currentVersion != latestVersion.OrderByDescending(x => x.Id).FirstOrDefault().Version)
                    {
                        MessageBox.Show("There is a new version available. Please download the latest version from the website.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("You are using the latest version.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
            }
        }

        private void docToolStripMenuItemTutorial_Click(object sender, EventArgs e)
        {

        }
    }
}
