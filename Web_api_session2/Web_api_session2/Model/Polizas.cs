using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class Polizas
    {
        public Polizas()
        {
            PolizasCfdi = new HashSet<PolizasCfdi>();
        }

        public int PolizaId { get; set; }
        public int ProcesoId { get; set; }
        public int DoctoId { get; set; }
        public string Cuenta { get; set; }
        public int? NumAsiento { get; set; }
        public string Refer { get; set; }
        public string TipoAsiento { get; set; }
        public decimal? Importe { get; set; }
        public string ExtraInfo { get; set; }

        public virtual ICollection<PolizasCfdi> PolizasCfdi { get; set; }
    }
}
