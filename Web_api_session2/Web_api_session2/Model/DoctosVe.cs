using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DoctosVe
    {
        public DoctosVe()
        {
            DoctosVeDet = new HashSet<DoctosVeDet>();
            DoctosVeLigasDoctoVeDest = new HashSet<DoctosVeLigas>();
            DoctosVeLigasDoctoVeFte = new HashSet<DoctosVeLigas>();
            ImpuestosDoctosVe = new HashSet<ImpuestosDoctosVe>();
            VencimientosCargosVe = new HashSet<VencimientosCargosVe>();
        }

        public int DoctoVeId { get; set; }
        public string TipoDocto { get; set; }
        public string SubtipoDocto { get; set; }
        public string Folio { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public string ClaveCliente { get; set; }
        public int ClienteId { get; set; }
        public int DirCliId { get; set; }
        public int DirConsigId { get; set; }
        public int? AlmacenId { get; set; }
        public int? LugarExpedicionId { get; set; }
        public int MonedaId { get; set; }
        public decimal? TipoCambio { get; set; }
        public string TipoDscto { get; set; }
        public decimal? DsctoPctje { get; set; }
        public decimal? DsctoImporte { get; set; }
        public string Estatus { get; set; }
        public string Aplicado { get; set; }
        public DateTime? FechaVigenciaEntrega { get; set; }
        public string OrdenCompra { get; set; }
        public DateTime? FechaOrdenCompra { get; set; }
        public string FolioReciboMercancia { get; set; }
        public DateTime? FechaReciboMercancia { get; set; }
        public string Descripcion { get; set; }
        public decimal? ImporteNeto { get; set; }
        public decimal? Fletes { get; set; }
        public decimal? OtrosCargos { get; set; }
        public decimal? TotalImpuestos { get; set; }
        public decimal? TotalRetenciones { get; set; }
        public decimal? TotalAnticipos { get; set; }
        public decimal PesoEmbarque { get; set; }
        public string FormaEmitida { get; set; }
        public string Contabilizado { get; set; }
        public string AcreditarCxc { get; set; }
        public string SistemaOrigen { get; set; }
        public int CondPagoId { get; set; }
        public DateTime? FechaDsctoPpag { get; set; }
        public decimal? PctjeDsctoPpag { get; set; }
        public int? VendedorId { get; set; }
        public decimal? PctjeComis { get; set; }
        public int? ViaEmbarqueId { get; set; }
        public decimal? ImporteCobro { get; set; }
        public string DescripcionCobro { get; set; }
        public int? ImpuestoSustituidoId { get; set; }
        public int? ImpuestoSustitutoId { get; set; }
        public string UsuarioCreador { get; set; }
        public string EsCfd { get; set; }
        public string ModalidadFacturacion { get; set; }
        public string Enviado { get; set; }
        public DateTime? FechaHoraEnvio { get; set; }
        public string EmailEnvio { get; set; }
        public string CfdEnvioEspecial { get; set; }
        public string UsoCfdi { get; set; }
        public string MetodoPagoSat { get; set; }
        public string CfdiCertificado { get; set; }
        public int? CfdiFactDevueltaId { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string CargarSun { get; set; }
        public string UsuarioAutModif { get; set; }
        public string UsuarioCancelacion { get; set; }
        public DateTime? FechaHoraCancelacion { get; set; }
        public string UsuarioAutCancelacion { get; set; }

        public virtual Almacenes Almacen { get; set; }
        public virtual RepositorioCfdi CfdiFactDevuelta { get; set; }
        public virtual Clientes Cliente { get; set; }
        public virtual CondicionesPago CondPago { get; set; }
        public virtual DirsClientes DirCli { get; set; }
        public virtual DirsClientes DirConsig { get; set; }
        public virtual Impuestos ImpuestoSustituido { get; set; }
        public virtual Impuestos ImpuestoSustituto { get; set; }
        public virtual Monedas Moneda { get; set; }
        public virtual Vendedores Vendedor { get; set; }
        public virtual ViasEmbarque ViaEmbarque { get; set; }
        public virtual DoctosVeCamposAddenda DoctosVeCamposAddenda { get; set; }
        public virtual LibresCotVe LibresCotVe { get; set; }
        public virtual LibresDevfacVe LibresDevfacVe { get; set; }
        public virtual LibresDevremVe LibresDevremVe { get; set; }
        public virtual LibresFacVe LibresFacVe { get; set; }
        public virtual LibresPedVe LibresPedVe { get; set; }
        public virtual LibresRemVe LibresRemVe { get; set; }
        public virtual ICollection<DoctosVeDet> DoctosVeDet { get; set; }
        public virtual ICollection<DoctosVeLigas> DoctosVeLigasDoctoVeDest { get; set; }
        public virtual ICollection<DoctosVeLigas> DoctosVeLigasDoctoVeFte { get; set; }
        public virtual ICollection<ImpuestosDoctosVe> ImpuestosDoctosVe { get; set; }
        public virtual ICollection<VencimientosCargosVe> VencimientosCargosVe { get; set; }
    }
}
