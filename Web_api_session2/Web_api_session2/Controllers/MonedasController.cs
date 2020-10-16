using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_api_session2.Dto;
using Web_api_session2.Model;
using AutoMapper;

namespace Web_api_session2.Controllers
{


    [Route("[controller]")]
    [ApiController]
    public class MonedasController : ControllerBase
    {
        private readonly IMapper _mapper;

        private MicrosipContext db;
        public MonedasController(MicrosipContext db,
            IMapper mapper)
        {
            this.db = db;
            this._mapper = mapper;

        }

        [HttpGet]
        public IEnumerable<MonedaDto> Get()
        {
            foreach (var item in db.Monedas.ToList())
                yield return _mapper.Map<MonedaDto>(item);            
        }

        [Route("ByName/{nombre}")]
        [HttpGet]
        public List<Monedas> GetByName (String nombre)
        {
            return db.Monedas.Where(x => x.Nombre == nombre).ToList();
        }

        [HttpPost]
        public int Post (MonedaDto moneda)
        {
            return 1;
        }
    }
}