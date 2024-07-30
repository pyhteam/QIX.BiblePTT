

using QIX.BiblePTT.Services;
using System.Text.Json;

namespace QIX.BiblePTT.ControlViews
{
    public partial class BibleControlView : UserControl
    {
        private readonly IBibleService _bibleService;
        public BibleControlView(IBibleService bibleService)
        {
            InitializeComponent();
            _bibleService = bibleService;
        }

        private void btnFilterVerb_Click(object sender, EventArgs e)
        {

        }

        private async void LoadBiBle()
        {
            var result = await _bibleService.GetBibles("mww", "all");
            if (result.Success)
            {
                // get json parse to dynamic
                dynamic data = JsonSerializer.Deserialize<dynamic>(result.Data);
                if (data.response.code == 200)
                {
                    // get data
                    var bibles = data.data;
                    // bind data to combobox
                    selectBible.Items.AddRange(bibles.versions);
                }
            }
        }

        private void selectBible_SelectedValueChanged(object sender, object value)
        {

        }

        private void BibleControlView_Load(object sender, EventArgs e)
        {
            this.LoadBiBle();
        }
    }
}
