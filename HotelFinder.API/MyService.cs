using System.Net.Http;
using System.Threading.Tasks;

namespace HotelFinder.API
{
    public class MyService
    {
        private readonly HttpClient _httpClient;

        public MyService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetDataFromWebServiceAsync(string endpoint)
        {
            var response = await _httpClient.GetAsync(endpoint);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }
    }

}
