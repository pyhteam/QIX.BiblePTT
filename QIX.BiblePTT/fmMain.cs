using QIX.BiblePTT.ControlViews;
using QIX.BiblePTT.Services.Interface;

namespace QIX.BiblePTT
{
    public partial class fmMain : Form
    {
        private readonly IBibleService _bibleService;
        private readonly IBookService _bookService;

        public fmMain(IBibleService bibleService, IBookService bookService)
        {
            InitializeComponent();
            _bibleService = bibleService;
            _bookService = bookService;
        }

        private void fmMain_Load(object sender, EventArgs e)
        {
            var bibleControlView = new BibleControlView(_bibleService,_bookService);
            panelMain.Controls.Add(bibleControlView);
            bibleControlView.Dock = DockStyle.Fill;
        }
    }
}
