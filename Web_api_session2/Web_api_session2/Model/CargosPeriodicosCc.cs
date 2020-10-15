using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class CargosPeriodicosCc
    {
        public int CargoPeriodId { get; set; }
        public int GrupoCarPeriodId { get; set; }
        public string ClaveCliente { get; set; }
        public int ClienteId { get; set; }
        public int ConceptoCcId { get; set; }
        public int? LugarExpedicionId { get; set; }
        public decimal? Importe { get; set; }
        public decimal? Impuesto { get; set; }
        public decimal? IvaRetenido { get; set; }
        public decimal? IsrRetenido { get; set; }
        public string Descripcion { get; set; }
        public string CuentaConcepto { get; set; }
        public int? CondPagoId { get; set; }
        public string UsoCfdi { get; set; }
        public string MetodoPagoSat { get; set; }
        public int? ImpuestoId { get; set; }
        public int? ImpuestoIvaRetId { get; set; }
        public int? ImpuestoIsrRetId { get; set; }
        public DateTime? FechaUltAplic { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual Clientes Cliente { get; set; }
        public virtual ConceptosCc ConceptoCc { get; set; }
        public virtual CondicionesPago CondPago { get; set; }
        public virtual GruposCargosPeriodicosCc GrupoCarPeriod { get; set; }
        public virtual Impuestos ImpuestoIsrRet { get; set; }
        public virtual Impuestos ImpuestoIvaRet { get; set; }
        public virtual Impuestos ImpuestoNavigation { get; set; }
        public virtual LibresCargosPerCc LibresCargosPerCc { get; set; }
    }
}
