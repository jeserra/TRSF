using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DoctosCm
    {
        public DoctosCm()
        {
            DoctosCmDet = new HashSet<DoctosCmDet>();
            DoctosCmLigasDoctoCmDest = new HashSet<DoctosCmLigas>();
            DoctosCmLigasDoctoCmFte = new HashSet<DoctosCmLigas>();
            ImpuestosDoctosCm = new HashSet<ImpuestosDoctosCm>();
            VencimientosCargosCm = new HashSet<VencimientosCargosCm>();
        }

        public int DoctoCmId { get; set; }
        public string TipoDocto { get; set; }
        public string SubtipoDocto { get; set; }
        public string Folio { get; set; }
        public DateTime Fecha { get; set; }
        public string ClaveProv { get; set; }
        public int ProveedorId { get; set; }
        public string FolioProv { get; set; }
        public string FacturaDev { get; set; }
        public int? ConsigCmId { get; set; }
        public int AlmacenId { get; set; }
        public int? PedimentoId { get; set; }
        public int MonedaId { get; set; }
        public decimal? TipoCambio { get; set; }
        public string TipoDscto { get; set; }
        public decimal? DsctoPctje { get; set; }
        public decimal? DsctoImporte { get; set; }
        public string Estatus { get; set; }
        public string Aplicado { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public string Descripcion { get; set; }
        public decimal? ImporteNeto { get; set; }
        public decimal? Fletes { get; set; }
        public decimal? OtrosCargos { get; set; }
        public decimal? TotalImpuestos { get; set; }
        public decimal? TotalRetenciones { get; set; }
        public decimal? GastosAduanales { get; set; }
        public decimal? OtrosGastos { get; set; }
        public string FormaEmitida { get; set; }
        public string Contabilizado { get; set; }
        public string AcreditarCxp { get; set; }
        public string SistemaOrigen { get; set; }
        public int CondPagoId { get; set; }
        public DateTime? FechaDsctoPpag { get; set; }
        public decimal? PctjeDsctoPpag { get; set; }
        public int? ViaEmbarqueId { get; set; }
        public int? ImpuestoSustituidoId { get; set; }
        public int? ImpuestoSustitutoId { get; set; }
        public string CargarSun { get; set; }
        public string Enviado { get; set; }
        public DateTime? FechaHoraEnvio { get; set; }
        public string EmailEnvio { get; set; }
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

        public virtual Almacenes Almacen { get; set; }
        public virtual CondicionesPagoCp CondPago { get; set; }
        public virtual Impuestos ImpuestoSustituido { get; set; }
        public virtual Impuestos ImpuestoSustituto { get; set; }
        public virtual Monedas Moneda { get; set; }
        public virtual Pedimentos Pedimento { get; set; }
        public virtual Proveedores Proveedor { get; set; }
        public virtual ViasEmbarque ViaEmbarque { get; set; }
        public virtual DoctosCmProeve DoctosCmProeve { get; set; }
        public virtual LibresComCm LibresComCm { get; set; }
        public virtual LibresDevcomCm LibresDevcomCm { get; set; }
        public virtual LibresDevrecCm LibresDevrecCm { get; set; }
        public virtual LibresOcoCm LibresOcoCm { get; set; }
        public virtual LibresRecCm LibresRecCm { get; set; }
        public virtual ICollection<DoctosCmDet> DoctosCmDet { get; set; }
        public virtual ICollection<DoctosCmLigas> DoctosCmLigasDoctoCmDest { get; set; }
        public virtual ICollection<DoctosCmLigas> DoctosCmLigasDoctoCmFte { get; set; }
        public virtual ICollection<ImpuestosDoctosCm> ImpuestosDoctosCm { get; set; }
        public virtual ICollection<VencimientosCargosCm> VencimientosCargosCm { get; set; }
    }
}
