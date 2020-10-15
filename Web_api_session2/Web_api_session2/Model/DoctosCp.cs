using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DoctosCp
    {
        public DoctosCp()
        {
            ImportesDoctosCpDoctoCp = new HashSet<ImportesDoctosCp>();
            ImportesDoctosCpDoctoCpAcr = new HashSet<ImportesDoctosCp>();
            SubMovtosCpDoctoCp = new HashSet<SubMovtosCp>();
            SubMovtosCpSubMovto = new HashSet<SubMovtosCp>();
            VencimientosCargosCp = new HashSet<VencimientosCargosCp>();
        }

        public int DoctoCpId { get; set; }
        public int ConceptoCpId { get; set; }
        public string Folio { get; set; }
        public string NaturalezaConcepto { get; set; }
        public DateTime Fecha { get; set; }
        public string ClaveProv { get; set; }
        public int ProveedorId { get; set; }
        public decimal? TipoCambio { get; set; }
        public string Cancelado { get; set; }
        public string Aplicado { get; set; }
        public string Descripcion { get; set; }
        public string CuentaConcepto { get; set; }
        public string FormaEmitida { get; set; }
        public string Contabilizado { get; set; }
        public string ContabilizadoGyp { get; set; }
        public int? CondPagoId { get; set; }
        public DateTime? FechaDsctoPpag { get; set; }
        public decimal? PctjeDsctoPpag { get; set; }
        public string Exportado { get; set; }
        public string SistemaOrigen { get; set; }
        public string IntegBa { get; set; }
        public string ContabilizadoBa { get; set; }
        public string TieneCfd { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }
        public string UsuarioCancelacion { get; set; }
        public DateTime? FechaHoraCancelacion { get; set; }
        public string UsuarioAutCancelacion { get; set; }

        public virtual ConceptosCp ConceptoCp { get; set; }
        public virtual CondicionesPagoCp CondPago { get; set; }
        public virtual Proveedores Proveedor { get; set; }
        public virtual DoctosCpInfoBan DoctosCpInfoBan { get; set; }
        public virtual LibresCargosCp LibresCargosCp { get; set; }
        public virtual LibresCreditosCp LibresCreditosCp { get; set; }
        public virtual ICollection<ImportesDoctosCp> ImportesDoctosCpDoctoCp { get; set; }
        public virtual ICollection<ImportesDoctosCp> ImportesDoctosCpDoctoCpAcr { get; set; }
        public virtual ICollection<SubMovtosCp> SubMovtosCpDoctoCp { get; set; }
        public virtual ICollection<SubMovtosCp> SubMovtosCpSubMovto { get; set; }
        public virtual ICollection<VencimientosCargosCp> VencimientosCargosCp { get; set; }
    }
}
