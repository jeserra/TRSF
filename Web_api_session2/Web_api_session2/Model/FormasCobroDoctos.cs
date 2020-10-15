using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class FormasCobroDoctos
    {
        public int FormaCobroDocId { get; set; }
        public string NomTablaDoctos { get; set; }
        public int DoctoId { get; set; }
        public int FormaCobroId { get; set; }
        public string NumCtaPago { get; set; }
        public string ClaveSisFormaCob { get; set; }
        public string Referencia { get; set; }
        public decimal? Importe { get; set; }
    }
}
