using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper; 

namespace Web_api_session2
{
    public class ApiMapperProfile: Profile
    {
        public ApiMapperProfile()
        {
            CreateMap<Model.Monedas, Dto.MonedaDto>()
                .ReverseMap();         
        }
    }
}
