

using QIX.BiblePTT.Common;

namespace QIX.BiblePTT.Services
{
    public class BibleService : IBibleService
    {
        private HttpClient _client;
        public BibleService(HttpClient client)
        {
            _client = client ?? new HttpClient();
        }
        public async Task<ApiResponse> GetBibles(string language_tag, string type)
        {
            var result = new ApiResponse();
            try
            {
                var url = $"{ConstBibleAPI.Host}{ConstBibleAPI.GetBible}?language_tag={language_tag}&type={type}";
                var response = await _client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    result.Success = true;
                    result.Data = content;
                    return result;
                }
                result.Success = false;
                result.Message = response.ReasonPhrase;
                return result;

            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
                return result;
            }

        }
    }
}