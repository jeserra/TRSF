using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ViaticosNoDet
    {
        public int ViaticoNoDetId { get; set; }
        public int ViaticoNoId { get; set; }
        public string TipoMovto { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Importe { get; set; }
        public string TipoComprobacion { get; set; }
        public string IncluirEnCfdi { get; set; }
        public int? PrestamoEmpId { get; set; }
        public string Referencia { get; set; }
        public string Observaciones { get; set; }

        public virtual PrestamosEmp PrestamoEmp { get; set; }
        public virtual ViaticosNo ViaticoNo { get; set; }
    }
}
