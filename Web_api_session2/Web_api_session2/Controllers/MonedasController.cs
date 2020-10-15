using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_api_session2.Dto;
using Web_api_session2.Model;

namespace Web_api_session2.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MonedasController : ControllerBase
    {
        private MicrosipContext db;
        public MonedasController(MicrosipContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public IEnumerable<MonedaDto> Get()
        {
            

            foreach (var item in db.Monedas.ToList())
                yield return new MonedaDto()
                {
                    Nombre = item.Nombre,
                    ClaveFiscal = item.ClaveFiscal,
                    Simbolo = item.Simbolo
                };
            
        }

        [Route("ByName/{nombre}")]
        [HttpGet]
        public List<Monedas> GetByName (String nombre)
        {
            return db.Monedas.Where(x => x.Nombre == nombre).ToList();
        }
    }
}