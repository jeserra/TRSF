using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class EdosctaBaDet
    {
        public int EdoctaBaDetId { get; set; }
        public int EdoctaBaId { get; set; }
        public int CuentaBanId { get; set; }
        public DateTime Fecha { get; set; }
        public string TipoMovto { get; set; }
        public string Refer { get; set; }
        public decimal? Importe { get; set; }
        public string Descripcion { get; set; }
        public string Conciliado { get; set; }
        public DateTime? FechaConciliacion { get; set; }

        public virtual CuentasBancarias CuentaBan { get; set; }
        public virtual EdosctaBa EdoctaBa { get; set; }
    }
}
