using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSample.Models
{
    public class LocationDto
    {
        public string Name { get; set; }
        public int Latitud { get; set; }
        public int Longitud { get; set; }
    }
}
