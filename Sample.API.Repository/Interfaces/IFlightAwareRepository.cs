using Sample.API.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sample.API.Repository.Interfaces
{
    public interface IFlightAwareRepository
    {
        Task<AirportWeather> GetAirportWeather(string airportCode);
    }
}
