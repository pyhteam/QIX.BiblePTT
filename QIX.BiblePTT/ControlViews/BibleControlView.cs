
using QIX.BiblePTT.Services;
using QIX.BiblePTT.Services.Interface;

namespace QIX.BiblePTT.ControlViews
{
    public partial class BibleControlView : UserControl
    {
        private readonly IBibleService _bibleService;
        private readonly IBookService _bookService;
        public BibleControlView(IBibleService bibleService, IBookService bookService)
        {
            InitializeComponent();
            _bibleService = bibleService;
            _bookService = bookService;
        }

        private void btnFilterVerb_Click(object sender, EventArgs e)
        {

        }

        private async void LoadBiBle(string filter)
        {
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
            var books = await _bookService.GetAll(bibleCode, txtSearchBook.Text);
            // update the book list with the new filtered books
            menuBooks.Items.Clear();
            foreach (var book in books)
            {
                var item = new AntdUI.MenuItem(book.Code + " - " + book.Name);
                // send book code to the event handler
                item.Tag = book.Code;
                menuBooks.Items.Add(item);
            }
        }

        private void book_Click(object? sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;
            if (menuItem != null)
            {
                var bookCode = menuItem.Tag.ToString();
                // Use the bookCode as needed
            }
        }

        private void BibleControlView_Load(object sender, EventArgs e)
        {
            this.LoadBiBle(txtSearchBook.Text);
        }

        private void selectBible_MouseHover(object sender, EventArgs e)
        {
            // tooltip full text
            var tooltip = new ToolTip();
            tooltip.SetToolTip(selectBible, selectBible.Text);
        }
    }
}
