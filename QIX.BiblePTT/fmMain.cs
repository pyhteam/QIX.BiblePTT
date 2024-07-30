using QIX.BiblePTT.ControlViews;

namespace QIX.BiblePTT
{
    public partial class fmMain : Form
    {
        public fmMain()
        {
            InitializeComponent();
        }

        private void fmMain_Load(object sender, EventArgs e)
        {
            var bibleControlView = new BibleControlView();
            panelMain.Controls.Add(bibleControlView);
            bibleControlView.Dock = DockStyle.Fill;
        }
    }
}
