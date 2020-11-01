using Sample.API.Repository.Interfaces;
using Sample.API.Services.Interfaces;
using Sample.API.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sample.API.Services
{
    public class AirportWeatherService : IAirportWeatherService
    {
        private readonly IFlightAwareRepository _repository;

        public AirportWeatherService(IFlightAwareRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<AirportWeather> GetAirportWeather(string airportCode)
        {
            return await _repository.GetAirportWeather(airportCode);
        }
    }
}
