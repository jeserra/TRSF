using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DoctosPv
    {
        public DoctosPv()
        {
            DoctosPvCobros = new HashSet<DoctosPvCobros>();
            DoctosPvDet = new HashSet<DoctosPvDet>();
            DoctosPvLigasDoctoPvDest = new HashSet<DoctosPvLigas>();
            DoctosPvLigasDoctoPvFte = new HashSet<DoctosPvLigas>();
            DoctosPvOfertasMm = new HashSet<DoctosPvOfertasMm>();
            ImpuestosDoctosPv = new HashSet<ImpuestosDoctosPv>();
        }

        public int DoctoPvId { get; set; }
        public int CajaId { get; set; }
        public string TipoDocto { get; set; }
        public string Folio { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public int? CajeroId { get; set; }
        public string ClaveCliente { get; set; }
        public int? ClienteId { get; set; }
        public string ClaveClienteFac { get; set; }
        public int? ClienteFacId { get; set; }
        public int? DirCliId { get; set; }
        public int? AlmacenId { get; set; }
        public int? LugarExpedicionId { get; set; }
        public int? MonedaId { get; set; }
        public string ImpuestoIncluido { get; set; }
        public decimal? TipoCambio { get; set; }
        public string TipoDscto { get; set; }
        public decimal? DsctoPctje { get; set; }
        public decimal? DsctoImporte { get; set; }
        public string Estatus { get; set; }
        public string Aplicado { get; set; }
        public decimal? ImporteNeto { get; set; }
        public decimal? TotalImpuestos { get; set; }
        public decimal? ImporteDonativo { get; set; }
        public decimal? TotalFpgc { get; set; }
        public string TicketEmitido { get; set; }
        public string FormaGlobalEmitida { get; set; }
        public string FormaEmitida { get; set; }
        public string Contabilizado { get; set; }
        public string SistemaOrigen { get; set; }
        public int? VendedorId { get; set; }
        public string CargarSun { get; set; }
        public string Persona { get; set; }
        public string TipoGenFac { get; set; }
        public string EsFacGlobal { get; set; }
        public DateTime? FechaIniFacGlobal { get; set; }
        public DateTime? FechaFinFacGlobal { get; set; }
        public string InclFacturadosFacGlobal { get; set; }
        public int? AlmacenIdFacGlobal { get; set; }
        public string ReferReting { get; set; }
        public string UnidComprom { get; set; }
        public string Descripcion { get; set; }
        public int? ImpuestoSustituidoId { get; set; }
        public int? ImpuestoSustitutoId { get; set; }
        public string EsCfd { get; set; }
        public string ModalidadFacturacion { get; set; }
        public string Enviado { get; set; }
        public string EmailEnvio { get; set; }
        public string UsuarioCreador { get; set; }
        public string CfdiCertificado { get; set; }
        public string UsoCfdi { get; set; }
        public string MetodoPagoSat { get; set; }
        public int? PartidaAjusteId { get; set; }
        public decimal? PrecioOrigPartidaAjuste { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioCancelacion { get; set; }
        public string UsuarioAutModif { get; set; }
        public DateTime? FechaHoraCancelacion { get; set; }
        public DateTime? FechaHoraEnvio { get; set; }
        public string UsuarioAutCancelacion { get; set; }

        public virtual Almacenes Almacen { get; set; }
        public virtual Almacenes AlmacenIdFacGlobalNavigation { get; set; }
        public virtual Cajas Caja { get; set; }
        public virtual Cajeros Cajero { get; set; }
        public virtual Clientes Cliente { get; set; }
        public virtual Clientes ClienteFac { get; set; }
        public virtual DirsClientes DirCli { get; set; }
        public virtual Impuestos ImpuestoSustituido { get; set; }
        public virtual Impuestos ImpuestoSustituto { get; set; }
        public virtual Monedas Moneda { get; set; }
        public virtual Vendedores Vendedor { get; set; }
        public virtual LibresOrdvtaPv LibresOrdvtaPv { get; set; }
        public virtual ICollection<DoctosPvCobros> DoctosPvCobros { get; set; }
        public virtual ICollection<DoctosPvDet> DoctosPvDet { get; set; }
        public virtual ICollection<DoctosPvLigas> DoctosPvLigasDoctoPvDest { get; set; }
        public virtual ICollection<DoctosPvLigas> DoctosPvLigasDoctoPvFte { get; set; }
        public virtual ICollection<DoctosPvOfertasMm> DoctosPvOfertasMm { get; set; }
        public virtual ICollection<ImpuestosDoctosPv> ImpuestosDoctosPv { get; set; }
    }
}
