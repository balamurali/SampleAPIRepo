using Sample.API.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sample.API.Services.Interfaces
{
    public interface IAirportWeatherService
    {
        Task<AirportWeather> GetAirportWeather(string airportCode);
    }
}
