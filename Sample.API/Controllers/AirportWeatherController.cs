using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sample.API.Services.Interfaces;
using Sample.API.Shared;

namespace Sample.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AirportWeatherController : ControllerBase
    {
        private readonly IAirportWeatherService _service;

        public AirportWeatherController(IAirportWeatherService service)
        {
            _service = service?? throw new ArgumentNullException(nameof(service)); 
        }

        [HttpGet]
        public async Task<IActionResult> Get(string airportCode)
        {
            if (string.IsNullOrWhiteSpace(airportCode))
                return BadRequest("Invalid airport code");

            return Ok(await _service.GetAirportWeather("KJFK"));
        }
    }
}
