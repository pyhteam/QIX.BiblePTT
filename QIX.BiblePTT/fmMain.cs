using QIX.BiblePTT.ControlViews;
using QIX.BiblePTT.Services;

namespace QIX.BiblePTT
{
    public partial class fmMain : Form
    {
        private readonly IBibleService _bibleService;
        public fmMain(IBibleService bibleService)
        {
            InitializeComponent();
            _bibleService = bibleService;
        }

        private void fmMain_Load(object sender, EventArgs e)
        {
            var bibleControlView = new BibleControlView(_bibleService);
            panelMain.Controls.Add(bibleControlView);
            bibleControlView.Dock = DockStyle.Fill;
        }
    }
}
