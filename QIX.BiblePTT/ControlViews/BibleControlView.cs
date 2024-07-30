

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
                // Deserialize JSON to JsonElement
                JsonElement root = JsonSerializer.Deserialize<JsonElement>(result.Data);
                // Access properties
                if (root.GetProperty("response").GetProperty("code").GetInt32() == 200)
                {
                    // Get data
                    JsonElement versions = root.GetProperty("response").GetProperty("data").GetProperty("versions");

                    // Bind data to combobox
                    foreach (JsonElement version in versions.EnumerateArray())
                    {
                        selectBible.Items.Add(version.GetProperty("local_title").GetString());
                    }
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
