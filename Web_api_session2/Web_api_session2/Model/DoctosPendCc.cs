using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DoctosPendCc
    {
        public DoctosPendCc()
        {
            ImportesDoctosPendCc = new HashSet<ImportesDoctosPendCc>();
            VencimientosCargosPendCc = new HashSet<VencimientosCargosPendCc>();
        }

        public int DoctoPendCcId { get; set; }
        public int ConceptoCcId { get; set; }
        public string Folio { get; set; }
        public DateTime Fecha { get; set; }
        public string ClaveCliente { get; set; }
        public int ClienteId { get; set; }
        public decimal TipoCambio { get; set; }
        public string Cancelado { get; set; }
        public string Descripcion { get; set; }
        public string CuentaConcepto { get; set; }
        public int? CobradorId { get; set; }
        public string FormaEmitida { get; set; }
        public string Contabilizado { get; set; }
        public string Importado { get; set; }
        public int? CondPagoId { get; set; }
        public decimal? PctjeDsctoPpag { get; set; }
        public DateTime? FechaDsctoPpag { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }

        public virtual Clientes Cliente { get; set; }
        public virtual Cobradores Cobrador { get; set; }
        public virtual ConceptosCc ConceptoCc { get; set; }
        public virtual CondicionesPago CondPago { get; set; }
        public virtual ICollection<ImportesDoctosPendCc> ImportesDoctosPendCc { get; set; }
        public virtual ICollection<VencimientosCargosPendCc> VencimientosCargosPendCc { get; set; }
    }
}
