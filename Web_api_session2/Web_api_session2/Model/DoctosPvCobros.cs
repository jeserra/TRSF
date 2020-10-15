using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DoctosPvCobros
    {
        public DoctosPvCobros()
        {
            DoctosPvCobrosRefer = new HashSet<DoctosPvCobrosRefer>();
        }

        public int DoctoPvCobroId { get; set; }
        public int DoctoPvId { get; set; }
        public string Tipo { get; set; }
        public int FormaCobroId { get; set; }
        public decimal? Importe { get; set; }
        public decimal? TipoCambio { get; set; }
        public decimal? ImporteMonDoc { get; set; }

        public virtual DoctosPv DoctoPv { get; set; }
        public virtual FormasCobro FormaCobro { get; set; }
        public virtual MovtosEfvoCaja MovtosEfvoCaja { get; set; }
        public virtual ICollection<DoctosPvCobrosRefer> DoctosPvCobrosRefer { get; set; }
    }
}
