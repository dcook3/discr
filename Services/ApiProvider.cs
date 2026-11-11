using Discr.Models;
using Microsoft.Extensions.Options;

namespace Discr.Services
{
    public class ApiProvider(HttpClient http, IOptions<ApiSettings> options) : IApiProvider
    {
        private readonly string _apiKey = options.Value.ApiKey;

        public async Task<string> GetAsync(string url)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Add("Authorization", $"Bearer {_apiKey}");
            var response = await http.SendAsync(request);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
