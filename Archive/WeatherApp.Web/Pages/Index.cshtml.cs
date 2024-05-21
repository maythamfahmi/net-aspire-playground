using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.OutputCaching;

namespace WeatherApp.Web.Pages
{
    [StreamRendering(true)]
    [OutputCache(Duration = 10)]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly WeatherApiClient _client;

        public IndexModel(ILogger<IndexModel> logger, WeatherApiClient client)
        {
            _logger = logger;
            _client = client;
        }

        [ViewData]
        public IEnumerable<WeatherForecast> WeatherForecasts { get; set; }

        public async Task OnGet()
        {
            WeatherForecasts = await _client.GetWeatherForecast() ?? Enumerable.Empty<WeatherForecast>();
        }
    }
}
