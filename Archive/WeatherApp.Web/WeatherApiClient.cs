using Microsoft.Net.Http.Headers;

namespace WeatherApp.Web
{
    public class WeatherApiClient
    {
        private readonly HttpClient _httpClient;

        public WeatherApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;

            //_httpClient.BaseAddress = new Uri("https://api.github.com/");

            //// using Microsoft.Net.Http.Headers;
            //// The GitHub API requires two headers.
            //_httpClient.DefaultRequestHeaders.Add(
            //    HeaderNames.Accept, "application/vnd.github.v3+json");
            //_httpClient.DefaultRequestHeaders.Add(
            //    HeaderNames.UserAgent, "HttpRequestsSample");
        }

        public HttpClient GetHttpClient()
        {
            return _httpClient;
        }

        public async Task<IEnumerable<WeatherForecast>?> GetWeatherForecast() =>
            await _httpClient.GetFromJsonAsync<IEnumerable<WeatherForecast>>(
                "WeatherForecast");
    }
}
