using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DoctosPvCobrosRefer
    {
        public int DoctoPvCobroId { get; set; }
        public int FormaCobroReferId { get; set; }
        public string Referencia { get; set; }

        public virtual DoctosPvCobros DoctoPvCobro { get; set; }
        public virtual FormasCobroRefer FormaCobroRefer { get; set; }
    }
}
