using QIX.BiblePTT.ControlViews;
using QIX.BiblePTT.Services.Interface;

namespace QIX.BiblePTT
{
    public partial class fmMain : Form
    {
        private readonly IBibleService _bibleService;
        private readonly IBookService _bookService;
        private readonly IVerseService _verseService;

        public fmMain(IBibleService bibleService, IBookService bookService, IVerseService verseService)
        {
            InitializeComponent();
            _bibleService = bibleService;
            _bookService = bookService;
            _verseService = verseService;
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

        }

        private void lusSibDhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not yet implemented. (Coming soon!)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
