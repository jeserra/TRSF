using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DatosAdicionales
    {
        public int DatosAdicionalesId { get; set; }
        public string NomTabla { get; set; }
        public int ElemId { get; set; }
        public string TipoReg { get; set; }
        public string Clave { get; set; }
        public string Datos { get; set; }
    }
}
