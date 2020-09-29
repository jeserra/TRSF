using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApiSample.Models;

namespace WebApiSample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LocationController : ControllerBase
    {
        private readonly ILogger<LocationController> _logger;

        public LocationController(ILogger<LocationController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<LocationDto> GetLocations()
        {
            List<LocationDto> list = new List<LocationDto>()
            {
                new LocationDto () { Name = "Zapopan", Latitud = 23, Longitud = 23 },
                new LocationDto () { Name = "rio Grande", Latitud = 22, Longitud = 99},
                new LocationDto () { Name = "Sombrerete", Latitud = 45, Longitud = 99}
            };

            return list;
        }
    }
}