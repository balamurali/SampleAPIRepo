using Sample.API.Repository.Interfaces;
using Sample.API.Shared;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Sample.API.Repository
{
    public class FlightAwareRepository : IFlightAwareRepository
    {
        private readonly IHttpClientFactory _clientFactory;

        public FlightAwareRepository(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory ?? throw new ArgumentNullException(nameof(clientFactory));
        }

        public async Task<AirportWeather> GetAirportWeather(string airportCode)
        {
            var client = _clientFactory.CreateClient("FlightAware");

            var response = await client.GetAsync(new Uri(client.BaseAddress + "MetarEx?airport=" + airportCode + "&startTime=0&howMany=1&offset=0 "));

            if (response.IsSuccessStatusCode)
            {
                string jsonContent = await response.Content.ReadAsStringAsync();
                return Newtonsoft.Json.JsonConvert.DeserializeObject<AirportWeather>(jsonContent);
            }

            throw new HttpRequestException(string.Format(System.Globalization.CultureInfo.InvariantCulture,
            "Response status code does not indicate success: {0} ({1}).{2}",
            (int)response.StatusCode,
            response.ReasonPhrase,
            response.Content)
            );
        }
       
    }
}
