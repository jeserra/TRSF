using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DoctosBa
    {
        public DoctosBa()
        {
            DoctosBaInfoBan = new HashSet<DoctosBaInfoBan>();
            TraspasosBaDoctoBaDep = new HashSet<TraspasosBa>();
        }

        public int DoctoBaId { get; set; }
        public int ConceptoBaId { get; set; }
        public int? CuentaBanId { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaAplic { get; set; }
        public string TipoMovFiscal { get; set; }
        public string TipoMovto { get; set; }
        public string Refer { get; set; }
        public decimal? Importe { get; set; }
        public int MonedaId { get; set; }
        public decimal? TipoCambio { get; set; }
        public string Estatus { get; set; }
        public string Cancelado { get; set; }
        public string Aplicado { get; set; }
        public string Conciliado { get; set; }
        public DateTime? FechaConciliacion { get; set; }
        public string Descripcion { get; set; }
        public string ClaveBen { get; set; }
        public int? BeneficiarioId { get; set; }
        public string FormaEmitida { get; set; }
        public string SistemaOrigen { get; set; }
        public string Nombre { get; set; }
        public int? GrupoMovPeriodId { get; set; }
        public string EsTraspaso { get; set; }
        public string Capturado { get; set; }
        public string IntegCo { get; set; }
        public int IdOriginal { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }
        public string UsuarioCancelacion { get; set; }
        public DateTime? FechaHoraCancelacion { get; set; }
        public string UsuarioAutCancelacion { get; set; }

        public virtual Beneficiarios Beneficiario { get; set; }
        public virtual ConceptosBa ConceptoBa { get; set; }
        public virtual CuentasBancarias CuentaBan { get; set; }
        public virtual GruposMovPeriodBa GrupoMovPeriod { get; set; }
        public virtual Monedas Moneda { get; set; }
        public virtual TraspasosBa TraspasosBaDoctoBaRet { get; set; }
        public virtual ICollection<DoctosBaInfoBan> DoctosBaInfoBan { get; set; }
        public virtual ICollection<TraspasosBa> TraspasosBaDoctoBaDep { get; set; }
    }
}
