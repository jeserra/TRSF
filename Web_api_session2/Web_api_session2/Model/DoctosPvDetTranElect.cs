using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DoctosPvDetTranElect
    {
        public int DoctoPvDetId { get; set; }
        public string ParamsText { get; set; }
        public string ClaveServicio { get; set; }
        public int CajaId { get; set; }
        public int CajeroId { get; set; }
        public DateTime FechaHora { get; set; }
        public string ClaveReceptor { get; set; }
        public decimal? Importe { get; set; }
        public decimal? Costo { get; set; }
        public string Autorizacion { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }

        public virtual Cajas Caja { get; set; }
        public virtual Cajeros Cajero { get; set; }
        public virtual DoctosPvDet DoctoPvDet { get; set; }
    }
}
