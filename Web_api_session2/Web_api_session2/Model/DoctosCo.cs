using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DoctosCo
    {
        public DoctosCo()
        {
            DoctosCoCfdi = new HashSet<DoctosCoCfdi>();
            DoctosCoDet = new HashSet<DoctosCoDet>();
            DoctosCoFiles = new HashSet<DoctosCoFiles>();
        }

        public int DoctoCoId { get; set; }
        public int TipoPolizaId { get; set; }
        public string Poliza { get; set; }
        public DateTime Fecha { get; set; }
        public int MonedaId { get; set; }
        public decimal? TipoCambio { get; set; }
        public string Estatus { get; set; }
        public string Cancelado { get; set; }
        public string Aplicado { get; set; }
        public string Ajuste { get; set; }
        public string IntegCo { get; set; }
        public string Descripcion { get; set; }
        public string FormaEmitida { get; set; }
        public string SistemaOrigen { get; set; }
        public string Nombre { get; set; }
        public int? GrupoPolPeriodId { get; set; }
        public string IntegBa { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }
        public string UsuarioCancelacion { get; set; }
        public DateTime? FechaHoraCancelacion { get; set; }
        public string UsuarioAutCancelacion { get; set; }

        public virtual GruposPolizasPeriodCo GrupoPolPeriod { get; set; }
        public virtual Monedas Moneda { get; set; }
        public virtual TiposPolizas TipoPoliza { get; set; }
        public virtual LibresPolCo LibresPolCo { get; set; }
        public virtual ICollection<DoctosCoCfdi> DoctosCoCfdi { get; set; }
        public virtual ICollection<DoctosCoDet> DoctosCoDet { get; set; }
        public virtual ICollection<DoctosCoFiles> DoctosCoFiles { get; set; }
    }
}
