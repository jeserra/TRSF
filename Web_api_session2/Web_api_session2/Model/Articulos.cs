using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class Articulos
    {
        public Articulos()
        {
            ArticulosClientes = new HashSet<ArticulosClientes>();
            ArticulosDiscretos = new HashSet<ArticulosDiscretos>();
            ArticulosTiendaLinea = new HashSet<ArticulosTiendaLinea>();
            ArticulosWeb = new HashSet<ArticulosWeb>();
            CapasCostos = new HashSet<CapasCostos>();
            CapasPedimentos = new HashSet<CapasPedimentos>();
            ClavesArticulos = new HashSet<ClavesArticulos>();
            ComisVenArt = new HashSet<ComisVenArt>();
            CompromArticulos = new HashSet<CompromArticulos>();
            DoctosCmDet = new HashSet<DoctosCmDet>();
            DoctosInDet = new HashSet<DoctosInDet>();
            DoctosInvfisDet = new HashSet<DoctosInvfisDet>();
            DoctosPvDet = new HashSet<DoctosPvDet>();
            DoctosTrDet = new HashSet<DoctosTrDet>();
            DoctosVeDet = new HashSet<DoctosVeDet>();
            DsctosArtcliArts = new HashSet<DsctosArtcliArts>();
            DsctosArtproArts = new HashSet<DsctosArtproArts>();
            DsctosMaxArts = new HashSet<DsctosMaxArts>();
            DsctosPromoArts = new HashSet<DsctosPromoArts>();
            DsctosPromoProvArts = new HashSet<DsctosPromoProvArts>();
            DsctosVolArts = new HashSet<DsctosVolArts>();
            DsctosVolProvArts = new HashSet<DsctosVolProvArts>();
            ImagenesArticulos = new HashSet<ImagenesArticulos>();
            ImpuestosArticulos = new HashSet<ImpuestosArticulos>();
            JuegosAEnsamblar = new HashSet<JuegosAEnsamblar>();
            JuegosDetArticulo = new HashSet<JuegosDet>();
            JuegosDetComponente = new HashSet<JuegosDet>();
            NivelesArticulos = new HashSet<NivelesArticulos>();
            OfertasMmDet = new HashSet<OfertasMmDet>();
            PreciosArticulos = new HashSet<PreciosArticulos>();
            PreciosCompra = new HashSet<PreciosCompra>();
            SaldosIn = new HashSet<SaldosIn>();
        }

        public int ArticuloId { get; set; }
        public string Nombre { get; set; }
        public string EsAlmacenable { get; set; }
        public string EsJuego { get; set; }
        public string Estatus { get; set; }
        public string CausaSusp { get; set; }
        public DateTime? FechaSusp { get; set; }
        public string ImprimirComp { get; set; }
        public string PermitirAgregarComp { get; set; }
        public int? LineaArticuloId { get; set; }
        public string UnidadVenta { get; set; }
        public string UnidadCompra { get; set; }
        public decimal? ContenidoUnidadCompra { get; set; }
        public decimal? PesoUnitario { get; set; }
        public string EsPesoVariable { get; set; }
        public string Seguimiento { get; set; }
        public int? DiasGarantia { get; set; }
        public string EsImportado { get; set; }
        public string EsSiempreImportado { get; set; }
        public decimal? PctjeArancel { get; set; }
        public string NotasCompras { get; set; }
        public string ImprimirNotasCompras { get; set; }
        public string NotasVentas { get; set; }
        public string ImprimirNotasVentas { get; set; }
        public string EsPrecioVariable { get; set; }
        public string CuentaAlmacen { get; set; }
        public string CuentaCostoVenta { get; set; }
        public string CuentaVentas { get; set; }
        public string CuentaDevolVentas { get; set; }
        public string CuentaCompras { get; set; }
        public string CuentaDevolCompras { get; set; }
        public string AplicarFactorVenta { get; set; }
        public decimal FactorVenta { get; set; }
        public string RedPrecioConImpto { get; set; }
        public decimal? FactorRedPrecioConImpto { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual LineasArticulos LineaArticulo { get; set; }
        public virtual ArticulosVariantes ArticulosVariantes { get; set; }
        public virtual LibresArticulos LibresArticulos { get; set; }
        public virtual VariantesArts VariantesArts { get; set; }
        public virtual ICollection<ArticulosClientes> ArticulosClientes { get; set; }
        public virtual ICollection<ArticulosDiscretos> ArticulosDiscretos { get; set; }
        public virtual ICollection<ArticulosTiendaLinea> ArticulosTiendaLinea { get; set; }
        public virtual ICollection<ArticulosWeb> ArticulosWeb { get; set; }
        public virtual ICollection<CapasCostos> CapasCostos { get; set; }
        public virtual ICollection<CapasPedimentos> CapasPedimentos { get; set; }
        public virtual ICollection<ClavesArticulos> ClavesArticulos { get; set; }
        public virtual ICollection<ComisVenArt> ComisVenArt { get; set; }
        public virtual ICollection<CompromArticulos> CompromArticulos { get; set; }
        public virtual ICollection<DoctosCmDet> DoctosCmDet { get; set; }
        public virtual ICollection<DoctosInDet> DoctosInDet { get; set; }
        public virtual ICollection<DoctosInvfisDet> DoctosInvfisDet { get; set; }
        public virtual ICollection<DoctosPvDet> DoctosPvDet { get; set; }
        public virtual ICollection<DoctosTrDet> DoctosTrDet { get; set; }
        public virtual ICollection<DoctosVeDet> DoctosVeDet { get; set; }
        public virtual ICollection<DsctosArtcliArts> DsctosArtcliArts { get; set; }
        public virtual ICollection<DsctosArtproArts> DsctosArtproArts { get; set; }
        public virtual ICollection<DsctosMaxArts> DsctosMaxArts { get; set; }
        public virtual ICollection<DsctosPromoArts> DsctosPromoArts { get; set; }
        public virtual ICollection<DsctosPromoProvArts> DsctosPromoProvArts { get; set; }
        public virtual ICollection<DsctosVolArts> DsctosVolArts { get; set; }
        public virtual ICollection<DsctosVolProvArts> DsctosVolProvArts { get; set; }
        public virtual ICollection<ImagenesArticulos> ImagenesArticulos { get; set; }
        public virtual ICollection<ImpuestosArticulos> ImpuestosArticulos { get; set; }
        public virtual ICollection<JuegosAEnsamblar> JuegosAEnsamblar { get; set; }
        public virtual ICollection<JuegosDet> JuegosDetArticulo { get; set; }
        public virtual ICollection<JuegosDet> JuegosDetComponente { get; set; }
        public virtual ICollection<NivelesArticulos> NivelesArticulos { get; set; }
        public virtual ICollection<OfertasMmDet> OfertasMmDet { get; set; }
        public virtual ICollection<PreciosArticulos> PreciosArticulos { get; set; }
        public virtual ICollection<PreciosCompra> PreciosCompra { get; set; }
        public virtual ICollection<SaldosIn> SaldosIn { get; set; }
    }
}
