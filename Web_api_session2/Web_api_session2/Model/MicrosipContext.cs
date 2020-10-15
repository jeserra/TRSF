using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Web_api_session2.Model
{
    public partial class MicrosipContext : DbContext
    {
        public MicrosipContext()
        {
        }

        public MicrosipContext(DbContextOptions<MicrosipContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActivosFijos> ActivosFijos { get; set; }
        public virtual DbSet<AcumCuentasCoTemp> AcumCuentasCoTemp { get; set; }
        public virtual DbSet<Aduanas> Aduanas { get; set; }
        public virtual DbSet<Agentes> Agentes { get; set; }
        public virtual DbSet<Almacenes> Almacenes { get; set; }
        public virtual DbSet<AnticiposCc> AnticiposCc { get; set; }
        public virtual DbSet<Articulos> Articulos { get; set; }
        public virtual DbSet<ArticulosClientes> ArticulosClientes { get; set; }
        public virtual DbSet<ArticulosDiscretos> ArticulosDiscretos { get; set; }
        public virtual DbSet<ArticulosTiendaLinea> ArticulosTiendaLinea { get; set; }
        public virtual DbSet<ArticulosVariantes> ArticulosVariantes { get; set; }
        public virtual DbSet<ArticulosWeb> ArticulosWeb { get; set; }
        public virtual DbSet<AtribArtsVariantes> AtribArtsVariantes { get; set; }
        public virtual DbSet<Atributos> Atributos { get; set; }
        public virtual DbSet<Bancos> Bancos { get; set; }
        public virtual DbSet<Beneficiarios> Beneficiarios { get; set; }
        public virtual DbSet<BookmarksReportes> BookmarksReportes { get; set; }
        public virtual DbSet<Cajas> Cajas { get; set; }
        public virtual DbSet<CajasCajeros> CajasCajeros { get; set; }
        public virtual DbSet<Cajeros> Cajeros { get; set; }
        public virtual DbSet<CapasCostos> CapasCostos { get; set; }
        public virtual DbSet<CapasPedimentos> CapasPedimentos { get; set; }
        public virtual DbSet<CargosPeriodicosCc> CargosPeriodicosCc { get; set; }
        public virtual DbSet<CentrosCosto> CentrosCosto { get; set; }
        public virtual DbSet<CertCfdProv> CertCfdProv { get; set; }
        public virtual DbSet<CfdRecibidos> CfdRecibidos { get; set; }
        public virtual DbSet<Ciudades> Ciudades { get; set; }
        public virtual DbSet<ClasificadoresCat> ClasificadoresCat { get; set; }
        public virtual DbSet<ClasificadoresCatValores> ClasificadoresCatValores { get; set; }
        public virtual DbSet<ClavesArticulos> ClavesArticulos { get; set; }
        public virtual DbSet<ClavesCatSec> ClavesCatSec { get; set; }
        public virtual DbSet<ClavesClientes> ClavesClientes { get; set; }
        public virtual DbSet<ClavesEmpleados> ClavesEmpleados { get; set; }
        public virtual DbSet<ClavesProveedores> ClavesProveedores { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Cobradores> Cobradores { get; set; }
        public virtual DbSet<ComandosDispositivos> ComandosDispositivos { get; set; }
        public virtual DbSet<ComandosTiposDispositivos> ComandosTiposDispositivos { get; set; }
        public virtual DbSet<ComisCobTipoCli> ComisCobTipoCli { get; set; }
        public virtual DbSet<ComisCobZona> ComisCobZona { get; set; }
        public virtual DbSet<ComisVenArt> ComisVenArt { get; set; }
        public virtual DbSet<ComisVenCli> ComisVenCli { get; set; }
        public virtual DbSet<ComisVenGrupo> ComisVenGrupo { get; set; }
        public virtual DbSet<ComisVenLinea> ComisVenLinea { get; set; }
        public virtual DbSet<ComisVenTipoCli> ComisVenTipoCli { get; set; }
        public virtual DbSet<ComisVenZona> ComisVenZona { get; set; }
        public virtual DbSet<CompromArticulos> CompromArticulos { get; set; }
        public virtual DbSet<ConceptosBa> ConceptosBa { get; set; }
        public virtual DbSet<ConceptosCc> ConceptosCc { get; set; }
        public virtual DbSet<ConceptosCp> ConceptosCp { get; set; }
        public virtual DbSet<ConceptosDimNo> ConceptosDimNo { get; set; }
        public virtual DbSet<ConceptosEmp> ConceptosEmp { get; set; }
        public virtual DbSet<CondicionesPago> CondicionesPago { get; set; }
        public virtual DbSet<CondicionesPagoCp> CondicionesPagoCp { get; set; }
        public virtual DbSet<ConstanciasRet> ConstanciasRet { get; set; }
        public virtual DbSet<ContratosLft> ContratosLft { get; set; }
        public virtual DbSet<CuentasBancarias> CuentasBancarias { get; set; }
        public virtual DbSet<CuentasCo> CuentasCo { get; set; }
        public virtual DbSet<CuentasCoDiot> CuentasCoDiot { get; set; }
        public virtual DbSet<CuentasNo> CuentasNo { get; set; }
        public virtual DbSet<DatosAdicionales> DatosAdicionales { get; set; }
        public virtual DbSet<DepositosCc> DepositosCc { get; set; }
        public virtual DbSet<DepositosCcDet> DepositosCcDet { get; set; }
        public virtual DbSet<DeptosCo> DeptosCo { get; set; }
        public virtual DbSet<DeptosNo> DeptosNo { get; set; }
        public virtual DbSet<DescripPolizas> DescripPolizas { get; set; }
        public virtual DbSet<DesgloseEnDiscretos> DesgloseEnDiscretos { get; set; }
        public virtual DbSet<DesgloseEnDiscretosCm> DesgloseEnDiscretosCm { get; set; }
        public virtual DbSet<DesgloseEnDiscretosInvfis> DesgloseEnDiscretosInvfis { get; set; }
        public virtual DbSet<DesgloseEnDiscretosPv> DesgloseEnDiscretosPv { get; set; }
        public virtual DbSet<DesgloseEnDiscretosVe> DesgloseEnDiscretosVe { get; set; }
        public virtual DbSet<DesgloseEnPedimentos> DesgloseEnPedimentos { get; set; }
        public virtual DbSet<DirsClientes> DirsClientes { get; set; }
        public virtual DbSet<Dispositivos> Dispositivos { get; set; }
        public virtual DbSet<DispositivosCajas> DispositivosCajas { get; set; }
        public virtual DbSet<DoctosBa> DoctosBa { get; set; }
        public virtual DbSet<DoctosBaInfoBan> DoctosBaInfoBan { get; set; }
        public virtual DbSet<DoctosCc> DoctosCc { get; set; }
        public virtual DbSet<DoctosCcInfoBan> DoctosCcInfoBan { get; set; }
        public virtual DbSet<DoctosCm> DoctosCm { get; set; }
        public virtual DbSet<DoctosCmDet> DoctosCmDet { get; set; }
        public virtual DbSet<DoctosCmLigas> DoctosCmLigas { get; set; }
        public virtual DbSet<DoctosCmLigasDet> DoctosCmLigasDet { get; set; }
        public virtual DbSet<DoctosCmProeve> DoctosCmProeve { get; set; }
        public virtual DbSet<DoctosCo> DoctosCo { get; set; }
        public virtual DbSet<DoctosCoCfdi> DoctosCoCfdi { get; set; }
        public virtual DbSet<DoctosCoDet> DoctosCoDet { get; set; }
        public virtual DbSet<DoctosCoDetCfdi> DoctosCoDetCfdi { get; set; }
        public virtual DbSet<DoctosCoDetDiot> DoctosCoDetDiot { get; set; }
        public virtual DbSet<DoctosCoDetInfoBan> DoctosCoDetInfoBan { get; set; }
        public virtual DbSet<DoctosCoFiles> DoctosCoFiles { get; set; }
        public virtual DbSet<DoctosCp> DoctosCp { get; set; }
        public virtual DbSet<DoctosCpInfoBan> DoctosCpInfoBan { get; set; }
        public virtual DbSet<DoctosEntreSis> DoctosEntreSis { get; set; }
        public virtual DbSet<DoctosIn> DoctosIn { get; set; }
        public virtual DbSet<DoctosInDet> DoctosInDet { get; set; }
        public virtual DbSet<DoctosInDetCompras> DoctosInDetCompras { get; set; }
        public virtual DbSet<DoctosInvfis> DoctosInvfis { get; set; }
        public virtual DbSet<DoctosInvfisDet> DoctosInvfisDet { get; set; }
        public virtual DbSet<DoctosPendCc> DoctosPendCc { get; set; }
        public virtual DbSet<DoctosProcCancel> DoctosProcCancel { get; set; }
        public virtual DbSet<DoctosPv> DoctosPv { get; set; }
        public virtual DbSet<DoctosPvCobros> DoctosPvCobros { get; set; }
        public virtual DbSet<DoctosPvCobrosRefer> DoctosPvCobrosRefer { get; set; }
        public virtual DbSet<DoctosPvDet> DoctosPvDet { get; set; }
        public virtual DbSet<DoctosPvDetTranElect> DoctosPvDetTranElect { get; set; }
        public virtual DbSet<DoctosPvLigas> DoctosPvLigas { get; set; }
        public virtual DbSet<DoctosPvLigasDet> DoctosPvLigasDet { get; set; }
        public virtual DbSet<DoctosPvNombresOfertasMm> DoctosPvNombresOfertasMm { get; set; }
        public virtual DbSet<DoctosPvOfertasMm> DoctosPvOfertasMm { get; set; }
        public virtual DbSet<DoctosPvOfertasMmDet> DoctosPvOfertasMmDet { get; set; }
        public virtual DbSet<DoctosPvTranPendTc> DoctosPvTranPendTc { get; set; }
        public virtual DbSet<DoctosSucursales> DoctosSucursales { get; set; }
        public virtual DbSet<DoctosTr> DoctosTr { get; set; }
        public virtual DbSet<DoctosTrDet> DoctosTrDet { get; set; }
        public virtual DbSet<DoctosVe> DoctosVe { get; set; }
        public virtual DbSet<DoctosVeCamposAddenda> DoctosVeCamposAddenda { get; set; }
        public virtual DbSet<DoctosVeDet> DoctosVeDet { get; set; }
        public virtual DbSet<DoctosVeLigas> DoctosVeLigas { get; set; }
        public virtual DbSet<DoctosVeLigasDet> DoctosVeLigasDet { get; set; }
        public virtual DbSet<DsctosArtcliArts> DsctosArtcliArts { get; set; }
        public virtual DbSet<DsctosArtcliGrupos> DsctosArtcliGrupos { get; set; }
        public virtual DbSet<DsctosArtcliLineas> DsctosArtcliLineas { get; set; }
        public virtual DbSet<DsctosArtproArts> DsctosArtproArts { get; set; }
        public virtual DbSet<DsctosArtproGrupos> DsctosArtproGrupos { get; set; }
        public virtual DbSet<DsctosArtproLineas> DsctosArtproLineas { get; set; }
        public virtual DbSet<DsctosMaxArts> DsctosMaxArts { get; set; }
        public virtual DbSet<DsctosMaxGrupos> DsctosMaxGrupos { get; set; }
        public virtual DbSet<DsctosMaxLineas> DsctosMaxLineas { get; set; }
        public virtual DbSet<DsctosPromoArts> DsctosPromoArts { get; set; }
        public virtual DbSet<DsctosPromoGrupos> DsctosPromoGrupos { get; set; }
        public virtual DbSet<DsctosPromoLineas> DsctosPromoLineas { get; set; }
        public virtual DbSet<DsctosPromoProvArts> DsctosPromoProvArts { get; set; }
        public virtual DbSet<DsctosPromoProvGrupos> DsctosPromoProvGrupos { get; set; }
        public virtual DbSet<DsctosPromoProvLineas> DsctosPromoProvLineas { get; set; }
        public virtual DbSet<DsctosVolArts> DsctosVolArts { get; set; }
        public virtual DbSet<DsctosVolGlobales> DsctosVolGlobales { get; set; }
        public virtual DbSet<DsctosVolGrupos> DsctosVolGrupos { get; set; }
        public virtual DbSet<DsctosVolLineas> DsctosVolLineas { get; set; }
        public virtual DbSet<DsctosVolProvArts> DsctosVolProvArts { get; set; }
        public virtual DbSet<DsctosVolProvGlob> DsctosVolProvGlob { get; set; }
        public virtual DbSet<DsctosVolProvGrupos> DsctosVolProvGrupos { get; set; }
        public virtual DbSet<DsctosVolProvLineas> DsctosVolProvLineas { get; set; }
        public virtual DbSet<EdosctaBa> EdosctaBa { get; set; }
        public virtual DbSet<EdosctaBaDet> EdosctaBaDet { get; set; }
        public virtual DbSet<ElementosCatClasif> ElementosCatClasif { get; set; }
        public virtual DbSet<Empleados> Empleados { get; set; }
        public virtual DbSet<EquivalenciasImpuestos> EquivalenciasImpuestos { get; set; }
        public virtual DbSet<EquivalenciasImpuestosDet> EquivalenciasImpuestosDet { get; set; }
        public virtual DbSet<EquivalenciasMonedas> EquivalenciasMonedas { get; set; }
        public virtual DbSet<EspecsEdofin> EspecsEdofin { get; set; }
        public virtual DbSet<Estados> Estados { get; set; }
        public virtual DbSet<EstatusAsimilados> EstatusAsimilados { get; set; }
        public virtual DbSet<ExcepEmpleados> ExcepEmpleados { get; set; }
        public virtual DbSet<ExcepEmpleadosDet> ExcepEmpleadosDet { get; set; }
        public virtual DbSet<ExcepGenerales> ExcepGenerales { get; set; }
        public virtual DbSet<ExisDiscretos> ExisDiscretos { get; set; }
        public virtual DbSet<FechasBaseCostos> FechasBaseCostos { get; set; }
        public virtual DbSet<FoliosCajas> FoliosCajas { get; set; }
        public virtual DbSet<FoliosCompras> FoliosCompras { get; set; }
        public virtual DbSet<FoliosFiscales> FoliosFiscales { get; set; }
        public virtual DbSet<FoliosVentas> FoliosVentas { get; set; }
        public virtual DbSet<FormasCobro> FormasCobro { get; set; }
        public virtual DbSet<FormasCobroCc> FormasCobroCc { get; set; }
        public virtual DbSet<FormasCobroClientes> FormasCobroClientes { get; set; }
        public virtual DbSet<FormasCobroDenom> FormasCobroDenom { get; set; }
        public virtual DbSet<FormasCobroDoctos> FormasCobroDoctos { get; set; }
        public virtual DbSet<FormasCobroRefer> FormasCobroRefer { get; set; }
        public virtual DbSet<FormatosEdofin> FormatosEdofin { get; set; }
        public virtual DbSet<FormatosEdofinDet> FormatosEdofinDet { get; set; }
        public virtual DbSet<FormatosTicketsDet> FormatosTicketsDet { get; set; }
        public virtual DbSet<FrecuenciasPago> FrecuenciasPago { get; set; }
        public virtual DbSet<GruposActivosFijos> GruposActivosFijos { get; set; }
        public virtual DbSet<GruposCargosPeriodicosCc> GruposCargosPeriodicosCc { get; set; }
        public virtual DbSet<GruposCuentas> GruposCuentas { get; set; }
        public virtual DbSet<GruposCuentasDet> GruposCuentasDet { get; set; }
        public virtual DbSet<GruposLineas> GruposLineas { get; set; }
        public virtual DbSet<GruposLineasWeb> GruposLineasWeb { get; set; }
        public virtual DbSet<GruposMovPeriodBa> GruposMovPeriodBa { get; set; }
        public virtual DbSet<GruposPagosElect> GruposPagosElect { get; set; }
        public virtual DbSet<GruposPolizasPeriodCo> GruposPolizasPeriodCo { get; set; }
        public virtual DbSet<GruposRutas> GruposRutas { get; set; }
        public virtual DbSet<HistoriaCambiaria> HistoriaCambiaria { get; set; }
        public virtual DbSet<IdsConver> IdsConver { get; set; }
        public virtual DbSet<ImagenesActivosFijos> ImagenesActivosFijos { get; set; }
        public virtual DbSet<ImagenesArticulos> ImagenesArticulos { get; set; }
        public virtual DbSet<ImagenesCajas> ImagenesCajas { get; set; }
        public virtual DbSet<ImagenesCajasDet> ImagenesCajasDet { get; set; }
        public virtual DbSet<ImagenesClientes> ImagenesClientes { get; set; }
        public virtual DbSet<ImagenesEmpleados> ImagenesEmpleados { get; set; }
        public virtual DbSet<ImagenesProveedores> ImagenesProveedores { get; set; }
        public virtual DbSet<ImportesDoctosCc> ImportesDoctosCc { get; set; }
        public virtual DbSet<ImportesDoctosCcImptos> ImportesDoctosCcImptos { get; set; }
        public virtual DbSet<ImportesDoctosCp> ImportesDoctosCp { get; set; }
        public virtual DbSet<ImportesDoctosCpImptos> ImportesDoctosCpImptos { get; set; }
        public virtual DbSet<ImportesDoctosPendCc> ImportesDoctosPendCc { get; set; }
        public virtual DbSet<Impuestos> Impuestos { get; set; }
        public virtual DbSet<ImpuestosArticulos> ImpuestosArticulos { get; set; }
        public virtual DbSet<ImpuestosDoctosCm> ImpuestosDoctosCm { get; set; }
        public virtual DbSet<ImpuestosDoctosCmDet> ImpuestosDoctosCmDet { get; set; }
        public virtual DbSet<ImpuestosDoctosPv> ImpuestosDoctosPv { get; set; }
        public virtual DbSet<ImpuestosDoctosPvDet> ImpuestosDoctosPvDet { get; set; }
        public virtual DbSet<ImpuestosDoctosVe> ImpuestosDoctosVe { get; set; }
        public virtual DbSet<ImpuestosDoctosVeDet> ImpuestosDoctosVeDet { get; set; }
        public virtual DbSet<ImpuestosGravados> ImpuestosGravados { get; set; }
        public virtual DbSet<Incapacidades> Incapacidades { get; set; }
        public virtual DbSet<Incidencias> Incidencias { get; set; }
        public virtual DbSet<Inpc> Inpc { get; set; }
        public virtual DbSet<JuegosAEnsamblar> JuegosAEnsamblar { get; set; }
        public virtual DbSet<JuegosDet> JuegosDet { get; set; }
        public virtual DbSet<LibresActFijos> LibresActFijos { get; set; }
        public virtual DbSet<LibresArticulos> LibresArticulos { get; set; }
        public virtual DbSet<LibresCargosCc> LibresCargosCc { get; set; }
        public virtual DbSet<LibresCargosCp> LibresCargosCp { get; set; }
        public virtual DbSet<LibresCargosPerCc> LibresCargosPerCc { get; set; }
        public virtual DbSet<LibresClientes> LibresClientes { get; set; }
        public virtual DbSet<LibresComCm> LibresComCm { get; set; }
        public virtual DbSet<LibresCotVe> LibresCotVe { get; set; }
        public virtual DbSet<LibresCreditosCc> LibresCreditosCc { get; set; }
        public virtual DbSet<LibresCreditosCp> LibresCreditosCp { get; set; }
        public virtual DbSet<LibresCtasBan> LibresCtasBan { get; set; }
        public virtual DbSet<LibresCuentasCo> LibresCuentasCo { get; set; }
        public virtual DbSet<LibresDevcomCm> LibresDevcomCm { get; set; }
        public virtual DbSet<LibresDevfacVe> LibresDevfacVe { get; set; }
        public virtual DbSet<LibresDevrecCm> LibresDevrecCm { get; set; }
        public virtual DbSet<LibresDevremVe> LibresDevremVe { get; set; }
        public virtual DbSet<LibresEmpleados> LibresEmpleados { get; set; }
        public virtual DbSet<LibresEntradasIn> LibresEntradasIn { get; set; }
        public virtual DbSet<LibresFacVe> LibresFacVe { get; set; }
        public virtual DbSet<LibresInvfis> LibresInvfis { get; set; }
        public virtual DbSet<LibresOcoCm> LibresOcoCm { get; set; }
        public virtual DbSet<LibresOrdvtaPv> LibresOrdvtaPv { get; set; }
        public virtual DbSet<LibresPedVe> LibresPedVe { get; set; }
        public virtual DbSet<LibresPolCo> LibresPolCo { get; set; }
        public virtual DbSet<LibresProveedor> LibresProveedor { get; set; }
        public virtual DbSet<LibresRecCm> LibresRecCm { get; set; }
        public virtual DbSet<LibresRemVe> LibresRemVe { get; set; }
        public virtual DbSet<LibresSalidasIn> LibresSalidasIn { get; set; }
        public virtual DbSet<LineasArticulos> LineasArticulos { get; set; }
        public virtual DbSet<LineasArticulosWeb> LineasArticulosWeb { get; set; }
        public virtual DbSet<ListaElimHist> ListaElimHist { get; set; }
        public virtual DbSet<ListasAtributos> ListasAtributos { get; set; }
        public virtual DbSet<LugaresExpedicion> LugaresExpedicion { get; set; }
        public virtual DbSet<MensajesGuids> MensajesGuids { get; set; }
        public virtual DbSet<Monedas> Monedas { get; set; }
        public virtual DbSet<MovtosAhorroEmp> MovtosAhorroEmp { get; set; }
        public virtual DbSet<MovtosCajas> MovtosCajas { get; set; }
        public virtual DbSet<MovtosCajasCajeros> MovtosCajasCajeros { get; set; }
        public virtual DbSet<MovtosCajasFondo> MovtosCajasFondo { get; set; }
        public virtual DbSet<MovtosEfvoCaja> MovtosEfvoCaja { get; set; }
        public virtual DbSet<NivelesArticulos> NivelesArticulos { get; set; }
        public virtual DbSet<Nominas> Nominas { get; set; }
        public virtual DbSet<OfertasMm> OfertasMm { get; set; }
        public virtual DbSet<OfertasMmDet> OfertasMmDet { get; set; }
        public virtual DbSet<PagosNomina> PagosNomina { get; set; }
        public virtual DbSet<PagosNominaCancelados> PagosNominaCancelados { get; set; }
        public virtual DbSet<PagosNominaDet> PagosNominaDet { get; set; }
        public virtual DbSet<PagosNominaVac> PagosNominaVac { get; set; }
        public virtual DbSet<Paises> Paises { get; set; }
        public virtual DbSet<PedidosWeb> PedidosWeb { get; set; }
        public virtual DbSet<Pedimentos> Pedimentos { get; set; }
        public virtual DbSet<PeriodosVac> PeriodosVac { get; set; }
        public virtual DbSet<PlanesVisitas> PlanesVisitas { get; set; }
        public virtual DbSet<PlanesVisitasDet> PlanesVisitasDet { get; set; }
        public virtual DbSet<PlantillasPolCo> PlantillasPolCo { get; set; }
        public virtual DbSet<PlantillasPolCoDet> PlantillasPolCoDet { get; set; }
        public virtual DbSet<PlazosCondPag> PlazosCondPag { get; set; }
        public virtual DbSet<PlazosCondPagCp> PlazosCondPagCp { get; set; }
        public virtual DbSet<PoliticasComisionesCobradores> PoliticasComisionesCobradores { get; set; }
        public virtual DbSet<PoliticasComisionesVendedores> PoliticasComisionesVendedores { get; set; }
        public virtual DbSet<PoliticasDsctosArtCli> PoliticasDsctosArtCli { get; set; }
        public virtual DbSet<PoliticasDsctosMaximos> PoliticasDsctosMaximos { get; set; }
        public virtual DbSet<PoliticasDsctosPromoProv> PoliticasDsctosPromoProv { get; set; }
        public virtual DbSet<PoliticasDsctosPromocion> PoliticasDsctosPromocion { get; set; }
        public virtual DbSet<PoliticasDsctosVolProv> PoliticasDsctosVolProv { get; set; }
        public virtual DbSet<PoliticasDsctosVolumen> PoliticasDsctosVolumen { get; set; }
        public virtual DbSet<PoliticasPreciosClientes> PoliticasPreciosClientes { get; set; }
        public virtual DbSet<PoliticasPreciosProv> PoliticasPreciosProv { get; set; }
        public virtual DbSet<Polizas> Polizas { get; set; }
        public virtual DbSet<PolizasCfdi> PolizasCfdi { get; set; }
        public virtual DbSet<PreciosArticulos> PreciosArticulos { get; set; }
        public virtual DbSet<PreciosCliCli> PreciosCliCli { get; set; }
        public virtual DbSet<PreciosCliTipo> PreciosCliTipo { get; set; }
        public virtual DbSet<PreciosCliZona> PreciosCliZona { get; set; }
        public virtual DbSet<PreciosCompra> PreciosCompra { get; set; }
        public virtual DbSet<PreciosCompraDet> PreciosCompraDet { get; set; }
        public virtual DbSet<PreciosEmpresa> PreciosEmpresa { get; set; }
        public virtual DbSet<PreciosProv> PreciosProv { get; set; }
        public virtual DbSet<PrestamosEmp> PrestamosEmp { get; set; }
        public virtual DbSet<Presupuestos> Presupuestos { get; set; }
        public virtual DbSet<ProrrateosDet> ProrrateosDet { get; set; }
        public virtual DbSet<Proveedores> Proveedores { get; set; }
        public virtual DbSet<PuestosNo> PuestosNo { get; set; }
        public virtual DbSet<RazonesVisInef> RazonesVisInef { get; set; }
        public virtual DbSet<Recordatorios> Recordatorios { get; set; }
        public virtual DbSet<RedondeoPrecios> RedondeoPrecios { get; set; }
        public virtual DbSet<RegPatronales> RegPatronales { get; set; }
        public virtual DbSet<Registry> Registry { get; set; }
        public virtual DbSet<RepositorioCfdi> RepositorioCfdi { get; set; }
        public virtual DbSet<ResumenElimHistIn> ResumenElimHistIn { get; set; }
        public virtual DbSet<RolesClavesArticulos> RolesClavesArticulos { get; set; }
        public virtual DbSet<RolesClavesClientes> RolesClavesClientes { get; set; }
        public virtual DbSet<RolesClavesEmpleados> RolesClavesEmpleados { get; set; }
        public virtual DbSet<RolesClavesProveedores> RolesClavesProveedores { get; set; }
        public virtual DbSet<RolesImagenesActivosFijos> RolesImagenesActivosFijos { get; set; }
        public virtual DbSet<RolesImagenesArticulos> RolesImagenesArticulos { get; set; }
        public virtual DbSet<RolesImagenesClientes> RolesImagenesClientes { get; set; }
        public virtual DbSet<RolesImagenesEmpleados> RolesImagenesEmpleados { get; set; }
        public virtual DbSet<RolesImagenesProveedores> RolesImagenesProveedores { get; set; }
        public virtual DbSet<Rutas> Rutas { get; set; }
        public virtual DbSet<RutasDet> RutasDet { get; set; }
        public virtual DbSet<SalariosMin> SalariosMin { get; set; }
        public virtual DbSet<SaldosBa> SaldosBa { get; set; }
        public virtual DbSet<SaldosCc> SaldosCc { get; set; }
        public virtual DbSet<SaldosCo> SaldosCo { get; set; }
        public virtual DbSet<SaldosCp> SaldosCp { get; set; }
        public virtual DbSet<SaldosEdofin> SaldosEdofin { get; set; }
        public virtual DbSet<SaldosIn> SaldosIn { get; set; }
        public virtual DbSet<Semaforos> Semaforos { get; set; }
        public virtual DbSet<SnubeComandosAgente> SnubeComandosAgente { get; set; }
        public virtual DbSet<SnubeConciliacionInfo> SnubeConciliacionInfo { get; set; }
        public virtual DbSet<SnubeEventosTemp> SnubeEventosTemp { get; set; }
        public virtual DbSet<SnubeGttEventos> SnubeGttEventos { get; set; }
        public virtual DbSet<SnubeMapeos> SnubeMapeos { get; set; }
        public virtual DbSet<SnubeSucursales> SnubeSucursales { get; set; }
        public virtual DbSet<SnubeSucursalesConsultas> SnubeSucursalesConsultas { get; set; }
        public virtual DbSet<SnubeSucursalesDispersion> SnubeSucursalesDispersion { get; set; }
        public virtual DbSet<SnubeSucursalesLlaves> SnubeSucursalesLlaves { get; set; }
        public virtual DbSet<SubMovtosCc> SubMovtosCc { get; set; }
        public virtual DbSet<SubMovtosCp> SubMovtosCp { get; set; }
        public virtual DbSet<SubMovtosIn> SubMovtosIn { get; set; }
        public virtual DbSet<SubMovtosPv> SubMovtosPv { get; set; }
        public virtual DbSet<SubMovtosVe> SubMovtosVe { get; set; }
        public virtual DbSet<SubcontratosEmp> SubcontratosEmp { get; set; }
        public virtual DbSet<Sucursales> Sucursales { get; set; }
        public virtual DbSet<TablasNo> TablasNo { get; set; }
        public virtual DbSet<TablasNoDet> TablasNoDet { get; set; }
        public virtual DbSet<TempVentasDesgl> TempVentasDesgl { get; set; }
        public virtual DbSet<TercerosCo> TercerosCo { get; set; }
        public virtual DbSet<TiposBitacoras> TiposBitacoras { get; set; }
        public virtual DbSet<TiposClientes> TiposClientes { get; set; }
        public virtual DbSet<TiposContratosLft> TiposContratosLft { get; set; }
        public virtual DbSet<TiposCtasBan> TiposCtasBan { get; set; }
        public virtual DbSet<TiposDispositivos> TiposDispositivos { get; set; }
        public virtual DbSet<TiposImpuestos> TiposImpuestos { get; set; }
        public virtual DbSet<TiposIsn> TiposIsn { get; set; }
        public virtual DbSet<TiposPolizas> TiposPolizas { get; set; }
        public virtual DbSet<TiposPolizasDet> TiposPolizasDet { get; set; }
        public virtual DbSet<TiposProv> TiposProv { get; set; }
        public virtual DbSet<TiposTablasNo> TiposTablasNo { get; set; }
        public virtual DbSet<TraspasosBa> TraspasosBa { get; set; }
        public virtual DbSet<UnidadesVenta> UnidadesVenta { get; set; }
        public virtual DbSet<UsosAnticiposCc> UsosAnticiposCc { get; set; }
        public virtual DbSet<UsosCapasCostos> UsosCapasCostos { get; set; }
        public virtual DbSet<UsosCapasPedimentos> UsosCapasPedimentos { get; set; }
        public virtual DbSet<UsosFoliosFiscales> UsosFoliosFiscales { get; set; }
        public virtual DbSet<UsosFoliosFiscalesCancelados> UsosFoliosFiscalesCancelados { get; set; }
        public virtual DbSet<UsosPeriodosVac> UsosPeriodosVac { get; set; }
        public virtual DbSet<Vacaciones> Vacaciones { get; set; }
        public virtual DbSet<ValoresAtribArtsVariantes> ValoresAtribArtsVariantes { get; set; }
        public virtual DbSet<VariantesArts> VariantesArts { get; set; }
        public virtual DbSet<VariantesArtsDet> VariantesArtsDet { get; set; }
        public virtual DbSet<VencimientosCargosCc> VencimientosCargosCc { get; set; }
        public virtual DbSet<VencimientosCargosCm> VencimientosCargosCm { get; set; }
        public virtual DbSet<VencimientosCargosCp> VencimientosCargosCp { get; set; }
        public virtual DbSet<VencimientosCargosPendCc> VencimientosCargosPendCc { get; set; }
        public virtual DbSet<VencimientosCargosVe> VencimientosCargosVe { get; set; }
        public virtual DbSet<Vendedores> Vendedores { get; set; }
        public virtual DbSet<VersionesDb> VersionesDb { get; set; }
        public virtual DbSet<ViasEmbarque> ViasEmbarque { get; set; }
        public virtual DbSet<ViaticosNo> ViaticosNo { get; set; }
        public virtual DbSet<ViaticosNoCancelados> ViaticosNoCancelados { get; set; }
        public virtual DbSet<ViaticosNoDet> ViaticosNoDet { get; set; }
        public virtual DbSet<Visitas> Visitas { get; set; }
        public virtual DbSet<ZonasClientes> ZonasClientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(" Data Source=localhost\\sqlexpress;Initial Catalog=Microsip;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActivosFijos>(entity =>
            {
                entity.HasKey(e => e.ActivoFijoId)
                    .HasName("activos_fijos_pk");

                entity.ToTable("activos_fijos");

                entity.HasIndex(e => e.Nombre)
                    .HasName("activos_fijos_ie1");

                entity.Property(e => e.ActivoFijoId)
                    .HasColumnName("activo_fijo_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CausaBaja)
                    .HasColumnName("causa_baja")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CrearPolizasDepcon)
                    .HasColumnName("crear_polizas_depcon")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CrearPolizasDepfis)
                    .HasColumnName("crear_polizas_depfis")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CuentaDepconDepId).HasColumnName("cuenta_depcon_dep_id");

                entity.Property(e => e.CuentaDepconGasId).HasColumnName("cuenta_depcon_gas_id");

                entity.Property(e => e.CuentaDepfisDepId).HasColumnName("cuenta_depfis_dep_id");

                entity.Property(e => e.CuentaDepfisGasId).HasColumnName("cuenta_depfis_gas_id");

                entity.Property(e => e.DeducInmed)
                    .HasColumnName("deduc_inmed")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Depcon)
                    .HasColumnName("depcon")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Depfis)
                    .HasColumnName("depfis")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DeptoDepconDepId).HasColumnName("depto_depcon_dep_id");

                entity.Property(e => e.DeptoDepconGasId).HasColumnName("depto_depcon_gas_id");

                entity.Property(e => e.DeptoDepfisDepId).HasColumnName("depto_depfis_dep_id");

                entity.Property(e => e.DeptoDepfisGasId).HasColumnName("depto_depfis_gas_id");

                entity.Property(e => e.Estatus)
                    .IsRequired()
                    .HasColumnName("estatus")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.FechaAdq)
                    .HasColumnName("fecha_adq")
                    .HasColumnType("date");

                entity.Property(e => e.FechaBaja)
                    .HasColumnName("fecha_baja")
                    .HasColumnType("date");

                entity.Property(e => e.FechaFinDepcon)
                    .HasColumnName("fecha_fin_depcon")
                    .HasColumnType("date");

                entity.Property(e => e.FechaFinDepfis)
                    .HasColumnName("fecha_fin_depfis")
                    .HasColumnType("date");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.FechaIniDeducInmed)
                    .HasColumnName("fecha_ini_deduc_inmed")
                    .HasColumnType("date");

                entity.Property(e => e.FechaIniDepcon)
                    .HasColumnName("fecha_ini_depcon")
                    .HasColumnType("date");

                entity.Property(e => e.FechaIniDepfis)
                    .HasColumnName("fecha_ini_depfis")
                    .HasColumnType("date");

                entity.Property(e => e.GrupoActfijoId).HasColumnName("grupo_actfijo_id");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Notas)
                    .HasColumnName("notas")
                    .IsUnicode(false);

                entity.Property(e => e.PctjeDeducInmed)
                    .HasColumnName("pctje_deduc_inmed")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.PctjeDepcon)
                    .HasColumnName("pctje_depcon")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.PctjeDepfis)
                    .HasColumnName("pctje_depfis")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.ValorAdq)
                    .HasColumnName("valor_adq")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ValorDepfis)
                    .HasColumnName("valor_depfis")
                    .HasColumnType("decimal(15, 2)");

                entity.HasOne(d => d.CuentaDepconDep)
                    .WithMany(p => p.ActivosFijosCuentaDepconDep)
                    .HasForeignKey(d => d.CuentaDepconDepId)
                    .HasConstraintName("ctas_co_a_depcon_dep");

                entity.HasOne(d => d.CuentaDepconGas)
                    .WithMany(p => p.ActivosFijosCuentaDepconGas)
                    .HasForeignKey(d => d.CuentaDepconGasId)
                    .HasConstraintName("ctas_co_a_depcon_gas");

                entity.HasOne(d => d.CuentaDepfisDep)
                    .WithMany(p => p.ActivosFijosCuentaDepfisDep)
                    .HasForeignKey(d => d.CuentaDepfisDepId)
                    .HasConstraintName("ctas_co_a_depfis_dep");

                entity.HasOne(d => d.CuentaDepfisGas)
                    .WithMany(p => p.ActivosFijosCuentaDepfisGas)
                    .HasForeignKey(d => d.CuentaDepfisGasId)
                    .HasConstraintName("ctas_co_a_depfis_gas");

                entity.HasOne(d => d.DeptoDepconDep)
                    .WithMany(p => p.ActivosFijosDeptoDepconDep)
                    .HasForeignKey(d => d.DeptoDepconDepId)
                    .HasConstraintName("deptos_co_a_depcon_dep");

                entity.HasOne(d => d.DeptoDepconGas)
                    .WithMany(p => p.ActivosFijosDeptoDepconGas)
                    .HasForeignKey(d => d.DeptoDepconGasId)
                    .HasConstraintName("deptos_co_a_depcon_gas");

                entity.HasOne(d => d.DeptoDepfisDep)
                    .WithMany(p => p.ActivosFijosDeptoDepfisDep)
                    .HasForeignKey(d => d.DeptoDepfisDepId)
                    .HasConstraintName("deptos_co_a_depfis_dep");

                entity.HasOne(d => d.DeptoDepfisGas)
                    .WithMany(p => p.ActivosFijosDeptoDepfisGas)
                    .HasForeignKey(d => d.DeptoDepfisGasId)
                    .HasConstraintName("deptos_co_a_depfis_gas");

                entity.HasOne(d => d.GrupoActfijo)
                    .WithMany(p => p.ActivosFijos)
                    .HasForeignKey(d => d.GrupoActfijoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("grupos_a_act_fijos");
            });

            modelBuilder.Entity<AcumCuentasCoTemp>(entity =>
            {
                entity.HasKey(e => new { e.ProcesoId, e.CuentaJt, e.OrdenDepto, e.ClaveDepto })
                    .HasName("acum_cuentas_co_temp_pk");

                entity.ToTable("acum_cuentas_co_temp");

                entity.Property(e => e.ProcesoId).HasColumnName("proceso_id");

                entity.Property(e => e.CuentaJt)
                    .HasColumnName("cuenta_jt")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.OrdenDepto)
                    .HasColumnName("orden_depto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaveDepto)
                    .HasColumnName("clave_depto")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Cant01)
                    .HasColumnName("cant01")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Cant02)
                    .HasColumnName("cant02")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Cant03)
                    .HasColumnName("cant03")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Cant04)
                    .HasColumnName("cant04")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Cant05)
                    .HasColumnName("cant05")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Cant06)
                    .HasColumnName("cant06")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Cant07)
                    .HasColumnName("cant07")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Cant08)
                    .HasColumnName("cant08")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Cant09)
                    .HasColumnName("cant09")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Cant10)
                    .HasColumnName("cant10")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Cant11)
                    .HasColumnName("cant11")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Cant12)
                    .HasColumnName("cant12")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.CuentaId).HasColumnName("cuenta_id");
            });

            modelBuilder.Entity<Aduanas>(entity =>
            {
                entity.HasKey(e => e.AduanaId)
                    .HasName("aduanas_pk");

                entity.ToTable("aduanas");

                entity.HasIndex(e => e.Nombre)
                    .HasName("aduanas_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.AduanaId)
                    .HasColumnName("aduana_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CiudadId).HasColumnName("ciudad_id");

                entity.Property(e => e.EsPredet)
                    .HasColumnName("es_predet")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Gln)
                    .HasColumnName("gln")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.Ciudad)
                    .WithMany(p => p.Aduanas)
                    .HasForeignKey(d => d.CiudadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ciudades_a_aduanas");
            });

            modelBuilder.Entity<Agentes>(entity =>
            {
                entity.HasKey(e => e.AgenteId)
                    .HasName("agentes_pk");

                entity.ToTable("agentes");

                entity.HasIndex(e => e.Clave)
                    .HasName("agentes_ak2")
                    .IsUnique()
                    .HasFilter("([clave] IS NOT NULL)");

                entity.HasIndex(e => e.Nombre)
                    .HasName("agentes_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.HasIndex(e => e.Usuario)
                    .HasName("agentes_ak3")
                    .IsUnique()
                    .HasFilter("([usuario] IS NOT NULL)");

                entity.Property(e => e.AgenteId)
                    .HasColumnName("agente_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AlmacenId).HasColumnName("almacen_id");

                entity.Property(e => e.Clave)
                    .HasColumnName("clave")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CobradorId).HasColumnName("cobrador_id");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RegistraCobros)
                    .HasColumnName("registra_cobros")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RegistraPedidos)
                    .HasColumnName("registra_pedidos")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasColumnName("usuario")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.VendedorId).HasColumnName("vendedor_id");

                entity.Property(e => e.VersionRegistro).HasColumnName("version_registro");

                entity.HasOne(d => d.Almacen)
                    .WithMany(p => p.Agentes)
                    .HasForeignKey(d => d.AlmacenId)
                    .HasConstraintName("almacenes_a_agentes");

                entity.HasOne(d => d.Cobrador)
                    .WithMany(p => p.Agentes)
                    .HasForeignKey(d => d.CobradorId)
                    .HasConstraintName("cobradores_a_agentes");

                entity.HasOne(d => d.Vendedor)
                    .WithMany(p => p.Agentes)
                    .HasForeignKey(d => d.VendedorId)
                    .HasConstraintName("vendedores_a_agentes");
            });

            modelBuilder.Entity<Almacenes>(entity =>
            {
                entity.HasKey(e => e.AlmacenId)
                    .HasName("almacenes_pk");

                entity.ToTable("almacenes");

                entity.HasIndex(e => e.Nombre)
                    .HasName("almacenes_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.AlmacenId)
                    .HasColumnName("almacen_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Calle)
                    .HasColumnName("calle")
                    .HasMaxLength(430)
                    .IsUnicode(false);

                entity.Property(e => e.Ciudad)
                    .HasColumnName("ciudad")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CiudadId).HasColumnName("ciudad_id");

                entity.Property(e => e.CodigoPostal)
                    .HasColumnName("codigo_postal")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Colonia)
                    .HasColumnName("colonia")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaAlmacen)
                    .HasColumnName("cuenta_almacen")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaCompras)
                    .HasColumnName("cuenta_compras")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaCostoVenta)
                    .HasColumnName("cuenta_costo_venta")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaDevolCompras)
                    .HasColumnName("cuenta_devol_compras")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaDevolVentas)
                    .HasColumnName("cuenta_devol_ventas")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaVentas)
                    .HasColumnName("cuenta_ventas")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EsPpal)
                    .HasColumnName("es_ppal")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EsPredet)
                    .HasColumnName("es_predet")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreAbrev)
                    .IsRequired()
                    .HasColumnName("nombre_abrev")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCalle)
                    .HasColumnName("nombre_calle")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumExterior)
                    .HasColumnName("num_exterior")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumInterior)
                    .HasColumnName("num_interior")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Pais)
                    .HasColumnName("pais")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Poblacion)
                    .HasColumnName("poblacion")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Referencia)
                    .HasColumnName("referencia")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono1)
                    .HasColumnName("telefono1")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono2)
                    .HasColumnName("telefono2")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.CiudadNavigation)
                    .WithMany(p => p.Almacenes)
                    .HasForeignKey(d => d.CiudadId)
                    .HasConstraintName("ciudades_a_almacenes");
            });

            modelBuilder.Entity<AnticiposCc>(entity =>
            {
                entity.HasKey(e => e.AnticipoCcId)
                    .HasName("anticipos_cc_pk");

                entity.ToTable("anticipos_cc");

                entity.Property(e => e.AnticipoCcId)
                    .HasColumnName("anticipo_cc_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClienteId).HasColumnName("cliente_id");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estatus)
                    .IsRequired()
                    .HasColumnName("estatus")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.Folio)
                    .IsRequired()
                    .HasColumnName("folio")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TieneImpuesto)
                    .IsRequired()
                    .HasColumnName("tiene_impuesto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.AnticiposCc)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cliente_a_anticipos_cc");
            });

            modelBuilder.Entity<Articulos>(entity =>
            {
                entity.HasKey(e => e.ArticuloId)
                    .HasName("articulos_pk1");

                entity.ToTable("articulos");

                entity.HasIndex(e => e.Nombre)
                    .HasName("articulos_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.ArticuloId)
                    .HasColumnName("articulo_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AplicarFactorVenta)
                    .IsRequired()
                    .HasColumnName("aplicar_factor_venta")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CausaSusp)
                    .HasColumnName("causa_susp")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContenidoUnidadCompra)
                    .HasColumnName("contenido_unidad_compra")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.CuentaAlmacen)
                    .HasColumnName("cuenta_almacen")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaCompras)
                    .HasColumnName("cuenta_compras")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaCostoVenta)
                    .HasColumnName("cuenta_costo_venta")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaDevolCompras)
                    .HasColumnName("cuenta_devol_compras")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaDevolVentas)
                    .HasColumnName("cuenta_devol_ventas")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaVentas)
                    .HasColumnName("cuenta_ventas")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DiasGarantia).HasColumnName("dias_garantia");

                entity.Property(e => e.EsAlmacenable)
                    .HasColumnName("es_almacenable")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EsImportado)
                    .HasColumnName("es_importado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EsJuego)
                    .HasColumnName("es_juego")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EsPesoVariable)
                    .HasColumnName("es_peso_variable")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EsPrecioVariable)
                    .HasColumnName("es_precio_variable")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EsSiempreImportado)
                    .HasColumnName("es_siempre_importado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estatus)
                    .IsRequired()
                    .HasColumnName("estatus")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.FactorRedPrecioConImpto)
                    .HasColumnName("factor_red_precio_con_impto")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.FactorVenta)
                    .HasColumnName("factor_venta")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.FechaSusp)
                    .HasColumnName("fecha_susp")
                    .HasColumnType("date");

                entity.Property(e => e.ImprimirComp)
                    .HasColumnName("imprimir_comp")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ImprimirNotasCompras)
                    .HasColumnName("imprimir_notas_compras")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ImprimirNotasVentas)
                    .HasColumnName("imprimir_notas_ventas")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LineaArticuloId).HasColumnName("linea_articulo_id");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NotasCompras)
                    .HasColumnName("notas_compras")
                    .IsUnicode(false);

                entity.Property(e => e.NotasVentas)
                    .HasColumnName("notas_ventas")
                    .IsUnicode(false);

                entity.Property(e => e.PctjeArancel)
                    .HasColumnName("pctje_arancel")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.PermitirAgregarComp)
                    .HasColumnName("permitir_agregar_comp")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PesoUnitario)
                    .HasColumnName("peso_unitario")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.RedPrecioConImpto)
                    .IsRequired()
                    .HasColumnName("red_precio_con_impto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Seguimiento)
                    .HasColumnName("seguimiento")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.UnidadCompra)
                    .HasColumnName("unidad_compra")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UnidadVenta)
                    .HasColumnName("unidad_venta")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.LineaArticulo)
                    .WithMany(p => p.Articulos)
                    .HasForeignKey(d => d.LineaArticuloId)
                    .HasConstraintName("lineas_a_articulos");
            });

            modelBuilder.Entity<ArticulosClientes>(entity =>
            {
                entity.HasKey(e => e.ArtCliId)
                    .HasName("articulos_clientes_pk");

                entity.ToTable("articulos_clientes");

                entity.HasIndex(e => new { e.ClienteId, e.ArticuloId })
                    .HasName("articulos_clientes_ak1")
                    .IsUnique()
                    .HasFilter("([cliente_id] IS NOT NULL AND [articulo_id] IS NOT NULL)");

                entity.HasIndex(e => new { e.ClienteId, e.ClaveArtCli })
                    .HasName("articulos_clientes_ie1");

                entity.Property(e => e.ArtCliId)
                    .HasColumnName("art_cli_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArticuloId).HasColumnName("articulo_id");

                entity.Property(e => e.CamposAddenda)
                    .HasColumnName("campos_addenda")
                    .IsUnicode(false);

                entity.Property(e => e.ClaveArtCli)
                    .HasColumnName("clave_art_cli")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClaveArticulo)
                    .HasColumnName("clave_articulo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteId).HasColumnName("cliente_id");

                entity.HasOne(d => d.Articulo)
                    .WithMany(p => p.ArticulosClientes)
                    .HasForeignKey(d => d.ArticuloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("art_a_articulos_clientes");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.ArticulosClientes)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cli_a_articulos_clientes");
            });

            modelBuilder.Entity<ArticulosDiscretos>(entity =>
            {
                entity.HasKey(e => e.ArtDiscretoId)
                    .HasName("articulos_discretos_pk");

                entity.ToTable("articulos_discretos");

                entity.HasIndex(e => new { e.ArticuloId, e.Clave })
                    .HasName("articulos_discretos_ak1")
                    .IsUnique()
                    .HasFilter("([articulo_id] IS NOT NULL AND [clave] IS NOT NULL)");

                entity.Property(e => e.ArtDiscretoId)
                    .HasColumnName("art_discreto_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArticuloId).HasColumnName("articulo_id");

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasColumnName("clave")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("tipo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Articulo)
                    .WithMany(p => p.ArticulosDiscretos)
                    .HasForeignKey(d => d.ArticuloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("arts_a_discretos");
            });

            modelBuilder.Entity<ArticulosTiendaLinea>(entity =>
            {
                entity.ToTable("articulos_tienda_linea");

                entity.HasIndex(e => e.ArticuloTwId)
                    .HasName("articulos_tienda_linea_ie1");

                entity.Property(e => e.ArticulosTiendaLineaId)
                    .HasColumnName("articulos_tienda_linea_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArticuloId).HasColumnName("articulo_id");

                entity.Property(e => e.ArticuloTwId)
                    .IsRequired()
                    .HasColumnName("articulo_tw_id")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClaveSis)
                    .IsRequired()
                    .HasColumnName("clave_sis")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Articulo)
                    .WithMany(p => p.ArticulosTiendaLinea)
                    .HasForeignKey(d => d.ArticuloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("articulos_a_arts_tienda_linea");
            });

            modelBuilder.Entity<ArticulosVariantes>(entity =>
            {
                entity.HasKey(e => e.ArtPadreVarId)
                    .HasName("articulos_variantes_pk");

                entity.ToTable("articulos_variantes");

                entity.Property(e => e.ArtPadreVarId)
                    .HasColumnName("art_padre_var_id")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.ArtPadreVar)
                    .WithOne(p => p.ArticulosVariantes)
                    .HasForeignKey<ArticulosVariantes>(d => d.ArtPadreVarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("articulos_a_art_vars");
            });

            modelBuilder.Entity<ArticulosWeb>(entity =>
            {
                entity.HasKey(e => e.ArticuloWebId)
                    .HasName("articulos_web_pk");

                entity.ToTable("articulos_web");

                entity.HasIndex(e => new { e.ClaveSis, e.Politica, e.ArticuloId })
                    .HasName("articulos_web_ak1")
                    .IsUnique()
                    .HasFilter("([clave_sis] IS NOT NULL AND [politica] IS NOT NULL AND [articulo_id] IS NOT NULL)");

                entity.Property(e => e.ArticuloWebId)
                    .HasColumnName("articulo_web_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Accion)
                    .HasColumnName("accion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ArticuloId).HasColumnName("articulo_id");

                entity.Property(e => e.ClaveSis)
                    .HasColumnName("clave_sis")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Politica)
                    .HasColumnName("politica")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Articulo)
                    .WithMany(p => p.ArticulosWeb)
                    .HasForeignKey(d => d.ArticuloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("articulos_a_arts_web");
            });

            modelBuilder.Entity<AtribArtsVariantes>(entity =>
            {
                entity.HasKey(e => e.AtribId)
                    .HasName("atrib_arts_variantes_pk");

                entity.ToTable("atrib_arts_variantes");

                entity.HasIndex(e => new { e.ArtPadreVarId, e.Nombre })
                    .HasName("atrib_arts_variantes_ak1")
                    .IsUnique()
                    .HasFilter("([art_padre_var_id] IS NOT NULL AND [nombre] IS NOT NULL)");

                entity.Property(e => e.AtribId)
                    .HasColumnName("atrib_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArtPadreVarId).HasColumnName("art_padre_var_id");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Posicion).HasColumnName("posicion");

                entity.HasOne(d => d.ArtPadreVar)
                    .WithMany(p => p.AtribArtsVariantes)
                    .HasForeignKey(d => d.ArtPadreVarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("arts_variantes_a_atrib");
            });

            modelBuilder.Entity<Atributos>(entity =>
            {
                entity.HasKey(e => e.AtributoId)
                    .HasName("atributos_pk");

                entity.ToTable("atributos");

                entity.HasIndex(e => new { e.ClaveObjeto, e.Nombre })
                    .HasName("atributos_ak1")
                    .IsUnique()
                    .HasFilter("([clave_objeto] IS NOT NULL AND [nombre] IS NOT NULL)");

                entity.HasIndex(e => new { e.ClaveObjeto, e.NombreColumna })
                    .HasName("atributos_ak2")
                    .IsUnique()
                    .HasFilter("([clave_objeto] IS NOT NULL AND [nombre_columna] IS NOT NULL)");

                entity.Property(e => e.AtributoId)
                    .HasColumnName("atributo_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClaveObjeto)
                    .IsRequired()
                    .HasColumnName("clave_objeto")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .IsUnicode(false);

                entity.Property(e => e.Escala).HasColumnName("escala");

                entity.Property(e => e.Longitud).HasColumnName("longitud");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.NombreColumna)
                    .IsRequired()
                    .HasColumnName("nombre_columna")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.Posicion).HasColumnName("posicion");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("tipo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ValorDefaultCaracter)
                    .HasColumnName("valor_default_caracter")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ValorDefaultNumerico)
                    .HasColumnName("valor_default_numerico")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ValorMaximo)
                    .HasColumnName("valor_maximo")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ValorMinimo)
                    .HasColumnName("valor_minimo")
                    .HasColumnType("decimal(18, 5)");
            });

            modelBuilder.Entity<Bancos>(entity =>
            {
                entity.HasKey(e => e.BancoId)
                    .HasName("bancos_pk");

                entity.ToTable("bancos");

                entity.HasIndex(e => e.Nombre)
                    .HasName("bancos_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.BancoId)
                    .HasColumnName("banco_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClaveFiscal)
                    .HasColumnName("clave_fiscal")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.EsPredet)
                    .HasColumnName("es_predet")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rfc)
                    .HasColumnName("rfc")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Beneficiarios>(entity =>
            {
                entity.HasKey(e => e.BeneficiarioId)
                    .HasName("beneficiarios_pk");

                entity.ToTable("beneficiarios");

                entity.HasIndex(e => e.Nombre)
                    .HasName("beneficiarios_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.BeneficiarioId)
                    .HasColumnName("beneficiario_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Rfc)
                    .HasColumnName("rfc")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.UltBanco)
                    .HasColumnName("ult_banco")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.UltCuentaBan)
                    .HasColumnName("ult_cuenta_ban")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UltNomBancoExt)
                    .HasColumnName("ult_nom_banco_ext")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BookmarksReportes>(entity =>
            {
                entity.HasKey(e => new { e.ReporteId, e.ObjetoId })
                    .HasName("bookmarks_reportes_pk");

                entity.ToTable("bookmarks_reportes");

                entity.Property(e => e.ReporteId).HasColumnName("reporte_id");

                entity.Property(e => e.ObjetoId).HasColumnName("objeto_id");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date")
                    .HasDefaultValueSql("('TODAY')");

                entity.Property(e => e.OrdenSeleccion).HasColumnName("orden_seleccion");
            });

            modelBuilder.Entity<Cajas>(entity =>
            {
                entity.HasKey(e => e.CajaId)
                    .HasName("cajas_pk");

                entity.ToTable("cajas");

                entity.HasIndex(e => e.Nombre)
                    .HasName("cajas_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.CajaId)
                    .HasColumnName("caja_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AlmacenId).HasColumnName("almacen_id");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.FormaCobroPredetId).HasColumnName("forma_cobro_predet_id");

                entity.Property(e => e.ImagenesCajaId).HasColumnName("imagenes_caja_id");

                entity.Property(e => e.ManejarVendedores)
                    .IsRequired()
                    .HasColumnName("manejar_vendedores")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ModificarAlmacen)
                    .IsRequired()
                    .HasColumnName("modificar_almacen")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PausaTerminarVenta)
                    .IsRequired()
                    .HasColumnName("pausa_terminar_venta")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PermiteCobrar)
                    .HasColumnName("permite_cobrar")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.VentasDesde)
                    .HasColumnName("ventas_desde")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('A')");

                entity.HasOne(d => d.Almacen)
                    .WithMany(p => p.Cajas)
                    .HasForeignKey(d => d.AlmacenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("almacenes_a_cajas");

                entity.HasOne(d => d.FormaCobroPredet)
                    .WithMany(p => p.Cajas)
                    .HasForeignKey(d => d.FormaCobroPredetId)
                    .HasConstraintName("formas_cobro_a_cajas");

                entity.HasOne(d => d.ImagenesCaja)
                    .WithMany(p => p.Cajas)
                    .HasForeignKey(d => d.ImagenesCajaId)
                    .HasConstraintName("imagenes_cajas_a_cajas");
            });

            modelBuilder.Entity<CajasCajeros>(entity =>
            {
                entity.HasKey(e => new { e.TipoAcceso, e.CajeroId, e.CajaId })
                    .HasName("cajas_cajeros_pk");

                entity.ToTable("cajas_cajeros");

                entity.Property(e => e.TipoAcceso)
                    .HasColumnName("tipo_acceso")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('O')");

                entity.Property(e => e.CajeroId).HasColumnName("cajero_id");

                entity.Property(e => e.CajaId).HasColumnName("caja_id");

                entity.HasOne(d => d.Caja)
                    .WithMany(p => p.CajasCajeros)
                    .HasForeignKey(d => d.CajaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cajas_a_cajas_cajeros");

                entity.HasOne(d => d.Cajero)
                    .WithMany(p => p.CajasCajeros)
                    .HasForeignKey(d => d.CajeroId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cajeros_a_cajas_cajeros");
            });

            modelBuilder.Entity<Cajeros>(entity =>
            {
                entity.HasKey(e => e.CajeroId)
                    .HasName("cajeros_pk");

                entity.ToTable("cajeros");

                entity.HasIndex(e => e.Usuario)
                    .HasName("cajeros_ak1")
                    .IsUnique()
                    .HasFilter("([usuario] IS NOT NULL)");

                entity.Property(e => e.CajeroId)
                    .HasColumnName("cajero_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AbrirCajas)
                    .IsRequired()
                    .HasColumnName("abrir_cajas")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OperarCajas)
                    .IsRequired()
                    .HasColumnName("operar_cajas")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ReportesCajaAbierta)
                    .HasColumnName("reportes_caja_abierta")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ReportesDelDia)
                    .IsRequired()
                    .HasColumnName("reportes_del_dia")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('C')");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasColumnName("usuario")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CapasCostos>(entity =>
            {
                entity.HasKey(e => e.CapaId)
                    .HasName("capas_costos_pk");

                entity.ToTable("capas_costos");

                entity.HasIndex(e => new { e.ArticuloId, e.AlmacenId, e.CapaAgotada, e.Fecha })
                    .HasName("capas_costos_ie1");

                entity.Property(e => e.CapaId)
                    .HasColumnName("capa_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AlmacenId).HasColumnName("almacen_id");

                entity.Property(e => e.ArticuloId).HasColumnName("articulo_id");

                entity.Property(e => e.CapaAgotada)
                    .HasColumnName("capa_agotada")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Existencia)
                    .HasColumnName("existencia")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.ValorTotal)
                    .HasColumnName("valor_total")
                    .HasColumnType("decimal(15, 2)");

                entity.HasOne(d => d.Almacen)
                    .WithMany(p => p.CapasCostos)
                    .HasForeignKey(d => d.AlmacenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("alms_a_capas_costos");

                entity.HasOne(d => d.Articulo)
                    .WithMany(p => p.CapasCostos)
                    .HasForeignKey(d => d.ArticuloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("arts_a_capas_costos");
            });

            modelBuilder.Entity<CapasPedimentos>(entity =>
            {
                entity.HasKey(e => e.CapaPedimentoId)
                    .HasName("capas_pedimentos_pk");

                entity.ToTable("capas_pedimentos");

                entity.HasIndex(e => new { e.ArticuloId, e.AlmacenId, e.CapaAgotada, e.Fecha })
                    .HasName("capas_pedimentos_ie1");

                entity.Property(e => e.CapaPedimentoId)
                    .HasColumnName("capa_pedimento_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AlmacenId).HasColumnName("almacen_id");

                entity.Property(e => e.ArtDiscretoId).HasColumnName("art_discreto_id");

                entity.Property(e => e.ArticuloId).HasColumnName("articulo_id");

                entity.Property(e => e.CapaAgotada)
                    .IsRequired()
                    .HasColumnName("capa_agotada")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Existencia)
                    .HasColumnName("existencia")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.PedimentoId).HasColumnName("pedimento_id");

                entity.HasOne(d => d.Almacen)
                    .WithMany(p => p.CapasPedimentos)
                    .HasForeignKey(d => d.AlmacenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("almacenes_a_capas_pedimentos");

                entity.HasOne(d => d.ArtDiscreto)
                    .WithMany(p => p.CapasPedimentos)
                    .HasForeignKey(d => d.ArtDiscretoId)
                    .HasConstraintName("discretos_a_capas_pedimentos");

                entity.HasOne(d => d.Articulo)
                    .WithMany(p => p.CapasPedimentos)
                    .HasForeignKey(d => d.ArticuloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("arts_a_capas_pedimentos");

                entity.HasOne(d => d.Pedimento)
                    .WithMany(p => p.CapasPedimentos)
                    .HasForeignKey(d => d.PedimentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pedimentos_a_capas");
            });

            modelBuilder.Entity<CargosPeriodicosCc>(entity =>
            {
                entity.HasKey(e => e.CargoPeriodId)
                    .HasName("cargos_period_cc_pk");

                entity.ToTable("cargos_periodicos_cc");

                entity.Property(e => e.CargoPeriodId)
                    .HasColumnName("cargo_period_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClaveCliente)
                    .HasColumnName("clave_cliente")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteId).HasColumnName("cliente_id");

                entity.Property(e => e.ConceptoCcId).HasColumnName("concepto_cc_id");

                entity.Property(e => e.CondPagoId).HasColumnName("cond_pago_id");

                entity.Property(e => e.CuentaConcepto)
                    .HasColumnName("cuenta_concepto")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.FechaUltAplic)
                    .HasColumnName("fecha_ult_aplic")
                    .HasColumnType("date");

                entity.Property(e => e.GrupoCarPeriodId).HasColumnName("grupo_car_period_id");

                entity.Property(e => e.Importe)
                    .HasColumnName("importe")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Impuesto)
                    .HasColumnName("impuesto")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ImpuestoId).HasColumnName("impuesto_id");

                entity.Property(e => e.ImpuestoIsrRetId).HasColumnName("impuesto_isr_ret_id");

                entity.Property(e => e.ImpuestoIvaRetId).HasColumnName("impuesto_iva_ret_id");

                entity.Property(e => e.IsrRetenido)
                    .HasColumnName("isr_retenido")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.IvaRetenido)
                    .HasColumnName("iva_retenido")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.LugarExpedicionId).HasColumnName("lugar_expedicion_id");

                entity.Property(e => e.MetodoPagoSat)
                    .HasColumnName("metodo_pago_sat")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsoCfdi)
                    .HasColumnName("uso_cfdi")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.CargosPeriodicosCc)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cli_a_car_per_cc");

                entity.HasOne(d => d.ConceptoCc)
                    .WithMany(p => p.CargosPeriodicosCc)
                    .HasForeignKey(d => d.ConceptoCcId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("concep_a_car_per_cc");

                entity.HasOne(d => d.CondPago)
                    .WithMany(p => p.CargosPeriodicosCc)
                    .HasForeignKey(d => d.CondPagoId)
                    .HasConstraintName("cond_a_car_per_cc");

                entity.HasOne(d => d.GrupoCarPeriod)
                    .WithMany(p => p.CargosPeriodicosCc)
                    .HasForeignKey(d => d.GrupoCarPeriodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("grupos_car_per_a_car_per_cc");

                entity.HasOne(d => d.ImpuestoNavigation)
                    .WithMany(p => p.CargosPeriodicosCcImpuestoNavigation)
                    .HasForeignKey(d => d.ImpuestoId)
                    .HasConstraintName("imptos_a_car_per_cc");

                entity.HasOne(d => d.ImpuestoIsrRet)
                    .WithMany(p => p.CargosPeriodicosCcImpuestoIsrRet)
                    .HasForeignKey(d => d.ImpuestoIsrRetId)
                    .HasConstraintName("imptos_a_car_per_cc_isr_ret");

                entity.HasOne(d => d.ImpuestoIvaRet)
                    .WithMany(p => p.CargosPeriodicosCcImpuestoIvaRet)
                    .HasForeignKey(d => d.ImpuestoIvaRetId)
                    .HasConstraintName("imptos_a_car_per_cc_iva_ret");
            });

            modelBuilder.Entity<CentrosCosto>(entity =>
            {
                entity.HasKey(e => e.CentroCostoId)
                    .HasName("centros_costo_pk");

                entity.ToTable("centros_costo");

                entity.HasIndex(e => e.Nombre)
                    .HasName("centros_costo_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.CentroCostoId)
                    .HasColumnName("centro_costo_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EsPredet)
                    .HasColumnName("es_predet")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CertCfdProv>(entity =>
            {
                entity.HasKey(e => e.ProveedorId)
                    .HasName("cert_cfd_prov_pk");

                entity.ToTable("cert_cfd_prov");

                entity.Property(e => e.ProveedorId)
                    .HasColumnName("proveedor_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Certificado)
                    .IsRequired()
                    .HasColumnName("certificado")
                    .IsUnicode(false);

                entity.Property(e => e.NumSerie)
                    .IsRequired()
                    .HasColumnName("num_serie")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Proveedor)
                    .WithOne(p => p.CertCfdProv)
                    .HasForeignKey<CertCfdProv>(d => d.ProveedorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("proveedores_a_cert_cfd_prov");
            });

            modelBuilder.Entity<CfdRecibidos>(entity =>
            {
                entity.HasKey(e => e.CfdRecibidoId)
                    .HasName("cfd_recibidos_pk");

                entity.ToTable("cfd_recibidos");

                entity.HasIndex(e => e.Fecha)
                    .HasName("cfd_recibidos_ie1");

                entity.HasIndex(e => new { e.ClaveSistema, e.DoctoId })
                    .HasName("cfd_recibidos_ak1")
                    .IsUnique()
                    .HasFilter("([clave_sistema] IS NOT NULL AND [docto_id] IS NOT NULL)");

                entity.Property(e => e.CfdRecibidoId)
                    .HasColumnName("cfd_recibido_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CfdiId).HasColumnName("cfdi_id");

                entity.Property(e => e.ClaveSistema)
                    .IsRequired()
                    .HasColumnName("clave_sistema")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DoctoId).HasColumnName("docto_id");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.Xml)
                    .IsRequired()
                    .HasColumnName("xml")
                    .IsUnicode(false);

                entity.HasOne(d => d.Cfdi)
                    .WithMany(p => p.CfdRecibidos)
                    .HasForeignKey(d => d.CfdiId)
                    .HasConstraintName("repos_cfdi_a_cfd_rec");
            });

            modelBuilder.Entity<Ciudades>(entity =>
            {
                entity.HasKey(e => e.CiudadId)
                    .HasName("ciudades_pk");

                entity.ToTable("ciudades");

                entity.HasIndex(e => new { e.Nombre, e.EstadoId })
                    .HasName("ciudades_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL AND [estado_id] IS NOT NULL)");

                entity.Property(e => e.CiudadId)
                    .HasColumnName("ciudad_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClaveFiscal)
                    .HasColumnName("clave_fiscal")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EsPredet)
                    .HasColumnName("es_predet")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EstadoId).HasColumnName("estado_id");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.Ciudades)
                    .HasForeignKey(d => d.EstadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("estados_a_ciudades");
            });

            modelBuilder.Entity<ClasificadoresCat>(entity =>
            {
                entity.HasKey(e => e.ClasificadorId)
                    .HasName("clasif_cat_pk1");

                entity.ToTable("clasificadores_cat");

                entity.HasIndex(e => new { e.TipoObjeto, e.Nombre })
                    .HasName("clasif_cat_ak1")
                    .IsUnique()
                    .HasFilter("([tipo_objeto] IS NOT NULL AND [nombre] IS NOT NULL)");

                entity.Property(e => e.ClasificadorId)
                    .HasColumnName("clasificador_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .IsUnicode(false);

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreAbrev)
                    .IsRequired()
                    .HasColumnName("nombre_abrev")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TipoObjeto)
                    .IsRequired()
                    .HasColumnName("tipo_objeto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClasificadoresCatValores>(entity =>
            {
                entity.HasKey(e => e.ValorClasifId)
                    .HasName("clasif_cat_valores_pk1");

                entity.ToTable("clasificadores_cat_valores");

                entity.HasIndex(e => new { e.ClasificadorId, e.Valor })
                    .HasName("clasif_cat_valores_ak1")
                    .IsUnique()
                    .HasFilter("([clasificador_id] IS NOT NULL AND [valor] IS NOT NULL)");

                entity.Property(e => e.ValorClasifId)
                    .HasColumnName("valor_clasif_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClasificadorId).HasColumnName("clasificador_id");

                entity.Property(e => e.Posicion).HasColumnName("posicion");

                entity.Property(e => e.Valor)
                    .IsRequired()
                    .HasColumnName("valor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Clasificador)
                    .WithMany(p => p.ClasificadoresCatValores)
                    .HasForeignKey(d => d.ClasificadorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("clasif_cat_a_clasif_val");
            });

            modelBuilder.Entity<ClavesArticulos>(entity =>
            {
                entity.HasKey(e => e.ClaveArticuloId)
                    .HasName("claves_articulos_pk");

                entity.ToTable("claves_articulos");

                entity.HasIndex(e => e.ClaveArticulo)
                    .HasName("claves_articulos_ak1")
                    .IsUnique()
                    .HasFilter("([clave_articulo] IS NOT NULL)");

                entity.Property(e => e.ClaveArticuloId)
                    .HasColumnName("clave_articulo_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArticuloId).HasColumnName("articulo_id");

                entity.Property(e => e.ClaveArticulo)
                    .IsRequired()
                    .HasColumnName("clave_articulo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RolClaveArtId).HasColumnName("rol_clave_art_id");

                entity.HasOne(d => d.Articulo)
                    .WithMany(p => p.ClavesArticulos)
                    .HasForeignKey(d => d.ArticuloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("art_a_claves_art");
            });

            modelBuilder.Entity<ClavesCatSec>(entity =>
            {
                entity.HasKey(e => new { e.NombreTabla, e.ElemId })
                    .HasName("claves_cat_sec_pk");

                entity.ToTable("claves_cat_sec");

                entity.HasIndex(e => new { e.NombreTabla, e.Clave })
                    .HasName("claves_cat_sec_ak1")
                    .IsUnique()
                    .HasFilter("([nombre_tabla] IS NOT NULL AND [clave] IS NOT NULL)");

                entity.Property(e => e.NombreTabla)
                    .HasColumnName("nombre_tabla")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.ElemId).HasColumnName("elem_id");

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasColumnName("clave")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClavesClientes>(entity =>
            {
                entity.HasKey(e => e.ClaveClienteId)
                    .HasName("claves_clientes_pk");

                entity.ToTable("claves_clientes");

                entity.HasIndex(e => e.ClaveCliente)
                    .HasName("claves_clientes_ak1")
                    .IsUnique()
                    .HasFilter("([clave_cliente] IS NOT NULL)");

                entity.Property(e => e.ClaveClienteId)
                    .HasColumnName("clave_cliente_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClaveCliente)
                    .IsRequired()
                    .HasColumnName("clave_cliente")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteId).HasColumnName("cliente_id");

                entity.Property(e => e.RolClaveCliId).HasColumnName("rol_clave_cli_id");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.ClavesClientes)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cli_a_claves_cli");
            });

            modelBuilder.Entity<ClavesEmpleados>(entity =>
            {
                entity.HasKey(e => e.ClaveEmpleadoId)
                    .HasName("claves_empleados_pk");

                entity.ToTable("claves_empleados");

                entity.HasIndex(e => e.ClaveEmpleado)
                    .HasName("claves_empleados_ak1")
                    .IsUnique()
                    .HasFilter("([clave_empleado] IS NOT NULL)");

                entity.Property(e => e.ClaveEmpleadoId)
                    .HasColumnName("clave_empleado_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClaveEmpleado)
                    .IsRequired()
                    .HasColumnName("clave_empleado")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmpleadoId).HasColumnName("empleado_id");

                entity.Property(e => e.RolClaveEmpId).HasColumnName("rol_clave_emp_id");

                entity.HasOne(d => d.Empleado)
                    .WithMany(p => p.ClavesEmpleados)
                    .HasForeignKey(d => d.EmpleadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("emp_a_claves_emp");
            });

            modelBuilder.Entity<ClavesProveedores>(entity =>
            {
                entity.HasKey(e => e.ClaveProvId)
                    .HasName("claves_proveedores_pk");

                entity.ToTable("claves_proveedores");

                entity.HasIndex(e => e.ClaveProv)
                    .HasName("claves_proveedores_ak1")
                    .IsUnique()
                    .HasFilter("([clave_prov] IS NOT NULL)");

                entity.Property(e => e.ClaveProvId)
                    .HasColumnName("clave_prov_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClaveProv)
                    .IsRequired()
                    .HasColumnName("clave_prov")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProveedorId).HasColumnName("proveedor_id");

                entity.Property(e => e.RolClaveProvId).HasColumnName("rol_clave_prov_id");

                entity.HasOne(d => d.Proveedor)
                    .WithMany(p => p.ClavesProveedores)
                    .HasForeignKey(d => d.ProveedorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("prov_a_claves_prov");
            });

            modelBuilder.Entity<Clientes>(entity =>
            {
                entity.HasKey(e => e.ClienteId)
                    .HasName("clientes_pk");

                entity.ToTable("clientes");

                entity.HasIndex(e => e.Nombre)
                    .HasName("clientes_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.ClienteId)
                    .HasColumnName("cliente_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CamposAddenda)
                    .HasColumnName("campos_addenda")
                    .IsUnicode(false);

                entity.Property(e => e.CausaSusp)
                    .HasColumnName("causa_susp")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CobradorId).HasColumnName("cobrador_id");

                entity.Property(e => e.CobrarImpuestos)
                    .HasColumnName("cobrar_impuestos")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CondPagoId).HasColumnName("cond_pago_id");

                entity.Property(e => e.Contacto1)
                    .HasColumnName("contacto1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contacto2)
                    .HasColumnName("contacto2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaAnticipos)
                    .HasColumnName("cuenta_anticipos")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaCxc)
                    .HasColumnName("cuenta_cxc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EmitirEdocta)
                    .HasColumnName("emitir_edocta")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estatus)
                    .HasColumnName("estatus")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.FechaSusp)
                    .HasColumnName("fecha_susp")
                    .HasColumnType("date");

                entity.Property(e => e.FormatosEmail)
                    .HasColumnName("formatos_email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GenerarIntereses)
                    .HasColumnName("generar_intereses")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LimiteCredito)
                    .HasColumnName("limite_credito")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.MonedaId).HasColumnName("moneda_id");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Notas)
                    .HasColumnName("notas")
                    .IsUnicode(false);

                entity.Property(e => e.NumProvCliente)
                    .HasColumnName("num_prov_cliente")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.ReceptorCfd)
                    .HasColumnName("receptor_cfd")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RetieneImpuestos)
                    .HasColumnName("retiene_impuestos")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SujetoIeps)
                    .IsRequired()
                    .HasColumnName("sujeto_ieps")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoClienteId).HasColumnName("tipo_cliente_id");

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.VendedorId).HasColumnName("vendedor_id");

                entity.Property(e => e.ZonaClienteId).HasColumnName("zona_cliente_id");

                entity.HasOne(d => d.Cobrador)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.CobradorId)
                    .HasConstraintName("cobrador_a_cli");

                entity.HasOne(d => d.CondPago)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.CondPagoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cond_pago_a_cli");

                entity.HasOne(d => d.Moneda)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.MonedaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("moneda_a_cli");

                entity.HasOne(d => d.TipoCliente)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.TipoClienteId)
                    .HasConstraintName("tipos_cli_a_cli");

                entity.HasOne(d => d.Vendedor)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.VendedorId)
                    .HasConstraintName("vendedor_a_cli");

                entity.HasOne(d => d.ZonaCliente)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.ZonaClienteId)
                    .HasConstraintName("zonas_cli_a_cli");
            });

            modelBuilder.Entity<Cobradores>(entity =>
            {
                entity.HasKey(e => e.CobradorId)
                    .HasName("cobradores_pk");

                entity.ToTable("cobradores");

                entity.HasIndex(e => e.Nombre)
                    .HasName("cobradores_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.CobradorId)
                    .HasColumnName("cobrador_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EsPredet)
                    .HasColumnName("es_predet")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PoliticaComisCobId).HasColumnName("politica_comis_cob_id");

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.PoliticaComisCob)
                    .WithMany(p => p.Cobradores)
                    .HasForeignKey(d => d.PoliticaComisCobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("politicas_comis_a_cob");
            });

            modelBuilder.Entity<ComandosDispositivos>(entity =>
            {
                entity.HasKey(e => e.ComandoDispId)
                    .HasName("comandos_dispositivos_pk");

                entity.ToTable("comandos_dispositivos");

                entity.HasIndex(e => new { e.DispositivoId, e.ComandoTipoDispId })
                    .HasName("comandos_dispositivos_ak1")
                    .IsUnique()
                    .HasFilter("([dispositivo_id] IS NOT NULL AND [comando_tipo_disp_id] IS NOT NULL)");

                entity.Property(e => e.ComandoDispId)
                    .HasColumnName("comando_disp_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ComandoTipoDispId).HasColumnName("comando_tipo_disp_id");

                entity.Property(e => e.DispositivoId).HasColumnName("dispositivo_id");

                entity.Property(e => e.Secuencia)
                    .HasColumnName("secuencia")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ComandoTipoDisp)
                    .WithMany(p => p.ComandosDispositivos)
                    .HasForeignKey(d => d.ComandoTipoDispId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("com_tipos_disp_a_com_disp");

                entity.HasOne(d => d.Dispositivo)
                    .WithMany(p => p.ComandosDispositivos)
                    .HasForeignKey(d => d.DispositivoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("disp_a_comandos_disp");
            });

            modelBuilder.Entity<ComandosTiposDispositivos>(entity =>
            {
                entity.HasKey(e => e.ComandoTipoDispId)
                    .HasName("comandos_tipos_disp_pk");

                entity.ToTable("comandos_tipos_dispositivos");

                entity.HasIndex(e => new { e.TipoDispId, e.Nombre })
                    .HasName("comandos_tipos_disp_ak1")
                    .IsUnique()
                    .HasFilter("([tipo_disp_id] IS NOT NULL AND [nombre] IS NOT NULL)");

                entity.Property(e => e.ComandoTipoDispId)
                    .HasColumnName("comando_tipo_disp_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdInterno)
                    .HasColumnName("id_interno")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Posicion).HasColumnName("posicion");

                entity.Property(e => e.TipoDispId).HasColumnName("tipo_disp_id");

                entity.HasOne(d => d.TipoDisp)
                    .WithMany(p => p.ComandosTiposDispositivos)
                    .HasForeignKey(d => d.TipoDispId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tipos_disp_a_comandos");
            });

            modelBuilder.Entity<ComisCobTipoCli>(entity =>
            {
                entity.ToTable("comis_cob_tipo_cli");

                entity.HasIndex(e => new { e.PoliticaComisCobId, e.TipoClienteId })
                    .HasName("comis_cob_tpocli_ak1")
                    .IsUnique()
                    .HasFilter("([politica_comis_cob_id] IS NOT NULL AND [tipo_cliente_id] IS NOT NULL)");

                entity.Property(e => e.ComisCobTipoCliId)
                    .HasColumnName("comis_cob_tipo_cli_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.PctjeEnSaldoVencido)
                    .HasColumnName("pctje_en_saldo_vencido")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.PctjeEnSaldoXven)
                    .HasColumnName("pctje_en_saldo_xven")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.PoliticaComisCobId).HasColumnName("politica_comis_cob_id");

                entity.Property(e => e.TipoClienteId).HasColumnName("tipo_cliente_id");

                entity.HasOne(d => d.PoliticaComisCob)
                    .WithMany(p => p.ComisCobTipoCli)
                    .HasForeignKey(d => d.PoliticaComisCobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pol_comis_cob_a_comis_tpocli");

                entity.HasOne(d => d.TipoCliente)
                    .WithMany(p => p.ComisCobTipoCli)
                    .HasForeignKey(d => d.TipoClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tpocli_a_comis_cob_tpocli");
            });

            modelBuilder.Entity<ComisCobZona>(entity =>
            {
                entity.ToTable("comis_cob_zona");

                entity.HasIndex(e => new { e.PoliticaComisCobId, e.ZonaClienteId })
                    .HasName("comis_cob_zona_ak1")
                    .IsUnique()
                    .HasFilter("([politica_comis_cob_id] IS NOT NULL AND [zona_cliente_id] IS NOT NULL)");

                entity.Property(e => e.ComisCobZonaId)
                    .HasColumnName("comis_cob_zona_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.PctjeEnSaldoVencido)
                    .HasColumnName("pctje_en_saldo_vencido")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.PctjeEnSaldoXven)
                    .HasColumnName("pctje_en_saldo_xven")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.PoliticaComisCobId).HasColumnName("politica_comis_cob_id");

                entity.Property(e => e.ZonaClienteId).HasColumnName("zona_cliente_id");

                entity.HasOne(d => d.PoliticaComisCob)
                    .WithMany(p => p.ComisCobZona)
                    .HasForeignKey(d => d.PoliticaComisCobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pol_comis_cob_a_comis_zona");

                entity.HasOne(d => d.ZonaCliente)
                    .WithMany(p => p.ComisCobZona)
                    .HasForeignKey(d => d.ZonaClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("zonas_a_comis_cob_zona");
            });

            modelBuilder.Entity<ComisVenArt>(entity =>
            {
                entity.ToTable("comis_ven_art");

                entity.HasIndex(e => new { e.PoliticaComisVenId, e.ArticuloId })
                    .HasName("comis_ven_art_ak1")
                    .IsUnique()
                    .HasFilter("([politica_comis_ven_id] IS NOT NULL AND [articulo_id] IS NOT NULL)");

                entity.Property(e => e.ComisVenArtId)
                    .HasColumnName("comis_ven_art_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArticuloId).HasColumnName("articulo_id");

                entity.Property(e => e.ClaveArticulo)
                    .HasColumnName("clave_articulo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Comision)
                    .HasColumnName("comision")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.PoliticaComisVenId).HasColumnName("politica_comis_ven_id");

                entity.HasOne(d => d.Articulo)
                    .WithMany(p => p.ComisVenArt)
                    .HasForeignKey(d => d.ArticuloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("arts_a_comis_ven_art");

                entity.HasOne(d => d.PoliticaComisVen)
                    .WithMany(p => p.ComisVenArt)
                    .HasForeignKey(d => d.PoliticaComisVenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pol_comis_ven_a_comis_art");
            });

            modelBuilder.Entity<ComisVenCli>(entity =>
            {
                entity.ToTable("comis_ven_cli");

                entity.HasIndex(e => new { e.PoliticaComisVenId, e.ClienteId })
                    .HasName("comis_ven_cli_ak1")
                    .IsUnique()
                    .HasFilter("([politica_comis_ven_id] IS NOT NULL AND [cliente_id] IS NOT NULL)");

                entity.Property(e => e.ComisVenCliId)
                    .HasColumnName("comis_ven_cli_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClaveCliente)
                    .HasColumnName("clave_cliente")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteId).HasColumnName("cliente_id");

                entity.Property(e => e.Comision)
                    .HasColumnName("comision")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.PoliticaComisVenId).HasColumnName("politica_comis_ven_id");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.ComisVenCli)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cli_a_comis_ven_cli");

                entity.HasOne(d => d.PoliticaComisVen)
                    .WithMany(p => p.ComisVenCli)
                    .HasForeignKey(d => d.PoliticaComisVenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pol_comis_ven_a_comis_cli");
            });

            modelBuilder.Entity<ComisVenGrupo>(entity =>
            {
                entity.ToTable("comis_ven_grupo");

                entity.HasIndex(e => new { e.PoliticaComisVenId, e.GrupoLineaId })
                    .HasName("comis_ven_grupo_ak1")
                    .IsUnique()
                    .HasFilter("([politica_comis_ven_id] IS NOT NULL AND [grupo_linea_id] IS NOT NULL)");

                entity.Property(e => e.ComisVenGrupoId)
                    .HasColumnName("comis_ven_grupo_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Comision)
                    .HasColumnName("comision")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.GrupoLineaId).HasColumnName("grupo_linea_id");

                entity.Property(e => e.PoliticaComisVenId).HasColumnName("politica_comis_ven_id");

                entity.HasOne(d => d.GrupoLinea)
                    .WithMany(p => p.ComisVenGrupo)
                    .HasForeignKey(d => d.GrupoLineaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("grupo_a_comis_ven_grupo");

                entity.HasOne(d => d.PoliticaComisVen)
                    .WithMany(p => p.ComisVenGrupo)
                    .HasForeignKey(d => d.PoliticaComisVenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pol_comis_ven_a_comis_grupo");
            });

            modelBuilder.Entity<ComisVenLinea>(entity =>
            {
                entity.ToTable("comis_ven_linea");

                entity.HasIndex(e => new { e.PoliticaComisVenId, e.LineaArticuloId })
                    .HasName("comis_ven_linea_ak1")
                    .IsUnique()
                    .HasFilter("([politica_comis_ven_id] IS NOT NULL AND [linea_articulo_id] IS NOT NULL)");

                entity.Property(e => e.ComisVenLineaId)
                    .HasColumnName("comis_ven_linea_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Comision)
                    .HasColumnName("comision")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.LineaArticuloId).HasColumnName("linea_articulo_id");

                entity.Property(e => e.PoliticaComisVenId).HasColumnName("politica_comis_ven_id");

                entity.HasOne(d => d.LineaArticulo)
                    .WithMany(p => p.ComisVenLinea)
                    .HasForeignKey(d => d.LineaArticuloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("lineas_a_comis_ven_lineas");

                entity.HasOne(d => d.PoliticaComisVen)
                    .WithMany(p => p.ComisVenLinea)
                    .HasForeignKey(d => d.PoliticaComisVenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pol_comis_ven_a_comis_linea");
            });

            modelBuilder.Entity<ComisVenTipoCli>(entity =>
            {
                entity.ToTable("comis_ven_tipo_cli");

                entity.HasIndex(e => new { e.PoliticaComisVenId, e.TipoClienteId })
                    .HasName("comis_ven_tipo_cli_ak1")
                    .IsUnique()
                    .HasFilter("([politica_comis_ven_id] IS NOT NULL AND [tipo_cliente_id] IS NOT NULL)");

                entity.Property(e => e.ComisVenTipoCliId)
                    .HasColumnName("comis_ven_tipo_cli_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Comision)
                    .HasColumnName("comision")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.PoliticaComisVenId).HasColumnName("politica_comis_ven_id");

                entity.Property(e => e.TipoClienteId).HasColumnName("tipo_cliente_id");

                entity.HasOne(d => d.PoliticaComisVen)
                    .WithMany(p => p.ComisVenTipoCli)
                    .HasForeignKey(d => d.PoliticaComisVenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pol_comis_ven_a_comis_tipocli");

                entity.HasOne(d => d.TipoCliente)
                    .WithMany(p => p.ComisVenTipoCli)
                    .HasForeignKey(d => d.TipoClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tpocli_a_comis_ven_tpocli");
            });

            modelBuilder.Entity<ComisVenZona>(entity =>
            {
                entity.ToTable("comis_ven_zona");

                entity.HasIndex(e => new { e.PoliticaComisVenId, e.ZonaClienteId })
                    .HasName("comis_ven_zona_ak1")
                    .IsUnique()
                    .HasFilter("([politica_comis_ven_id] IS NOT NULL AND [zona_cliente_id] IS NOT NULL)");

                entity.Property(e => e.ComisVenZonaId)
                    .HasColumnName("comis_ven_zona_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Comision)
                    .HasColumnName("comision")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.PoliticaComisVenId).HasColumnName("politica_comis_ven_id");

                entity.Property(e => e.ZonaClienteId).HasColumnName("zona_cliente_id");

                entity.HasOne(d => d.PoliticaComisVen)
                    .WithMany(p => p.ComisVenZona)
                    .HasForeignKey(d => d.PoliticaComisVenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pol_comis_ven_a_comis_zona");

                entity.HasOne(d => d.ZonaCliente)
                    .WithMany(p => p.ComisVenZona)
                    .HasForeignKey(d => d.ZonaClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("zona_a_comis_ven_zona");
            });

            modelBuilder.Entity<CompromArticulos>(entity =>
            {
                entity.HasKey(e => e.CompromArtId)
                    .HasName("comprom_articulos_pk");

                entity.ToTable("comprom_articulos");

                entity.HasIndex(e => new { e.ArticuloId, e.AlmacenId })
                    .HasName("comprom_articulos_ak1")
                    .IsUnique()
                    .HasFilter("([articulo_id] IS NOT NULL AND [almacen_id] IS NOT NULL)");

                entity.Property(e => e.CompromArtId)
                    .HasColumnName("comprom_art_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AlmacenId).HasColumnName("almacen_id");

                entity.Property(e => e.ArticuloId).HasColumnName("articulo_id");

                entity.Property(e => e.UnidadesComprom)
                    .HasColumnName("unidades_comprom")
                    .HasColumnType("decimal(18, 5)");

                entity.HasOne(d => d.Almacen)
                    .WithMany(p => p.CompromArticulos)
                    .HasForeignKey(d => d.AlmacenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("alm_a_comprom");

                entity.HasOne(d => d.Articulo)
                    .WithMany(p => p.CompromArticulos)
                    .HasForeignKey(d => d.ArticuloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("arts_a_comprom");
            });

            modelBuilder.Entity<ConceptosBa>(entity =>
            {
                entity.HasKey(e => e.ConceptoBaId)
                    .HasName("conceptos_ba_pk");

                entity.ToTable("conceptos_ba");

                entity.HasIndex(e => e.Nombre)
                    .HasName("conceptos_ba_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.ConceptoBaId)
                    .HasColumnName("concepto_ba_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DiasTransito).HasColumnName("dias_transito");

                entity.Property(e => e.EsPredef)
                    .HasColumnName("es_predef")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EsPredet)
                    .HasColumnName("es_predet")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.IdInterno)
                    .HasColumnName("id_interno")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Naturaleza)
                    .IsRequired()
                    .HasColumnName("naturaleza")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('R')");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreAbrev)
                    .IsRequired()
                    .HasColumnName("nombre_abrev")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PregBeneficiario)
                    .IsRequired()
                    .HasColumnName("preg_beneficiario")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PregPoliza)
                    .IsRequired()
                    .HasColumnName("preg_poliza")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoMovFiscal)
                    .HasColumnName("tipo_mov_fiscal")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoPolizaId).HasColumnName("tipo_poliza_id");

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.TipoPoliza)
                    .WithMany(p => p.ConceptosBa)
                    .HasForeignKey(d => d.TipoPolizaId)
                    .HasConstraintName("tippol_a_concep_ba");
            });

            modelBuilder.Entity<ConceptosCc>(entity =>
            {
                entity.HasKey(e => e.ConceptoCcId)
                    .HasName("conceptos_cc_pk");

                entity.ToTable("conceptos_cc");

                entity.HasIndex(e => e.Nombre)
                    .HasName("conceptos_cc_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.ConceptoCcId)
                    .HasColumnName("concepto_cc_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AfectoAIetu)
                    .HasColumnName("afecto_a_ietu")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AplicarDsctoPpag)
                    .HasColumnName("aplicar_dscto_ppag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AplicarImpuesto)
                    .HasColumnName("aplicar_impuesto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AplicarInteresMor)
                    .HasColumnName("aplicar_interes_mor")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaveProdservSat)
                    .HasColumnName("clave_prodserv_sat")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaveUmedSat)
                    .HasColumnName("clave_umed_sat")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CrearPolizas)
                    .HasColumnName("crear_polizas")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CuentaContable)
                    .HasColumnName("cuenta_contable")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DescConcepXml)
                    .HasColumnName("desc_concep_xml")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DescripcionInmueble)
                    .HasColumnName("descripcion_inmueble")
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionPoliza)
                    .HasColumnName("descripcion_poliza")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EsPredef)
                    .HasColumnName("es_predef")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EsPredet)
                    .HasColumnName("es_predet")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.FolioAutom)
                    .HasColumnName("folio_autom")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdInterno)
                    .HasColumnName("id_interno")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IntegrarComis)
                    .HasColumnName("integrar_comis")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ModalidadFacturacion)
                    .HasColumnName("modalidad_facturacion")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Naturaleza)
                    .HasColumnName("naturaleza")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('C')");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreAbrev)
                    .IsRequired()
                    .HasColumnName("nombre_abrev")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumCtaPredial)
                    .HasColumnName("num_cta_predial")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PregCuenta)
                    .HasColumnName("preg_cuenta")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RetenerIsr)
                    .HasColumnName("retener_isr")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RetenerIva)
                    .HasColumnName("retener_iva")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SigFolio)
                    .HasColumnName("sig_folio")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoPoliza)
                    .HasColumnName("tipo_poliza")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConceptosCp>(entity =>
            {
                entity.HasKey(e => e.ConceptoCpId)
                    .HasName("conceptos_cp_pk");

                entity.ToTable("conceptos_cp");

                entity.HasIndex(e => e.Nombre)
                    .HasName("conceptos_cp_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.ConceptoCpId)
                    .HasColumnName("concepto_cp_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AfectoAIetu)
                    .HasColumnName("afecto_a_ietu")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AplicarDsctoPpag)
                    .HasColumnName("aplicar_dscto_ppag")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AplicarImpuesto)
                    .HasColumnName("aplicar_impuesto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CrearPolizas)
                    .HasColumnName("crear_polizas")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CuentaContable)
                    .HasColumnName("cuenta_contable")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionPoliza)
                    .HasColumnName("descripcion_poliza")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EsBancarizado)
                    .HasColumnName("es_bancarizado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EsPredef)
                    .HasColumnName("es_predef")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EsPredet)
                    .HasColumnName("es_predet")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.FolioAutom)
                    .HasColumnName("folio_autom")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GenerarConstancias)
                    .HasColumnName("generar_constancias")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdInterno)
                    .HasColumnName("id_interno")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Naturaleza)
                    .HasColumnName("naturaleza")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('C')");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreAbrev)
                    .IsRequired()
                    .HasColumnName("nombre_abrev")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PregCuenta)
                    .HasColumnName("preg_cuenta")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RetenerIsr)
                    .HasColumnName("retener_isr")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RetenerIva)
                    .HasColumnName("retener_iva")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SigFolio)
                    .HasColumnName("sig_folio")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoConstancia)
                    .HasColumnName("tipo_constancia")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoPoliza)
                    .HasColumnName("tipo_poliza")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConceptosDimNo>(entity =>
            {
                entity.HasKey(e => e.ConceptoDimNoId)
                    .HasName("conceptos_dim_no_pk");

                entity.ToTable("conceptos_dim_no");

                entity.Property(e => e.ConceptoDimNoId)
                    .HasColumnName("concepto_dim_no_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConceptoDimId).HasColumnName("concepto_dim_id");

                entity.Property(e => e.ConceptoNoId).HasColumnName("concepto_no_id");
            });

            modelBuilder.Entity<ConceptosEmp>(entity =>
            {
                entity.HasKey(e => e.ConcepEmpId)
                    .HasName("conceptos_emp_pk");

                entity.ToTable("conceptos_emp");

                entity.HasIndex(e => new { e.EmpleadoId, e.ConceptoNoId })
                    .HasName("conceptos_emp_ak1")
                    .IsUnique()
                    .HasFilter("([empleado_id] IS NOT NULL AND [concepto_no_id] IS NOT NULL)");

                entity.Property(e => e.ConcepEmpId)
                    .HasColumnName("concep_emp_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AhorroEmpresa)
                    .HasColumnName("ahorro_empresa")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ConceptoNoId).HasColumnName("concepto_no_id");

                entity.Property(e => e.CuentaContable)
                    .HasColumnName("cuenta_contable")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Cuota)
                    .HasColumnName("cuota")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.EmpleadoId).HasColumnName("empleado_id");

                entity.Property(e => e.FechaFinVigencia)
                    .HasColumnName("fecha_fin_vigencia")
                    .HasColumnType("date");

                entity.Property(e => e.FechaIniVigencia)
                    .HasColumnName("fecha_ini_vigencia")
                    .HasColumnType("date");

                entity.Property(e => e.Suspendido)
                    .HasColumnName("suspendido")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Vigencia)
                    .IsRequired()
                    .HasColumnName("vigencia")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Empleado)
                    .WithMany(p => p.ConceptosEmp)
                    .HasForeignKey(d => d.EmpleadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("emp_a_concep_emp");
            });

            modelBuilder.Entity<CondicionesPago>(entity =>
            {
                entity.HasKey(e => e.CondPagoId)
                    .HasName("condiciones_pago_pk");

                entity.ToTable("condiciones_pago");

                entity.HasIndex(e => e.Nombre)
                    .HasName("condiciones_pago_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.CondPagoId)
                    .HasColumnName("cond_pago_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DiasPpag).HasColumnName("dias_ppag");

                entity.Property(e => e.EsPredet)
                    .HasColumnName("es_predet")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PctjeDsctoPpag)
                    .HasColumnName("pctje_dscto_ppag")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CondicionesPagoCp>(entity =>
            {
                entity.HasKey(e => e.CondPagoId)
                    .HasName("condiciones_pago_cp_pk");

                entity.ToTable("condiciones_pago_cp");

                entity.HasIndex(e => e.Nombre)
                    .HasName("condiciones_pago_cp_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.CondPagoId)
                    .HasColumnName("cond_pago_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DiasPpag).HasColumnName("dias_ppag");

                entity.Property(e => e.EsPredet)
                    .HasColumnName("es_predet")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PctjeDsctoPpag)
                    .HasColumnName("pctje_dscto_ppag")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConstanciasRet>(entity =>
            {
                entity.HasKey(e => e.ConstanciaRetId)
                    .HasName("constancias_ret_pk");

                entity.ToTable("constancias_ret");

                entity.HasIndex(e => new { e.ProveedorId, e.TipoConstancia, e.FechaInicial })
                    .HasName("constancias_ret_ie1");

                entity.Property(e => e.ConstanciaRetId)
                    .HasColumnName("constancia_ret_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BaseGravable)
                    .HasColumnName("base_gravable")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Cancelado)
                    .IsRequired()
                    .HasColumnName("cancelado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CfdiCertificado)
                    .IsRequired()
                    .HasColumnName("cfdi_certificado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ClaveProv)
                    .HasColumnName("clave_prov")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmailEnvio)
                    .HasColumnName("email_envio")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Enviado)
                    .IsRequired()
                    .HasColumnName("enviado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EsManual)
                    .IsRequired()
                    .HasColumnName("es_manual")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaFinal)
                    .HasColumnName("fecha_final")
                    .HasColumnType("date");

                entity.Property(e => e.FechaHoraCancelacion).HasColumnName("fecha_hora_cancelacion");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraEnvio).HasColumnName("fecha_hora_envio");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.FechaInicial)
                    .HasColumnName("fecha_inicial")
                    .HasColumnType("date");

                entity.Property(e => e.FormaEmitida)
                    .IsRequired()
                    .HasColumnName("forma_emitida")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hora)
                    .HasColumnName("hora")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsrRetenido)
                    .HasColumnName("isr_retenido")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.IvaRetenido)
                    .HasColumnName("iva_retenido")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.LugarExpedicionId).HasColumnName("lugar_expedicion_id");

                entity.Property(e => e.ProveedorId).HasColumnName("proveedor_id");

                entity.Property(e => e.TipoConstancia)
                    .IsRequired()
                    .HasColumnName("tipo_constancia")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAutCancelacion)
                    .HasColumnName("usuario_aut_cancelacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCancelacion)
                    .HasColumnName("usuario_cancelacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.Proveedor)
                    .WithMany(p => p.ConstanciasRet)
                    .HasForeignKey(d => d.ProveedorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("prov_a_constancias_ret");
            });

            modelBuilder.Entity<ContratosLft>(entity =>
            {
                entity.HasKey(e => e.ContratoLftId)
                    .HasName("contratos_lft_pk");

                entity.ToTable("contratos_lft");

                entity.HasIndex(e => new { e.EmpleadoId, e.FechaInicio })
                    .HasName("contratos_lft_ak1")
                    .IsUnique()
                    .HasFilter("([empleado_id] IS NOT NULL AND [fecha_inicio] IS NOT NULL)");

                entity.Property(e => e.ContratoLftId)
                    .HasColumnName("contrato_lft_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EmpleadoId).HasColumnName("empleado_id");

                entity.Property(e => e.FechaFin)
                    .HasColumnName("fecha_fin")
                    .HasColumnType("date");

                entity.Property(e => e.FechaInicio)
                    .HasColumnName("fecha_inicio")
                    .HasColumnType("date");

                entity.Property(e => e.TipoContLftId).HasColumnName("tipo_cont_lft_id");

                entity.HasOne(d => d.Empleado)
                    .WithMany(p => p.ContratosLft)
                    .HasForeignKey(d => d.EmpleadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("empleados_a_contratos_lft");

                entity.HasOne(d => d.TipoContLft)
                    .WithMany(p => p.ContratosLft)
                    .HasForeignKey(d => d.TipoContLftId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tipo_cont_lft_a_cont_lft");
            });

            modelBuilder.Entity<CuentasBancarias>(entity =>
            {
                entity.HasKey(e => e.CuentaBanId)
                    .HasName("cuentas_bancarias_pk");

                entity.ToTable("cuentas_bancarias");

                entity.HasIndex(e => e.Nombre)
                    .HasName("cuentas_bancarias_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.CuentaBanId)
                    .HasColumnName("cuenta_ban_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BancoId).HasColumnName("banco_id");

                entity.Property(e => e.ChequeAutom)
                    .HasColumnName("cheque_autom")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Clabe)
                    .HasColumnName("clabe")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Conciliar)
                    .IsRequired()
                    .HasColumnName("conciliar")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CuentaContable)
                    .HasColumnName("cuenta_contable")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DigitosConci).HasColumnName("digitos_conci");

                entity.Property(e => e.EsPredet)
                    .HasColumnName("es_predet")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.FechaIniConci)
                    .HasColumnName("fecha_ini_conci")
                    .HasColumnType("date");

                entity.Property(e => e.FechaUltConci)
                    .HasColumnName("fecha_ult_conci")
                    .HasColumnType("date");

                entity.Property(e => e.MonedaId).HasColumnName("moneda_id");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumCuenta)
                    .HasColumnName("num_cuenta")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SigCheque)
                    .HasColumnName("sig_cheque")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sucursal)
                    .HasColumnName("sucursal")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCtabanId).HasColumnName("tipo_ctaban_id");

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.Banco)
                    .WithMany(p => p.CuentasBancarias)
                    .HasForeignKey(d => d.BancoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("bancos_a_ctaban");

                entity.HasOne(d => d.Moneda)
                    .WithMany(p => p.CuentasBancarias)
                    .HasForeignKey(d => d.MonedaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("monedas_a_ctasban");

                entity.HasOne(d => d.TipoCtaban)
                    .WithMany(p => p.CuentasBancarias)
                    .HasForeignKey(d => d.TipoCtabanId)
                    .HasConstraintName("tipos_ctasban_a_ctasban");
            });

            modelBuilder.Entity<CuentasCo>(entity =>
            {
                entity.HasKey(e => e.CuentaId)
                    .HasName("cuentas_co_pk");

                entity.ToTable("cuentas_co");

                entity.HasIndex(e => e.CuentaJt)
                    .HasName("cuentas_co_ak2")
                    .IsUnique()
                    .HasFilter("([cuenta_jt] IS NOT NULL)");

                entity.HasIndex(e => e.CuentaPt)
                    .HasName("cuentas_co_ak1")
                    .IsUnique()
                    .HasFilter("([cuenta_pt] IS NOT NULL)");

                entity.Property(e => e.CuentaId)
                    .HasColumnName("cuenta_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CuentaFiscalJt)
                    .HasColumnName("cuenta_fiscal_jt")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaFiscalPt)
                    .HasColumnName("cuenta_fiscal_pt")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaJt)
                    .IsRequired()
                    .HasColumnName("cuenta_jt")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaPadreId).HasColumnName("cuenta_padre_id");

                entity.Property(e => e.CuentaPt)
                    .IsRequired()
                    .HasColumnName("cuenta_pt")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.EsProrrateo)
                    .IsRequired()
                    .HasColumnName("es_prorrateo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Naturaleza)
                    .HasColumnName("naturaleza")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notas)
                    .HasColumnName("notas")
                    .IsUnicode(false);

                entity.Property(e => e.Subcuenta).HasColumnName("subcuenta");

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.CuentaPadre)
                    .WithMany(p => p.InverseCuentaPadre)
                    .HasForeignKey(d => d.CuentaPadreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cuentas_co_a_cta_padre");
            });

            modelBuilder.Entity<CuentasCoDiot>(entity =>
            {
                entity.HasKey(e => e.CuentaId)
                    .HasName("cuentas_co_diot_pk");

                entity.ToTable("cuentas_co_diot");

                entity.Property(e => e.CuentaId)
                    .HasColumnName("cuenta_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.MonitorearDebe)
                    .IsRequired()
                    .HasColumnName("monitorear_debe")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MonitorearHaber)
                    .IsRequired()
                    .HasColumnName("monitorear_haber")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Cuenta)
                    .WithOne(p => p.CuentasCoDiot)
                    .HasForeignKey<CuentasCoDiot>(d => d.CuentaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cuentas_co_a_cuentas_diot");
            });

            modelBuilder.Entity<CuentasNo>(entity =>
            {
                entity.HasKey(e => new { e.ConceptoNoId, e.DeptoNoId })
                    .HasName("cuentas_no_pk");

                entity.ToTable("cuentas_no");

                entity.Property(e => e.ConceptoNoId).HasColumnName("concepto_no_id");

                entity.Property(e => e.DeptoNoId).HasColumnName("depto_no_id");

                entity.Property(e => e.CuentaContable)
                    .HasColumnName("cuenta_contable")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.DeptoNo)
                    .WithMany(p => p.CuentasNo)
                    .HasForeignKey(d => d.DeptoNoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("deptos_a_ctas_no");
            });

            modelBuilder.Entity<DatosAdicionales>(entity =>
            {
                entity.ToTable("datos_adicionales");

                entity.HasIndex(e => e.Clave)
                    .HasName("datos_adicionales_ie1");

                entity.HasIndex(e => new { e.NomTabla, e.ElemId, e.TipoReg })
                    .HasName("datos_adicionales_ie2");

                entity.Property(e => e.DatosAdicionalesId)
                    .HasColumnName("datos_adicionales_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Clave)
                    .HasColumnName("clave")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Datos)
                    .HasColumnName("datos")
                    .IsUnicode(false);

                entity.Property(e => e.ElemId).HasColumnName("elem_id");

                entity.Property(e => e.NomTabla)
                    .IsRequired()
                    .HasColumnName("nom_tabla")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.TipoReg)
                    .IsRequired()
                    .HasColumnName("tipo_reg")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('1')");
            });

            modelBuilder.Entity<DepositosCc>(entity =>
            {
                entity.HasKey(e => e.DepositoCcId)
                    .HasName("depositos_cc_pk");

                entity.ToTable("depositos_cc");

                entity.HasIndex(e => e.Fecha)
                    .HasName("depositos_cc_ie2");

                entity.HasIndex(e => new { e.CuentaBanId, e.Fecha })
                    .HasName("depositos_cc_ie1");

                entity.Property(e => e.DepositoCcId)
                    .HasColumnName("deposito_cc_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aplicado)
                    .IsRequired()
                    .HasColumnName("aplicado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CuentaBanId).HasColumnName("cuenta_ban_id");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Estatus)
                    .IsRequired()
                    .HasColumnName("estatus")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.FechaHoraCancelacion).HasColumnName("fecha_hora_cancelacion");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.FormaCobroCcId).HasColumnName("forma_cobro_cc_id");

                entity.Property(e => e.FormaEmitida)
                    .IsRequired()
                    .HasColumnName("forma_emitida")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Importe)
                    .HasColumnName("importe")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ReferMovtoBancario)
                    .HasColumnName("refer_movto_bancario")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoCambio)
                    .HasColumnName("tipo_cambio")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.UsuarioAutCancelacion)
                    .HasColumnName("usuario_aut_cancelacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCancelacion)
                    .HasColumnName("usuario_cancelacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.CuentaBan)
                    .WithMany(p => p.DepositosCc)
                    .HasForeignKey(d => d.CuentaBanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cuentas_ban_a_depositos_cc");

                entity.HasOne(d => d.FormaCobroCc)
                    .WithMany(p => p.DepositosCc)
                    .HasForeignKey(d => d.FormaCobroCcId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("formas_cob_cc_a_depositos_cc");
            });

            modelBuilder.Entity<DepositosCcDet>(entity =>
            {
                entity.HasKey(e => e.DepositoCcDetId)
                    .HasName("depositos_cc_det_pk");

                entity.ToTable("depositos_cc_det");

                entity.HasIndex(e => new { e.DepositoCcId, e.DoctoCcId })
                    .HasName("depositos_cc_det_ak1")
                    .IsUnique()
                    .HasFilter("([deposito_cc_id] IS NOT NULL AND [docto_cc_id] IS NOT NULL)");

                entity.Property(e => e.DepositoCcDetId)
                    .HasColumnName("deposito_cc_det_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DepositoCcId).HasColumnName("deposito_cc_id");

                entity.Property(e => e.DoctoCcId).HasColumnName("docto_cc_id");

                entity.HasOne(d => d.DepositoCc)
                    .WithMany(p => p.DepositosCcDet)
                    .HasForeignKey(d => d.DepositoCcId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("depositos_cc_a_det");

                entity.HasOne(d => d.DoctoCc)
                    .WithMany(p => p.DepositosCcDet)
                    .HasForeignKey(d => d.DoctoCcId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_cc_a_depositos_cc_det");
            });

            modelBuilder.Entity<DeptosCo>(entity =>
            {
                entity.HasKey(e => e.DeptoCoId)
                    .HasName("deptos_co_pk");

                entity.ToTable("deptos_co");

                entity.HasIndex(e => e.Clave)
                    .HasName("deptos_co_ak2")
                    .IsUnique()
                    .HasFilter("([clave] IS NOT NULL)");

                entity.HasIndex(e => e.Nombre)
                    .HasName("deptos_co_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.DeptoCoId)
                    .HasColumnName("depto_co_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasColumnName("clave")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.EsPredet)
                    .HasColumnName("es_predet")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DeptosNo>(entity =>
            {
                entity.HasKey(e => e.DeptoNoId)
                    .HasName("deptos_no_pk");

                entity.ToTable("deptos_no");

                entity.HasIndex(e => e.Nombre)
                    .HasName("deptos_no_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.DeptoNoId)
                    .HasColumnName("depto_no_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EsPredet)
                    .HasColumnName("es_predet")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DescripPolizas>(entity =>
            {
                entity.HasKey(e => e.DescripPolizaId)
                    .HasName("descrip_polizas_pk");

                entity.ToTable("descrip_polizas");

                entity.HasIndex(e => e.Nombre)
                    .HasName("descrip_polizas_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.DescripPolizaId)
                    .HasColumnName("descrip_poliza_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DesgloseEnDiscretos>(entity =>
            {
                entity.HasKey(e => e.DesgloseDiscretoId)
                    .HasName("desglose_en_discretos_pk");

                entity.ToTable("desglose_en_discretos");

                entity.HasIndex(e => new { e.ArtDiscretoId, e.DoctoInDetId })
                    .HasName("desglose_en_discretos_ie1");

                entity.HasIndex(e => new { e.DoctoInDetId, e.ArtDiscretoId })
                    .HasName("desglose_en_discretos_ak1")
                    .IsUnique()
                    .HasFilter("([docto_in_det_id] IS NOT NULL AND [art_discreto_id] IS NOT NULL)");

                entity.Property(e => e.DesgloseDiscretoId)
                    .HasColumnName("desglose_discreto_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArtDiscretoId).HasColumnName("art_discreto_id");

                entity.Property(e => e.DoctoInDetId).HasColumnName("docto_in_det_id");

                entity.Property(e => e.Unidades)
                    .HasColumnName("unidades")
                    .HasColumnType("decimal(18, 5)");

                entity.HasOne(d => d.ArtDiscreto)
                    .WithMany(p => p.DesgloseEnDiscretos)
                    .HasForeignKey(d => d.ArtDiscretoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("discretos_a_desglose");

                entity.HasOne(d => d.DoctoInDet)
                    .WithMany(p => p.DesgloseEnDiscretos)
                    .HasForeignKey(d => d.DoctoInDetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_in_det_a_desglose");
            });

            modelBuilder.Entity<DesgloseEnDiscretosCm>(entity =>
            {
                entity.HasKey(e => e.DesgloseDiscretoCmId)
                    .HasName("desglose_en_discretos_cm_pk");

                entity.ToTable("desglose_en_discretos_cm");

                entity.HasIndex(e => new { e.DoctoCmDetId, e.ArtDiscretoId })
                    .HasName("desglose_en_discretos_cm_ak1")
                    .IsUnique()
                    .HasFilter("([docto_cm_det_id] IS NOT NULL AND [art_discreto_id] IS NOT NULL)");

                entity.Property(e => e.DesgloseDiscretoCmId)
                    .HasColumnName("desglose_discreto_cm_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArtDiscretoId).HasColumnName("art_discreto_id");

                entity.Property(e => e.DoctoCmDetId).HasColumnName("docto_cm_det_id");

                entity.Property(e => e.Unidades)
                    .HasColumnName("unidades")
                    .HasColumnType("decimal(18, 5)");

                entity.HasOne(d => d.ArtDiscreto)
                    .WithMany(p => p.DesgloseEnDiscretosCm)
                    .HasForeignKey(d => d.ArtDiscretoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("discretos_a_desglose_cm");

                entity.HasOne(d => d.DoctoCmDet)
                    .WithMany(p => p.DesgloseEnDiscretosCm)
                    .HasForeignKey(d => d.DoctoCmDetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_cm_det_a_desglose");
            });

            modelBuilder.Entity<DesgloseEnDiscretosInvfis>(entity =>
            {
                entity.HasKey(e => e.DesglDiscretoInvfisId)
                    .HasName("desgl_discretos_invfis_pk");

                entity.ToTable("desglose_en_discretos_invfis");

                entity.HasIndex(e => new { e.DoctoInvfisDetId, e.ArtDiscretoId })
                    .HasName("desgl_discretos_invfis_ak1")
                    .IsUnique()
                    .HasFilter("([docto_invfis_det_id] IS NOT NULL AND [art_discreto_id] IS NOT NULL)");

                entity.Property(e => e.DesglDiscretoInvfisId)
                    .HasColumnName("desgl_discreto_invfis_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArtDiscretoId).HasColumnName("art_discreto_id");

                entity.Property(e => e.DoctoInvfisDetId).HasColumnName("docto_invfis_det_id");

                entity.Property(e => e.Unidades)
                    .HasColumnName("unidades")
                    .HasColumnType("decimal(18, 5)");

                entity.HasOne(d => d.ArtDiscreto)
                    .WithMany(p => p.DesgloseEnDiscretosInvfis)
                    .HasForeignKey(d => d.ArtDiscretoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("discretos_a_desglose_invfis");

                entity.HasOne(d => d.DoctoInvfisDet)
                    .WithMany(p => p.DesgloseEnDiscretosInvfis)
                    .HasForeignKey(d => d.DoctoInvfisDetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_invfis_det_a_desglose");
            });

            modelBuilder.Entity<DesgloseEnDiscretosPv>(entity =>
            {
                entity.HasKey(e => e.DesgloseDiscretoPvId)
                    .HasName("desglose_en_discretos_pv_pk");

                entity.ToTable("desglose_en_discretos_pv");

                entity.HasIndex(e => new { e.DoctoPvDetId, e.ArtDiscretoId })
                    .HasName("desglose_en_discretos_pv_ak1")
                    .IsUnique()
                    .HasFilter("([docto_pv_det_id] IS NOT NULL AND [art_discreto_id] IS NOT NULL)");

                entity.Property(e => e.DesgloseDiscretoPvId)
                    .HasColumnName("desglose_discreto_pv_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArtDiscretoId).HasColumnName("art_discreto_id");

                entity.Property(e => e.DoctoPvDetId).HasColumnName("docto_pv_det_id");

                entity.Property(e => e.Unidades)
                    .HasColumnName("unidades")
                    .HasColumnType("decimal(18, 5)");

                entity.HasOne(d => d.ArtDiscreto)
                    .WithMany(p => p.DesgloseEnDiscretosPv)
                    .HasForeignKey(d => d.ArtDiscretoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("discretos_a_desglose_pv");

                entity.HasOne(d => d.DoctoPvDet)
                    .WithMany(p => p.DesgloseEnDiscretosPv)
                    .HasForeignKey(d => d.DoctoPvDetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_pv_det_a_desglose");
            });

            modelBuilder.Entity<DesgloseEnDiscretosVe>(entity =>
            {
                entity.HasKey(e => e.DesgloseDiscretoVeId)
                    .HasName("desglose_en_discretos_ve_pk");

                entity.ToTable("desglose_en_discretos_ve");

                entity.HasIndex(e => new { e.DoctoVeDetId, e.ArtDiscretoId })
                    .HasName("desglose_en_discretos_ve_ak1")
                    .IsUnique()
                    .HasFilter("([docto_ve_det_id] IS NOT NULL AND [art_discreto_id] IS NOT NULL)");

                entity.Property(e => e.DesgloseDiscretoVeId)
                    .HasColumnName("desglose_discreto_ve_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArtDiscretoId).HasColumnName("art_discreto_id");

                entity.Property(e => e.DoctoVeDetId).HasColumnName("docto_ve_det_id");

                entity.Property(e => e.Unidades)
                    .HasColumnName("unidades")
                    .HasColumnType("decimal(18, 5)");

                entity.HasOne(d => d.ArtDiscreto)
                    .WithMany(p => p.DesgloseEnDiscretosVe)
                    .HasForeignKey(d => d.ArtDiscretoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("discretos_a_desglose_ve");

                entity.HasOne(d => d.DoctoVeDet)
                    .WithMany(p => p.DesgloseEnDiscretosVe)
                    .HasForeignKey(d => d.DoctoVeDetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_ve_det_a_desglose");
            });

            modelBuilder.Entity<DesgloseEnPedimentos>(entity =>
            {
                entity.HasKey(e => new { e.DoctoInDetId, e.PedimentoId })
                    .HasName("desglose_en_pedimentos_pk");

                entity.ToTable("desglose_en_pedimentos");

                entity.Property(e => e.DoctoInDetId).HasColumnName("docto_in_det_id");

                entity.Property(e => e.PedimentoId).HasColumnName("pedimento_id");

                entity.HasOne(d => d.DoctoInDet)
                    .WithMany(p => p.DesgloseEnPedimentos)
                    .HasForeignKey(d => d.DoctoInDetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_det_a_desgl_pedimentos");

                entity.HasOne(d => d.Pedimento)
                    .WithMany(p => p.DesgloseEnPedimentos)
                    .HasForeignKey(d => d.PedimentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pedimentos_a_desgl");
            });

            modelBuilder.Entity<DirsClientes>(entity =>
            {
                entity.HasKey(e => e.DirCliId)
                    .HasName("dirs_cli_pk");

                entity.ToTable("dirs_clientes");

                entity.HasIndex(e => new { e.ClienteId, e.NombreConsig })
                    .HasName("dirs_cli_ak1")
                    .IsUnique()
                    .HasFilter("([cliente_id] IS NOT NULL AND [nombre_consig] IS NOT NULL)");

                entity.Property(e => e.DirCliId)
                    .HasColumnName("dir_cli_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Calle)
                    .HasColumnName("calle")
                    .HasMaxLength(430)
                    .IsUnicode(false);

                entity.Property(e => e.CiudadId).HasColumnName("ciudad_id");

                entity.Property(e => e.ClienteId).HasColumnName("cliente_id");

                entity.Property(e => e.CodigoPostal)
                    .HasColumnName("codigo_postal")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Colonia)
                    .HasColumnName("colonia")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ColoniaClaveFiscal)
                    .HasColumnName("colonia_clave_fiscal")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Contacto)
                    .HasColumnName("contacto")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EsDirPpal)
                    .HasColumnName("es_dir_ppal")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EstadoId).HasColumnName("estado_id");

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Gln)
                    .HasColumnName("gln")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCalle)
                    .HasColumnName("nombre_calle")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombreConsig)
                    .IsRequired()
                    .HasColumnName("nombre_consig")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NumExterior)
                    .HasColumnName("num_exterior")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumInterior)
                    .HasColumnName("num_interior")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaisId).HasColumnName("pais_id");

                entity.Property(e => e.Poblacion)
                    .HasColumnName("poblacion")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PoblacionClaveFiscal)
                    .HasColumnName("poblacion_clave_fiscal")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Referencia)
                    .HasColumnName("referencia")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RfcCurp)
                    .HasColumnName("rfc_curp")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.TaxId)
                    .HasColumnName("tax_id")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono1)
                    .HasColumnName("telefono1")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono2)
                    .HasColumnName("telefono2")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.UsarParaEnvios)
                    .HasColumnName("usar_para_envios")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsarParaFacturar)
                    .HasColumnName("usar_para_facturar")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ViaEmbarqueId).HasColumnName("via_embarque_id");

                entity.HasOne(d => d.Ciudad)
                    .WithMany(p => p.DirsClientes)
                    .HasForeignKey(d => d.CiudadId)
                    .HasConstraintName("ciudades_a_dirs_cli");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.DirsClientes)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cli_a_dirs");

                entity.HasOne(d => d.ViaEmbarque)
                    .WithMany(p => p.DirsClientes)
                    .HasForeignKey(d => d.ViaEmbarqueId)
                    .HasConstraintName("via_emb_a_dir_cli");
            });

            modelBuilder.Entity<Dispositivos>(entity =>
            {
                entity.HasKey(e => e.DispositivoId)
                    .HasName("dispositivos_pk");

                entity.ToTable("dispositivos");

                entity.HasIndex(e => e.Nombre)
                    .HasName("dispositivos_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.DispositivoId)
                    .HasColumnName("dispositivo_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AutorizadorTarjeta)
                    .HasColumnName("autorizador_tarjeta")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BitPesoExcedido).HasColumnName("bit_peso_excedido");

                entity.Property(e => e.BitPesoInestable).HasColumnName("bit_peso_inestable");

                entity.Property(e => e.BitPesoNegativo).HasColumnName("bit_peso_negativo");

                entity.Property(e => e.BitsDatos).HasColumnName("bits_datos");

                entity.Property(e => e.BitsParada)
                    .HasColumnName("bits_parada")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.BitsSegundo).HasColumnName("bits_segundo");

                entity.Property(e => e.BytePesoExcedido).HasColumnName("byte_peso_excedido");

                entity.Property(e => e.BytePesoInestable).HasColumnName("byte_peso_inestable");

                entity.Property(e => e.BytePesoNegativo).HasColumnName("byte_peso_negativo");

                entity.Property(e => e.ControlFlujo)
                    .HasColumnName("control_flujo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('X')");

                entity.Property(e => e.EsPinpad)
                    .IsRequired()
                    .HasColumnName("es_pinpad")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EsPredet)
                    .HasColumnName("es_predet")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.ImpresoraIntegrada)
                    .HasColumnName("impresora_integrada")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InicioPeso).HasColumnName("inicio_peso");

                entity.Property(e => e.ModeloPinpad)
                    .HasColumnName("modelo_pinpad")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MsgTorrAbierta1)
                    .HasColumnName("msg_torr_abierta1")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MsgTorrAbierta2)
                    .HasColumnName("msg_torr_abierta2")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MsgTorrCambio2)
                    .HasColumnName("msg_torr_cambio2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MsgTorrCerrada1)
                    .HasColumnName("msg_torr_cerrada1")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MsgTorrCerrada2)
                    .HasColumnName("msg_torr_cerrada2")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MsgTorrTotal1)
                    .HasColumnName("msg_torr_total1")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MsgTorrTotal2)
                    .HasColumnName("msg_torr_total2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Paridad)
                    .HasColumnName("paridad")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.TipoDispId).HasColumnName("tipo_disp_id");

                entity.Property(e => e.TipoPuerto)
                    .IsRequired()
                    .HasColumnName("tipo_puerto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.VersionRegistro).HasColumnName("version_registro");

                entity.HasOne(d => d.TipoDisp)
                    .WithMany(p => p.Dispositivos)
                    .HasForeignKey(d => d.TipoDispId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tipos_disp_a_disp");
            });

            modelBuilder.Entity<DispositivosCajas>(entity =>
            {
                entity.HasKey(e => e.DispCajaId)
                    .HasName("dispositivos_cajas_pk");

                entity.ToTable("dispositivos_cajas");

                entity.HasIndex(e => new { e.CajaId, e.TipoDispId })
                    .HasName("dispositivos_cajas_ak1")
                    .IsUnique()
                    .HasFilter("([caja_id] IS NOT NULL AND [tipo_disp_id] IS NOT NULL)");

                entity.Property(e => e.DispCajaId)
                    .HasColumnName("disp_caja_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CajaId).HasColumnName("caja_id");

                entity.Property(e => e.DispositivoId).HasColumnName("dispositivo_id");

                entity.Property(e => e.Habilitado)
                    .HasColumnName("habilitado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Impresora)
                    .HasColumnName("impresora")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.NumPuerto).HasColumnName("num_puerto");

                entity.Property(e => e.TipoDispId).HasColumnName("tipo_disp_id");

                entity.Property(e => e.TipoManejo)
                    .IsRequired()
                    .HasColumnName("tipo_manejo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('I')");

                entity.HasOne(d => d.Caja)
                    .WithMany(p => p.DispositivosCajas)
                    .HasForeignKey(d => d.CajaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cajas_a_disp_cajas");

                entity.HasOne(d => d.Dispositivo)
                    .WithMany(p => p.DispositivosCajas)
                    .HasForeignKey(d => d.DispositivoId)
                    .HasConstraintName("disp_a_disp_cajas");

                entity.HasOne(d => d.TipoDisp)
                    .WithMany(p => p.DispositivosCajas)
                    .HasForeignKey(d => d.TipoDispId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tipos_disp_a_disp_cajas");
            });

            modelBuilder.Entity<DoctosBa>(entity =>
            {
                entity.HasKey(e => e.DoctoBaId)
                    .HasName("doctos_ba_pk");

                entity.ToTable("doctos_ba");

                entity.HasIndex(e => e.Fecha)
                    .HasName("doctos_ba_ie2");

                entity.HasIndex(e => e.IdOriginal)
                    .HasName("doctos_ba_ak1")
                    .IsUnique()
                    .HasFilter("([id_original] IS NOT NULL)");

                entity.HasIndex(e => new { e.CuentaBanId, e.Fecha, e.TipoMovto, e.ConceptoBaId, e.Refer })
                    .HasName("doctos_ba_ie1");

                entity.Property(e => e.DoctoBaId)
                    .HasColumnName("docto_ba_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aplicado)
                    .HasColumnName("aplicado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BeneficiarioId).HasColumnName("beneficiario_id");

                entity.Property(e => e.Cancelado)
                    .HasColumnName("cancelado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Capturado)
                    .HasColumnName("capturado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaveBen)
                    .HasColumnName("clave_ben")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ConceptoBaId).HasColumnName("concepto_ba_id");

                entity.Property(e => e.Conciliado)
                    .HasColumnName("conciliado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CuentaBanId).HasColumnName("cuenta_ban_id");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EsTraspaso)
                    .HasColumnName("es_traspaso")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estatus)
                    .IsRequired()
                    .HasColumnName("estatus")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.FechaAplic)
                    .HasColumnName("fecha_aplic")
                    .HasColumnType("date");

                entity.Property(e => e.FechaConciliacion)
                    .HasColumnName("fecha_conciliacion")
                    .HasColumnType("date");

                entity.Property(e => e.FechaHoraCancelacion).HasColumnName("fecha_hora_cancelacion");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.FormaEmitida)
                    .HasColumnName("forma_emitida")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GrupoMovPeriodId).HasColumnName("grupo_mov_period_id");

                entity.Property(e => e.IdOriginal).HasColumnName("id_original");

                entity.Property(e => e.Importe)
                    .HasColumnName("importe")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.IntegCo)
                    .HasColumnName("integ_co")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MonedaId).HasColumnName("moneda_id");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Refer)
                    .HasColumnName("refer")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SistemaOrigen)
                    .IsRequired()
                    .HasColumnName("sistema_origen")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoCambio)
                    .HasColumnName("tipo_cambio")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TipoMovFiscal)
                    .IsRequired()
                    .HasColumnName("tipo_mov_fiscal")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoMovto)
                    .HasColumnName("tipo_movto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAutCancelacion)
                    .HasColumnName("usuario_aut_cancelacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCancelacion)
                    .HasColumnName("usuario_cancelacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.Beneficiario)
                    .WithMany(p => p.DoctosBa)
                    .HasForeignKey(d => d.BeneficiarioId)
                    .HasConstraintName("benef_a_doctos_ba");

                entity.HasOne(d => d.ConceptoBa)
                    .WithMany(p => p.DoctosBa)
                    .HasForeignKey(d => d.ConceptoBaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("concep_a_doctos_ba");

                entity.HasOne(d => d.CuentaBan)
                    .WithMany(p => p.DoctosBa)
                    .HasForeignKey(d => d.CuentaBanId)
                    .HasConstraintName("ctaban_a_doctos_ba");

                entity.HasOne(d => d.GrupoMovPeriod)
                    .WithMany(p => p.DoctosBa)
                    .HasForeignKey(d => d.GrupoMovPeriodId)
                    .HasConstraintName("grupos_mov_per_a_doctos_ba");

                entity.HasOne(d => d.Moneda)
                    .WithMany(p => p.DoctosBa)
                    .HasForeignKey(d => d.MonedaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("monedas_a_doctos_ba");
            });

            modelBuilder.Entity<DoctosBaInfoBan>(entity =>
            {
                entity.HasKey(e => e.DoctoBaInfoBanId)
                    .HasName("doctos_ba_info_ban_pk");

                entity.ToTable("doctos_ba_info_ban");

                entity.Property(e => e.DoctoBaInfoBanId)
                    .HasColumnName("docto_ba_info_ban_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BancoTercero)
                    .HasColumnName("banco_tercero")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaBanTercero)
                    .HasColumnName("cuenta_ban_tercero")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DoctoBaId).HasColumnName("docto_ba_id");

                entity.Property(e => e.Importe)
                    .HasColumnName("importe")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.MetodoPago)
                    .HasColumnName("metodo_pago")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NomBancoTerceroExt)
                    .HasColumnName("nom_banco_tercero_ext")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Refer)
                    .HasColumnName("refer")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TerceroCoId).HasColumnName("tercero_co_id");

                entity.HasOne(d => d.DoctoBa)
                    .WithMany(p => p.DoctosBaInfoBan)
                    .HasForeignKey(d => d.DoctoBaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_ba_a_info_ban");

                entity.HasOne(d => d.TerceroCo)
                    .WithMany(p => p.DoctosBaInfoBan)
                    .HasForeignKey(d => d.TerceroCoId)
                    .HasConstraintName("terceros_a_doctos_ba_info_ban");
            });

            modelBuilder.Entity<DoctosCc>(entity =>
            {
                entity.HasKey(e => e.DoctoCcId)
                    .HasName("doctos_cc_pk");

                entity.ToTable("doctos_cc");

                entity.HasIndex(e => new { e.ConceptoCcId, e.Folio, e.Aplicado })
                    .HasName("doctos_cc_ak1")
                    .IsUnique()
                    .HasFilter("([concepto_cc_id] IS NOT NULL AND [folio] IS NOT NULL AND [aplicado] IS NOT NULL)");

                entity.HasIndex(e => new { e.Fecha, e.NaturalezaConcepto, e.ConceptoCcId, e.Folio })
                    .HasName("doctos_cc_ie1");

                entity.HasIndex(e => new { e.ClienteId, e.Fecha, e.NaturalezaConcepto, e.ConceptoCcId, e.Folio })
                    .HasName("doctos_cc_ie2");

                entity.Property(e => e.DoctoCcId)
                    .HasColumnName("docto_cc_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aplicado)
                    .IsRequired()
                    .HasColumnName("aplicado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cancelado)
                    .HasColumnName("cancelado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CfdiAsociadoId).HasColumnName("cfdi_asociado_id");

                entity.Property(e => e.CfdiCertificado)
                    .IsRequired()
                    .HasColumnName("cfdi_certificado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ClaveCliente)
                    .HasColumnName("clave_cliente")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteId).HasColumnName("cliente_id");

                entity.Property(e => e.CobradorId).HasColumnName("cobrador_id");

                entity.Property(e => e.ConceptoCcId).HasColumnName("concepto_cc_id");

                entity.Property(e => e.CondPagoId).HasColumnName("cond_pago_id");

                entity.Property(e => e.Contabilizado)
                    .HasColumnName("contabilizado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContabilizadoBa)
                    .IsRequired()
                    .HasColumnName("contabilizado_ba")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContabilizadoGyp)
                    .IsRequired()
                    .HasColumnName("contabilizado_gyp")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CuentaBanId).HasColumnName("cuenta_ban_id");

                entity.Property(e => e.CuentaConcepto)
                    .HasColumnName("cuenta_concepto")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EmailEnvio)
                    .HasColumnName("email_envio")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Enviado)
                    .IsRequired()
                    .HasColumnName("enviado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EsCfd)
                    .IsRequired()
                    .HasColumnName("es_cfd")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estatus)
                    .IsRequired()
                    .HasColumnName("estatus")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.EstatusAnt)
                    .IsRequired()
                    .HasColumnName("estatus_ant")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FacturaMostrador)
                    .HasColumnName("factura_mostrador")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.FechaAplicacion)
                    .HasColumnName("fecha_aplicacion")
                    .HasColumnType("date");

                entity.Property(e => e.FechaDsctoPpag)
                    .HasColumnName("fecha_dscto_ppag")
                    .HasColumnType("date");

                entity.Property(e => e.FechaHoraCancelacion).HasColumnName("fecha_hora_cancelacion");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraEnvio).HasColumnName("fecha_hora_envio");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Folio)
                    .IsRequired()
                    .HasColumnName("folio")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FormaEmitida)
                    .HasColumnName("forma_emitida")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hora)
                    .HasColumnName("hora")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ImporteCobro)
                    .HasColumnName("importe_cobro")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.IntegBa)
                    .IsRequired()
                    .HasColumnName("integ_ba")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LugarExpedicionId).HasColumnName("lugar_expedicion_id");

                entity.Property(e => e.MetodoPagoCfdiAsociado)
                    .HasColumnName("metodo_pago_cfdi_asociado")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MetodoPagoSat)
                    .HasColumnName("metodo_pago_sat")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ModalidadFacturacion)
                    .HasColumnName("modalidad_facturacion")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PREIMP')");

                entity.Property(e => e.NaturalezaConcepto)
                    .IsRequired()
                    .HasColumnName("naturaleza_concepto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PctjeDsctoPpag)
                    .HasColumnName("pctje_dscto_ppag")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.ReferMovtoBancario)
                    .HasColumnName("refer_movto_bancario")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SistemaOrigen)
                    .IsRequired()
                    .HasColumnName("sistema_origen")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TieneAnticipo)
                    .IsRequired()
                    .HasColumnName("tiene_anticipo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoCambio)
                    .HasColumnName("tipo_cambio")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.UsoCfdi)
                    .HasColumnName("uso_cfdi")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAutCancelacion)
                    .HasColumnName("usuario_aut_cancelacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCancelacion)
                    .HasColumnName("usuario_cancelacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.CfdiAsociado)
                    .WithMany(p => p.DoctosCc)
                    .HasForeignKey(d => d.CfdiAsociadoId)
                    .HasConstraintName("repositorio_a_doctos_cc");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.DoctosCc)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cli_a_doctos_cc");

                entity.HasOne(d => d.Cobrador)
                    .WithMany(p => p.DoctosCc)
                    .HasForeignKey(d => d.CobradorId)
                    .HasConstraintName("cobrador_a_doctos_cc");

                entity.HasOne(d => d.ConceptoCc)
                    .WithMany(p => p.DoctosCc)
                    .HasForeignKey(d => d.ConceptoCcId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("concep_a_doctos_cc");

                entity.HasOne(d => d.CondPago)
                    .WithMany(p => p.DoctosCc)
                    .HasForeignKey(d => d.CondPagoId)
                    .HasConstraintName("cond_a_doctos_cc");

                entity.HasOne(d => d.CuentaBan)
                    .WithMany(p => p.DoctosCc)
                    .HasForeignKey(d => d.CuentaBanId)
                    .HasConstraintName("cuentas_ban_a_doctos_cc");
            });

            modelBuilder.Entity<DoctosCcInfoBan>(entity =>
            {
                entity.HasKey(e => e.DoctoCcId)
                    .HasName("doctos_cc_info_ban_pk");

                entity.ToTable("doctos_cc_info_ban");

                entity.Property(e => e.DoctoCcId)
                    .HasColumnName("docto_cc_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BancoOrigId).HasColumnName("banco_orig_id");

                entity.Property(e => e.CepCadPago)
                    .HasColumnName("cep_cad_pago")
                    .IsUnicode(false);

                entity.Property(e => e.CepCertPago)
                    .HasColumnName("cep_cert_pago")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CepSelloPago)
                    .HasColumnName("cep_sello_pago")
                    .IsUnicode(false);

                entity.Property(e => e.CepTipoCadPago)
                    .HasColumnName("cep_tipo_cad_pago")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaBanOrig)
                    .IsRequired()
                    .HasColumnName("cuenta_ban_orig")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.BancoOrig)
                    .WithMany(p => p.DoctosCcInfoBan)
                    .HasForeignKey(d => d.BancoOrigId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("bancos_a_doctos_cc_info_ban");

                entity.HasOne(d => d.DoctoCc)
                    .WithOne(p => p.DoctosCcInfoBan)
                    .HasForeignKey<DoctosCcInfoBan>(d => d.DoctoCcId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_cc_a_info_ban");
            });

            modelBuilder.Entity<DoctosCm>(entity =>
            {
                entity.HasKey(e => e.DoctoCmId)
                    .HasName("doctos_cm_pk");

                entity.ToTable("doctos_cm");

                entity.HasIndex(e => new { e.Fecha, e.TipoDocto, e.Folio })
                    .HasName("doctos_cm_ie1");

                entity.HasIndex(e => new { e.TipoDocto, e.Folio, e.Aplicado })
                    .HasName("doctos_cm_ak1")
                    .IsUnique()
                    .HasFilter("([tipo_docto] IS NOT NULL AND [folio] IS NOT NULL AND [aplicado] IS NOT NULL)");

                entity.Property(e => e.DoctoCmId)
                    .HasColumnName("docto_cm_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AcreditarCxp)
                    .HasColumnName("acreditar_cxp")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AlmacenId).HasColumnName("almacen_id");

                entity.Property(e => e.Aplicado)
                    .HasColumnName("aplicado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CargarSun)
                    .IsRequired()
                    .HasColumnName("cargar_sun")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaveProv)
                    .HasColumnName("clave_prov")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CondPagoId).HasColumnName("cond_pago_id");

                entity.Property(e => e.ConsigCmId).HasColumnName("consig_cm_id");

                entity.Property(e => e.Contabilizado)
                    .HasColumnName("contabilizado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DsctoImporte)
                    .HasColumnName("dscto_importe")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.DsctoPctje)
                    .HasColumnName("dscto_pctje")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.EmailEnvio)
                    .HasColumnName("email_envio")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Enviado)
                    .IsRequired()
                    .HasColumnName("enviado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estatus)
                    .HasColumnName("estatus")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FacturaDev)
                    .HasColumnName("factura_dev")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.FechaDsctoPpag)
                    .HasColumnName("fecha_dscto_ppag")
                    .HasColumnType("date");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnName("fecha_entrega")
                    .HasColumnType("date");

                entity.Property(e => e.FechaHoraCancelacion).HasColumnName("fecha_hora_cancelacion");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraEnvio).HasColumnName("fecha_hora_envio");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Fletes)
                    .HasColumnName("fletes")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Folio)
                    .IsRequired()
                    .HasColumnName("folio")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FolioProv)
                    .HasColumnName("folio_prov")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FormaEmitida)
                    .HasColumnName("forma_emitida")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GastosAduanales)
                    .HasColumnName("gastos_aduanales")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ImporteNeto)
                    .HasColumnName("importe_neto")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ImpuestoSustituidoId).HasColumnName("impuesto_sustituido_id");

                entity.Property(e => e.ImpuestoSustitutoId).HasColumnName("impuesto_sustituto_id");

                entity.Property(e => e.MonedaId).HasColumnName("moneda_id");

                entity.Property(e => e.OtrosCargos)
                    .HasColumnName("otros_cargos")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.OtrosGastos)
                    .HasColumnName("otros_gastos")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.PctjeDsctoPpag)
                    .HasColumnName("pctje_dscto_ppag")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.PedimentoId).HasColumnName("pedimento_id");

                entity.Property(e => e.ProveedorId).HasColumnName("proveedor_id");

                entity.Property(e => e.SistemaOrigen)
                    .IsRequired()
                    .HasColumnName("sistema_origen")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SubtipoDocto)
                    .HasColumnName("subtipo_docto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.TieneCfd)
                    .HasColumnName("tiene_cfd")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoCambio)
                    .HasColumnName("tipo_cambio")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TipoDocto)
                    .IsRequired()
                    .HasColumnName("tipo_docto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoDscto)
                    .HasColumnName("tipo_dscto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TotalImpuestos)
                    .HasColumnName("total_impuestos")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.TotalRetenciones)
                    .HasColumnName("total_retenciones")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.UsuarioAutCancelacion)
                    .HasColumnName("usuario_aut_cancelacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCancelacion)
                    .HasColumnName("usuario_cancelacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.ViaEmbarqueId).HasColumnName("via_embarque_id");

                entity.HasOne(d => d.Almacen)
                    .WithMany(p => p.DoctosCm)
                    .HasForeignKey(d => d.AlmacenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("almacenes_a_doctos_cm");

                entity.HasOne(d => d.CondPago)
                    .WithMany(p => p.DoctosCm)
                    .HasForeignKey(d => d.CondPagoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cond_pag_a_doctos_cm");

                entity.HasOne(d => d.ImpuestoSustituido)
                    .WithMany(p => p.DoctosCmImpuestoSustituido)
                    .HasForeignKey(d => d.ImpuestoSustituidoId)
                    .HasConstraintName("impto_sustituido_cm");

                entity.HasOne(d => d.ImpuestoSustituto)
                    .WithMany(p => p.DoctosCmImpuestoSustituto)
                    .HasForeignKey(d => d.ImpuestoSustitutoId)
                    .HasConstraintName("impto_sustituto_cm");

                entity.HasOne(d => d.Moneda)
                    .WithMany(p => p.DoctosCm)
                    .HasForeignKey(d => d.MonedaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("monedas_a_doctos_cm");

                entity.HasOne(d => d.Pedimento)
                    .WithMany(p => p.DoctosCm)
                    .HasForeignKey(d => d.PedimentoId)
                    .HasConstraintName("pedimentos_a_doctos_cm");

                entity.HasOne(d => d.Proveedor)
                    .WithMany(p => p.DoctosCm)
                    .HasForeignKey(d => d.ProveedorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("prov_a_doctos_cm");

                entity.HasOne(d => d.ViaEmbarque)
                    .WithMany(p => p.DoctosCm)
                    .HasForeignKey(d => d.ViaEmbarqueId)
                    .HasConstraintName("vias_emb_a_doctos_cm");
            });

            modelBuilder.Entity<DoctosCmDet>(entity =>
            {
                entity.HasKey(e => e.DoctoCmDetId)
                    .HasName("doctos_cm_det_pk");

                entity.ToTable("doctos_cm_det");

                entity.Property(e => e.DoctoCmDetId)
                    .HasColumnName("docto_cm_det_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArticuloId).HasColumnName("articulo_id");

                entity.Property(e => e.ClaveArticulo)
                    .HasColumnName("clave_articulo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContenidoUmed)
                    .HasColumnName("contenido_umed")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.DoctoCmId).HasColumnName("docto_cm_id");

                entity.Property(e => e.DsctoArt)
                    .HasColumnName("dscto_art")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.DsctoExtra)
                    .HasColumnName("dscto_extra")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Notas)
                    .HasColumnName("notas")
                    .IsUnicode(false);

                entity.Property(e => e.PctjeArancel)
                    .HasColumnName("pctje_arancel")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.PctjeDscto)
                    .HasColumnName("pctje_dscto")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.PctjeDsctoPro)
                    .HasColumnName("pctje_dscto_pro")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.PctjeDsctoPromo)
                    .HasColumnName("pctje_dscto_promo")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.PctjeDsctoVol)
                    .HasColumnName("pctje_dscto_vol")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.Posicion).HasColumnName("posicion");

                entity.Property(e => e.PrecioTotalNeto)
                    .HasColumnName("precio_total_neto")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.PrecioUnitario)
                    .HasColumnName("precio_unitario")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Umed)
                    .HasColumnName("umed")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Unidades)
                    .HasColumnName("unidades")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.UnidadesARec)
                    .HasColumnName("unidades_a_rec")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.UnidadesRecDev)
                    .HasColumnName("unidades_rec_dev")
                    .HasColumnType("decimal(18, 5)");

                entity.HasOne(d => d.Articulo)
                    .WithMany(p => p.DoctosCmDet)
                    .HasForeignKey(d => d.ArticuloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("arts_a_doctos_cm_det");

                entity.HasOne(d => d.DoctoCm)
                    .WithMany(p => p.DoctosCmDet)
                    .HasForeignKey(d => d.DoctoCmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_cm_a_det");
            });

            modelBuilder.Entity<DoctosCmLigas>(entity =>
            {
                entity.HasKey(e => e.DoctoCmLigaId)
                    .HasName("doctos_cm_ligas_pk");

                entity.ToTable("doctos_cm_ligas");

                entity.HasIndex(e => new { e.DoctoCmDestId, e.DoctoCmFteId })
                    .HasName("doctos_cm_ligas_ak2")
                    .IsUnique()
                    .HasFilter("([docto_cm_dest_id] IS NOT NULL AND [docto_cm_fte_id] IS NOT NULL)");

                entity.HasIndex(e => new { e.DoctoCmFteId, e.DoctoCmDestId })
                    .HasName("doctos_cm_ligas_ak1")
                    .IsUnique()
                    .HasFilter("([docto_cm_fte_id] IS NOT NULL AND [docto_cm_dest_id] IS NOT NULL)");

                entity.Property(e => e.DoctoCmLigaId)
                    .HasColumnName("docto_cm_liga_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DoctoCmDestId).HasColumnName("docto_cm_dest_id");

                entity.Property(e => e.DoctoCmFteId).HasColumnName("docto_cm_fte_id");

                entity.HasOne(d => d.DoctoCmDest)
                    .WithMany(p => p.DoctosCmLigasDoctoCmDest)
                    .HasForeignKey(d => d.DoctoCmDestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_cm_a_ligas_dest");

                entity.HasOne(d => d.DoctoCmFte)
                    .WithMany(p => p.DoctosCmLigasDoctoCmFte)
                    .HasForeignKey(d => d.DoctoCmFteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_cm_a_ligas_fte");
            });

            modelBuilder.Entity<DoctosCmLigasDet>(entity =>
            {
                entity.HasKey(e => new { e.DoctoCmLigaId, e.DoctoCmDetFteId, e.DoctoCmDetDestId })
                    .HasName("doctos_cm_ligas_det_pk");

                entity.ToTable("doctos_cm_ligas_det");

                entity.HasIndex(e => e.DoctoCmDetDestId)
                    .HasName("doctos_cm_ligas_det_ie2");

                entity.HasIndex(e => e.DoctoCmDetFteId)
                    .HasName("doctos_cm_ligas_det_ie1");

                entity.Property(e => e.DoctoCmLigaId).HasColumnName("docto_cm_liga_id");

                entity.Property(e => e.DoctoCmDetFteId).HasColumnName("docto_cm_det_fte_id");

                entity.Property(e => e.DoctoCmDetDestId).HasColumnName("docto_cm_det_dest_id");

                entity.HasOne(d => d.DoctoCmDetDest)
                    .WithMany(p => p.DoctosCmLigasDetDoctoCmDetDest)
                    .HasForeignKey(d => d.DoctoCmDetDestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_cm_det_a_ligas_dest");

                entity.HasOne(d => d.DoctoCmDetFte)
                    .WithMany(p => p.DoctosCmLigasDetDoctoCmDetFte)
                    .HasForeignKey(d => d.DoctoCmDetFteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_cm_det_a_ligas_fte");

                entity.HasOne(d => d.DoctoCmLiga)
                    .WithMany(p => p.DoctosCmLigasDet)
                    .HasForeignKey(d => d.DoctoCmLigaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_cm_ligas_a_det");
            });

            modelBuilder.Entity<DoctosCmProeve>(entity =>
            {
                entity.HasKey(e => e.DoctoCmId)
                    .HasName("doctos_cm_proeve_pk");

                entity.ToTable("doctos_cm_proeve");

                entity.Property(e => e.DoctoCmId)
                    .HasColumnName("docto_cm_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Calle)
                    .IsRequired()
                    .HasColumnName("calle")
                    .HasMaxLength(430)
                    .IsUnicode(false);

                entity.Property(e => e.CiudadId).HasColumnName("ciudad_id");

                entity.Property(e => e.CodigoPostal)
                    .HasColumnName("codigo_postal")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Colonia)
                    .HasColumnName("colonia")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Contacto)
                    .HasColumnName("contacto")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoId).HasColumnName("estado_id");

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCalle)
                    .HasColumnName("nombre_calle")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumExterior)
                    .HasColumnName("num_exterior")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumInterior)
                    .HasColumnName("num_interior")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaisId).HasColumnName("pais_id");

                entity.Property(e => e.Poblacion)
                    .HasColumnName("poblacion")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Referencia)
                    .HasColumnName("referencia")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RfcCurp)
                    .HasColumnName("rfc_curp")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono1)
                    .HasColumnName("telefono1")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono2)
                    .HasColumnName("telefono2")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.HasOne(d => d.Ciudad)
                    .WithMany(p => p.DoctosCmProeve)
                    .HasForeignKey(d => d.CiudadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ciudades_a_proeve");

                entity.HasOne(d => d.DoctoCm)
                    .WithOne(p => p.DoctosCmProeve)
                    .HasForeignKey<DoctosCmProeve>(d => d.DoctoCmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_cm_a_proeve");

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.DoctosCmProeve)
                    .HasForeignKey(d => d.EstadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("estados_a_proeve");

                entity.HasOne(d => d.Pais)
                    .WithMany(p => p.DoctosCmProeve)
                    .HasForeignKey(d => d.PaisId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("paises_a_proeve");
            });

            modelBuilder.Entity<DoctosCo>(entity =>
            {
                entity.HasKey(e => e.DoctoCoId)
                    .HasName("doctos_co_pk");

                entity.ToTable("doctos_co");

                entity.HasIndex(e => new { e.Fecha, e.TipoPolizaId, e.Poliza })
                    .HasName("doctos_co_ie1");

                entity.Property(e => e.DoctoCoId)
                    .HasColumnName("docto_co_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Ajuste)
                    .IsRequired()
                    .HasColumnName("ajuste")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Aplicado)
                    .IsRequired()
                    .HasColumnName("aplicado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cancelado)
                    .IsRequired()
                    .HasColumnName("cancelado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Estatus)
                    .IsRequired()
                    .HasColumnName("estatus")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.FechaHoraCancelacion).HasColumnName("fecha_hora_cancelacion");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.FormaEmitida)
                    .HasColumnName("forma_emitida")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GrupoPolPeriodId).HasColumnName("grupo_pol_period_id");

                entity.Property(e => e.IntegBa)
                    .IsRequired()
                    .HasColumnName("integ_ba")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IntegCo)
                    .IsRequired()
                    .HasColumnName("integ_co")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MonedaId).HasColumnName("moneda_id");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Poliza)
                    .IsRequired()
                    .HasColumnName("poliza")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.SistemaOrigen)
                    .IsRequired()
                    .HasColumnName("sistema_origen")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoCambio)
                    .HasColumnName("tipo_cambio")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TipoPolizaId).HasColumnName("tipo_poliza_id");

                entity.Property(e => e.UsuarioAutCancelacion)
                    .HasColumnName("usuario_aut_cancelacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCancelacion)
                    .HasColumnName("usuario_cancelacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.GrupoPolPeriod)
                    .WithMany(p => p.DoctosCo)
                    .HasForeignKey(d => d.GrupoPolPeriodId)
                    .HasConstraintName("grupos_pol_per_a_doctos_co");

                entity.HasOne(d => d.Moneda)
                    .WithMany(p => p.DoctosCo)
                    .HasForeignKey(d => d.MonedaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("monedas_a_doctos_co");

                entity.HasOne(d => d.TipoPoliza)
                    .WithMany(p => p.DoctosCo)
                    .HasForeignKey(d => d.TipoPolizaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tippol_a_doctos_co");
            });

            modelBuilder.Entity<DoctosCoCfdi>(entity =>
            {
                entity.HasKey(e => e.DoctoCoCfdiId)
                    .HasName("doctos_co_cfdi_pk");

                entity.ToTable("doctos_co_cfdi");

                entity.Property(e => e.DoctoCoCfdiId)
                    .HasColumnName("docto_co_cfdi_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CfdiId).HasColumnName("cfdi_id");

                entity.Property(e => e.DoctoCoId).HasColumnName("docto_co_id");

                entity.Property(e => e.EsGlobal)
                    .HasColumnName("es_global")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Cfdi)
                    .WithMany(p => p.DoctosCoCfdi)
                    .HasForeignKey(d => d.CfdiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("repos_cfdi_a_doctos_co_cfdi");

                entity.HasOne(d => d.DoctoCo)
                    .WithMany(p => p.DoctosCoCfdi)
                    .HasForeignKey(d => d.DoctoCoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_co_a_cfdi");
            });

            modelBuilder.Entity<DoctosCoDet>(entity =>
            {
                entity.HasKey(e => e.DoctoCoDetId)
                    .HasName("doctos_co_det_pk");

                entity.ToTable("doctos_co_det");

                entity.HasIndex(e => new { e.CuentaId, e.DeptoCoId, e.Fecha })
                    .HasName("doctos_co_det_ie2");

                entity.Property(e => e.DoctoCoDetId)
                    .HasColumnName("docto_co_det_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Ajuste)
                    .HasColumnName("ajuste")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Aplicado)
                    .HasColumnName("aplicado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cancelado)
                    .HasColumnName("cancelado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CuentaId).HasColumnName("cuenta_id");

                entity.Property(e => e.DeptoCoId).HasColumnName("depto_co_id");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DoctoCoId).HasColumnName("docto_co_id");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.Importe)
                    .HasColumnName("importe")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ImporteMn)
                    .HasColumnName("importe_mn")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.MonedaId).HasColumnName("moneda_id");

                entity.Property(e => e.Posicion).HasColumnName("posicion");

                entity.Property(e => e.RecordatorioId).HasColumnName("recordatorio_id");

                entity.Property(e => e.Refer)
                    .HasColumnName("refer")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TipoAsiento)
                    .IsRequired()
                    .HasColumnName("tipo_asiento")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('C')");

                entity.HasOne(d => d.Cuenta)
                    .WithMany(p => p.DoctosCoDet)
                    .HasForeignKey(d => d.CuentaId)
                    .HasConstraintName("cuentas_co_a_doctos_det");

                entity.HasOne(d => d.DeptoCo)
                    .WithMany(p => p.DoctosCoDet)
                    .HasForeignKey(d => d.DeptoCoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("deptos_co_a_doctos_det");

                entity.HasOne(d => d.DoctoCo)
                    .WithMany(p => p.DoctosCoDet)
                    .HasForeignKey(d => d.DoctoCoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_co_a_det");

                entity.HasOne(d => d.Moneda)
                    .WithMany(p => p.DoctosCoDet)
                    .HasForeignKey(d => d.MonedaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("monedas_a_doctos_co_det");

                entity.HasOne(d => d.Recordatorio)
                    .WithMany(p => p.DoctosCoDet)
                    .HasForeignKey(d => d.RecordatorioId)
                    .HasConstraintName("record_a_doctos_co_det");
            });

            modelBuilder.Entity<DoctosCoDetCfdi>(entity =>
            {
                entity.HasKey(e => new { e.DoctoCoDetId, e.DoctoCoCfdiId })
                    .HasName("doctos_co_det_cfdi_pk");

                entity.ToTable("doctos_co_det_cfdi");

                entity.Property(e => e.DoctoCoDetId).HasColumnName("docto_co_det_id");

                entity.Property(e => e.DoctoCoCfdiId).HasColumnName("docto_co_cfdi_id");

                entity.HasOne(d => d.DoctoCoCfdi)
                    .WithMany(p => p.DoctosCoDetCfdi)
                    .HasForeignKey(d => d.DoctoCoCfdiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_co_cfdi_a_det");

                entity.HasOne(d => d.DoctoCoDet)
                    .WithMany(p => p.DoctosCoDetCfdi)
                    .HasForeignKey(d => d.DoctoCoDetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_co_det_a_cfdi");
            });

            modelBuilder.Entity<DoctosCoDetDiot>(entity =>
            {
                entity.HasKey(e => e.DoctoCoDetId)
                    .HasName("doctos_co_det_diot_pk");

                entity.ToTable("doctos_co_det_diot");

                entity.HasIndex(e => e.Fecha)
                    .HasName("doctos_co_det_diot_ie1");

                entity.Property(e => e.DoctoCoDetId)
                    .HasColumnName("docto_co_det_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EsDevolucion)
                    .HasColumnName("es_devolucion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.IgnorarOperacion)
                    .IsRequired()
                    .HasColumnName("ignorar_operacion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ImporteBaseIva0)
                    .HasColumnName("importe_base_iva_0")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ImporteBaseIvaExento)
                    .HasColumnName("importe_base_iva_exento")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ImporteBaseIvaExentoImp)
                    .HasColumnName("importe_base_iva_exento_imp")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ImporteBaseIvaFronterizo)
                    .HasColumnName("importe_base_iva_fronterizo")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ImporteBaseIvaGral)
                    .HasColumnName("importe_base_iva_gral")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ImporteBaseIvaGralImp)
                    .HasColumnName("importe_base_iva_gral_imp")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.IvaDevolucion)
                    .HasColumnName("iva_devolucion")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.IvaNoAcredFronterizo)
                    .HasColumnName("iva_no_acred_fronterizo")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.IvaNoAcredGral)
                    .HasColumnName("iva_no_acred_gral")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.IvaNoAcredGralImp)
                    .HasColumnName("iva_no_acred_gral_imp")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.IvaRetenido)
                    .HasColumnName("iva_retenido")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.TerceroCoId).HasColumnName("tercero_co_id");

                entity.Property(e => e.TipoOperacion)
                    .HasColumnName("tipo_operacion")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.DoctoCoDet)
                    .WithOne(p => p.DoctosCoDetDiot)
                    .HasForeignKey<DoctosCoDetDiot>(d => d.DoctoCoDetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_co_det_a_diot");

                entity.HasOne(d => d.TerceroCo)
                    .WithMany(p => p.DoctosCoDetDiot)
                    .HasForeignKey(d => d.TerceroCoId)
                    .HasConstraintName("terceros_a_doc_co_det_diot");
            });

            modelBuilder.Entity<DoctosCoDetInfoBan>(entity =>
            {
                entity.HasKey(e => e.DoctoCoDetInfoBanId)
                    .HasName("doctos_co_det_info_ban_pk");

                entity.ToTable("doctos_co_det_info_ban");

                entity.Property(e => e.DoctoCoDetInfoBanId)
                    .HasColumnName("docto_co_det_info_ban_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BancoTercero)
                    .HasColumnName("banco_tercero")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BeneficiarioId).HasColumnName("beneficiario_id");

                entity.Property(e => e.CuentaBanId).HasColumnName("cuenta_ban_id");

                entity.Property(e => e.CuentaBanTercero)
                    .HasColumnName("cuenta_ban_tercero")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DoctoCoDetId).HasColumnName("docto_co_det_id");

                entity.Property(e => e.Importe)
                    .HasColumnName("importe")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.MetodoPago)
                    .HasColumnName("metodo_pago")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NomBancoTerceroExt)
                    .HasColumnName("nom_banco_tercero_ext")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Refer)
                    .HasColumnName("refer")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TerceroCoId).HasColumnName("tercero_co_id");

                entity.Property(e => e.TipoMovFiscal)
                    .IsRequired()
                    .HasColumnName("tipo_mov_fiscal")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Beneficiario)
                    .WithMany(p => p.DoctosCoDetInfoBan)
                    .HasForeignKey(d => d.BeneficiarioId)
                    .HasConstraintName("benef_a_doc_co_det_info_ban");

                entity.HasOne(d => d.CuentaBan)
                    .WithMany(p => p.DoctosCoDetInfoBan)
                    .HasForeignKey(d => d.CuentaBanId)
                    .HasConstraintName("ctas_ban_a_doc_co_det_info_ban");

                entity.HasOne(d => d.DoctoCoDet)
                    .WithMany(p => p.DoctosCoDetInfoBan)
                    .HasForeignKey(d => d.DoctoCoDetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_co_det_a_info_ban");

                entity.HasOne(d => d.TerceroCo)
                    .WithMany(p => p.DoctosCoDetInfoBan)
                    .HasForeignKey(d => d.TerceroCoId)
                    .HasConstraintName("terceros_a_doc_co_det_info_ban");
            });

            modelBuilder.Entity<DoctosCoFiles>(entity =>
            {
                entity.HasKey(e => e.DoctoCoFileId)
                    .HasName("doctos_co_files_pk");

                entity.ToTable("doctos_co_files");

                entity.HasIndex(e => new { e.DoctoCoId, e.FileName })
                    .HasName("doctos_co_files_ak1")
                    .IsUnique()
                    .HasFilter("([docto_co_id] IS NOT NULL AND [file_name] IS NOT NULL)");

                entity.Property(e => e.DoctoCoFileId)
                    .HasColumnName("docto_co_file_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DoctoCoId).HasColumnName("docto_co_id");

                entity.Property(e => e.FileDate).HasColumnName("file_date");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasColumnName("file_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FileSize).HasColumnName("file_size");

                entity.Property(e => e.FileStream)
                    .IsRequired()
                    .HasColumnName("file_stream")
                    .IsUnicode(false);

                entity.HasOne(d => d.DoctoCo)
                    .WithMany(p => p.DoctosCoFiles)
                    .HasForeignKey(d => d.DoctoCoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_co_a_files");
            });

            modelBuilder.Entity<DoctosCp>(entity =>
            {
                entity.HasKey(e => e.DoctoCpId)
                    .HasName("doctos_cp_pk");

                entity.ToTable("doctos_cp");

                entity.HasIndex(e => new { e.Fecha, e.NaturalezaConcepto, e.ConceptoCpId, e.Folio })
                    .HasName("doctos_cp_ie1");

                entity.HasIndex(e => new { e.ProveedorId, e.ConceptoCpId, e.Folio, e.Aplicado })
                    .HasName("doctos_cp_ak1")
                    .IsUnique()
                    .HasFilter("([proveedor_id] IS NOT NULL AND [concepto_cp_id] IS NOT NULL AND [folio] IS NOT NULL AND [aplicado] IS NOT NULL)");

                entity.HasIndex(e => new { e.ProveedorId, e.Fecha, e.NaturalezaConcepto, e.ConceptoCpId, e.Folio })
                    .HasName("doctos_cp_ie2");

                entity.Property(e => e.DoctoCpId)
                    .HasColumnName("docto_cp_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aplicado)
                    .IsRequired()
                    .HasColumnName("aplicado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cancelado)
                    .HasColumnName("cancelado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaveProv)
                    .HasColumnName("clave_prov")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ConceptoCpId).HasColumnName("concepto_cp_id");

                entity.Property(e => e.CondPagoId).HasColumnName("cond_pago_id");

                entity.Property(e => e.Contabilizado)
                    .HasColumnName("contabilizado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContabilizadoBa)
                    .IsRequired()
                    .HasColumnName("contabilizado_ba")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContabilizadoGyp)
                    .IsRequired()
                    .HasColumnName("contabilizado_gyp")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CuentaConcepto)
                    .HasColumnName("cuenta_concepto")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Exportado)
                    .HasColumnName("exportado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.FechaDsctoPpag)
                    .HasColumnName("fecha_dscto_ppag")
                    .HasColumnType("date");

                entity.Property(e => e.FechaHoraCancelacion).HasColumnName("fecha_hora_cancelacion");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Folio)
                    .IsRequired()
                    .HasColumnName("folio")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FormaEmitida)
                    .HasColumnName("forma_emitida")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IntegBa)
                    .IsRequired()
                    .HasColumnName("integ_ba")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NaturalezaConcepto)
                    .IsRequired()
                    .HasColumnName("naturaleza_concepto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PctjeDsctoPpag)
                    .HasColumnName("pctje_dscto_ppag")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.ProveedorId).HasColumnName("proveedor_id");

                entity.Property(e => e.SistemaOrigen)
                    .IsRequired()
                    .HasColumnName("sistema_origen")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TieneCfd)
                    .HasColumnName("tiene_cfd")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoCambio)
                    .HasColumnName("tipo_cambio")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.UsuarioAutCancelacion)
                    .HasColumnName("usuario_aut_cancelacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCancelacion)
                    .HasColumnName("usuario_cancelacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.ConceptoCp)
                    .WithMany(p => p.DoctosCp)
                    .HasForeignKey(d => d.ConceptoCpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("concep_a_doctos_cp");

                entity.HasOne(d => d.CondPago)
                    .WithMany(p => p.DoctosCp)
                    .HasForeignKey(d => d.CondPagoId)
                    .HasConstraintName("cond_a_doctos_cp");

                entity.HasOne(d => d.Proveedor)
                    .WithMany(p => p.DoctosCp)
                    .HasForeignKey(d => d.ProveedorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("prov_a_doctos_cp");
            });

            modelBuilder.Entity<DoctosCpInfoBan>(entity =>
            {
                entity.HasKey(e => e.DoctoCpId)
                    .HasName("doctos_cp_info_ban_pk");

                entity.ToTable("doctos_cp_info_ban");

                entity.Property(e => e.DoctoCpId)
                    .HasColumnName("docto_cp_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BancoDest)
                    .HasColumnName("banco_dest")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.BeneficiarioId).HasColumnName("beneficiario_id");

                entity.Property(e => e.CuentaBanDest)
                    .HasColumnName("cuenta_ban_dest")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaBanId).HasColumnName("cuenta_ban_id");

                entity.Property(e => e.MetodoPago)
                    .HasColumnName("metodo_pago")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NomBancoDestExt)
                    .HasColumnName("nom_banco_dest_ext")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Refer)
                    .HasColumnName("refer")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoMovFiscal)
                    .IsRequired()
                    .HasColumnName("tipo_mov_fiscal")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Beneficiario)
                    .WithMany(p => p.DoctosCpInfoBan)
                    .HasForeignKey(d => d.BeneficiarioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("benef_a_doc_cp_info_ban");

                entity.HasOne(d => d.CuentaBan)
                    .WithMany(p => p.DoctosCpInfoBan)
                    .HasForeignKey(d => d.CuentaBanId)
                    .HasConstraintName("ctas_ban_a_doc_cp_info_ban");

                entity.HasOne(d => d.DoctoCp)
                    .WithOne(p => p.DoctosCpInfoBan)
                    .HasForeignKey<DoctosCpInfoBan>(d => d.DoctoCpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_cp_a_info_ban");
            });

            modelBuilder.Entity<DoctosEntreSis>(entity =>
            {
                entity.HasKey(e => e.DoctoDestId)
                    .HasName("doctos_entre_sis_pk");

                entity.ToTable("doctos_entre_sis");

                entity.HasIndex(e => e.DoctoFteId)
                    .HasName("doctos_entre_sis_ie1");

                entity.Property(e => e.DoctoDestId)
                    .HasColumnName("docto_dest_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClaveSisDest)
                    .IsRequired()
                    .HasColumnName("clave_sis_dest")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaveSisFte)
                    .IsRequired()
                    .HasColumnName("clave_sis_fte")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DoctoFteId).HasColumnName("docto_fte_id");

                entity.Property(e => e.TipoDocto)
                    .IsRequired()
                    .HasColumnName("tipo_docto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<DoctosIn>(entity =>
            {
                entity.HasKey(e => e.DoctoInId)
                    .HasName("doctos_in_pk");

                entity.ToTable("doctos_in");

                entity.HasIndex(e => new { e.ConceptoInId, e.Folio, e.Aplicado })
                    .HasName("doctos_in_ak1")
                    .IsUnique()
                    .HasFilter("([concepto_in_id] IS NOT NULL AND [folio] IS NOT NULL AND [aplicado] IS NOT NULL)");

                entity.HasIndex(e => new { e.Fecha, e.NaturalezaConcepto, e.ConceptoInId, e.Folio })
                    .HasName("doctos_in_ie1");

                entity.HasIndex(e => new { e.NaturalezaConcepto, e.Fecha, e.ConceptoInId, e.Folio })
                    .HasName("doctos_in_ie2");

                entity.Property(e => e.DoctoInId)
                    .HasColumnName("docto_in_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AlmacenDestinoId).HasColumnName("almacen_destino_id");

                entity.Property(e => e.AlmacenId).HasColumnName("almacen_id");

                entity.Property(e => e.Aplicado)
                    .HasColumnName("aplicado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cancelado)
                    .HasColumnName("cancelado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CentroCostoId).HasColumnName("centro_costo_id");

                entity.Property(e => e.ConceptoInId).HasColumnName("concepto_in_id");

                entity.Property(e => e.Contabilizado)
                    .HasColumnName("contabilizado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CuentaConcepto)
                    .HasColumnName("cuenta_concepto")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.FechaHoraCancelacion).HasColumnName("fecha_hora_cancelacion");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Folio)
                    .IsRequired()
                    .HasColumnName("folio")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FormaEmitida)
                    .HasColumnName("forma_emitida")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NaturalezaConcepto)
                    .IsRequired()
                    .HasColumnName("naturaleza_concepto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SistemaOrigen)
                    .IsRequired()
                    .HasColumnName("sistema_origen")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAutCancelacion)
                    .HasColumnName("usuario_aut_cancelacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCancelacion)
                    .HasColumnName("usuario_cancelacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.AlmacenDestino)
                    .WithMany(p => p.DoctosInAlmacenDestino)
                    .HasForeignKey(d => d.AlmacenDestinoId)
                    .HasConstraintName("alm_destino_a_doctos_in");

                entity.HasOne(d => d.Almacen)
                    .WithMany(p => p.DoctosInAlmacen)
                    .HasForeignKey(d => d.AlmacenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("alm_a_doctos_in");

                entity.HasOne(d => d.CentroCosto)
                    .WithMany(p => p.DoctosIn)
                    .HasForeignKey(d => d.CentroCostoId)
                    .HasConstraintName("centros_costo_a_doctos_in");
            });

            modelBuilder.Entity<DoctosInDet>(entity =>
            {
                entity.HasKey(e => e.DoctoInDetId)
                    .HasName("doctos_in_det_pk");

                entity.ToTable("doctos_in_det");

                entity.HasIndex(e => new { e.ArticuloId, e.AlmacenId, e.Fecha })
                    .HasName("doctos_in_det_ie1");

                entity.Property(e => e.DoctoInDetId)
                    .HasColumnName("docto_in_det_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AlmacenId).HasColumnName("almacen_id");

                entity.Property(e => e.Aplicado)
                    .HasColumnName("aplicado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ArticuloId).HasColumnName("articulo_id");

                entity.Property(e => e.Cancelado)
                    .HasColumnName("cancelado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CentroCostoId).HasColumnName("centro_costo_id");

                entity.Property(e => e.ClaveArticulo)
                    .HasColumnName("clave_articulo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ConceptoInId).HasColumnName("concepto_in_id");

                entity.Property(e => e.CosteoPend)
                    .HasColumnName("costeo_pend")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CostoTotal)
                    .HasColumnName("costo_total")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.CostoUnitario)
                    .HasColumnName("costo_unitario")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.DoctoInId).HasColumnName("docto_in_id");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.MetodoCosteo)
                    .IsRequired()
                    .HasColumnName("metodo_costeo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PedimentoPend)
                    .HasColumnName("pedimento_pend")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Rol)
                    .IsRequired()
                    .HasColumnName("rol")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.TipoMovto)
                    .IsRequired()
                    .HasColumnName("tipo_movto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Unidades)
                    .HasColumnName("unidades")
                    .HasColumnType("decimal(18, 5)");

                entity.HasOne(d => d.Almacen)
                    .WithMany(p => p.DoctosInDet)
                    .HasForeignKey(d => d.AlmacenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("alm_a_doctos_in_det");

                entity.HasOne(d => d.Articulo)
                    .WithMany(p => p.DoctosInDet)
                    .HasForeignKey(d => d.ArticuloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("arts_a_doctos_in_det");

                entity.HasOne(d => d.CentroCosto)
                    .WithMany(p => p.DoctosInDet)
                    .HasForeignKey(d => d.CentroCostoId)
                    .HasConstraintName("centros_costo_a_doctos_in_det");

                entity.HasOne(d => d.DoctoIn)
                    .WithMany(p => p.DoctosInDet)
                    .HasForeignKey(d => d.DoctoInId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_in_a_det");
            });

            modelBuilder.Entity<DoctosInDetCompras>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("doctos_in_det_compras");

                entity.HasIndex(e => e.ArticuloId)
                    .HasName("doctos_in_det_compras_ie1");

                entity.Property(e => e.ArticuloId).HasColumnName("articulo_id");

                entity.Property(e => e.DoctoInDetId).HasColumnName("docto_in_det_id");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.HasOne(d => d.DoctoInDet)
                    .WithMany()
                    .HasForeignKey(d => d.DoctoInDetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_in_det_a_compras");
            });

            modelBuilder.Entity<DoctosInvfis>(entity =>
            {
                entity.HasKey(e => e.DoctoInvfisId)
                    .HasName("doctos_invfis_pk");

                entity.ToTable("doctos_invfis");

                entity.HasIndex(e => e.Folio)
                    .HasName("doctos_invfis_ak1")
                    .IsUnique()
                    .HasFilter("([folio] IS NOT NULL)");

                entity.Property(e => e.DoctoInvfisId)
                    .HasColumnName("docto_invfis_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AlmacenId).HasColumnName("almacen_id");

                entity.Property(e => e.Aplicado)
                    .HasColumnName("aplicado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cancelado)
                    .HasColumnName("cancelado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DoctoInIdEnt).HasColumnName("docto_in_id_ent");

                entity.Property(e => e.DoctoInIdSal).HasColumnName("docto_in_id_sal");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.FechaHoraCancelacion).HasColumnName("fecha_hora_cancelacion");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Folio)
                    .IsRequired()
                    .HasColumnName("folio")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAutCancelacion)
                    .HasColumnName("usuario_aut_cancelacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCancelacion)
                    .HasColumnName("usuario_cancelacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.Almacen)
                    .WithMany(p => p.DoctosInvfis)
                    .HasForeignKey(d => d.AlmacenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("alm_a_invfis");

                entity.HasOne(d => d.DoctoInIdEntNavigation)
                    .WithMany(p => p.DoctosInvfisDoctoInIdEntNavigation)
                    .HasForeignKey(d => d.DoctoInIdEnt)
                    .HasConstraintName("doctos_invfis_a_invfis_ent");

                entity.HasOne(d => d.DoctoInIdSalNavigation)
                    .WithMany(p => p.DoctosInvfisDoctoInIdSalNavigation)
                    .HasForeignKey(d => d.DoctoInIdSal)
                    .HasConstraintName("doctos_invfis_a_invfis_sal");
            });

            modelBuilder.Entity<DoctosInvfisDet>(entity =>
            {
                entity.HasKey(e => e.DoctoInvfisDetId)
                    .HasName("doctos_invfis_det_pk");

                entity.ToTable("doctos_invfis_det");

                entity.HasIndex(e => new { e.DoctoInvfisId, e.ArticuloId })
                    .HasName("doctos_invfis_det_ak1")
                    .IsUnique()
                    .HasFilter("([docto_invfis_id] IS NOT NULL AND [articulo_id] IS NOT NULL)");

                entity.HasIndex(e => new { e.DoctoInvfisId, e.DoctoInvfisDetId })
                    .HasName("doctos_invfis_det_ak2");

                entity.Property(e => e.DoctoInvfisDetId)
                    .HasColumnName("docto_invfis_det_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArticuloId).HasColumnName("articulo_id");

                entity.Property(e => e.ClaveArticulo)
                    .HasColumnName("clave_articulo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DoctoInDetIdEnt).HasColumnName("docto_in_det_id_ent");

                entity.Property(e => e.DoctoInDetIdSal).HasColumnName("docto_in_det_id_sal");

                entity.Property(e => e.DoctoInvfisId).HasColumnName("docto_invfis_id");

                entity.Property(e => e.Unidades)
                    .HasColumnName("unidades")
                    .HasColumnType("decimal(18, 5)");

                entity.HasOne(d => d.Articulo)
                    .WithMany(p => p.DoctosInvfisDet)
                    .HasForeignKey(d => d.ArticuloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("arts_a_invfis_det");

                entity.HasOne(d => d.DoctoInDetIdEntNavigation)
                    .WithMany(p => p.DoctosInvfisDetDoctoInDetIdEntNavigation)
                    .HasForeignKey(d => d.DoctoInDetIdEnt)
                    .HasConstraintName("doctos_in_det_ent_a_invfis_det");

                entity.HasOne(d => d.DoctoInDetIdSalNavigation)
                    .WithMany(p => p.DoctosInvfisDetDoctoInDetIdSalNavigation)
                    .HasForeignKey(d => d.DoctoInDetIdSal)
                    .HasConstraintName("doctos_in_det_sal_a_invfis_det");

                entity.HasOne(d => d.DoctoInvfis)
                    .WithMany(p => p.DoctosInvfisDet)
                    .HasForeignKey(d => d.DoctoInvfisId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_invfis_a_det");
            });

            modelBuilder.Entity<DoctosPendCc>(entity =>
            {
                entity.HasKey(e => e.DoctoPendCcId)
                    .HasName("doctos_pend_cc_pk");

                entity.ToTable("doctos_pend_cc");

                entity.Property(e => e.DoctoPendCcId)
                    .HasColumnName("docto_pend_cc_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cancelado)
                    .HasColumnName("cancelado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaveCliente)
                    .HasColumnName("clave_cliente")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteId).HasColumnName("cliente_id");

                entity.Property(e => e.CobradorId).HasColumnName("cobrador_id");

                entity.Property(e => e.ConceptoCcId).HasColumnName("concepto_cc_id");

                entity.Property(e => e.CondPagoId).HasColumnName("cond_pago_id");

                entity.Property(e => e.Contabilizado)
                    .IsRequired()
                    .HasColumnName("contabilizado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CuentaConcepto)
                    .HasColumnName("cuenta_concepto")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.FechaDsctoPpag)
                    .HasColumnName("fecha_dscto_ppag")
                    .HasColumnType("date");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Folio)
                    .HasColumnName("folio")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FormaEmitida)
                    .IsRequired()
                    .HasColumnName("forma_emitida")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Importado)
                    .IsRequired()
                    .HasColumnName("importado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PctjeDsctoPpag)
                    .HasColumnName("pctje_dscto_ppag")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.TipoCambio)
                    .HasColumnName("tipo_cambio")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.DoctosPendCc)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cli_a_doctos_pend_cc");

                entity.HasOne(d => d.Cobrador)
                    .WithMany(p => p.DoctosPendCc)
                    .HasForeignKey(d => d.CobradorId)
                    .HasConstraintName("cob_a_doctos_pend_cc");

                entity.HasOne(d => d.ConceptoCc)
                    .WithMany(p => p.DoctosPendCc)
                    .HasForeignKey(d => d.ConceptoCcId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("concep_a_doctos_pend_cc");

                entity.HasOne(d => d.CondPago)
                    .WithMany(p => p.DoctosPendCc)
                    .HasForeignKey(d => d.CondPagoId)
                    .HasConstraintName("cond_pag_a_doctos_pend_cc");
            });

            modelBuilder.Entity<DoctosProcCancel>(entity =>
            {
                entity.HasKey(e => new { e.ClaveSis, e.DoctoId })
                    .HasName("doctos_proc_cancel_pk");

                entity.ToTable("doctos_proc_cancel");

                entity.Property(e => e.ClaveSis)
                    .HasColumnName("clave_sis")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DoctoId).HasColumnName("docto_id");

                entity.Property(e => e.CfdiId).HasColumnName("cfdi_id");

                entity.Property(e => e.Estatus)
                    .IsRequired()
                    .HasColumnName("estatus")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.HasOne(d => d.Cfdi)
                    .WithMany(p => p.DoctosProcCancel)
                    .HasForeignKey(d => d.CfdiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cfdi_a_doctos_proc_cancel");
            });

            modelBuilder.Entity<DoctosPv>(entity =>
            {
                entity.HasKey(e => e.DoctoPvId)
                    .HasName("doctos_pv_pk");

                entity.ToTable("doctos_pv");

                entity.HasIndex(e => new { e.Fecha, e.TipoDocto, e.Folio })
                    .HasName("doctos_pv_ie1");

                entity.HasIndex(e => new { e.TipoDocto, e.Folio, e.Aplicado })
                    .HasName("doctos_pv_ak1")
                    .IsUnique()
                    .HasFilter("([tipo_docto] IS NOT NULL AND [folio] IS NOT NULL AND [aplicado] IS NOT NULL)");

                entity.Property(e => e.DoctoPvId)
                    .HasColumnName("docto_pv_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AlmacenId).HasColumnName("almacen_id");

                entity.Property(e => e.AlmacenIdFacGlobal).HasColumnName("almacen_id_fac_global");

                entity.Property(e => e.Aplicado)
                    .HasColumnName("aplicado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CajaId).HasColumnName("caja_id");

                entity.Property(e => e.CajeroId).HasColumnName("cajero_id");

                entity.Property(e => e.CargarSun)
                    .HasColumnName("cargar_sun")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CfdiCertificado)
                    .IsRequired()
                    .HasColumnName("cfdi_certificado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ClaveCliente)
                    .HasColumnName("clave_cliente")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClaveClienteFac)
                    .HasColumnName("clave_cliente_fac")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteFacId).HasColumnName("cliente_fac_id");

                entity.Property(e => e.ClienteId).HasColumnName("cliente_id");

                entity.Property(e => e.Contabilizado)
                    .HasColumnName("contabilizado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DirCliId).HasColumnName("dir_cli_id");

                entity.Property(e => e.DsctoImporte)
                    .HasColumnName("dscto_importe")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.DsctoPctje)
                    .HasColumnName("dscto_pctje")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.EmailEnvio)
                    .HasColumnName("email_envio")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Enviado)
                    .HasColumnName("enviado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EsCfd)
                    .HasColumnName("es_cfd")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EsFacGlobal)
                    .IsRequired()
                    .HasColumnName("es_fac_global")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estatus)
                    .HasColumnName("estatus")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date")
                    .HasDefaultValueSql("('TODAY')");

                entity.Property(e => e.FechaFinFacGlobal)
                    .HasColumnName("fecha_fin_fac_global")
                    .HasColumnType("date");

                entity.Property(e => e.FechaHoraCancelacion).HasColumnName("fecha_hora_cancelacion");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraEnvio).HasColumnName("fecha_hora_envio");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.FechaIniFacGlobal)
                    .HasColumnName("fecha_ini_fac_global")
                    .HasColumnType("date");

                entity.Property(e => e.Folio)
                    .IsRequired()
                    .HasColumnName("folio")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FormaEmitida)
                    .HasColumnName("forma_emitida")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FormaGlobalEmitida)
                    .HasColumnName("forma_global_emitida")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hora)
                    .HasColumnName("hora")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ImporteDonativo)
                    .HasColumnName("importe_donativo")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ImporteNeto)
                    .HasColumnName("importe_neto")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ImpuestoIncluido)
                    .HasColumnName("impuesto_incluido")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ImpuestoSustituidoId).HasColumnName("impuesto_sustituido_id");

                entity.Property(e => e.ImpuestoSustitutoId).HasColumnName("impuesto_sustituto_id");

                entity.Property(e => e.InclFacturadosFacGlobal)
                    .HasColumnName("incl_facturados_fac_global")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LugarExpedicionId).HasColumnName("lugar_expedicion_id");

                entity.Property(e => e.MetodoPagoSat)
                    .HasColumnName("metodo_pago_sat")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ModalidadFacturacion)
                    .HasColumnName("modalidad_facturacion")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MonedaId).HasColumnName("moneda_id");

                entity.Property(e => e.PartidaAjusteId).HasColumnName("partida_ajuste_id");

                entity.Property(e => e.Persona)
                    .HasColumnName("persona")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrecioOrigPartidaAjuste)
                    .HasColumnName("precio_orig_partida_ajuste")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ReferReting)
                    .HasColumnName("refer_reting")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SistemaOrigen)
                    .IsRequired()
                    .HasColumnName("sistema_origen")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TicketEmitido)
                    .HasColumnName("ticket_emitido")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoCambio)
                    .HasColumnName("tipo_cambio")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TipoDocto)
                    .IsRequired()
                    .HasColumnName("tipo_docto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoDscto)
                    .HasColumnName("tipo_dscto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoGenFac)
                    .HasColumnName("tipo_gen_fac")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TotalFpgc)
                    .HasColumnName("total_fpgc")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.TotalImpuestos)
                    .HasColumnName("total_impuestos")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.UnidComprom)
                    .HasColumnName("unid_comprom")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsoCfdi)
                    .HasColumnName("uso_cfdi")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAutCancelacion)
                    .HasColumnName("usuario_aut_cancelacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCancelacion)
                    .HasColumnName("usuario_cancelacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.VendedorId).HasColumnName("vendedor_id");

                entity.HasOne(d => d.Almacen)
                    .WithMany(p => p.DoctosPvAlmacen)
                    .HasForeignKey(d => d.AlmacenId)
                    .HasConstraintName("alm_a_doctos_pv");

                entity.HasOne(d => d.AlmacenIdFacGlobalNavigation)
                    .WithMany(p => p.DoctosPvAlmacenIdFacGlobalNavigation)
                    .HasForeignKey(d => d.AlmacenIdFacGlobal)
                    .HasConstraintName("alm_fac_global_a_doctos_pv");

                entity.HasOne(d => d.Caja)
                    .WithMany(p => p.DoctosPv)
                    .HasForeignKey(d => d.CajaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cajas_a_doctos_pv");

                entity.HasOne(d => d.Cajero)
                    .WithMany(p => p.DoctosPv)
                    .HasForeignKey(d => d.CajeroId)
                    .HasConstraintName("cajeros_a_doctos_pv");

                entity.HasOne(d => d.ClienteFac)
                    .WithMany(p => p.DoctosPvClienteFac)
                    .HasForeignKey(d => d.ClienteFacId)
                    .HasConstraintName("cli_fac_a_doctos_pv");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.DoctosPvCliente)
                    .HasForeignKey(d => d.ClienteId)
                    .HasConstraintName("clientes_a_doctos_pv");

                entity.HasOne(d => d.DirCli)
                    .WithMany(p => p.DoctosPv)
                    .HasForeignKey(d => d.DirCliId)
                    .HasConstraintName("dirs_cli_a_doctos_pv");

                entity.HasOne(d => d.ImpuestoSustituido)
                    .WithMany(p => p.DoctosPvImpuestoSustituido)
                    .HasForeignKey(d => d.ImpuestoSustituidoId)
                    .HasConstraintName("impto_sustituido_pv");

                entity.HasOne(d => d.ImpuestoSustituto)
                    .WithMany(p => p.DoctosPvImpuestoSustituto)
                    .HasForeignKey(d => d.ImpuestoSustitutoId)
                    .HasConstraintName("impto_sustituto_pv");

                entity.HasOne(d => d.Moneda)
                    .WithMany(p => p.DoctosPv)
                    .HasForeignKey(d => d.MonedaId)
                    .HasConstraintName("monedas_a_doctos_pv");

                entity.HasOne(d => d.Vendedor)
                    .WithMany(p => p.DoctosPv)
                    .HasForeignKey(d => d.VendedorId)
                    .HasConstraintName("vendedores_a_doctos_pv");
            });

            modelBuilder.Entity<DoctosPvCobros>(entity =>
            {
                entity.HasKey(e => e.DoctoPvCobroId)
                    .HasName("doctos_pv_cobros_pk");

                entity.ToTable("doctos_pv_cobros");

                entity.HasIndex(e => new { e.DoctoPvId, e.Tipo, e.FormaCobroId })
                    .HasName("doctos_pv_cobros_ak1")
                    .IsUnique()
                    .HasFilter("([docto_pv_id] IS NOT NULL AND [tipo] IS NOT NULL AND [forma_cobro_id] IS NOT NULL)");

                entity.Property(e => e.DoctoPvCobroId)
                    .HasColumnName("docto_pv_cobro_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DoctoPvId).HasColumnName("docto_pv_id");

                entity.Property(e => e.FormaCobroId).HasColumnName("forma_cobro_id");

                entity.Property(e => e.Importe)
                    .HasColumnName("importe")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ImporteMonDoc)
                    .HasColumnName("importe_mon_doc")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("tipo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoCambio)
                    .HasColumnName("tipo_cambio")
                    .HasColumnType("decimal(18, 6)");

                entity.HasOne(d => d.DoctoPv)
                    .WithMany(p => p.DoctosPvCobros)
                    .HasForeignKey(d => d.DoctoPvId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_pv_a_doctos_pv_cobros");

                entity.HasOne(d => d.FormaCobro)
                    .WithMany(p => p.DoctosPvCobros)
                    .HasForeignKey(d => d.FormaCobroId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("formas_cobro_a_doc_pv_cobros");
            });

            modelBuilder.Entity<DoctosPvCobrosRefer>(entity =>
            {
                entity.HasKey(e => new { e.DoctoPvCobroId, e.FormaCobroReferId })
                    .HasName("doctos_pv_cobros_refer_pk");

                entity.ToTable("doctos_pv_cobros_refer");

                entity.Property(e => e.DoctoPvCobroId).HasColumnName("docto_pv_cobro_id");

                entity.Property(e => e.FormaCobroReferId).HasColumnName("forma_cobro_refer_id");

                entity.Property(e => e.Referencia)
                    .HasColumnName("referencia")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.DoctoPvCobro)
                    .WithMany(p => p.DoctosPvCobrosRefer)
                    .HasForeignKey(d => d.DoctoPvCobroId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_pv_cobros_a_refer");

                entity.HasOne(d => d.FormaCobroRefer)
                    .WithMany(p => p.DoctosPvCobrosRefer)
                    .HasForeignKey(d => d.FormaCobroReferId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("formas_cobro_refer_a_valores");
            });

            modelBuilder.Entity<DoctosPvDet>(entity =>
            {
                entity.HasKey(e => e.DoctoPvDetId)
                    .HasName("doctos_pv_det_pk");

                entity.ToTable("doctos_pv_det");

                entity.Property(e => e.DoctoPvDetId)
                    .HasColumnName("docto_pv_det_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArticuloId).HasColumnName("articulo_id");

                entity.Property(e => e.ClaveArticulo)
                    .HasColumnName("clave_articulo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DoctoPvId).HasColumnName("docto_pv_id");

                entity.Property(e => e.DsctoArt)
                    .HasColumnName("dscto_art")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.DsctoExtra)
                    .HasColumnName("dscto_extra")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.EsTranElect)
                    .HasColumnName("es_tran_elect")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EstatusTranElect)
                    .HasColumnName("estatus_tran_elect")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ImpuestoPorUnidad)
                    .HasColumnName("impuesto_por_unidad")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Notas)
                    .HasColumnName("notas")
                    .IsUnicode(false);

                entity.Property(e => e.PctjeComis)
                    .HasColumnName("pctje_comis")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.PctjeDscto)
                    .HasColumnName("pctje_dscto")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.Posicion).HasColumnName("posicion");

                entity.Property(e => e.PrecioModificado)
                    .IsRequired()
                    .HasColumnName("precio_modificado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.PrecioTotalNeto)
                    .HasColumnName("precio_total_neto")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.PrecioUnitario)
                    .HasColumnName("precio_unitario")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.PrecioUnitarioImpto)
                    .HasColumnName("precio_unitario_impto")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Rol)
                    .IsRequired()
                    .HasColumnName("rol")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoContabUnid)
                    .HasColumnName("tipo_contab_unid")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Unidades)
                    .HasColumnName("unidades")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.UnidadesDev)
                    .HasColumnName("unidades_dev")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.VendedorId).HasColumnName("vendedor_id");

                entity.HasOne(d => d.Articulo)
                    .WithMany(p => p.DoctosPvDet)
                    .HasForeignKey(d => d.ArticuloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("arts_a_doctos_pv_det");

                entity.HasOne(d => d.DoctoPv)
                    .WithMany(p => p.DoctosPvDet)
                    .HasForeignKey(d => d.DoctoPvId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_pv_a_det");

                entity.HasOne(d => d.Vendedor)
                    .WithMany(p => p.DoctosPvDet)
                    .HasForeignKey(d => d.VendedorId)
                    .HasConstraintName("vendedores_a_doctos_pv_det");
            });

            modelBuilder.Entity<DoctosPvDetTranElect>(entity =>
            {
                entity.HasKey(e => e.DoctoPvDetId)
                    .HasName("doctos_pv_det_tran_elect_pk");

                entity.ToTable("doctos_pv_det_tran_elect");

                entity.HasIndex(e => new { e.ClaveServicio, e.FechaHora })
                    .HasName("doctos_pv_det_tran_elect_ie2");

                entity.HasIndex(e => new { e.ClaveServicio, e.FechaHoraCreacion })
                    .HasName("doctos_pv_det_tran_elect_ie1");

                entity.Property(e => e.DoctoPvDetId)
                    .HasColumnName("docto_pv_det_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Autorizacion)
                    .IsRequired()
                    .HasColumnName("autorizacion")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CajaId).HasColumnName("caja_id");

                entity.Property(e => e.CajeroId).HasColumnName("cajero_id");

                entity.Property(e => e.ClaveReceptor)
                    .HasColumnName("clave_receptor")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClaveServicio)
                    .IsRequired()
                    .HasColumnName("clave_servicio")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Costo)
                    .HasColumnName("costo")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.FechaHora).HasColumnName("fecha_hora");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.Importe)
                    .HasColumnName("importe")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ParamsText)
                    .IsRequired()
                    .HasColumnName("params_text")
                    .IsUnicode(false);

                entity.HasOne(d => d.Caja)
                    .WithMany(p => p.DoctosPvDetTranElect)
                    .HasForeignKey(d => d.CajaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cajas_a_det_tran_elect");

                entity.HasOne(d => d.Cajero)
                    .WithMany(p => p.DoctosPvDetTranElect)
                    .HasForeignKey(d => d.CajeroId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cajeros_a_det_tran_elect");

                entity.HasOne(d => d.DoctoPvDet)
                    .WithOne(p => p.DoctosPvDetTranElect)
                    .HasForeignKey<DoctosPvDetTranElect>(d => d.DoctoPvDetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_pv_det_a_tran_elect");
            });

            modelBuilder.Entity<DoctosPvLigas>(entity =>
            {
                entity.HasKey(e => e.DoctoPvLigaId)
                    .HasName("doctos_pv_ligas_pk");

                entity.ToTable("doctos_pv_ligas");

                entity.HasIndex(e => new { e.DoctoPvDestId, e.DoctoPvFteId })
                    .HasName("doctos_pv_ligas_ak2")
                    .IsUnique()
                    .HasFilter("([docto_pv_dest_id] IS NOT NULL AND [docto_pv_fte_id] IS NOT NULL)");

                entity.HasIndex(e => new { e.DoctoPvFteId, e.DoctoPvDestId })
                    .HasName("doctos_pv_ligas_ak1")
                    .IsUnique()
                    .HasFilter("([docto_pv_fte_id] IS NOT NULL AND [docto_pv_dest_id] IS NOT NULL)");

                entity.Property(e => e.DoctoPvLigaId)
                    .HasColumnName("docto_pv_liga_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DoctoPvDestId).HasColumnName("docto_pv_dest_id");

                entity.Property(e => e.DoctoPvFteId).HasColumnName("docto_pv_fte_id");

                entity.HasOne(d => d.DoctoPvDest)
                    .WithMany(p => p.DoctosPvLigasDoctoPvDest)
                    .HasForeignKey(d => d.DoctoPvDestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_pv_a_ligas_dest");

                entity.HasOne(d => d.DoctoPvFte)
                    .WithMany(p => p.DoctosPvLigasDoctoPvFte)
                    .HasForeignKey(d => d.DoctoPvFteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_pv_a_ligas_fte");
            });

            modelBuilder.Entity<DoctosPvLigasDet>(entity =>
            {
                entity.HasKey(e => new { e.DoctoPvLigaId, e.DoctoPvDetFteId, e.DoctoPvDetDestId })
                    .HasName("doctos_pv_ligas_det_pk");

                entity.ToTable("doctos_pv_ligas_det");

                entity.HasIndex(e => e.DoctoPvDetDestId)
                    .HasName("doctos_pv_ligas_det_ie2");

                entity.HasIndex(e => e.DoctoPvDetFteId)
                    .HasName("doctos_pv_ligas_det_ie1");

                entity.Property(e => e.DoctoPvLigaId).HasColumnName("docto_pv_liga_id");

                entity.Property(e => e.DoctoPvDetFteId).HasColumnName("docto_pv_det_fte_id");

                entity.Property(e => e.DoctoPvDetDestId).HasColumnName("docto_pv_det_dest_id");

                entity.HasOne(d => d.DoctoPvDetDest)
                    .WithMany(p => p.DoctosPvLigasDetDoctoPvDetDest)
                    .HasForeignKey(d => d.DoctoPvDetDestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_pv_det_a_ligas_dest");

                entity.HasOne(d => d.DoctoPvDetFte)
                    .WithMany(p => p.DoctosPvLigasDetDoctoPvDetFte)
                    .HasForeignKey(d => d.DoctoPvDetFteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_pv_det_a_ligas_fte");

                entity.HasOne(d => d.DoctoPvLiga)
                    .WithMany(p => p.DoctosPvLigasDet)
                    .HasForeignKey(d => d.DoctoPvLigaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_pv_ligas_a_det");
            });

            modelBuilder.Entity<DoctosPvNombresOfertasMm>(entity =>
            {
                entity.HasKey(e => e.NombreOfertaId)
                    .HasName("doctos_pv_nombres_oferta_mm_pk");

                entity.ToTable("doctos_pv_nombres_ofertas_mm");

                entity.HasIndex(e => e.NombreOferta)
                    .HasName("doctos_pv_nombres_oferta_mm_ak1")
                    .IsUnique()
                    .HasFilter("([nombre_oferta] IS NOT NULL)");

                entity.Property(e => e.NombreOfertaId)
                    .HasColumnName("nombre_oferta_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.NombreOferta)
                    .IsRequired()
                    .HasColumnName("nombre_oferta")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DoctosPvOfertasMm>(entity =>
            {
                entity.HasKey(e => e.DoctoPvOfertaMmId)
                    .HasName("doctos_pv_ofertas_mm_pk");

                entity.ToTable("doctos_pv_ofertas_mm");

                entity.Property(e => e.DoctoPvOfertaMmId)
                    .HasColumnName("docto_pv_oferta_mm_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DoctoPvId).HasColumnName("docto_pv_id");

                entity.Property(e => e.NombreOfertaId).HasColumnName("nombre_oferta_id");

                entity.HasOne(d => d.DoctoPv)
                    .WithMany(p => p.DoctosPvOfertasMm)
                    .HasForeignKey(d => d.DoctoPvId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_pv_a_ofertas_mm");

                entity.HasOne(d => d.NombreOferta)
                    .WithMany(p => p.DoctosPvOfertasMm)
                    .HasForeignKey(d => d.NombreOfertaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_pv_nombres_a_ofertas_mm");
            });

            modelBuilder.Entity<DoctosPvOfertasMmDet>(entity =>
            {
                entity.HasKey(e => e.DoctoPvOfertaMmDetId)
                    .HasName("doctos_pv_ofertas_mm_det_pk");

                entity.ToTable("doctos_pv_ofertas_mm_det");

                entity.Property(e => e.DoctoPvOfertaMmDetId)
                    .HasColumnName("docto_pv_oferta_mm_det_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DoctoPvDetId).HasColumnName("docto_pv_det_id");

                entity.Property(e => e.DoctoPvDetOrigId).HasColumnName("docto_pv_det_orig_id");

                entity.Property(e => e.DoctoPvOfertaMmId).HasColumnName("docto_pv_oferta_mm_id");

                entity.Property(e => e.PctjeDscto)
                    .HasColumnName("pctje_dscto")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.PctjeDsctoOrig)
                    .HasColumnName("pctje_dscto_orig")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.PrecioEspecial)
                    .HasColumnName("precio_especial")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.PrecioUnitarioImptoOrig)
                    .HasColumnName("precio_unitario_impto_orig")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.PrecioUnitarioOrig)
                    .HasColumnName("precio_unitario_orig")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TipoDscto)
                    .IsRequired()
                    .HasColumnName("tipo_dscto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Unidades)
                    .HasColumnName("unidades")
                    .HasColumnType("decimal(18, 5)");

                entity.HasOne(d => d.DoctoPvOfertaMm)
                    .WithMany(p => p.DoctosPvOfertasMmDet)
                    .HasForeignKey(d => d.DoctoPvOfertaMmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_pv_ofertas_mm_a_det");
            });

            modelBuilder.Entity<DoctosPvTranPendTc>(entity =>
            {
                entity.HasKey(e => e.DoctoPvTranPendTcId)
                    .HasName("doctos_pv_tran_pend_tc_pk");

                entity.ToTable("doctos_pv_tran_pend_tc");

                entity.HasIndex(e => e.CajaId)
                    .HasName("doctos_pv_tran_pend_tc_uq1")
                    .IsUnique()
                    .HasFilter("([caja_id] IS NOT NULL)");

                entity.Property(e => e.DoctoPvTranPendTcId)
                    .HasColumnName("docto_pv_tran_pend_tc_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CajaId).HasColumnName("caja_id");

                entity.Property(e => e.DeclinadoEmv)
                    .HasColumnName("declinado_emv")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DoctoPvCobroId).HasColumnName("docto_pv_cobro_id");

                entity.Property(e => e.FormaCobroId).HasColumnName("forma_cobro_id");

                entity.Property(e => e.ParamsCance)
                    .IsRequired()
                    .HasColumnName("params_cance")
                    .IsUnicode(false);

                entity.HasOne(d => d.Caja)
                    .WithOne(p => p.DoctosPvTranPendTc)
                    .HasForeignKey<DoctosPvTranPendTc>(d => d.CajaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cajas_a_doctos_pv_tran_pend_tc");

                entity.HasOne(d => d.FormaCobro)
                    .WithMany(p => p.DoctosPvTranPendTc)
                    .HasForeignKey(d => d.FormaCobroId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("formas_cob_a_doctos_trn_pend_tc");
            });

            modelBuilder.Entity<DoctosSucursales>(entity =>
            {
                entity.HasKey(e => new { e.SistemaOrigen, e.DoctoId })
                    .HasName("doctos_sucursales_pk");

                entity.ToTable("doctos_sucursales");

                entity.HasIndex(e => new { e.SistemaOrigen, e.SucursalId, e.Fecha })
                    .HasName("doctos_sucursales_ie1");

                entity.Property(e => e.SistemaOrigen)
                    .HasColumnName("sistema_origen")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DoctoId).HasColumnName("docto_id");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.SucursalId).HasColumnName("sucursal_id");

                entity.HasOne(d => d.Sucursal)
                    .WithMany(p => p.DoctosSucursales)
                    .HasForeignKey(d => d.SucursalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sucursales_a_doctos");
            });

            modelBuilder.Entity<DoctosTr>(entity =>
            {
                entity.HasKey(e => e.DoctoTrId)
                    .HasName("doctos_tr_pk");

                entity.ToTable("doctos_tr");

                entity.HasIndex(e => e.Folio)
                    .HasName("doctos_tr_ak1")
                    .IsUnique()
                    .HasFilter("([folio] IS NOT NULL)");

                entity.HasIndex(e => new { e.ClaveSis, e.DoctoOrigenId })
                    .HasName("doctos_tr_ie1");

                entity.Property(e => e.DoctoTrId)
                    .HasColumnName("docto_tr_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cancelado)
                    .IsRequired()
                    .HasColumnName("cancelado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CfdiCertificado)
                    .IsRequired()
                    .HasColumnName("cfdi_certificado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ClaveCliente)
                    .HasColumnName("clave_cliente")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClaveSis)
                    .IsRequired()
                    .HasColumnName("clave_sis")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClienteId).HasColumnName("cliente_id");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DirCliId).HasColumnName("dir_cli_id");

                entity.Property(e => e.DoctoOrigenId).HasColumnName("docto_origen_id");

                entity.Property(e => e.EmailEnvio)
                    .HasColumnName("email_envio")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Enviado)
                    .IsRequired()
                    .HasColumnName("enviado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.FechaHoraCancelacion).HasColumnName("fecha_hora_cancelacion");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraEnvio).HasColumnName("fecha_hora_envio");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Folio)
                    .IsRequired()
                    .HasColumnName("folio")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FormaEmitida)
                    .HasColumnName("forma_emitida")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hora)
                    .HasColumnName("hora")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LugarExpedicionId).HasColumnName("lugar_expedicion_id");

                entity.Property(e => e.UsuarioAutCancelacion)
                    .HasColumnName("usuario_aut_cancelacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCancelacion)
                    .HasColumnName("usuario_cancelacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.DoctosTr)
                    .HasForeignKey(d => d.ClienteId)
                    .HasConstraintName("clientes_a_doctos_tr");

                entity.HasOne(d => d.DirCli)
                    .WithMany(p => p.DoctosTr)
                    .HasForeignKey(d => d.DirCliId)
                    .HasConstraintName("dirs_cli_a_doctos_tr");
            });

            modelBuilder.Entity<DoctosTrDet>(entity =>
            {
                entity.HasKey(e => e.DoctoTrDetId)
                    .HasName("doctos_tr_det_pk");

                entity.ToTable("doctos_tr_det");

                entity.Property(e => e.DoctoTrDetId)
                    .HasColumnName("docto_tr_det_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArticuloId).HasColumnName("articulo_id");

                entity.Property(e => e.ClaveArticulo)
                    .HasColumnName("clave_articulo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DoctoOrigenDetId).HasColumnName("docto_origen_det_id");

                entity.Property(e => e.DoctoTrId).HasColumnName("docto_tr_id");

                entity.Property(e => e.MovtoJuegoPadreId).HasColumnName("movto_juego_padre_id");

                entity.Property(e => e.Posicion).HasColumnName("posicion");

                entity.Property(e => e.Rol)
                    .IsRequired()
                    .HasColumnName("rol")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Unidades)
                    .HasColumnName("unidades")
                    .HasColumnType("decimal(18, 5)");

                entity.HasOne(d => d.Articulo)
                    .WithMany(p => p.DoctosTrDet)
                    .HasForeignKey(d => d.ArticuloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("arts_a_doctos_tr_det");

                entity.HasOne(d => d.DoctoTr)
                    .WithMany(p => p.DoctosTrDet)
                    .HasForeignKey(d => d.DoctoTrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_tr_a_det");

                entity.HasOne(d => d.MovtoJuegoPadre)
                    .WithMany(p => p.InverseMovtoJuegoPadre)
                    .HasForeignKey(d => d.MovtoJuegoPadreId)
                    .HasConstraintName("doctos_tr_det_a_movto_padre");
            });

            modelBuilder.Entity<DoctosVe>(entity =>
            {
                entity.HasKey(e => e.DoctoVeId)
                    .HasName("doctos_ve_pk");

                entity.ToTable("doctos_ve");

                entity.HasIndex(e => new { e.Fecha, e.TipoDocto, e.Folio })
                    .HasName("doctos_ve_ie1");

                entity.HasIndex(e => new { e.TipoDocto, e.Folio, e.Aplicado })
                    .HasName("doctos_ve_ak1")
                    .IsUnique()
                    .HasFilter("([tipo_docto] IS NOT NULL AND [folio] IS NOT NULL AND [aplicado] IS NOT NULL)");

                entity.Property(e => e.DoctoVeId)
                    .HasColumnName("docto_ve_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AcreditarCxc)
                    .HasColumnName("acreditar_cxc")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AlmacenId).HasColumnName("almacen_id");

                entity.Property(e => e.Aplicado)
                    .HasColumnName("aplicado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CargarSun)
                    .IsRequired()
                    .HasColumnName("cargar_sun")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CfdEnvioEspecial)
                    .HasColumnName("cfd_envio_especial")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CfdiCertificado)
                    .IsRequired()
                    .HasColumnName("cfdi_certificado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.CfdiFactDevueltaId).HasColumnName("cfdi_fact_devuelta_id");

                entity.Property(e => e.ClaveCliente)
                    .HasColumnName("clave_cliente")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteId).HasColumnName("cliente_id");

                entity.Property(e => e.CondPagoId).HasColumnName("cond_pago_id");

                entity.Property(e => e.Contabilizado)
                    .HasColumnName("contabilizado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionCobro)
                    .HasColumnName("descripcion_cobro")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DirCliId).HasColumnName("dir_cli_id");

                entity.Property(e => e.DirConsigId).HasColumnName("dir_consig_id");

                entity.Property(e => e.DsctoImporte)
                    .HasColumnName("dscto_importe")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.DsctoPctje)
                    .HasColumnName("dscto_pctje")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.EmailEnvio)
                    .HasColumnName("email_envio")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Enviado)
                    .IsRequired()
                    .HasColumnName("enviado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EsCfd)
                    .IsRequired()
                    .HasColumnName("es_cfd")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estatus)
                    .HasColumnName("estatus")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.FechaDsctoPpag)
                    .HasColumnName("fecha_dscto_ppag")
                    .HasColumnType("date");

                entity.Property(e => e.FechaHoraCancelacion).HasColumnName("fecha_hora_cancelacion");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraEnvio).HasColumnName("fecha_hora_envio");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.FechaOrdenCompra)
                    .HasColumnName("fecha_orden_compra")
                    .HasColumnType("date");

                entity.Property(e => e.FechaReciboMercancia)
                    .HasColumnName("fecha_recibo_mercancia")
                    .HasColumnType("date");

                entity.Property(e => e.FechaVigenciaEntrega)
                    .HasColumnName("fecha_vigencia_entrega")
                    .HasColumnType("date");

                entity.Property(e => e.Fletes)
                    .HasColumnName("fletes")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Folio)
                    .IsRequired()
                    .HasColumnName("folio")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FolioReciboMercancia)
                    .HasColumnName("folio_recibo_mercancia")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.FormaEmitida)
                    .HasColumnName("forma_emitida")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hora)
                    .HasColumnName("hora")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ImporteCobro)
                    .HasColumnName("importe_cobro")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ImporteNeto)
                    .HasColumnName("importe_neto")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ImpuestoSustituidoId).HasColumnName("impuesto_sustituido_id");

                entity.Property(e => e.ImpuestoSustitutoId).HasColumnName("impuesto_sustituto_id");

                entity.Property(e => e.LugarExpedicionId).HasColumnName("lugar_expedicion_id");

                entity.Property(e => e.MetodoPagoSat)
                    .HasColumnName("metodo_pago_sat")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ModalidadFacturacion)
                    .HasColumnName("modalidad_facturacion")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MonedaId).HasColumnName("moneda_id");

                entity.Property(e => e.OrdenCompra)
                    .HasColumnName("orden_compra")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.OtrosCargos)
                    .HasColumnName("otros_cargos")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.PctjeComis)
                    .HasColumnName("pctje_comis")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.PctjeDsctoPpag)
                    .HasColumnName("pctje_dscto_ppag")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.PesoEmbarque)
                    .HasColumnName("peso_embarque")
                    .HasColumnType("decimal(12, 3)");

                entity.Property(e => e.SistemaOrigen)
                    .IsRequired()
                    .HasColumnName("sistema_origen")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SubtipoDocto)
                    .HasColumnName("subtipo_docto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.TipoCambio)
                    .HasColumnName("tipo_cambio")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TipoDocto)
                    .IsRequired()
                    .HasColumnName("tipo_docto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoDscto)
                    .HasColumnName("tipo_dscto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TotalAnticipos)
                    .HasColumnName("total_anticipos")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.TotalImpuestos)
                    .HasColumnName("total_impuestos")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.TotalRetenciones)
                    .HasColumnName("total_retenciones")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.UsoCfdi)
                    .HasColumnName("uso_cfdi")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAutCancelacion)
                    .HasColumnName("usuario_aut_cancelacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCancelacion)
                    .HasColumnName("usuario_cancelacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.VendedorId).HasColumnName("vendedor_id");

                entity.Property(e => e.ViaEmbarqueId).HasColumnName("via_embarque_id");

                entity.HasOne(d => d.Almacen)
                    .WithMany(p => p.DoctosVe)
                    .HasForeignKey(d => d.AlmacenId)
                    .HasConstraintName("almacenes_a_doctos_ve");

                entity.HasOne(d => d.CfdiFactDevuelta)
                    .WithMany(p => p.DoctosVe)
                    .HasForeignKey(d => d.CfdiFactDevueltaId)
                    .HasConstraintName("repositorio_a_doctos_ve");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.DoctosVe)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("clientes_a_doctos_ve");

                entity.HasOne(d => d.CondPago)
                    .WithMany(p => p.DoctosVe)
                    .HasForeignKey(d => d.CondPagoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cond_pag_a_doctos_ve");

                entity.HasOne(d => d.DirCli)
                    .WithMany(p => p.DoctosVeDirCli)
                    .HasForeignKey(d => d.DirCliId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dirs_cli_a_doctos_ve");

                entity.HasOne(d => d.DirConsig)
                    .WithMany(p => p.DoctosVeDirConsig)
                    .HasForeignKey(d => d.DirConsigId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dir_consig_a_doctos_ve");

                entity.HasOne(d => d.ImpuestoSustituido)
                    .WithMany(p => p.DoctosVeImpuestoSustituido)
                    .HasForeignKey(d => d.ImpuestoSustituidoId)
                    .HasConstraintName("impto_sustituido_ve");

                entity.HasOne(d => d.ImpuestoSustituto)
                    .WithMany(p => p.DoctosVeImpuestoSustituto)
                    .HasForeignKey(d => d.ImpuestoSustitutoId)
                    .HasConstraintName("impto_sustituto_ve");

                entity.HasOne(d => d.Moneda)
                    .WithMany(p => p.DoctosVe)
                    .HasForeignKey(d => d.MonedaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("monedas_a_doctos_ve");

                entity.HasOne(d => d.Vendedor)
                    .WithMany(p => p.DoctosVe)
                    .HasForeignKey(d => d.VendedorId)
                    .HasConstraintName("vendedor_a_doctos_ve");

                entity.HasOne(d => d.ViaEmbarque)
                    .WithMany(p => p.DoctosVe)
                    .HasForeignKey(d => d.ViaEmbarqueId)
                    .HasConstraintName("vias_emb_a_doctos_ve");
            });

            modelBuilder.Entity<DoctosVeCamposAddenda>(entity =>
            {
                entity.HasKey(e => e.DoctoVeId)
                    .HasName("doctos_ve_campos_addenda_pk");

                entity.ToTable("doctos_ve_campos_addenda");

                entity.Property(e => e.DoctoVeId)
                    .HasColumnName("docto_ve_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CamposAddenda)
                    .HasColumnName("campos_addenda")
                    .IsUnicode(false);

                entity.HasOne(d => d.DoctoVe)
                    .WithOne(p => p.DoctosVeCamposAddenda)
                    .HasForeignKey<DoctosVeCamposAddenda>(d => d.DoctoVeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_ve_a_campos_addenda");
            });

            modelBuilder.Entity<DoctosVeDet>(entity =>
            {
                entity.HasKey(e => e.DoctoVeDetId)
                    .HasName("doctos_ve_det_pk");

                entity.ToTable("doctos_ve_det");

                entity.Property(e => e.DoctoVeDetId)
                    .HasColumnName("docto_ve_det_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArticuloId).HasColumnName("articulo_id");

                entity.Property(e => e.ClaveArticulo)
                    .HasColumnName("clave_articulo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DoctoVeId).HasColumnName("docto_ve_id");

                entity.Property(e => e.DsctoArt)
                    .HasColumnName("dscto_art")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.DsctoExtra)
                    .HasColumnName("dscto_extra")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Notas)
                    .HasColumnName("notas")
                    .IsUnicode(false);

                entity.Property(e => e.PctjeComis)
                    .HasColumnName("pctje_comis")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.PctjeDscto)
                    .HasColumnName("pctje_dscto")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.PctjeDsctoCli)
                    .HasColumnName("pctje_dscto_cli")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.PctjeDsctoPromo)
                    .HasColumnName("pctje_dscto_promo")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.PctjeDsctoVol)
                    .HasColumnName("pctje_dscto_vol")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.Posicion).HasColumnName("posicion");

                entity.Property(e => e.PrecioTotalNeto)
                    .HasColumnName("precio_total_neto")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.PrecioUnitario)
                    .HasColumnName("precio_unitario")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Rol)
                    .IsRequired()
                    .HasColumnName("rol")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Unidades)
                    .HasColumnName("unidades")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.UnidadesASurtir)
                    .HasColumnName("unidades_a_surtir")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.UnidadesComprom)
                    .HasColumnName("unidades_comprom")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.UnidadesSurtDev)
                    .HasColumnName("unidades_surt_dev")
                    .HasColumnType("decimal(18, 5)");

                entity.HasOne(d => d.Articulo)
                    .WithMany(p => p.DoctosVeDet)
                    .HasForeignKey(d => d.ArticuloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("arts_a_doctos_ve_det");

                entity.HasOne(d => d.DoctoVe)
                    .WithMany(p => p.DoctosVeDet)
                    .HasForeignKey(d => d.DoctoVeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_ve_a_det");
            });

            modelBuilder.Entity<DoctosVeLigas>(entity =>
            {
                entity.HasKey(e => e.DoctoVeLigaId)
                    .HasName("doctos_ve_ligas_pk");

                entity.ToTable("doctos_ve_ligas");

                entity.HasIndex(e => new { e.DoctoVeDestId, e.DoctoVeFteId })
                    .HasName("doctos_ve_ligas_ak2")
                    .IsUnique()
                    .HasFilter("([docto_ve_dest_id] IS NOT NULL AND [docto_ve_fte_id] IS NOT NULL)");

                entity.HasIndex(e => new { e.DoctoVeFteId, e.DoctoVeDestId })
                    .HasName("doctos_ve_ligas_ak1")
                    .IsUnique()
                    .HasFilter("([docto_ve_fte_id] IS NOT NULL AND [docto_ve_dest_id] IS NOT NULL)");

                entity.Property(e => e.DoctoVeLigaId)
                    .HasColumnName("docto_ve_liga_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DoctoVeDestId).HasColumnName("docto_ve_dest_id");

                entity.Property(e => e.DoctoVeFteId).HasColumnName("docto_ve_fte_id");

                entity.HasOne(d => d.DoctoVeDest)
                    .WithMany(p => p.DoctosVeLigasDoctoVeDest)
                    .HasForeignKey(d => d.DoctoVeDestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_ve_a_ligas_dest");

                entity.HasOne(d => d.DoctoVeFte)
                    .WithMany(p => p.DoctosVeLigasDoctoVeFte)
                    .HasForeignKey(d => d.DoctoVeFteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_ve_a_ligas_fte");
            });

            modelBuilder.Entity<DoctosVeLigasDet>(entity =>
            {
                entity.HasKey(e => new { e.DoctoVeLigaId, e.DoctoVeDetFteId, e.DoctoVeDetDestId })
                    .HasName("doctos_ve_ligas_det_pk");

                entity.ToTable("doctos_ve_ligas_det");

                entity.HasIndex(e => e.DoctoVeDetDestId)
                    .HasName("doctos_ve_ligas_det_ie2");

                entity.HasIndex(e => e.DoctoVeDetFteId)
                    .HasName("doctos_ve_ligas_det_ie1");

                entity.Property(e => e.DoctoVeLigaId).HasColumnName("docto_ve_liga_id");

                entity.Property(e => e.DoctoVeDetFteId).HasColumnName("docto_ve_det_fte_id");

                entity.Property(e => e.DoctoVeDetDestId).HasColumnName("docto_ve_det_dest_id");

                entity.HasOne(d => d.DoctoVeDetDest)
                    .WithMany(p => p.DoctosVeLigasDetDoctoVeDetDest)
                    .HasForeignKey(d => d.DoctoVeDetDestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_ve_det_a_ligas_dest");

                entity.HasOne(d => d.DoctoVeDetFte)
                    .WithMany(p => p.DoctosVeLigasDetDoctoVeDetFte)
                    .HasForeignKey(d => d.DoctoVeDetFteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_ve_det_a_ligas_fte");

                entity.HasOne(d => d.DoctoVeLiga)
                    .WithMany(p => p.DoctosVeLigasDet)
                    .HasForeignKey(d => d.DoctoVeLigaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_ve_ligas_a_det");
            });

            modelBuilder.Entity<DsctosArtcliArts>(entity =>
            {
                entity.HasKey(e => e.DsctoArtcliArtId)
                    .HasName("dsctos_artcli_arts_pk");

                entity.ToTable("dsctos_artcli_arts");

                entity.HasIndex(e => new { e.PoliticaDsctoArtCliId, e.ArticuloId })
                    .HasName("dsctos_artcli_arts_ak1")
                    .IsUnique()
                    .HasFilter("([politica_dscto_art_cli_id] IS NOT NULL AND [articulo_id] IS NOT NULL)");

                entity.Property(e => e.DsctoArtcliArtId)
                    .HasColumnName("dscto_artcli_art_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArticuloId).HasColumnName("articulo_id");

                entity.Property(e => e.ClaveArticulo)
                    .HasColumnName("clave_articulo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descuento)
                    .HasColumnName("descuento")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.PoliticaDsctoArtCliId).HasColumnName("politica_dscto_art_cli_id");

                entity.HasOne(d => d.Articulo)
                    .WithMany(p => p.DsctosArtcliArts)
                    .HasForeignKey(d => d.ArticuloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("arts_a_dsctos_artcli");

                entity.HasOne(d => d.PoliticaDsctoArtCli)
                    .WithMany(p => p.DsctosArtcliArts)
                    .HasForeignKey(d => d.PoliticaDsctoArtCliId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("arts_con_dscto_artcli");
            });

            modelBuilder.Entity<DsctosArtcliGrupos>(entity =>
            {
                entity.HasKey(e => e.DsctoArtcliGrupoId)
                    .HasName("dsctos_artcli_grupos_pk");

                entity.ToTable("dsctos_artcli_grupos");

                entity.HasIndex(e => new { e.PoliticaDsctoArtCliId, e.GrupoLineaId })
                    .HasName("dsctos_artcli_grupos_ak1")
                    .IsUnique()
                    .HasFilter("([politica_dscto_art_cli_id] IS NOT NULL AND [grupo_linea_id] IS NOT NULL)");

                entity.Property(e => e.DsctoArtcliGrupoId)
                    .HasColumnName("dscto_artcli_grupo_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descuento)
                    .HasColumnName("descuento")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.GrupoLineaId).HasColumnName("grupo_linea_id");

                entity.Property(e => e.PoliticaDsctoArtCliId).HasColumnName("politica_dscto_art_cli_id");

                entity.HasOne(d => d.GrupoLinea)
                    .WithMany(p => p.DsctosArtcliGrupos)
                    .HasForeignKey(d => d.GrupoLineaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("gpos_a_dsctos_artcli");

                entity.HasOne(d => d.PoliticaDsctoArtCli)
                    .WithMany(p => p.DsctosArtcliGrupos)
                    .HasForeignKey(d => d.PoliticaDsctoArtCliId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("grupos_con_dscto_artcli");
            });

            modelBuilder.Entity<DsctosArtcliLineas>(entity =>
            {
                entity.HasKey(e => e.DsctoArtcliLineaId)
                    .HasName("dsctos_artcli_lineas_pk");

                entity.ToTable("dsctos_artcli_lineas");

                entity.HasIndex(e => new { e.PoliticaDsctoArtCliId, e.LineaArticuloId })
                    .HasName("dsctos_artcli_lineas_ak1")
                    .IsUnique()
                    .HasFilter("([politica_dscto_art_cli_id] IS NOT NULL AND [linea_articulo_id] IS NOT NULL)");

                entity.Property(e => e.DsctoArtcliLineaId)
                    .HasColumnName("dscto_artcli_linea_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descuento)
                    .HasColumnName("descuento")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.LineaArticuloId).HasColumnName("linea_articulo_id");

                entity.Property(e => e.PoliticaDsctoArtCliId).HasColumnName("politica_dscto_art_cli_id");

                entity.HasOne(d => d.LineaArticulo)
                    .WithMany(p => p.DsctosArtcliLineas)
                    .HasForeignKey(d => d.LineaArticuloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("lineas_a_dsctos_artcli");

                entity.HasOne(d => d.PoliticaDsctoArtCli)
                    .WithMany(p => p.DsctosArtcliLineas)
                    .HasForeignKey(d => d.PoliticaDsctoArtCliId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("lineas_con_dscto_artcli");
            });

            modelBuilder.Entity<DsctosArtproArts>(entity =>
            {
                entity.HasKey(e => e.DsctoArtproArtId)
                    .HasName("dsctos_artpro_arts_pk");

                entity.ToTable("dsctos_artpro_arts");

                entity.HasIndex(e => new { e.PoliticaPreciosProvId, e.ArticuloId })
                    .HasName("dsctos_artpro_arts_ak1")
                    .IsUnique()
                    .HasFilter("([politica_precios_prov_id] IS NOT NULL AND [articulo_id] IS NOT NULL)");

                entity.Property(e => e.DsctoArtproArtId)
                    .HasColumnName("dscto_artpro_art_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArticuloId).HasColumnName("articulo_id");

                entity.Property(e => e.ClaveArticulo)
                    .HasColumnName("clave_articulo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descuento)
                    .HasColumnName("descuento")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.PoliticaPreciosProvId).HasColumnName("politica_precios_prov_id");

                entity.HasOne(d => d.Articulo)
                    .WithMany(p => p.DsctosArtproArts)
                    .HasForeignKey(d => d.ArticuloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("arts_a_dsctos_artpro");

                entity.HasOne(d => d.PoliticaPreciosProv)
                    .WithMany(p => p.DsctosArtproArts)
                    .HasForeignKey(d => d.PoliticaPreciosProvId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pol_pre_a_dsctos_artpro_art");
            });

            modelBuilder.Entity<DsctosArtproGrupos>(entity =>
            {
                entity.HasKey(e => e.DsctoArtproGrupoId)
                    .HasName("dsctos_artpro_grupos_pk");

                entity.ToTable("dsctos_artpro_grupos");

                entity.HasIndex(e => new { e.PoliticaPreciosProvId, e.GrupoLineaId })
                    .HasName("dsctos_artpro_grupos_ak1")
                    .IsUnique()
                    .HasFilter("([politica_precios_prov_id] IS NOT NULL AND [grupo_linea_id] IS NOT NULL)");

                entity.Property(e => e.DsctoArtproGrupoId)
                    .HasColumnName("dscto_artpro_grupo_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descuento)
                    .HasColumnName("descuento")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.GrupoLineaId).HasColumnName("grupo_linea_id");

                entity.Property(e => e.PoliticaPreciosProvId).HasColumnName("politica_precios_prov_id");

                entity.HasOne(d => d.GrupoLinea)
                    .WithMany(p => p.DsctosArtproGrupos)
                    .HasForeignKey(d => d.GrupoLineaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("gpos_a_dsctos_artpro");

                entity.HasOne(d => d.PoliticaPreciosProv)
                    .WithMany(p => p.DsctosArtproGrupos)
                    .HasForeignKey(d => d.PoliticaPreciosProvId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pol_pre_a_dsctos_artpro_gpos");
            });

            modelBuilder.Entity<DsctosArtproLineas>(entity =>
            {
                entity.HasKey(e => e.DsctoArtproLineaId)
                    .HasName("dsctos_artpro_lineas_pk");

                entity.ToTable("dsctos_artpro_lineas");

                entity.HasIndex(e => new { e.PoliticaPreciosProvId, e.LineaArticuloId })
                    .HasName("dsctos_artpro_lineas_ak1")
                    .IsUnique()
                    .HasFilter("([politica_precios_prov_id] IS NOT NULL AND [linea_articulo_id] IS NOT NULL)");

                entity.Property(e => e.DsctoArtproLineaId)
                    .HasColumnName("dscto_artpro_linea_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descuento)
                    .HasColumnName("descuento")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.LineaArticuloId).HasColumnName("linea_articulo_id");

                entity.Property(e => e.PoliticaPreciosProvId).HasColumnName("politica_precios_prov_id");

                entity.HasOne(d => d.LineaArticulo)
                    .WithMany(p => p.DsctosArtproLineas)
                    .HasForeignKey(d => d.LineaArticuloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("lineas_a_dsctos_artpro");

                entity.HasOne(d => d.PoliticaPreciosProv)
                    .WithMany(p => p.DsctosArtproLineas)
                    .HasForeignKey(d => d.PoliticaPreciosProvId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pol_pre_a_dsctos_artpro_lin");
            });

            modelBuilder.Entity<DsctosMaxArts>(entity =>
            {
                entity.HasKey(e => e.DsctoMaxArtId)
                    .HasName("dsctos_max_arts_pk");

                entity.ToTable("dsctos_max_arts");

                entity.HasIndex(e => new { e.PoliticaDsctoMaximoId, e.ArticuloId })
                    .HasName("dsctos_max_arts_ak1")
                    .IsUnique()
                    .HasFilter("([politica_dscto_maximo_id] IS NOT NULL AND [articulo_id] IS NOT NULL)");

                entity.Property(e => e.DsctoMaxArtId)
                    .HasColumnName("dscto_max_art_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArticuloId).HasColumnName("articulo_id");

                entity.Property(e => e.ClaveArticulo)
                    .HasColumnName("clave_articulo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DescuentoMaximo)
                    .HasColumnName("descuento_maximo")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.PoliticaDsctoMaximoId).HasColumnName("politica_dscto_maximo_id");

                entity.HasOne(d => d.Articulo)
                    .WithMany(p => p.DsctosMaxArts)
                    .HasForeignKey(d => d.ArticuloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("arts_a_dsctos_max");

                entity.HasOne(d => d.PoliticaDsctoMaximo)
                    .WithMany(p => p.DsctosMaxArts)
                    .HasForeignKey(d => d.PoliticaDsctoMaximoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("arts_con_dscto_max");
            });

            modelBuilder.Entity<DsctosMaxGrupos>(entity =>
            {
                entity.HasKey(e => e.DsctoMaxGrupoId)
                    .HasName("dsctos_max_grupos_pk");

                entity.ToTable("dsctos_max_grupos");

                entity.HasIndex(e => new { e.PoliticaDsctoMaximoId, e.GrupoLineaId })
                    .HasName("dsctos_max_grupos_ak1")
                    .IsUnique()
                    .HasFilter("([politica_dscto_maximo_id] IS NOT NULL AND [grupo_linea_id] IS NOT NULL)");

                entity.Property(e => e.DsctoMaxGrupoId)
                    .HasColumnName("dscto_max_grupo_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DescuentoMaximo)
                    .HasColumnName("descuento_maximo")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.GrupoLineaId).HasColumnName("grupo_linea_id");

                entity.Property(e => e.PoliticaDsctoMaximoId).HasColumnName("politica_dscto_maximo_id");

                entity.HasOne(d => d.GrupoLinea)
                    .WithMany(p => p.DsctosMaxGrupos)
                    .HasForeignKey(d => d.GrupoLineaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("gpos_a_dsctos_max");

                entity.HasOne(d => d.PoliticaDsctoMaximo)
                    .WithMany(p => p.DsctosMaxGrupos)
                    .HasForeignKey(d => d.PoliticaDsctoMaximoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("grupos_con_dscto_max");
            });

            modelBuilder.Entity<DsctosMaxLineas>(entity =>
            {
                entity.HasKey(e => e.DsctoMaxLineaId)
                    .HasName("dsctos_max_lineas_pk");

                entity.ToTable("dsctos_max_lineas");

                entity.HasIndex(e => new { e.PoliticaDsctoMaximoId, e.LineaArticuloId })
                    .HasName("dsctos_max_lineas_ak1")
                    .IsUnique()
                    .HasFilter("([politica_dscto_maximo_id] IS NOT NULL AND [linea_articulo_id] IS NOT NULL)");

                entity.Property(e => e.DsctoMaxLineaId)
                    .HasColumnName("dscto_max_linea_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DescuentoMaximo)
                    .HasColumnName("descuento_maximo")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.LineaArticuloId).HasColumnName("linea_articulo_id");

                entity.Property(e => e.PoliticaDsctoMaximoId).HasColumnName("politica_dscto_maximo_id");

                entity.HasOne(d => d.LineaArticulo)
                    .WithMany(p => p.DsctosMaxLineas)
                    .HasForeignKey(d => d.LineaArticuloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("lineas_a_dsctos_max");

                entity.HasOne(d => d.PoliticaDsctoMaximo)
                    .WithMany(p => p.DsctosMaxLineas)
                    .HasForeignKey(d => d.PoliticaDsctoMaximoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("lineas_con_dscto_max");
            });

            modelBuilder.Entity<DsctosPromoArts>(entity =>
            {
                entity.HasKey(e => e.DsctoPromoArtId)
                    .HasName("dsctos_promo_arts_pk");

                entity.ToTable("dsctos_promo_arts");

                entity.HasIndex(e => new { e.PoliticaDsctoPromoId, e.ArticuloId })
                    .HasName("dsctos_promo_arts_ak1")
                    .IsUnique()
                    .HasFilter("([politica_dscto_promo_id] IS NOT NULL AND [articulo_id] IS NOT NULL)");

                entity.Property(e => e.DsctoPromoArtId)
                    .HasColumnName("dscto_promo_art_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArticuloId).HasColumnName("articulo_id");

                entity.Property(e => e.ClaveArticulo)
                    .HasColumnName("clave_articulo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descuento)
                    .HasColumnName("descuento")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.PoliticaDsctoPromoId).HasColumnName("politica_dscto_promo_id");

                entity.HasOne(d => d.Articulo)
                    .WithMany(p => p.DsctosPromoArts)
                    .HasForeignKey(d => d.ArticuloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("arts_a_dsctos_promo");

                entity.HasOne(d => d.PoliticaDsctoPromo)
                    .WithMany(p => p.DsctosPromoArts)
                    .HasForeignKey(d => d.PoliticaDsctoPromoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("arts_con_dscto_promo");
            });

            modelBuilder.Entity<DsctosPromoGrupos>(entity =>
            {
                entity.HasKey(e => e.DsctoPromoGrupoId)
                    .HasName("dsctos_promo_grupos_pk");

                entity.ToTable("dsctos_promo_grupos");

                entity.HasIndex(e => new { e.PoliticaDsctoPromoId, e.GrupoLineaId })
                    .HasName("dsctos_promo_grupos_ak1")
                    .IsUnique()
                    .HasFilter("([politica_dscto_promo_id] IS NOT NULL AND [grupo_linea_id] IS NOT NULL)");

                entity.Property(e => e.DsctoPromoGrupoId)
                    .HasColumnName("dscto_promo_grupo_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descuento)
                    .HasColumnName("descuento")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.GrupoLineaId).HasColumnName("grupo_linea_id");

                entity.Property(e => e.PoliticaDsctoPromoId).HasColumnName("politica_dscto_promo_id");

                entity.HasOne(d => d.GrupoLinea)
                    .WithMany(p => p.DsctosPromoGrupos)
                    .HasForeignKey(d => d.GrupoLineaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("gpos_a_dsctos_promo");

                entity.HasOne(d => d.PoliticaDsctoPromo)
                    .WithMany(p => p.DsctosPromoGrupos)
                    .HasForeignKey(d => d.PoliticaDsctoPromoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("grupos_con_dscto_promo");
            });

            modelBuilder.Entity<DsctosPromoLineas>(entity =>
            {
                entity.HasKey(e => e.DsctoPromoLineaId)
                    .HasName("dsctos_promo_lineas_pk");

                entity.ToTable("dsctos_promo_lineas");

                entity.HasIndex(e => new { e.PoliticaDsctoPromoId, e.LineaArticuloId })
                    .HasName("dsctos_promo_lineas_ak1")
                    .IsUnique()
                    .HasFilter("([politica_dscto_promo_id] IS NOT NULL AND [linea_articulo_id] IS NOT NULL)");

                entity.Property(e => e.DsctoPromoLineaId)
                    .HasColumnName("dscto_promo_linea_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descuento)
                    .HasColumnName("descuento")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.LineaArticuloId).HasColumnName("linea_articulo_id");

                entity.Property(e => e.PoliticaDsctoPromoId).HasColumnName("politica_dscto_promo_id");

                entity.HasOne(d => d.LineaArticulo)
                    .WithMany(p => p.DsctosPromoLineas)
                    .HasForeignKey(d => d.LineaArticuloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("lineas_a_dsctos_promo");

                entity.HasOne(d => d.PoliticaDsctoPromo)
                    .WithMany(p => p.DsctosPromoLineas)
                    .HasForeignKey(d => d.PoliticaDsctoPromoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("lineas_con_dscto_promo");
            });

            modelBuilder.Entity<DsctosPromoProvArts>(entity =>
            {
                entity.HasKey(e => e.DsctoPromoProvArtId)
                    .HasName("dsctos_promo_prov_arts_pk");

                entity.ToTable("dsctos_promo_prov_arts");

                entity.HasIndex(e => new { e.PolDsctoPromoProvId, e.ArticuloId })
                    .HasName("dsctos_promo_prov_arts_ak1")
                    .IsUnique()
                    .HasFilter("([pol_dscto_promo_prov_id] IS NOT NULL AND [articulo_id] IS NOT NULL)");

                entity.Property(e => e.DsctoPromoProvArtId)
                    .HasColumnName("dscto_promo_prov_art_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArticuloId).HasColumnName("articulo_id");

                entity.Property(e => e.ClaveArticulo)
                    .HasColumnName("clave_articulo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descuento)
                    .HasColumnName("descuento")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.PolDsctoPromoProvId).HasColumnName("pol_dscto_promo_prov_id");

                entity.HasOne(d => d.Articulo)
                    .WithMany(p => p.DsctosPromoProvArts)
                    .HasForeignKey(d => d.ArticuloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("arts_a_dsctos_promo_prov");

                entity.HasOne(d => d.PolDsctoPromoProv)
                    .WithMany(p => p.DsctosPromoProvArts)
                    .HasForeignKey(d => d.PolDsctoPromoProvId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("arts_con_dscto_promo_prov");
            });

            modelBuilder.Entity<DsctosPromoProvGrupos>(entity =>
            {
                entity.HasKey(e => e.DsctoPromoProvGrupoId)
                    .HasName("dsctos_promo_prov_grupos_pk");

                entity.ToTable("dsctos_promo_prov_grupos");

                entity.HasIndex(e => new { e.PolDsctoPromoProvId, e.GrupoLineaId })
                    .HasName("dsctos_promo_prov_grupos_ak1")
                    .IsUnique()
                    .HasFilter("([pol_dscto_promo_prov_id] IS NOT NULL AND [grupo_linea_id] IS NOT NULL)");

                entity.Property(e => e.DsctoPromoProvGrupoId)
                    .HasColumnName("dscto_promo_prov_grupo_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descuento)
                    .HasColumnName("descuento")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.GrupoLineaId).HasColumnName("grupo_linea_id");

                entity.Property(e => e.PolDsctoPromoProvId).HasColumnName("pol_dscto_promo_prov_id");

                entity.HasOne(d => d.GrupoLinea)
                    .WithMany(p => p.DsctosPromoProvGrupos)
                    .HasForeignKey(d => d.GrupoLineaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("gpos_a_dsctos_promo_prov");

                entity.HasOne(d => d.PolDsctoPromoProv)
                    .WithMany(p => p.DsctosPromoProvGrupos)
                    .HasForeignKey(d => d.PolDsctoPromoProvId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("grupos_con_dscto_promo_prov");
            });

            modelBuilder.Entity<DsctosPromoProvLineas>(entity =>
            {
                entity.HasKey(e => e.DsctoPromoProvLineaId)
                    .HasName("dsctos_promo_prov_lineas_pk");

                entity.ToTable("dsctos_promo_prov_lineas");

                entity.HasIndex(e => new { e.PolDsctoPromoProvId, e.LineaArticuloId })
                    .HasName("dsctos_promo_prov_lineas_ak1")
                    .IsUnique()
                    .HasFilter("([pol_dscto_promo_prov_id] IS NOT NULL AND [linea_articulo_id] IS NOT NULL)");

                entity.Property(e => e.DsctoPromoProvLineaId)
                    .HasColumnName("dscto_promo_prov_linea_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descuento)
                    .HasColumnName("descuento")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.LineaArticuloId).HasColumnName("linea_articulo_id");

                entity.Property(e => e.PolDsctoPromoProvId).HasColumnName("pol_dscto_promo_prov_id");

                entity.HasOne(d => d.LineaArticulo)
                    .WithMany(p => p.DsctosPromoProvLineas)
                    .HasForeignKey(d => d.LineaArticuloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("lineas_a_dsctos_promo_prov");

                entity.HasOne(d => d.PolDsctoPromoProv)
                    .WithMany(p => p.DsctosPromoProvLineas)
                    .HasForeignKey(d => d.PolDsctoPromoProvId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("lineas_con_dscto_promo_prov");
            });

            modelBuilder.Entity<DsctosVolArts>(entity =>
            {
                entity.HasKey(e => e.DsctoVolArtId)
                    .HasName("dsctos_vol_arts_pk");

                entity.ToTable("dsctos_vol_arts");

                entity.HasIndex(e => new { e.PoliticaDsctoVolumenId, e.ArticuloId, e.Unidades })
                    .HasName("dsctos_vol_arts_ak1")
                    .IsUnique()
                    .HasFilter("([politica_dscto_volumen_id] IS NOT NULL AND [articulo_id] IS NOT NULL AND [unidades] IS NOT NULL)");

                entity.Property(e => e.DsctoVolArtId)
                    .HasColumnName("dscto_vol_art_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArticuloId).HasColumnName("articulo_id");

                entity.Property(e => e.Descuento)
                    .HasColumnName("descuento")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.PoliticaDsctoVolumenId).HasColumnName("politica_dscto_volumen_id");

                entity.Property(e => e.Unidades)
                    .HasColumnName("unidades")
                    .HasColumnType("decimal(18, 5)");

                entity.HasOne(d => d.Articulo)
                    .WithMany(p => p.DsctosVolArts)
                    .HasForeignKey(d => d.ArticuloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("arts_a_dsctos_vol");

                entity.HasOne(d => d.PoliticaDsctoVolumen)
                    .WithMany(p => p.DsctosVolArts)
                    .HasForeignKey(d => d.PoliticaDsctoVolumenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("arts_con_dscto_vol");
            });

            modelBuilder.Entity<DsctosVolGlobales>(entity =>
            {
                entity.HasKey(e => e.DsctoVolGlobalId)
                    .HasName("dsctos_vol_globales_pk");

                entity.ToTable("dsctos_vol_globales");

                entity.HasIndex(e => new { e.PoliticaDsctoVolumenId, e.Unidades })
                    .HasName("dsctos_vol_globales_ak1")
                    .IsUnique()
                    .HasFilter("([politica_dscto_volumen_id] IS NOT NULL AND [unidades] IS NOT NULL)");

                entity.Property(e => e.DsctoVolGlobalId)
                    .HasColumnName("dscto_vol_global_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descuento)
                    .HasColumnName("descuento")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.PoliticaDsctoVolumenId).HasColumnName("politica_dscto_volumen_id");

                entity.Property(e => e.Unidades)
                    .HasColumnName("unidades")
                    .HasColumnType("decimal(18, 5)");

                entity.HasOne(d => d.PoliticaDsctoVolumen)
                    .WithMany(p => p.DsctosVolGlobales)
                    .HasForeignKey(d => d.PoliticaDsctoVolumenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tabla_volumenes_glob");
            });

            modelBuilder.Entity<DsctosVolGrupos>(entity =>
            {
                entity.HasKey(e => e.DsctoVolGrupoId)
                    .HasName("dsctos_vol_grupos_pk");

                entity.ToTable("dsctos_vol_grupos");

                entity.HasIndex(e => new { e.PoliticaDsctoVolumenId, e.GrupoLineaId, e.Unidades })
                    .HasName("dsctos_vol_grupos_ak1")
                    .IsUnique()
                    .HasFilter("([politica_dscto_volumen_id] IS NOT NULL AND [grupo_linea_id] IS NOT NULL AND [unidades] IS NOT NULL)");

                entity.Property(e => e.DsctoVolGrupoId)
                    .HasColumnName("dscto_vol_grupo_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descuento)
                    .HasColumnName("descuento")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.GrupoLineaId).HasColumnName("grupo_linea_id");

                entity.Property(e => e.PoliticaDsctoVolumenId).HasColumnName("politica_dscto_volumen_id");

                entity.Property(e => e.Unidades)
                    .HasColumnName("unidades")
                    .HasColumnType("decimal(18, 5)");

                entity.HasOne(d => d.GrupoLinea)
                    .WithMany(p => p.DsctosVolGrupos)
                    .HasForeignKey(d => d.GrupoLineaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("gpos_a_dsctos_vol");

                entity.HasOne(d => d.PoliticaDsctoVolumen)
                    .WithMany(p => p.DsctosVolGrupos)
                    .HasForeignKey(d => d.PoliticaDsctoVolumenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("grupos_con_dscto_vol");
            });

            modelBuilder.Entity<DsctosVolLineas>(entity =>
            {
                entity.HasKey(e => e.DsctoVolLineaId)
                    .HasName("dsctos_vol_lineas_pk");

                entity.ToTable("dsctos_vol_lineas");

                entity.HasIndex(e => new { e.PoliticaDsctoVolumenId, e.LineaArticuloId, e.Unidades })
                    .HasName("dsctos_vol_lineas_ak1")
                    .IsUnique()
                    .HasFilter("([politica_dscto_volumen_id] IS NOT NULL AND [linea_articulo_id] IS NOT NULL AND [unidades] IS NOT NULL)");

                entity.Property(e => e.DsctoVolLineaId)
                    .HasColumnName("dscto_vol_linea_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descuento)
                    .HasColumnName("descuento")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.LineaArticuloId).HasColumnName("linea_articulo_id");

                entity.Property(e => e.PoliticaDsctoVolumenId).HasColumnName("politica_dscto_volumen_id");

                entity.Property(e => e.Unidades)
                    .HasColumnName("unidades")
                    .HasColumnType("decimal(18, 5)");

                entity.HasOne(d => d.LineaArticulo)
                    .WithMany(p => p.DsctosVolLineas)
                    .HasForeignKey(d => d.LineaArticuloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("lineas_a_dsctos_vol");

                entity.HasOne(d => d.PoliticaDsctoVolumen)
                    .WithMany(p => p.DsctosVolLineas)
                    .HasForeignKey(d => d.PoliticaDsctoVolumenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("lineas_con_dscto_vol");
            });

            modelBuilder.Entity<DsctosVolProvArts>(entity =>
            {
                entity.HasKey(e => e.DsctoVolProvArtId)
                    .HasName("dsctos_vol_prov_arts_pk");

                entity.ToTable("dsctos_vol_prov_arts");

                entity.HasIndex(e => new { e.PolDsctoVolProvId, e.ArticuloId, e.Unidades })
                    .HasName("dsctos_vol_prov_arts_ak1")
                    .IsUnique()
                    .HasFilter("([pol_dscto_vol_prov_id] IS NOT NULL AND [articulo_id] IS NOT NULL AND [unidades] IS NOT NULL)");

                entity.Property(e => e.DsctoVolProvArtId)
                    .HasColumnName("dscto_vol_prov_art_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArticuloId).HasColumnName("articulo_id");

                entity.Property(e => e.Descuento)
                    .HasColumnName("descuento")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.PolDsctoVolProvId).HasColumnName("pol_dscto_vol_prov_id");

                entity.Property(e => e.Unidades)
                    .HasColumnName("unidades")
                    .HasColumnType("decimal(18, 5)");

                entity.HasOne(d => d.Articulo)
                    .WithMany(p => p.DsctosVolProvArts)
                    .HasForeignKey(d => d.ArticuloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("arts_a_dsctos_vol_prov");

                entity.HasOne(d => d.PolDsctoVolProv)
                    .WithMany(p => p.DsctosVolProvArts)
                    .HasForeignKey(d => d.PolDsctoVolProvId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("arts_con_dscto_vol_prov");
            });

            modelBuilder.Entity<DsctosVolProvGlob>(entity =>
            {
                entity.HasKey(e => e.DsctoVolProvGlobId)
                    .HasName("dsctos_vol_prov_glob_pk");

                entity.ToTable("dsctos_vol_prov_glob");

                entity.HasIndex(e => new { e.PolDsctoVolProvId, e.Unidades })
                    .HasName("dsctos_vol_prov_glob_ak1")
                    .IsUnique()
                    .HasFilter("([pol_dscto_vol_prov_id] IS NOT NULL AND [unidades] IS NOT NULL)");

                entity.Property(e => e.DsctoVolProvGlobId)
                    .HasColumnName("dscto_vol_prov_glob_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descuento)
                    .HasColumnName("descuento")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.PolDsctoVolProvId).HasColumnName("pol_dscto_vol_prov_id");

                entity.Property(e => e.Unidades)
                    .HasColumnName("unidades")
                    .HasColumnType("decimal(18, 5)");

                entity.HasOne(d => d.PolDsctoVolProv)
                    .WithMany(p => p.DsctosVolProvGlob)
                    .HasForeignKey(d => d.PolDsctoVolProvId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tabla_vol_prov_glob");
            });

            modelBuilder.Entity<DsctosVolProvGrupos>(entity =>
            {
                entity.HasKey(e => e.DsctoVolProvGrupoId)
                    .HasName("dsctos_vol_prov_grupos_pk");

                entity.ToTable("dsctos_vol_prov_grupos");

                entity.HasIndex(e => new { e.PolDsctoVolProvId, e.GrupoLineaId, e.Unidades })
                    .HasName("dsctos_vol_prov_grupos_ak1")
                    .IsUnique()
                    .HasFilter("([pol_dscto_vol_prov_id] IS NOT NULL AND [grupo_linea_id] IS NOT NULL AND [unidades] IS NOT NULL)");

                entity.Property(e => e.DsctoVolProvGrupoId)
                    .HasColumnName("dscto_vol_prov_grupo_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descuento)
                    .HasColumnName("descuento")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.GrupoLineaId).HasColumnName("grupo_linea_id");

                entity.Property(e => e.PolDsctoVolProvId).HasColumnName("pol_dscto_vol_prov_id");

                entity.Property(e => e.Unidades)
                    .HasColumnName("unidades")
                    .HasColumnType("decimal(18, 5)");

                entity.HasOne(d => d.GrupoLinea)
                    .WithMany(p => p.DsctosVolProvGrupos)
                    .HasForeignKey(d => d.GrupoLineaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("gpos_a_dsctos_vol_prov");

                entity.HasOne(d => d.PolDsctoVolProv)
                    .WithMany(p => p.DsctosVolProvGrupos)
                    .HasForeignKey(d => d.PolDsctoVolProvId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("grupos_con_dscto_vol_prov");
            });

            modelBuilder.Entity<DsctosVolProvLineas>(entity =>
            {
                entity.HasKey(e => e.DsctoVolProvLineaId)
                    .HasName("dsctos_vol_prov_lineas_pk");

                entity.ToTable("dsctos_vol_prov_lineas");

                entity.HasIndex(e => new { e.PolDsctoVolProvId, e.LineaArticuloId, e.Unidades })
                    .HasName("dsctos_vol_prov_lineas_ak1")
                    .IsUnique()
                    .HasFilter("([pol_dscto_vol_prov_id] IS NOT NULL AND [linea_articulo_id] IS NOT NULL AND [unidades] IS NOT NULL)");

                entity.Property(e => e.DsctoVolProvLineaId)
                    .HasColumnName("dscto_vol_prov_linea_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descuento)
                    .HasColumnName("descuento")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.LineaArticuloId).HasColumnName("linea_articulo_id");

                entity.Property(e => e.PolDsctoVolProvId).HasColumnName("pol_dscto_vol_prov_id");

                entity.Property(e => e.Unidades)
                    .HasColumnName("unidades")
                    .HasColumnType("decimal(18, 5)");

                entity.HasOne(d => d.LineaArticulo)
                    .WithMany(p => p.DsctosVolProvLineas)
                    .HasForeignKey(d => d.LineaArticuloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("lineas_a_dsctos_vol_prov");

                entity.HasOne(d => d.PolDsctoVolProv)
                    .WithMany(p => p.DsctosVolProvLineas)
                    .HasForeignKey(d => d.PolDsctoVolProvId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("lineas_con_dscto_vol_prov");
            });

            modelBuilder.Entity<EdosctaBa>(entity =>
            {
                entity.HasKey(e => e.EdoctaBaId)
                    .HasName("edoscta_ba_pk");

                entity.ToTable("edoscta_ba");

                entity.HasIndex(e => new { e.CuentaBanId, e.FechaIni })
                    .HasName("edoscta_ba_ie1");

                entity.Property(e => e.EdoctaBaId)
                    .HasColumnName("edocta_ba_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CuentaBanId).HasColumnName("cuenta_ban_id");

                entity.Property(e => e.FechaFin)
                    .HasColumnName("fecha_fin")
                    .HasColumnType("date");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.FechaIni)
                    .HasColumnName("fecha_ini")
                    .HasColumnType("date");

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.CuentaBan)
                    .WithMany(p => p.EdosctaBa)
                    .HasForeignKey(d => d.CuentaBanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ctaban_a_edoscta");
            });

            modelBuilder.Entity<EdosctaBaDet>(entity =>
            {
                entity.HasKey(e => e.EdoctaBaDetId)
                    .HasName("edoscta_ba_det_pk");

                entity.ToTable("edoscta_ba_det");

                entity.HasIndex(e => new { e.CuentaBanId, e.Fecha, e.TipoMovto })
                    .HasName("edoscta_ba_det_ie1");

                entity.Property(e => e.EdoctaBaDetId)
                    .HasColumnName("edocta_ba_det_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Conciliado)
                    .HasColumnName("conciliado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CuentaBanId).HasColumnName("cuenta_ban_id");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EdoctaBaId).HasColumnName("edocta_ba_id");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.FechaConciliacion)
                    .HasColumnName("fecha_conciliacion")
                    .HasColumnType("date");

                entity.Property(e => e.Importe)
                    .HasColumnName("importe")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Refer)
                    .HasColumnName("refer")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoMovto)
                    .IsRequired()
                    .HasColumnName("tipo_movto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.CuentaBan)
                    .WithMany(p => p.EdosctaBaDet)
                    .HasForeignKey(d => d.CuentaBanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ctaban_a_edoscta_det");

                entity.HasOne(d => d.EdoctaBa)
                    .WithMany(p => p.EdosctaBaDet)
                    .HasForeignKey(d => d.EdoctaBaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("edoscta_ba_a_det");
            });

            modelBuilder.Entity<ElementosCatClasif>(entity =>
            {
                entity.HasKey(e => new { e.ElementoId, e.ValorClasifId })
                    .HasName("elementos_cat_clasif_pk1");

                entity.ToTable("elementos_cat_clasif");

                entity.Property(e => e.ElementoId).HasColumnName("elemento_id");

                entity.Property(e => e.ValorClasifId).HasColumnName("valor_clasif_id");

                entity.HasOne(d => d.ValorClasif)
                    .WithMany(p => p.ElementosCatClasif)
                    .HasForeignKey(d => d.ValorClasifId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("clasif_val_a_elem_clasif");
            });

            modelBuilder.Entity<Empleados>(entity =>
            {
                entity.HasKey(e => e.EmpleadoId)
                    .HasName("empleados_pk");

                entity.ToTable("empleados");

                entity.HasIndex(e => e.NombreCompleto)
                    .HasName("empleados_ie1");

                entity.HasIndex(e => e.Numero)
                    .HasName("empleados_ak1")
                    .IsUnique()
                    .HasFilter("([numero] IS NOT NULL)");

                entity.Property(e => e.EmpleadoId)
                    .HasColumnName("empleado_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApellidoMaterno)
                    .HasColumnName("apellido_materno")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ApellidoPaterno)
                    .IsRequired()
                    .HasColumnName("apellido_paterno")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CalcIsrAnual)
                    .IsRequired()
                    .HasColumnName("calc_isr_anual")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Calle)
                    .HasColumnName("calle")
                    .HasMaxLength(430)
                    .IsUnicode(false);

                entity.Property(e => e.Cas)
                    .IsRequired()
                    .HasColumnName("cas")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CiudadId).HasColumnName("ciudad_id");

                entity.Property(e => e.CiudadNacimientoId).HasColumnName("ciudad_nacimiento_id");

                entity.Property(e => e.CodigoPostal)
                    .HasColumnName("codigo_postal")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Colonia)
                    .HasColumnName("colonia")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Contrato)
                    .IsRequired()
                    .HasColumnName("contrato")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e.ContratoSat)
                    .IsRequired()
                    .HasColumnName("contrato_sat")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('01')");

                entity.Property(e => e.Curp)
                    .HasColumnName("curp")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.DeptoNoId).HasColumnName("depto_no_id");

                entity.Property(e => e.DeshabImptos)
                    .IsRequired()
                    .HasColumnName("deshab_imptos")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DiasHrsJsr)
                    .HasColumnName("dias_hrs_jsr")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EsSindicalizado)
                    .IsRequired()
                    .HasColumnName("es_sindicalizado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EstadoCivil)
                    .IsRequired()
                    .HasColumnName("estado_civil")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estatus)
                    .IsRequired()
                    .HasColumnName("estatus")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("fecha_ingreso")
                    .HasColumnType("date");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnName("fecha_nacimiento")
                    .HasColumnType("date");

                entity.Property(e => e.FormaPago)
                    .IsRequired()
                    .HasColumnName("forma_pago")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('E')");

                entity.Property(e => e.FrepagId).HasColumnName("frepag_id");

                entity.Property(e => e.GrupoPagoElectId).HasColumnName("grupo_pago_elect_id");

                entity.Property(e => e.Horario)
                    .HasColumnName("horario")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Imss)
                    .IsRequired()
                    .HasColumnName("imss")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Infonavit)
                    .IsRequired()
                    .HasColumnName("infonavit")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Jornada)
                    .HasColumnName("jornada")
                    .HasColumnType("decimal(4, 2)");

                entity.Property(e => e.JornadaSat)
                    .IsRequired()
                    .HasColumnName("jornada_sat")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('01')");

                entity.Property(e => e.NombreCalle)
                    .HasColumnName("nombre_calle")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCompleto)
                    .IsRequired()
                    .HasColumnName("nombre_completo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombreMadre)
                    .HasColumnName("nombre_madre")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombrePadre)
                    .HasColumnName("nombre_padre")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasColumnName("nombres")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumCtabanPagoElect)
                    .HasColumnName("num_ctaban_pago_elect")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumExterior)
                    .HasColumnName("num_exterior")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumHijos).HasColumnName("num_hijos");

                entity.Property(e => e.NumInterior)
                    .HasColumnName("num_interior")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Numero).HasColumnName("numero");

                entity.Property(e => e.OtroReg)
                    .HasColumnName("otro_reg")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.PctjeInteg)
                    .HasColumnName("pctje_integ")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.Pensionado)
                    .IsRequired()
                    .HasColumnName("pensionado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Poblacion)
                    .HasColumnName("poblacion")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ptu)
                    .IsRequired()
                    .HasColumnName("ptu")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PuestoNoId).HasColumnName("puesto_no_id");

                entity.Property(e => e.Referencia)
                    .HasColumnName("referencia")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RegImss)
                    .HasColumnName("reg_imss")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.RegPatronalId).HasColumnName("reg_patronal_id");

                entity.Property(e => e.Regimen)
                    .IsRequired()
                    .HasColumnName("regimen")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('S')");

                entity.Property(e => e.RegimenFiscal)
                    .IsRequired()
                    .HasColumnName("regimen_fiscal")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('2')");

                entity.Property(e => e.Rfc)
                    .HasColumnName("rfc")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.SalarioDiario)
                    .HasColumnName("salario_diario")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.SalarioHora)
                    .HasColumnName("salario_hora")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.SalarioInteg)
                    .HasColumnName("salario_integ")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Sexo)
                    .IsRequired()
                    .HasColumnName("sexo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('M')");

                entity.Property(e => e.TablaAntigId).HasColumnName("tabla_antig_id");

                entity.Property(e => e.Telefono1)
                    .HasColumnName("telefono1")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono2)
                    .HasColumnName("telefono2")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCtabanPagoElect)
                    .IsRequired()
                    .HasColumnName("tipo_ctaban_pago_elect")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('D')");

                entity.Property(e => e.TipoPension)
                    .HasColumnName("tipo_pension")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoSalario)
                    .HasColumnName("tipo_salario")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Turno)
                    .IsRequired()
                    .HasColumnName("turno")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('M')");

                entity.Property(e => e.UnidadMedica)
                    .HasColumnName("unidad_medica")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.ZonaSalmin)
                    .IsRequired()
                    .HasColumnName("zona_salmin")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('A')");

                entity.HasOne(d => d.Ciudad)
                    .WithMany(p => p.EmpleadosCiudad)
                    .HasForeignKey(d => d.CiudadId)
                    .HasConstraintName("ciudades_a_emp");

                entity.HasOne(d => d.CiudadNacimiento)
                    .WithMany(p => p.EmpleadosCiudadNacimiento)
                    .HasForeignKey(d => d.CiudadNacimientoId)
                    .HasConstraintName("ciudades_a_emp_nac");

                entity.HasOne(d => d.DeptoNo)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.DeptoNoId)
                    .HasConstraintName("deptos_a_emp");

                entity.HasOne(d => d.Frepag)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.FrepagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frepag_a_emp");

                entity.HasOne(d => d.GrupoPagoElect)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.GrupoPagoElectId)
                    .HasConstraintName("grupos_pagos_elect_a_emp");

                entity.HasOne(d => d.PuestoNo)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.PuestoNoId)
                    .HasConstraintName("puestos_a_emp");

                entity.HasOne(d => d.RegPatronal)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.RegPatronalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("reg_patronales_a_emp");

                entity.HasOne(d => d.TablaAntig)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.TablaAntigId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tablas_a_emp");
            });

            modelBuilder.Entity<EquivalenciasImpuestos>(entity =>
            {
                entity.HasKey(e => e.EquivImptosId)
                    .HasName("equivalencias_impuestos_pk");

                entity.ToTable("equivalencias_impuestos");

                entity.HasIndex(e => e.FechaInicio)
                    .HasName("equivalencias_impuestos_ak1")
                    .IsUnique()
                    .HasFilter("([fecha_inicio] IS NOT NULL)");

                entity.Property(e => e.EquivImptosId)
                    .HasColumnName("equiv_imptos_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.FechaInicio)
                    .HasColumnName("fecha_inicio")
                    .HasColumnType("date");

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EquivalenciasImpuestosDet>(entity =>
            {
                entity.HasKey(e => e.EquivImptosDetId)
                    .HasName("equivalencias_impuestos_det_pk");

                entity.ToTable("equivalencias_impuestos_det");

                entity.HasIndex(e => new { e.EquivImptosId, e.ImpuestoNuevoId })
                    .HasName("equivalencias_impuestos_det_ak1")
                    .IsUnique()
                    .HasFilter("([equiv_imptos_id] IS NOT NULL AND [impuesto_nuevo_id] IS NOT NULL)");

                entity.Property(e => e.EquivImptosDetId)
                    .HasColumnName("equiv_imptos_det_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EquivImptosId).HasColumnName("equiv_imptos_id");

                entity.Property(e => e.ImpuestoAnteriorId).HasColumnName("impuesto_anterior_id");

                entity.Property(e => e.ImpuestoNuevoId).HasColumnName("impuesto_nuevo_id");

                entity.HasOne(d => d.EquivImptos)
                    .WithMany(p => p.EquivalenciasImpuestosDet)
                    .HasForeignKey(d => d.EquivImptosId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("equiv_impto_a_det");

                entity.HasOne(d => d.ImpuestoAnterior)
                    .WithMany(p => p.EquivalenciasImpuestosDetImpuestoAnterior)
                    .HasForeignKey(d => d.ImpuestoAnteriorId)
                    .HasConstraintName("imptos_a_equiv_det_ant");

                entity.HasOne(d => d.ImpuestoNuevo)
                    .WithMany(p => p.EquivalenciasImpuestosDetImpuestoNuevo)
                    .HasForeignKey(d => d.ImpuestoNuevoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("imptos_a_equiv_det_nvo");
            });

            modelBuilder.Entity<EquivalenciasMonedas>(entity =>
            {
                entity.HasKey(e => e.EquivMonId)
                    .HasName("equivalencias_mon_pk");

                entity.ToTable("equivalencias_monedas");

                entity.HasIndex(e => e.Descripcion)
                    .HasName("equivalencias_mon_ak1")
                    .IsUnique()
                    .HasFilter("([descripcion] IS NOT NULL)");

                entity.Property(e => e.EquivMonId)
                    .HasColumnName("equiv_mon_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClaveFiscal)
                    .IsRequired()
                    .HasColumnName("clave_fiscal")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EspecsEdofin>(entity =>
            {
                entity.HasKey(e => e.EspecEdofinId)
                    .HasName("especs_edofin_pk");

                entity.ToTable("especs_edofin");

                entity.HasIndex(e => e.Nombre)
                    .HasName("especs_edofin_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.EspecEdofinId)
                    .HasColumnName("espec_edofin_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ColumnaVar)
                    .HasColumnName("columna_var")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e.Contenido)
                    .IsRequired()
                    .HasColumnName("contenido")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('E')");

                entity.Property(e => e.DeptoCoId).HasColumnName("depto_co_id");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.FormatoEdofinId).HasColumnName("formato_edofin_id");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SelImpresion)
                    .HasColumnName("sel_impresion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.Variacion)
                    .HasColumnName("variacion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.DeptoCo)
                    .WithMany(p => p.EspecsEdofin)
                    .HasForeignKey(d => d.DeptoCoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("deptos_co_a_especs");

                entity.HasOne(d => d.FormatoEdofin)
                    .WithMany(p => p.EspecsEdofin)
                    .HasForeignKey(d => d.FormatoEdofinId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("formatos_edofin_a_especs");
            });

            modelBuilder.Entity<Estados>(entity =>
            {
                entity.HasKey(e => e.EstadoId)
                    .HasName("estados_pk");

                entity.ToTable("estados");

                entity.HasIndex(e => new { e.Nombre, e.PaisId })
                    .HasName("estados_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL AND [pais_id] IS NOT NULL)");

                entity.Property(e => e.EstadoId)
                    .HasColumnName("estado_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClaveFiscal)
                    .HasColumnName("clave_fiscal")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EsPredet)
                    .HasColumnName("es_predet")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreAbrev)
                    .HasColumnName("nombre_abrev")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaisId).HasColumnName("pais_id");

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.Pais)
                    .WithMany(p => p.Estados)
                    .HasForeignKey(d => d.PaisId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("paises_a_estados");
            });

            modelBuilder.Entity<EstatusAsimilados>(entity =>
            {
                entity.HasKey(e => e.EstatusAsimiladoId)
                    .HasName("estatus_asimilados_pk");

                entity.ToTable("estatus_asimilados");

                entity.Property(e => e.EstatusAsimiladoId)
                    .HasColumnName("estatus_asimilado_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EmpleadoId).HasColumnName("empleado_id");

                entity.Property(e => e.Estatus)
                    .IsRequired()
                    .HasColumnName("estatus")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.HasOne(d => d.Empleado)
                    .WithMany(p => p.EstatusAsimilados)
                    .HasForeignKey(d => d.EmpleadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("emp_a_estatus_asimilados");
            });

            modelBuilder.Entity<ExcepEmpleados>(entity =>
            {
                entity.HasKey(e => e.ExcepEmpId)
                    .HasName("excep_empleados_pk");

                entity.ToTable("excep_empleados");

                entity.HasIndex(e => new { e.NominaId, e.EmpleadoId })
                    .HasName("excep_empleados_ak1")
                    .IsUnique()
                    .HasFilter("([nomina_id] IS NOT NULL AND [empleado_id] IS NOT NULL)");

                entity.Property(e => e.ExcepEmpId)
                    .HasColumnName("excep_emp_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CausaBaja)
                    .HasColumnName("causa_baja")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DiasACot)
                    .HasColumnName("dias_a_cot")
                    .HasColumnType("decimal(7, 4)");

                entity.Property(e => e.DiasAntigIndem)
                    .HasColumnName("dias_antig_indem")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DiasAusImss).HasColumnName("dias_aus_imss");

                entity.Property(e => e.DiasBaseIndem)
                    .HasColumnName("dias_base_indem")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DiasEsp).HasColumnName("dias_esp");

                entity.Property(e => e.DiasExt).HasColumnName("dias_ext");

                entity.Property(e => e.DiasHrsPagar)
                    .HasColumnName("dias_hrs_pagar")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DiasHrsPagarA7)
                    .HasColumnName("dias_hrs_pagar_a7")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DiasIncap).HasColumnName("dias_incap");

                entity.Property(e => e.DiasPrimerIndem)
                    .HasColumnName("dias_primer_indem")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DiasVac)
                    .HasColumnName("dias_vac")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.EmpleadoId).HasColumnName("empleado_id");

                entity.Property(e => e.Faltas)
                    .IsRequired()
                    .HasColumnName("faltas")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FaltasA7)
                    .IsRequired()
                    .HasColumnName("faltas_a7")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.HorasEsp)
                    .IsRequired()
                    .HasColumnName("horas_esp")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HorasExt)
                    .IsRequired()
                    .HasColumnName("horas_ext")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ImporteFaltas)
                    .HasColumnName("importe_faltas")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ImporteHorasEsp)
                    .HasColumnName("importe_horas_esp")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ImporteHorasExt)
                    .HasColumnName("importe_horas_ext")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.IncapTotal)
                    .IsRequired()
                    .HasColumnName("incap_total")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NominaId).HasColumnName("nomina_id");

                entity.Property(e => e.SeptimoDia)
                    .IsRequired()
                    .HasColumnName("septimo_dia")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.Empleado)
                    .WithMany(p => p.ExcepEmpleados)
                    .HasForeignKey(d => d.EmpleadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("emp_a_exc_emp");

                entity.HasOne(d => d.Nomina)
                    .WithMany(p => p.ExcepEmpleados)
                    .HasForeignKey(d => d.NominaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("nom_a_exc_emp");
            });

            modelBuilder.Entity<ExcepEmpleadosDet>(entity =>
            {
                entity.HasKey(e => e.ExcepEmpDetId)
                    .HasName("excep_empleados_det_pk");

                entity.ToTable("excep_empleados_det");

                entity.Property(e => e.ExcepEmpDetId)
                    .HasColumnName("excep_emp_det_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Activo)
                    .IsRequired()
                    .HasColumnName("activo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AhorroEmpresa)
                    .HasColumnName("ahorro_empresa")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ConceptoNoId).HasColumnName("concepto_no_id");

                entity.Property(e => e.Cuota)
                    .HasColumnName("cuota")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.EsPeriodico)
                    .IsRequired()
                    .HasColumnName("es_periodico")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ExcepEmpId).HasColumnName("excep_emp_id");

                entity.Property(e => e.IdInterno)
                    .HasColumnName("id_interno")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PrestamoEmpId).HasColumnName("prestamo_emp_id");

                entity.Property(e => e.SubemCausado)
                    .HasColumnName("subem_causado")
                    .HasColumnType("decimal(15, 2)");

                entity.HasOne(d => d.ExcepEmp)
                    .WithMany(p => p.ExcepEmpleadosDet)
                    .HasForeignKey(d => d.ExcepEmpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("exc_emp_a_det");

                entity.HasOne(d => d.PrestamoEmp)
                    .WithMany(p => p.ExcepEmpleadosDet)
                    .HasForeignKey(d => d.PrestamoEmpId)
                    .HasConstraintName("ptmo_emp_a_exc_emp_det");
            });

            modelBuilder.Entity<ExcepGenerales>(entity =>
            {
                entity.HasKey(e => e.ExcepGralId)
                    .HasName("excep_generales_pk");

                entity.ToTable("excep_generales");

                entity.HasIndex(e => new { e.NominaId, e.Tipo, e.ConceptoNoId, e.DeptoNoId, e.PuestoNoId, e.RegPatronalId })
                    .HasName("excep_generales_uq1")
                    .IsUnique()
                    .HasFilter("([nomina_id] IS NOT NULL AND [tipo] IS NOT NULL AND [concepto_no_id] IS NOT NULL AND [depto_no_id] IS NOT NULL AND [puesto_no_id] IS NOT NULL AND [reg_patronal_id] IS NOT NULL)");

                entity.Property(e => e.ExcepGralId)
                    .HasColumnName("excep_gral_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AhorroEmpresa)
                    .HasColumnName("ahorro_empresa")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.AplicarExcepIndiv)
                    .IsRequired()
                    .HasColumnName("aplicar_excep_indiv")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ConceptoNoId).HasColumnName("concepto_no_id");

                entity.Property(e => e.Cuota)
                    .HasColumnName("cuota")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.DeptoNoId).HasColumnName("depto_no_id");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.NominaId).HasColumnName("nomina_id");

                entity.Property(e => e.PuestoNoId).HasColumnName("puesto_no_id");

                entity.Property(e => e.RegPatronalId).HasColumnName("reg_patronal_id");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("tipo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.UnDepto)
                    .IsRequired()
                    .HasColumnName("un_depto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UnPuesto)
                    .HasColumnName("un_puesto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UnRegPatronal)
                    .IsRequired()
                    .HasColumnName("un_reg_patronal")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.DeptoNo)
                    .WithMany(p => p.ExcepGenerales)
                    .HasForeignKey(d => d.DeptoNoId)
                    .HasConstraintName("deptos_a_exc_grl");

                entity.HasOne(d => d.Nomina)
                    .WithMany(p => p.ExcepGenerales)
                    .HasForeignKey(d => d.NominaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("nom_a_exc_grl");

                entity.HasOne(d => d.PuestoNo)
                    .WithMany(p => p.ExcepGenerales)
                    .HasForeignKey(d => d.PuestoNoId)
                    .HasConstraintName("puestos_a_exc_grl");

                entity.HasOne(d => d.RegPatronal)
                    .WithMany(p => p.ExcepGenerales)
                    .HasForeignKey(d => d.RegPatronalId)
                    .HasConstraintName("reg_patronales_a_exc_grl");
            });

            modelBuilder.Entity<ExisDiscretos>(entity =>
            {
                entity.HasKey(e => e.ExisDiscretoId)
                    .HasName("exis_discretos_pk");

                entity.ToTable("exis_discretos");

                entity.HasIndex(e => new { e.ArtDiscretoId, e.AlmacenId })
                    .HasName("exis_discretos_ak1")
                    .IsUnique()
                    .HasFilter("([art_discreto_id] IS NOT NULL AND [almacen_id] IS NOT NULL)");

                entity.Property(e => e.ExisDiscretoId)
                    .HasColumnName("exis_discreto_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AlmacenId).HasColumnName("almacen_id");

                entity.Property(e => e.ArtDiscretoId).HasColumnName("art_discreto_id");

                entity.Property(e => e.Existencia)
                    .HasColumnName("existencia")
                    .HasColumnType("decimal(18, 5)");

                entity.HasOne(d => d.Almacen)
                    .WithMany(p => p.ExisDiscretos)
                    .HasForeignKey(d => d.AlmacenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("alm_a_exis_discretos");

                entity.HasOne(d => d.ArtDiscreto)
                    .WithMany(p => p.ExisDiscretos)
                    .HasForeignKey(d => d.ArtDiscretoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("discretos_a_exis_discretos");
            });

            modelBuilder.Entity<FechasBaseCostos>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("fechas_base_costos");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.TipoReg)
                    .IsRequired()
                    .HasColumnName("tipo_reg")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FoliosCajas>(entity =>
            {
                entity.HasKey(e => new { e.CajaId, e.TipoDocto })
                    .HasName("folios_cajas_pk");

                entity.ToTable("folios_cajas");

                entity.HasIndex(e => new { e.TipoDocto, e.Serie })
                    .HasName("folios_cajas_ak1")
                    .IsUnique()
                    .HasFilter("([tipo_docto] IS NOT NULL AND [serie] IS NOT NULL)");

                entity.Property(e => e.CajaId).HasColumnName("caja_id");

                entity.Property(e => e.TipoDocto)
                    .HasColumnName("tipo_docto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Consecutivo).HasColumnName("consecutivo");

                entity.Property(e => e.Serie)
                    .IsRequired()
                    .HasColumnName("serie")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.Caja)
                    .WithMany(p => p.FoliosCajas)
                    .HasForeignKey(d => d.CajaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cajas_a_folios_cajas");
            });

            modelBuilder.Entity<FoliosCompras>(entity =>
            {
                entity.HasKey(e => e.FolioComprasId)
                    .HasName("folios_compras_pk");

                entity.ToTable("folios_compras");

                entity.HasIndex(e => new { e.TipoDocto, e.Serie })
                    .HasName("folios_compras_ak1")
                    .IsUnique()
                    .HasFilter("([tipo_docto] IS NOT NULL AND [serie] IS NOT NULL)");

                entity.Property(e => e.FolioComprasId)
                    .HasColumnName("folio_compras_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Consecutivo).HasColumnName("consecutivo");

                entity.Property(e => e.Serie)
                    .IsRequired()
                    .HasColumnName("serie")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocto)
                    .IsRequired()
                    .HasColumnName("tipo_docto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FoliosFiscales>(entity =>
            {
                entity.ToTable("folios_fiscales");

                entity.Property(e => e.FoliosFiscalesId)
                    .HasColumnName("folios_fiscales_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AnoAprobacion).HasColumnName("ano_aprobacion");

                entity.Property(e => e.FechaAprobacion)
                    .HasColumnName("fecha_aprobacion")
                    .HasColumnType("date");

                entity.Property(e => e.FechaVencimiento)
                    .HasColumnName("fecha_vencimiento")
                    .HasColumnType("date");

                entity.Property(e => e.FolioFin).HasColumnName("folio_fin");

                entity.Property(e => e.FolioIni).HasColumnName("folio_ini");

                entity.Property(e => e.ImagenCbb)
                    .HasColumnName("imagen_cbb")
                    .IsUnicode(false);

                entity.Property(e => e.ModalidadFacturacion)
                    .HasColumnName("modalidad_facturacion")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumAprobacion)
                    .IsRequired()
                    .HasColumnName("num_aprobacion")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Serie)
                    .IsRequired()
                    .HasColumnName("serie")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.UltimoUtilizado).HasColumnName("ultimo_utilizado");
            });

            modelBuilder.Entity<FoliosVentas>(entity =>
            {
                entity.HasKey(e => e.FolioVentasId)
                    .HasName("folios_ventas_pk");

                entity.ToTable("folios_ventas");

                entity.HasIndex(e => new { e.TipoDocto, e.Serie })
                    .HasName("folios_ventas_ak1")
                    .IsUnique()
                    .HasFilter("([tipo_docto] IS NOT NULL AND [serie] IS NOT NULL)");

                entity.Property(e => e.FolioVentasId)
                    .HasColumnName("folio_ventas_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Consecutivo).HasColumnName("consecutivo");

                entity.Property(e => e.ModalidadFacturacion)
                    .HasColumnName("modalidad_facturacion")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Serie)
                    .IsRequired()
                    .HasColumnName("serie")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocto)
                    .IsRequired()
                    .HasColumnName("tipo_docto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FormasCobro>(entity =>
            {
                entity.HasKey(e => e.FormaCobroId)
                    .HasName("formas_cobro_pk");

                entity.ToTable("formas_cobro");

                entity.HasIndex(e => e.Nombre)
                    .HasName("formas_cobro_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.FormaCobroId)
                    .HasColumnName("forma_cobro_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AbrirCajon)
                    .HasColumnName("abrir_cajon")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AfiliacionAmexAtc)
                    .HasColumnName("afiliacion_amex_atc")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.AfiliacionAtc)
                    .HasColumnName("afiliacion_atc")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AlarmaExcesoEfectivo)
                    .IsRequired()
                    .HasColumnName("alarma_exceso_efectivo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AutomAtc)
                    .HasColumnName("autom_atc")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AutorizacionDesde)
                    .HasColumnName("autorizacion_desde")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.AutorizacionNecesaria)
                    .HasColumnName("autorizacion_necesaria")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AutorizacionTarjeta)
                    .HasColumnName("autorizacion_tarjeta")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaveFiscal)
                    .HasColumnName("clave_fiscal")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CobrarEnExceso)
                    .HasColumnName("cobrar_en_exceso")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContarEnCorte)
                    .HasColumnName("contar_en_corte")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CuentaContable)
                    .HasColumnName("cuenta_contable")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DarCambio)
                    .HasColumnName("dar_cambio")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DetenerVentaExcesoEfectivo)
                    .IsRequired()
                    .HasColumnName("detener_venta_exceso_efectivo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.IdInterno)
                    .HasColumnName("id_interno")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LimiteEfectivo)
                    .HasColumnName("limite_efectivo")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ListaMesesPromoAtc)
                    .HasColumnName("lista_meses_promo_atc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MonedaId).HasColumnName("moneda_id");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumMesesPromoAtc).HasColumnName("num_meses_promo_atc");

                entity.Property(e => e.OrdenDenominaciones)
                    .HasColumnName("orden_denominaciones")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("tipo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('E')");

                entity.Property(e => e.UrlServicioAtc)
                    .HasColumnName("url_servicio_atc")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UsarDenominaciones)
                    .IsRequired()
                    .HasColumnName("usar_denominaciones")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UserNameAtc)
                    .HasColumnName("user_name_atc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UserPswAtc)
                    .HasColumnName("user_psw_atc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.Moneda)
                    .WithMany(p => p.FormasCobro)
                    .HasForeignKey(d => d.MonedaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("monedas_a_formas_cobro");
            });

            modelBuilder.Entity<FormasCobroCc>(entity =>
            {
                entity.HasKey(e => e.FormaCobroCcId)
                    .HasName("formas_cobro_cc_pk");

                entity.ToTable("formas_cobro_cc");

                entity.HasIndex(e => e.Nombre)
                    .HasName("formas_cobro_cc_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.FormaCobroCcId)
                    .HasColumnName("forma_cobro_cc_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClaveFiscal)
                    .HasColumnName("clave_fiscal")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ConceptoBaId).HasColumnName("concepto_ba_id");

                entity.Property(e => e.DescripcionMovtoBa)
                    .HasColumnName("descripcion_movto_ba")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DiasTransito).HasColumnName("dias_transito");

                entity.Property(e => e.EsPredet)
                    .HasColumnName("es_predet")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.ManejoRefer)
                    .HasColumnName("manejo_refer")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MonedaId).HasColumnName("moneda_id");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferObligatoria)
                    .HasColumnName("refer_obligatoria")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RegistraInfoBan)
                    .IsRequired()
                    .HasColumnName("registra_info_ban")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.ConceptoBa)
                    .WithMany(p => p.FormasCobroCc)
                    .HasForeignKey(d => d.ConceptoBaId)
                    .HasConstraintName("conceptos_ba_a_formas_cobro_cc");

                entity.HasOne(d => d.Moneda)
                    .WithMany(p => p.FormasCobroCc)
                    .HasForeignKey(d => d.MonedaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("monedas_a_formas_cobro_cc");
            });

            modelBuilder.Entity<FormasCobroClientes>(entity =>
            {
                entity.HasKey(e => e.FormaCobroCliId)
                    .HasName("formas_cobro_clientes_pk");

                entity.ToTable("formas_cobro_clientes");

                entity.Property(e => e.FormaCobroCliId)
                    .HasColumnName("forma_cobro_cli_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BancoId).HasColumnName("banco_id");

                entity.Property(e => e.ClaveSistema)
                    .IsRequired()
                    .HasColumnName("clave_sistema")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClienteId).HasColumnName("cliente_id");

                entity.Property(e => e.FormaCobroId).HasColumnName("forma_cobro_id");

                entity.Property(e => e.NumCtaPago)
                    .HasColumnName("num_cta_pago")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UltUtilizada)
                    .IsRequired()
                    .HasColumnName("ult_utilizada")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Banco)
                    .WithMany(p => p.FormasCobroClientes)
                    .HasForeignKey(d => d.BancoId)
                    .HasConstraintName("bancos_a_formas_cobro_cli");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.FormasCobroClientes)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("clientes_a_formas_cobro_cli");
            });

            modelBuilder.Entity<FormasCobroDenom>(entity =>
            {
                entity.HasKey(e => e.FormaCobroDenomId)
                    .HasName("formas_cobro_denom_pk");

                entity.ToTable("formas_cobro_denom");

                entity.HasIndex(e => new { e.FormaCobroId, e.Denominacion })
                    .HasName("formas_cobro_denom_ak1")
                    .IsUnique()
                    .HasFilter("([forma_cobro_id] IS NOT NULL AND [denominacion] IS NOT NULL)");

                entity.Property(e => e.FormaCobroDenomId)
                    .HasColumnName("forma_cobro_denom_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Denominacion)
                    .HasColumnName("denominacion")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.FormaCobroId).HasColumnName("forma_cobro_id");

                entity.HasOne(d => d.FormaCobro)
                    .WithMany(p => p.FormasCobroDenom)
                    .HasForeignKey(d => d.FormaCobroId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("form_cob_a_denom");
            });

            modelBuilder.Entity<FormasCobroDoctos>(entity =>
            {
                entity.HasKey(e => e.FormaCobroDocId)
                    .HasName("formas_cobro_doctos_pk");

                entity.ToTable("formas_cobro_doctos");

                entity.HasIndex(e => new { e.NomTablaDoctos, e.DoctoId, e.FormaCobroId, e.NumCtaPago })
                    .HasName("formas_cobro_doctos_ak1")
                    .IsUnique()
                    .HasFilter("([nom_tabla_doctos] IS NOT NULL AND [docto_id] IS NOT NULL AND [forma_cobro_id] IS NOT NULL AND [num_cta_pago] IS NOT NULL)");

                entity.Property(e => e.FormaCobroDocId)
                    .HasColumnName("forma_cobro_doc_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClaveSisFormaCob)
                    .IsRequired()
                    .HasColumnName("clave_sis_forma_cob")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DoctoId).HasColumnName("docto_id");

                entity.Property(e => e.FormaCobroId).HasColumnName("forma_cobro_id");

                entity.Property(e => e.Importe)
                    .HasColumnName("importe")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.NomTablaDoctos)
                    .IsRequired()
                    .HasColumnName("nom_tabla_doctos")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.NumCtaPago)
                    .HasColumnName("num_cta_pago")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Referencia)
                    .HasColumnName("referencia")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FormasCobroRefer>(entity =>
            {
                entity.HasKey(e => e.FormaCobroReferId)
                    .HasName("formas_cobro_refer_pk");

                entity.ToTable("formas_cobro_refer");

                entity.HasIndex(e => new { e.FormaCobroId, e.Nombre })
                    .HasName("formas_cobro_refer_ak1")
                    .IsUnique()
                    .HasFilter("([forma_cobro_id] IS NOT NULL AND [nombre] IS NOT NULL)");

                entity.Property(e => e.FormaCobroReferId)
                    .HasColumnName("forma_cobro_refer_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.FormaCobroId).HasColumnName("forma_cobro_id");

                entity.Property(e => e.Habilitada)
                    .HasColumnName("habilitada")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdInterno)
                    .HasColumnName("id_interno")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ImprimirEnReportes)
                    .HasColumnName("imprimir_en_reportes")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ImprimirEnTickets)
                    .HasColumnName("imprimir_en_tickets")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Posicion).HasColumnName("posicion");

                entity.Property(e => e.Requerida)
                    .HasColumnName("requerida")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.FormaCobro)
                    .WithMany(p => p.FormasCobroRefer)
                    .HasForeignKey(d => d.FormaCobroId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("formas_cobro_a_refer");
            });

            modelBuilder.Entity<FormatosEdofin>(entity =>
            {
                entity.HasKey(e => e.FormatoEdofinId)
                    .HasName("formatos_edofin_pk");

                entity.ToTable("formatos_edofin");

                entity.HasIndex(e => e.Nombre)
                    .HasName("formatos_edofin_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.FormatoEdofinId)
                    .HasColumnName("formato_edofin_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("tipo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('B')");

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FormatosEdofinDet>(entity =>
            {
                entity.HasKey(e => e.FormatoEdofinDetId)
                    .HasName("formatos_edofin_det_pk");

                entity.ToTable("formatos_edofin_det");

                entity.HasIndex(e => new { e.FormatoEdofinId, e.Posicion })
                    .HasName("formatos_edofin_det_ie1");

                entity.Property(e => e.FormatoEdofinDetId)
                    .HasColumnName("formato_edofin_det_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Columna).HasColumnName("columna");

                entity.Property(e => e.Comando)
                    .IsRequired()
                    .HasColumnName("comando")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaId).HasColumnName("cuenta_id");

                entity.Property(e => e.CuentaJtFin)
                    .HasColumnName("cuenta_jt_fin")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaJtIni)
                    .HasColumnName("cuenta_jt_ini")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaPtFin)
                    .HasColumnName("cuenta_pt_fin")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaPtIni)
                    .HasColumnName("cuenta_pt_ini")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.EstiloFuenteImptes)
                    .HasColumnName("estilo_fuente_imptes")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EstiloFuenteLet)
                    .HasColumnName("estilo_fuente_let")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FormatoEdofinId).HasColumnName("formato_edofin_id");

                entity.Property(e => e.GrupoCuentasId).HasColumnName("grupo_cuentas_id");

                entity.Property(e => e.Impacum)
                    .HasColumnName("impacum")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Letrero)
                    .HasColumnName("letrero")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Naturaleza)
                    .HasColumnName("naturaleza")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nivel).HasColumnName("nivel");

                entity.Property(e => e.Notas)
                    .HasColumnName("notas")
                    .IsUnicode(false);

                entity.Property(e => e.Posicion).HasColumnName("posicion");

                entity.Property(e => e.SubrayarImptes)
                    .HasColumnName("subrayar_imptes")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SubrayarLet)
                    .HasColumnName("subrayar_let")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Cuenta)
                    .WithMany(p => p.FormatosEdofinDet)
                    .HasForeignKey(d => d.CuentaId)
                    .HasConstraintName("cuentas_co_a_edofin_det");

                entity.HasOne(d => d.FormatoEdofin)
                    .WithMany(p => p.FormatosEdofinDet)
                    .HasForeignKey(d => d.FormatoEdofinId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("formatos_edofin_a_det");

                entity.HasOne(d => d.GrupoCuentas)
                    .WithMany(p => p.FormatosEdofinDet)
                    .HasForeignKey(d => d.GrupoCuentasId)
                    .HasConstraintName("gpos_cuentas_a_edofin_det");
            });

            modelBuilder.Entity<FormatosTicketsDet>(entity =>
            {
                entity.HasKey(e => e.FormatoTicketDetId)
                    .HasName("formatos_tickets_det_pk");

                entity.ToTable("formatos_tickets_det");

                entity.HasIndex(e => new { e.FormatoTicketId, e.Posicion })
                    .HasName("formatos_tickets_det_ie1");

                entity.Property(e => e.FormatoTicketDetId)
                    .HasColumnName("formato_ticket_det_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Columna).HasColumnName("columna");

                entity.Property(e => e.Columna2).HasColumnName("columna2");

                entity.Property(e => e.Columna3).HasColumnName("columna3");

                entity.Property(e => e.Comando)
                    .IsRequired()
                    .HasColumnName("comando")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ComandoTipoDispId).HasColumnName("comando_tipo_disp_id");

                entity.Property(e => e.FormatoTicketId).HasColumnName("formato_ticket_id");

                entity.Property(e => e.Letrero)
                    .HasColumnName("letrero")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Posicion).HasColumnName("posicion");

                entity.HasOne(d => d.ComandoTipoDisp)
                    .WithMany(p => p.FormatosTicketsDet)
                    .HasForeignKey(d => d.ComandoTipoDispId)
                    .HasConstraintName("com_tipos_disp_a_fmtos_det");
            });

            modelBuilder.Entity<FrecuenciasPago>(entity =>
            {
                entity.HasKey(e => e.FrepagId)
                    .HasName("frecuencias_pago_pk");

                entity.ToTable("frecuencias_pago");

                entity.HasIndex(e => e.Nombre)
                    .HasName("frecuencias_pago_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.FrepagId)
                    .HasColumnName("frepag_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CalcImss)
                    .HasColumnName("calc_imss")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CalcIsr)
                    .HasColumnName("calc_isr")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CuentaPagosEfectivo)
                    .HasColumnName("cuenta_pagos_efectivo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaPagosEspecie)
                    .HasColumnName("cuenta_pagos_especie")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaPagosTrans)
                    .HasColumnName("cuenta_pagos_trans")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionPoliza)
                    .HasColumnName("descripcion_poliza")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DesglSeptimo)
                    .HasColumnName("desgl_septimo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DiasACot)
                    .HasColumnName("dias_a_cot")
                    .HasColumnType("decimal(7, 4)");

                entity.Property(e => e.DiasNetos)
                    .HasColumnName("dias_netos")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DiasPeriodo)
                    .HasColumnName("dias_periodo")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.EsPredet)
                    .HasColumnName("es_predet")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.HacerAjuste)
                    .HasColumnName("hacer_ajuste")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HacerDevol)
                    .HasColumnName("hacer_devol")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HorasPeriodo)
                    .HasColumnName("horas_periodo")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IncapSeptimo)
                    .IsRequired()
                    .HasColumnName("incap_septimo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PeriodicidadSat)
                    .HasColumnName("periodicidad_sat")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PeriodoTablaIsr)
                    .HasColumnName("periodo_tabla_isr")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.SeptimoDia)
                    .IsRequired()
                    .HasColumnName("septimo_dia")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TarifaIsr)
                    .IsRequired()
                    .HasColumnName("tarifa_isr")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoPago)
                    .IsRequired()
                    .HasColumnName("tipo_pago")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoPoliza)
                    .HasColumnName("tipo_poliza")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoProceso)
                    .IsRequired()
                    .HasColumnName("tipo_proceso")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GruposActivosFijos>(entity =>
            {
                entity.HasKey(e => e.GrupoActfijoId)
                    .HasName("grupos_act_fijos_pk");

                entity.ToTable("grupos_activos_fijos");

                entity.HasIndex(e => e.Nombre)
                    .HasName("grupos_act_fijos_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.GrupoActfijoId)
                    .HasColumnName("grupo_actfijo_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EsPredet)
                    .HasColumnName("es_predet")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SonTerrenos)
                    .HasColumnName("son_terrenos")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GruposCargosPeriodicosCc>(entity =>
            {
                entity.HasKey(e => e.GrupoCarPeriodId)
                    .HasName("grupos_car_period_cc_pk");

                entity.ToTable("grupos_cargos_periodicos_cc");

                entity.HasIndex(e => e.Nombre)
                    .HasName("grupos_car_period_cc_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.GrupoCarPeriodId)
                    .HasColumnName("grupo_car_period_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EsPredet)
                    .HasColumnName("es_predet")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GruposCuentas>(entity =>
            {
                entity.HasKey(e => e.GrupoCuentasId)
                    .HasName("grupos_cuentas_pk");

                entity.ToTable("grupos_cuentas");

                entity.HasIndex(e => e.Nombre)
                    .HasName("grupos_cuentas_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.GrupoCuentasId)
                    .HasColumnName("grupo_cuentas_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EsPredet)
                    .HasColumnName("es_predet")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subtipo)
                    .IsRequired()
                    .HasColumnName("subtipo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("tipo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GruposCuentasDet>(entity =>
            {
                entity.HasKey(e => e.GrupoCuentasDetId)
                    .HasName("grupos_cuentas_det_pk");

                entity.ToTable("grupos_cuentas_det");

                entity.Property(e => e.GrupoCuentasDetId)
                    .HasColumnName("grupo_cuentas_det_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CuentaJtFin)
                    .IsRequired()
                    .HasColumnName("cuenta_jt_fin")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaJtIni)
                    .IsRequired()
                    .HasColumnName("cuenta_jt_ini")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaPtFin)
                    .IsRequired()
                    .HasColumnName("cuenta_pt_fin")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaPtIni)
                    .IsRequired()
                    .HasColumnName("cuenta_pt_ini")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.GrupoCuentasId).HasColumnName("grupo_cuentas_id");

                entity.HasOne(d => d.GrupoCuentas)
                    .WithMany(p => p.GruposCuentasDet)
                    .HasForeignKey(d => d.GrupoCuentasId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("grupos_ctas_a_det");
            });

            modelBuilder.Entity<GruposLineas>(entity =>
            {
                entity.HasKey(e => e.GrupoLineaId)
                    .HasName("grupos_lineas_pk");

                entity.ToTable("grupos_lineas");

                entity.HasIndex(e => e.Nombre)
                    .HasName("grupos_lineas_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.GrupoLineaId)
                    .HasColumnName("grupo_linea_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AplicarFactorVenta)
                    .IsRequired()
                    .HasColumnName("aplicar_factor_venta")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CuentaAlmacen)
                    .HasColumnName("cuenta_almacen")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaCompras)
                    .HasColumnName("cuenta_compras")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaCostoVenta)
                    .HasColumnName("cuenta_costo_venta")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaDevolCompras)
                    .HasColumnName("cuenta_devol_compras")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaDevolVentas)
                    .HasColumnName("cuenta_devol_ventas")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaVentas)
                    .HasColumnName("cuenta_ventas")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EsPredet)
                    .HasColumnName("es_predet")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FactorVenta)
                    .HasColumnName("factor_venta")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GruposLineasWeb>(entity =>
            {
                entity.HasKey(e => e.GrupoLineaWebId)
                    .HasName("grupos_lineas_web_pk");

                entity.ToTable("grupos_lineas_web");

                entity.HasIndex(e => new { e.ClaveSis, e.Politica, e.GrupoLineaId })
                    .HasName("grupos_lineas_web_ak1")
                    .IsUnique()
                    .HasFilter("([clave_sis] IS NOT NULL AND [politica] IS NOT NULL AND [grupo_linea_id] IS NOT NULL)");

                entity.Property(e => e.GrupoLineaWebId)
                    .HasColumnName("grupo_linea_web_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Accion)
                    .HasColumnName("accion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaveSis)
                    .HasColumnName("clave_sis")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GrupoLineaId).HasColumnName("grupo_linea_id");

                entity.Property(e => e.Politica)
                    .HasColumnName("politica")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.GrupoLinea)
                    .WithMany(p => p.GruposLineasWeb)
                    .HasForeignKey(d => d.GrupoLineaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("grupos_a_gps_web");
            });

            modelBuilder.Entity<GruposMovPeriodBa>(entity =>
            {
                entity.HasKey(e => e.GrupoMovPeriodId)
                    .HasName("grupos_mov_period_ba_pk");

                entity.ToTable("grupos_mov_period_ba");

                entity.HasIndex(e => e.Nombre)
                    .HasName("grupos_mov_period_ba_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.GrupoMovPeriodId)
                    .HasColumnName("grupo_mov_period_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EsPredet)
                    .IsRequired()
                    .HasColumnName("es_predet")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GruposPagosElect>(entity =>
            {
                entity.HasKey(e => e.GrupoPagoElectId)
                    .HasName("grupos_pagos_elect_pk");

                entity.ToTable("grupos_pagos_elect");

                entity.HasIndex(e => e.Nombre)
                    .HasName("grupos_pagos_elect_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.GrupoPagoElectId)
                    .HasColumnName("grupo_pago_elect_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClaveLayout)
                    .IsRequired()
                    .HasColumnName("clave_layout")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaBanId).HasColumnName("cuenta_ban_id");

                entity.Property(e => e.EsPredet)
                    .HasColumnName("es_predet")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCtabanPredet)
                    .IsRequired()
                    .HasColumnName("tipo_ctaban_predet")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('D')");

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.CuentaBan)
                    .WithMany(p => p.GruposPagosElect)
                    .HasForeignKey(d => d.CuentaBanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ctaban_a_grupos_pagos_elect");
            });

            modelBuilder.Entity<GruposPolizasPeriodCo>(entity =>
            {
                entity.HasKey(e => e.GrupoPolPeriodId)
                    .HasName("grupos_pol_period_co_pk");

                entity.ToTable("grupos_polizas_period_co");

                entity.HasIndex(e => e.Nombre)
                    .HasName("grupos_pol_period_co_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.GrupoPolPeriodId)
                    .HasColumnName("grupo_pol_period_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EsPredet)
                    .HasColumnName("es_predet")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GruposRutas>(entity =>
            {
                entity.HasKey(e => e.GrupoRutasId)
                    .HasName("grupos_rutas_pk");

                entity.ToTable("grupos_rutas");

                entity.HasIndex(e => e.Nombre)
                    .HasName("grupos_rutas_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.GrupoRutasId)
                    .HasColumnName("grupo_rutas_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EsPredet)
                    .HasColumnName("es_predet")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.VersionRegistro).HasColumnName("version_registro");
            });

            modelBuilder.Entity<HistoriaCambiaria>(entity =>
            {
                entity.HasKey(e => e.HistoriaCambId)
                    .HasName("historia_camb_pk");

                entity.ToTable("historia_cambiaria");

                entity.HasIndex(e => new { e.MonedaId, e.Fecha })
                    .HasName("historia_camb_ak1")
                    .IsUnique()
                    .HasFilter("([moneda_id] IS NOT NULL AND [fecha] IS NOT NULL)");

                entity.Property(e => e.HistoriaCambId)
                    .HasColumnName("historia_camb_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.MonedaId).HasColumnName("moneda_id");

                entity.Property(e => e.TipoCambio)
                    .HasColumnName("tipo_cambio")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TipoCambioCobros)
                    .HasColumnName("tipo_cambio_cobros")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.Moneda)
                    .WithMany(p => p.HistoriaCambiaria)
                    .HasForeignKey(d => d.MonedaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("monedas_a_hist");
            });

            modelBuilder.Entity<IdsConver>(entity =>
            {
                entity.HasKey(e => new { e.TipoObjeto, e.ClaveObjeto })
                    .HasName("ids_conver_pk");

                entity.ToTable("ids_conver");

                entity.Property(e => e.TipoObjeto)
                    .HasColumnName("tipo_objeto")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ClaveObjeto)
                    .HasColumnName("clave_objeto")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ObjetoId).HasColumnName("objeto_id");
            });

            modelBuilder.Entity<ImagenesActivosFijos>(entity =>
            {
                entity.HasKey(e => e.ImagenActfijoId)
                    .HasName("imagenes_actfijos_pk");

                entity.ToTable("imagenes_activos_fijos");

                entity.Property(e => e.ImagenActfijoId)
                    .HasColumnName("imagen_actfijo_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActivoFijoId).HasColumnName("activo_fijo_id");

                entity.Property(e => e.Imagen)
                    .HasColumnName("imagen")
                    .IsUnicode(false);

                entity.Property(e => e.RolImagenActfijoId).HasColumnName("rol_imagen_actfijo_id");

                entity.HasOne(d => d.ActivoFijo)
                    .WithMany(p => p.ImagenesActivosFijos)
                    .HasForeignKey(d => d.ActivoFijoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("actfij_a_imagenes");
            });

            modelBuilder.Entity<ImagenesArticulos>(entity =>
            {
                entity.HasKey(e => e.ImagenArticuloId)
                    .HasName("imagenes_articulos_pk");

                entity.ToTable("imagenes_articulos");

                entity.Property(e => e.ImagenArticuloId)
                    .HasColumnName("imagen_articulo_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArticuloId).HasColumnName("articulo_id");

                entity.Property(e => e.Imagen)
                    .HasColumnName("imagen")
                    .IsUnicode(false);

                entity.Property(e => e.RolImagenArtId).HasColumnName("rol_imagen_art_id");

                entity.HasOne(d => d.Articulo)
                    .WithMany(p => p.ImagenesArticulos)
                    .HasForeignKey(d => d.ArticuloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("art_a_imagenes_art");
            });

            modelBuilder.Entity<ImagenesCajas>(entity =>
            {
                entity.HasKey(e => e.ImagenesCajaId)
                    .HasName("imagenes_cajas_pk");

                entity.ToTable("imagenes_cajas");

                entity.HasIndex(e => e.Nombre)
                    .HasName("imagenes_cajas_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.ImagenesCajaId)
                    .HasColumnName("imagenes_caja_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Activo)
                    .IsRequired()
                    .HasColumnName("activo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EsPredet)
                    .IsRequired()
                    .HasColumnName("es_predet")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TiempoEntreImagenes).HasColumnName("tiempo_entre_imagenes");

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ImagenesCajasDet>(entity =>
            {
                entity.HasKey(e => e.ImagenesCajaDetId)
                    .HasName("imagenes_caja_det_pk");

                entity.ToTable("imagenes_cajas_det");

                entity.Property(e => e.ImagenesCajaDetId)
                    .HasColumnName("imagenes_caja_det_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Activa)
                    .IsRequired()
                    .HasColumnName("activa")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Imagen)
                    .IsRequired()
                    .HasColumnName("imagen")
                    .IsUnicode(false);

                entity.Property(e => e.ImagenesCajaId).HasColumnName("imagenes_caja_id");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Posicion).HasColumnName("posicion");

                entity.HasOne(d => d.ImagenesCaja)
                    .WithMany(p => p.ImagenesCajasDet)
                    .HasForeignKey(d => d.ImagenesCajaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("imagenes_cajas_a_det");
            });

            modelBuilder.Entity<ImagenesClientes>(entity =>
            {
                entity.HasKey(e => e.ImagenClienteId)
                    .HasName("imagenes_clientes_pk");

                entity.ToTable("imagenes_clientes");

                entity.Property(e => e.ImagenClienteId)
                    .HasColumnName("imagen_cliente_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClienteId).HasColumnName("cliente_id");

                entity.Property(e => e.Imagen)
                    .HasColumnName("imagen")
                    .IsUnicode(false);

                entity.Property(e => e.RolImagenCliId).HasColumnName("rol_imagen_cli_id");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.ImagenesClientes)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cli_a_imagenes_cli");
            });

            modelBuilder.Entity<ImagenesEmpleados>(entity =>
            {
                entity.HasKey(e => e.ImagenEmpleadoId)
                    .HasName("imagenes_empleados_pk");

                entity.ToTable("imagenes_empleados");

                entity.Property(e => e.ImagenEmpleadoId)
                    .HasColumnName("imagen_empleado_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EmpleadoId).HasColumnName("empleado_id");

                entity.Property(e => e.Imagen)
                    .HasColumnName("imagen")
                    .IsUnicode(false);

                entity.Property(e => e.RolImagenEmpId).HasColumnName("rol_imagen_emp_id");

                entity.HasOne(d => d.Empleado)
                    .WithMany(p => p.ImagenesEmpleados)
                    .HasForeignKey(d => d.EmpleadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("emp_a_imagenes_emp");
            });

            modelBuilder.Entity<ImagenesProveedores>(entity =>
            {
                entity.HasKey(e => e.ImagenProvId)
                    .HasName("imagenes_proveedores_pk");

                entity.ToTable("imagenes_proveedores");

                entity.Property(e => e.ImagenProvId)
                    .HasColumnName("imagen_prov_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Imagen)
                    .HasColumnName("imagen")
                    .IsUnicode(false);

                entity.Property(e => e.ProveedorId).HasColumnName("proveedor_id");

                entity.Property(e => e.RolImagenProvId).HasColumnName("rol_imagen_prov_id");

                entity.HasOne(d => d.Proveedor)
                    .WithMany(p => p.ImagenesProveedores)
                    .HasForeignKey(d => d.ProveedorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("prov_a_imagenes_prov");
            });

            modelBuilder.Entity<ImportesDoctosCc>(entity =>
            {
                entity.HasKey(e => e.ImpteDoctoCcId)
                    .HasName("imptes_doctos_cc_pk");

                entity.ToTable("importes_doctos_cc");

                entity.Property(e => e.ImpteDoctoCcId)
                    .HasColumnName("impte_docto_cc_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aplicado)
                    .IsRequired()
                    .HasColumnName("aplicado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cancelado)
                    .HasColumnName("cancelado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DoctoCcAcrId).HasColumnName("docto_cc_acr_id");

                entity.Property(e => e.DoctoCcId).HasColumnName("docto_cc_id");

                entity.Property(e => e.DsctoPpag)
                    .HasColumnName("dscto_ppag")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Estatus)
                    .IsRequired()
                    .HasColumnName("estatus")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.Importe)
                    .HasColumnName("importe")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Impuesto)
                    .HasColumnName("impuesto")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.IsrRetenido)
                    .HasColumnName("isr_retenido")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.IvaRetenido)
                    .HasColumnName("iva_retenido")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.PctjeComisCob)
                    .HasColumnName("pctje_comis_cob")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.TipoImpte)
                    .HasColumnName("tipo_impte")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.DoctoCcAcr)
                    .WithMany(p => p.ImportesDoctosCcDoctoCcAcr)
                    .HasForeignKey(d => d.DoctoCcAcrId)
                    .HasConstraintName("cargo_afectado_cc");

                entity.HasOne(d => d.DoctoCc)
                    .WithMany(p => p.ImportesDoctosCcDoctoCc)
                    .HasForeignKey(d => d.DoctoCcId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("docto_padre_cc");
            });

            modelBuilder.Entity<ImportesDoctosCcImptos>(entity =>
            {
                entity.HasKey(e => e.ImpteDoctoCcImptoId)
                    .HasName("imptes_doctos_cc_imptos_pk");

                entity.ToTable("importes_doctos_cc_imptos");

                entity.HasIndex(e => new { e.ImpteDoctoCcId, e.ImpuestoId })
                    .HasName("imptes_doctos_cc_imptos_uq1")
                    .IsUnique()
                    .HasFilter("([impte_docto_cc_id] IS NOT NULL AND [impuesto_id] IS NOT NULL)");

                entity.Property(e => e.ImpteDoctoCcImptoId)
                    .HasColumnName("impte_docto_cc_impto_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Importe)
                    .HasColumnName("importe")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ImpteDoctoCcId).HasColumnName("impte_docto_cc_id");

                entity.Property(e => e.Impuesto)
                    .HasColumnName("impuesto")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ImpuestoId).HasColumnName("impuesto_id");

                entity.Property(e => e.PctjeImpuesto)
                    .HasColumnName("pctje_impuesto")
                    .HasColumnType("decimal(9, 6)");

                entity.HasOne(d => d.ImpteDoctoCc)
                    .WithMany(p => p.ImportesDoctosCcImptos)
                    .HasForeignKey(d => d.ImpteDoctoCcId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("imptes_doctos_cc_a_det_imp");

                entity.HasOne(d => d.ImpuestoNavigation)
                    .WithMany(p => p.ImportesDoctosCcImptos)
                    .HasForeignKey(d => d.ImpuestoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("imptos_a_imptes_doctos_cc_imp");
            });

            modelBuilder.Entity<ImportesDoctosCp>(entity =>
            {
                entity.HasKey(e => e.ImpteDoctoCpId)
                    .HasName("imptes_doctos_cp_pk");

                entity.ToTable("importes_doctos_cp");

                entity.Property(e => e.ImpteDoctoCpId)
                    .HasColumnName("impte_docto_cp_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aplicado)
                    .IsRequired()
                    .HasColumnName("aplicado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cancelado)
                    .HasColumnName("cancelado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DoctoCpAcrId).HasColumnName("docto_cp_acr_id");

                entity.Property(e => e.DoctoCpId).HasColumnName("docto_cp_id");

                entity.Property(e => e.DsctoPpag)
                    .HasColumnName("dscto_ppag")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Importe)
                    .HasColumnName("importe")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Impuesto)
                    .HasColumnName("impuesto")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.IsrRetenido)
                    .HasColumnName("isr_retenido")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.IvaRetenido)
                    .HasColumnName("iva_retenido")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.TipoImpte)
                    .HasColumnName("tipo_impte")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.DoctoCpAcr)
                    .WithMany(p => p.ImportesDoctosCpDoctoCpAcr)
                    .HasForeignKey(d => d.DoctoCpAcrId)
                    .HasConstraintName("cargo_afectado_cp");

                entity.HasOne(d => d.DoctoCp)
                    .WithMany(p => p.ImportesDoctosCpDoctoCp)
                    .HasForeignKey(d => d.DoctoCpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("docto_padre_cp");
            });

            modelBuilder.Entity<ImportesDoctosCpImptos>(entity =>
            {
                entity.HasKey(e => e.ImpteDoctoCpImptoId)
                    .HasName("imptes_doctos_cp_imptos_pk");

                entity.ToTable("importes_doctos_cp_imptos");

                entity.HasIndex(e => new { e.ImpteDoctoCpId, e.ImpuestoId })
                    .HasName("imptes_doctos_cp_imptos_uq1")
                    .IsUnique()
                    .HasFilter("([impte_docto_cp_id] IS NOT NULL AND [impuesto_id] IS NOT NULL)");

                entity.Property(e => e.ImpteDoctoCpImptoId)
                    .HasColumnName("impte_docto_cp_impto_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Importe)
                    .HasColumnName("importe")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ImpteDoctoCpId).HasColumnName("impte_docto_cp_id");

                entity.Property(e => e.Impuesto)
                    .HasColumnName("impuesto")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ImpuestoId).HasColumnName("impuesto_id");

                entity.Property(e => e.PctjeImpuesto)
                    .HasColumnName("pctje_impuesto")
                    .HasColumnType("decimal(9, 6)");

                entity.HasOne(d => d.ImpteDoctoCp)
                    .WithMany(p => p.ImportesDoctosCpImptos)
                    .HasForeignKey(d => d.ImpteDoctoCpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("imptes_doctos_cp_a_det_imp");

                entity.HasOne(d => d.ImpuestoNavigation)
                    .WithMany(p => p.ImportesDoctosCpImptos)
                    .HasForeignKey(d => d.ImpuestoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("imptos_a_imptes_doctos_cp_imp");
            });

            modelBuilder.Entity<ImportesDoctosPendCc>(entity =>
            {
                entity.HasKey(e => e.ImpteDoctoPendCcId)
                    .HasName("imptes_doctos_pend_cc_pk");

                entity.ToTable("importes_doctos_pend_cc");

                entity.Property(e => e.ImpteDoctoPendCcId)
                    .HasColumnName("impte_docto_pend_cc_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConceptoDoctoAcrId).HasColumnName("concepto_docto_acr_id");

                entity.Property(e => e.DoctoCcAcrId).HasColumnName("docto_cc_acr_id");

                entity.Property(e => e.DoctoPendCcId).HasColumnName("docto_pend_cc_id");

                entity.Property(e => e.DsctoPpag)
                    .HasColumnName("dscto_ppag")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.FolioDoctoAcr)
                    .HasColumnName("folio_docto_acr")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Importe)
                    .HasColumnName("importe")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Impuesto)
                    .HasColumnName("impuesto")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.IsrRetenido)
                    .HasColumnName("isr_retenido")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.IvaRetenido)
                    .HasColumnName("iva_retenido")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.PctjeComisCob)
                    .HasColumnName("pctje_comis_cob")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.TipoImpte)
                    .HasColumnName("tipo_impte")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.ConceptoDoctoAcr)
                    .WithMany(p => p.ImportesDoctosPendCc)
                    .HasForeignKey(d => d.ConceptoDoctoAcrId)
                    .HasConstraintName("concep_a_imptes_doc_pend_cc");

                entity.HasOne(d => d.DoctoCcAcr)
                    .WithMany(p => p.ImportesDoctosPendCc)
                    .HasForeignKey(d => d.DoctoCcAcrId)
                    .HasConstraintName("cargo_acreditado_cc");

                entity.HasOne(d => d.DoctoPendCc)
                    .WithMany(p => p.ImportesDoctosPendCc)
                    .HasForeignKey(d => d.DoctoPendCcId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("docto_pend_padre_cc");
            });

            modelBuilder.Entity<Impuestos>(entity =>
            {
                entity.HasKey(e => e.ImpuestoId)
                    .HasName("impuestos_pk");

                entity.ToTable("impuestos");

                entity.HasIndex(e => e.Nombre)
                    .HasName("impuestos_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.ImpuestoId)
                    .HasColumnName("impuesto_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CuentaEnCompras)
                    .HasColumnName("cuenta_en_compras")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaEnVentas)
                    .HasColumnName("cuenta_en_ventas")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EsPredet)
                    .HasColumnName("es_predet")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.ImporteUnitario)
                    .HasColumnName("importe_unitario")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PctjeImpuesto)
                    .HasColumnName("pctje_impuesto")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.TipoCalc)
                    .IsRequired()
                    .HasColumnName("tipo_calc")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e.TipoImptoId).HasColumnName("tipo_impto_id");

                entity.Property(e => e.TipoIva)
                    .HasColumnName("tipo_iva")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UnidadImpto)
                    .HasColumnName("unidad_impto")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.TipoImpto)
                    .WithMany(p => p.Impuestos)
                    .HasForeignKey(d => d.TipoImptoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tipos_imptos_a_imptos");
            });

            modelBuilder.Entity<ImpuestosArticulos>(entity =>
            {
                entity.HasKey(e => e.ImpuestoArtId)
                    .HasName("impuestos_articulos_pk");

                entity.ToTable("impuestos_articulos");

                entity.HasIndex(e => new { e.ArticuloId, e.ImpuestoId })
                    .HasName("impuestos_articulos_ak1")
                    .IsUnique()
                    .HasFilter("([articulo_id] IS NOT NULL AND [impuesto_id] IS NOT NULL)");

                entity.Property(e => e.ImpuestoArtId)
                    .HasColumnName("impuesto_art_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArticuloId).HasColumnName("articulo_id");

                entity.Property(e => e.ImpuestoId).HasColumnName("impuesto_id");

                entity.Property(e => e.UnidadesImpuesto)
                    .HasColumnName("unidades_impuesto")
                    .HasColumnType("decimal(18, 5)");

                entity.HasOne(d => d.Articulo)
                    .WithMany(p => p.ImpuestosArticulos)
                    .HasForeignKey(d => d.ArticuloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("arts_a_imptos_art");

                entity.HasOne(d => d.Impuesto)
                    .WithMany(p => p.ImpuestosArticulos)
                    .HasForeignKey(d => d.ImpuestoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("imptos_a_imptos_art");
            });

            modelBuilder.Entity<ImpuestosDoctosCm>(entity =>
            {
                entity.HasKey(e => new { e.DoctoCmId, e.ImpuestoId })
                    .HasName("impuestos_doctos_cm_pk");

                entity.ToTable("impuestos_doctos_cm");

                entity.Property(e => e.DoctoCmId).HasColumnName("docto_cm_id");

                entity.Property(e => e.ImpuestoId).HasColumnName("impuesto_id");

                entity.Property(e => e.CompraNeta)
                    .HasColumnName("compra_neta")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ImporteImpuesto)
                    .HasColumnName("importe_impuesto")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ImporteUnitarioImpuesto)
                    .HasColumnName("importe_unitario_impuesto")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.OtrosImpuestos)
                    .HasColumnName("otros_impuestos")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.PctjeImpuesto)
                    .HasColumnName("pctje_impuesto")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.UnidadesImpuesto).HasColumnName("unidades_impuesto");

                entity.HasOne(d => d.DoctoCm)
                    .WithMany(p => p.ImpuestosDoctosCm)
                    .HasForeignKey(d => d.DoctoCmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_cm_a_imptos_doctos");

                entity.HasOne(d => d.Impuesto)
                    .WithMany(p => p.ImpuestosDoctosCm)
                    .HasForeignKey(d => d.ImpuestoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("imptos_a_imptos_doctos_cm");
            });

            modelBuilder.Entity<ImpuestosDoctosCmDet>(entity =>
            {
                entity.HasKey(e => new { e.DoctoCmId, e.DoctoCmDetId, e.ImpuestoId })
                    .HasName("impuestos_doctos_cm_det_pk");

                entity.ToTable("impuestos_doctos_cm_det");

                entity.Property(e => e.DoctoCmId).HasColumnName("docto_cm_id");

                entity.Property(e => e.DoctoCmDetId).HasColumnName("docto_cm_det_id");

                entity.Property(e => e.ImpuestoId).HasColumnName("impuesto_id");

                entity.Property(e => e.CompraNeta)
                    .HasColumnName("compra_neta")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.IdInternoTipoImpto)
                    .HasColumnName("id_interno_tipo_impto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ImporteImpuesto)
                    .HasColumnName("importe_impuesto")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ImporteUnitarioImpuesto)
                    .HasColumnName("importe_unitario_impuesto")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.OtrosImpuestos)
                    .HasColumnName("otros_impuestos")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.PctjeImpuesto)
                    .HasColumnName("pctje_impuesto")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.TipoCalc)
                    .IsRequired()
                    .HasColumnName("tipo_calc")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UnidadesImpuesto).HasColumnName("unidades_impuesto");

                entity.HasOne(d => d.Impuesto)
                    .WithMany(p => p.ImpuestosDoctosCmDet)
                    .HasForeignKey(d => d.ImpuestoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("imptos_a_imptos_doctos_cm_det");
            });

            modelBuilder.Entity<ImpuestosDoctosPv>(entity =>
            {
                entity.HasKey(e => new { e.DoctoPvId, e.ImpuestoId })
                    .HasName("impuestos_doctos_pv_pk");

                entity.ToTable("impuestos_doctos_pv");

                entity.Property(e => e.DoctoPvId).HasColumnName("docto_pv_id");

                entity.Property(e => e.ImpuestoId).HasColumnName("impuesto_id");

                entity.Property(e => e.ImporteImpuesto)
                    .HasColumnName("importe_impuesto")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ImporteUnitarioImpuesto)
                    .HasColumnName("importe_unitario_impuesto")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.OtrosImpuestos)
                    .HasColumnName("otros_impuestos")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.PctjeImpuesto)
                    .HasColumnName("pctje_impuesto")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.UnidadesImpuesto).HasColumnName("unidades_impuesto");

                entity.Property(e => e.VentaBruta)
                    .HasColumnName("venta_bruta")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.VentaNeta)
                    .HasColumnName("venta_neta")
                    .HasColumnType("decimal(15, 2)");

                entity.HasOne(d => d.DoctoPv)
                    .WithMany(p => p.ImpuestosDoctosPv)
                    .HasForeignKey(d => d.DoctoPvId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_pv_a_imptos_doctos");

                entity.HasOne(d => d.Impuesto)
                    .WithMany(p => p.ImpuestosDoctosPv)
                    .HasForeignKey(d => d.ImpuestoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("imptos_a_imptos_doctos_pv");
            });

            modelBuilder.Entity<ImpuestosDoctosPvDet>(entity =>
            {
                entity.HasKey(e => new { e.DoctoPvId, e.DoctoPvDetId, e.ImpuestoId })
                    .HasName("impuestos_doctos_pv_det_pk");

                entity.ToTable("impuestos_doctos_pv_det");

                entity.Property(e => e.DoctoPvId).HasColumnName("docto_pv_id");

                entity.Property(e => e.DoctoPvDetId).HasColumnName("docto_pv_det_id");

                entity.Property(e => e.ImpuestoId).HasColumnName("impuesto_id");

                entity.Property(e => e.IdInternoTipoImpto)
                    .HasColumnName("id_interno_tipo_impto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ImporteImpuesto)
                    .HasColumnName("importe_impuesto")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ImporteImpuestoBruto)
                    .HasColumnName("importe_impuesto_bruto")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ImporteUnitarioImpuesto)
                    .HasColumnName("importe_unitario_impuesto")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.OtrosImpuestos)
                    .HasColumnName("otros_impuestos")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.PctjeImpuesto)
                    .HasColumnName("pctje_impuesto")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.TipoCalc)
                    .IsRequired()
                    .HasColumnName("tipo_calc")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UnidadesImpuesto).HasColumnName("unidades_impuesto");

                entity.Property(e => e.VentaBruta)
                    .HasColumnName("venta_bruta")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.VentaNeta)
                    .HasColumnName("venta_neta")
                    .HasColumnType("decimal(15, 2)");

                entity.HasOne(d => d.Impuesto)
                    .WithMany(p => p.ImpuestosDoctosPvDet)
                    .HasForeignKey(d => d.ImpuestoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("imptos_a_imptos_doctos_pv_det");
            });

            modelBuilder.Entity<ImpuestosDoctosVe>(entity =>
            {
                entity.HasKey(e => new { e.DoctoVeId, e.ImpuestoId })
                    .HasName("impuestos_doctos_ve_pk");

                entity.ToTable("impuestos_doctos_ve");

                entity.Property(e => e.DoctoVeId).HasColumnName("docto_ve_id");

                entity.Property(e => e.ImpuestoId).HasColumnName("impuesto_id");

                entity.Property(e => e.ImporteImpuesto)
                    .HasColumnName("importe_impuesto")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ImporteUnitarioImpuesto)
                    .HasColumnName("importe_unitario_impuesto")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.OtrosImpuestos)
                    .HasColumnName("otros_impuestos")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.PctjeImpuesto)
                    .HasColumnName("pctje_impuesto")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.UnidadesImpuesto).HasColumnName("unidades_impuesto");

                entity.Property(e => e.VentaBruta)
                    .HasColumnName("venta_bruta")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.VentaNeta)
                    .HasColumnName("venta_neta")
                    .HasColumnType("decimal(15, 2)");

                entity.HasOne(d => d.DoctoVe)
                    .WithMany(p => p.ImpuestosDoctosVe)
                    .HasForeignKey(d => d.DoctoVeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_ve_a_imptos_doctos");

                entity.HasOne(d => d.Impuesto)
                    .WithMany(p => p.ImpuestosDoctosVe)
                    .HasForeignKey(d => d.ImpuestoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("imptos_a_imptos_doctos");
            });

            modelBuilder.Entity<ImpuestosDoctosVeDet>(entity =>
            {
                entity.HasKey(e => new { e.DoctoVeId, e.DoctoVeDetId, e.ImpuestoId })
                    .HasName("impuestos_doctos_ve_det_pk");

                entity.ToTable("impuestos_doctos_ve_det");

                entity.Property(e => e.DoctoVeId).HasColumnName("docto_ve_id");

                entity.Property(e => e.DoctoVeDetId).HasColumnName("docto_ve_det_id");

                entity.Property(e => e.ImpuestoId).HasColumnName("impuesto_id");

                entity.Property(e => e.IdInternoTipoImpto)
                    .HasColumnName("id_interno_tipo_impto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ImporteImpuesto)
                    .HasColumnName("importe_impuesto")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ImporteImpuestoBruto)
                    .HasColumnName("importe_impuesto_bruto")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ImporteUnitarioImpuesto)
                    .HasColumnName("importe_unitario_impuesto")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.OtrosImpuestos)
                    .HasColumnName("otros_impuestos")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.PctjeImpuesto)
                    .HasColumnName("pctje_impuesto")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.TipoCalc)
                    .IsRequired()
                    .HasColumnName("tipo_calc")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UnidadesImpuesto).HasColumnName("unidades_impuesto");

                entity.Property(e => e.VentaBruta)
                    .HasColumnName("venta_bruta")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.VentaNeta)
                    .HasColumnName("venta_neta")
                    .HasColumnType("decimal(15, 2)");

                entity.HasOne(d => d.Impuesto)
                    .WithMany(p => p.ImpuestosDoctosVeDet)
                    .HasForeignKey(d => d.ImpuestoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("imptos_a_imptos_doctos_ve_det");
            });

            modelBuilder.Entity<ImpuestosGravados>(entity =>
            {
                entity.HasKey(e => new { e.TipoImptoId, e.TipoImptoGravadoId })
                    .HasName("impuestos_gravados_pk");

                entity.ToTable("impuestos_gravados");

                entity.Property(e => e.TipoImptoId).HasColumnName("tipo_impto_id");

                entity.Property(e => e.TipoImptoGravadoId).HasColumnName("tipo_impto_gravado_id");

                entity.HasOne(d => d.TipoImptoGravado)
                    .WithMany(p => p.ImpuestosGravadosTipoImptoGravado)
                    .HasForeignKey(d => d.TipoImptoGravadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("imptos_gravados_ids");

                entity.HasOne(d => d.TipoImpto)
                    .WithMany(p => p.ImpuestosGravadosTipoImpto)
                    .HasForeignKey(d => d.TipoImptoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("imptos_que_gravan_imptos");
            });

            modelBuilder.Entity<Incapacidades>(entity =>
            {
                entity.HasKey(e => e.IncapacidadId)
                    .HasName("incapacidades_pk");

                entity.ToTable("incapacidades");

                entity.HasIndex(e => new { e.EmpleadoId, e.Fecha })
                    .HasName("incapacidades_ak1")
                    .IsUnique()
                    .HasFilter("([empleado_id] IS NOT NULL AND [fecha] IS NOT NULL)");

                entity.Property(e => e.IncapacidadId)
                    .HasColumnName("incapacidad_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ControlIncap)
                    .HasColumnName("control_incap")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Dias).HasColumnName("dias");

                entity.Property(e => e.EmpleadoId).HasColumnName("empleado_id");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Folio)
                    .HasColumnName("folio")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Porcentaje)
                    .HasColumnName("porcentaje")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.Ramo)
                    .IsRequired()
                    .HasColumnName("ramo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('R')");

                entity.Property(e => e.Secuela)
                    .HasColumnName("secuela")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoRiesgo)
                    .HasColumnName("tipo_riesgo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.Empleado)
                    .WithMany(p => p.Incapacidades)
                    .HasForeignKey(d => d.EmpleadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("emp_a_incapa");
            });

            modelBuilder.Entity<Incidencias>(entity =>
            {
                entity.HasKey(e => e.IncidenciaId)
                    .HasName("incidencias_pk");

                entity.ToTable("incidencias");

                entity.HasIndex(e => new { e.Fecha, e.Tipo })
                    .HasName("incidencias_ie1");

                entity.HasIndex(e => new { e.EmpleadoId, e.Fecha, e.Tipo })
                    .HasName("incidencias_ak1")
                    .IsUnique()
                    .HasFilter("([empleado_id] IS NOT NULL AND [fecha] IS NOT NULL AND [tipo] IS NOT NULL)");

                entity.Property(e => e.IncidenciaId)
                    .HasColumnName("incidencia_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CausaBaja)
                    .HasColumnName("causa_baja")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmpleadoId).HasColumnName("empleado_id");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.FormaEmitida)
                    .HasColumnName("forma_emitida")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NuevoRegPatronalId).HasColumnName("nuevo_reg_patronal_id");

                entity.Property(e => e.PctjeInteg)
                    .HasColumnName("pctje_integ")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.PercepVarDiaria)
                    .HasColumnName("percep_var_diaria")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.RegPatronalId).HasColumnName("reg_patronal_id");

                entity.Property(e => e.SalarioDiario)
                    .HasColumnName("salario_diario")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.SalarioHora)
                    .HasColumnName("salario_hora")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.SalarioInteg)
                    .HasColumnName("salario_integ")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.SalintDefault)
                    .IsRequired()
                    .HasColumnName("salint_default")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoSalario)
                    .HasColumnName("tipo_salario")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.Empleado)
                    .WithMany(p => p.Incidencias)
                    .HasForeignKey(d => d.EmpleadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("emp_a_incide");

                entity.HasOne(d => d.NuevoRegPatronal)
                    .WithMany(p => p.IncidenciasNuevoRegPatronal)
                    .HasForeignKey(d => d.NuevoRegPatronalId)
                    .HasConstraintName("reg_patronales_a_incide_2");

                entity.HasOne(d => d.RegPatronal)
                    .WithMany(p => p.IncidenciasRegPatronal)
                    .HasForeignKey(d => d.RegPatronalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("reg_patronales_a_incide");
            });

            modelBuilder.Entity<Inpc>(entity =>
            {
                entity.HasKey(e => new { e.Ano, e.Mes })
                    .HasName("inpc_pk");

                entity.ToTable("inpc");

                entity.Property(e => e.Ano).HasColumnName("ano");

                entity.Property(e => e.Mes).HasColumnName("mes");

                entity.Property(e => e.Indice)
                    .HasColumnName("indice")
                    .HasColumnType("decimal(14, 8)");
            });

            modelBuilder.Entity<JuegosAEnsamblar>(entity =>
            {
                entity.HasKey(e => new { e.ReporteId, e.JuegoId })
                    .HasName("juegos_a_ensamblar_pk");

                entity.ToTable("juegos_a_ensamblar");

                entity.Property(e => e.ReporteId).HasColumnName("reporte_id");

                entity.Property(e => e.JuegoId).HasColumnName("juego_id");

                entity.Property(e => e.Unidades)
                    .HasColumnName("unidades")
                    .HasColumnType("decimal(18, 5)");

                entity.HasOne(d => d.Juego)
                    .WithMany(p => p.JuegosAEnsamblar)
                    .HasForeignKey(d => d.JuegoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("arts_a_juegos_ens");
            });

            modelBuilder.Entity<JuegosDet>(entity =>
            {
                entity.HasKey(e => new { e.ArticuloId, e.ComponenteId })
                    .HasName("juegos_det_pk");

                entity.ToTable("juegos_det");

                entity.Property(e => e.ArticuloId).HasColumnName("articulo_id");

                entity.Property(e => e.ComponenteId).HasColumnName("componente_id");

                entity.Property(e => e.ClaveArticuloId).HasColumnName("clave_articulo_id");

                entity.Property(e => e.EsReemplazable)
                    .HasColumnName("es_reemplazable")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PermitirModifUnid)
                    .HasColumnName("permitir_modif_unid")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Unidades)
                    .HasColumnName("unidades")
                    .HasColumnType("decimal(18, 5)");

                entity.HasOne(d => d.Articulo)
                    .WithMany(p => p.JuegosDetArticulo)
                    .HasForeignKey(d => d.ArticuloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("art_a_juegos");

                entity.HasOne(d => d.ClaveArticulo)
                    .WithMany(p => p.JuegosDet)
                    .HasForeignKey(d => d.ClaveArticuloId)
                    .HasConstraintName("claves_art_a_juegos_det");

                entity.HasOne(d => d.Componente)
                    .WithMany(p => p.JuegosDetComponente)
                    .HasForeignKey(d => d.ComponenteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("arts_a_juegos_det");
            });

            modelBuilder.Entity<LibresActFijos>(entity =>
            {
                entity.HasKey(e => e.ActivoFijoId)
                    .HasName("libres_actfijos_pk");

                entity.ToTable("libres_act_fijos");

                entity.Property(e => e.ActivoFijoId)
                    .HasColumnName("activo_fijo_id")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.ActivoFijo)
                    .WithOne(p => p.LibresActFijos)
                    .HasForeignKey<LibresActFijos>(d => d.ActivoFijoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("actfijos_a_libres");
            });

            modelBuilder.Entity<LibresArticulos>(entity =>
            {
                entity.HasKey(e => e.ArticuloId)
                    .HasName("libres_articulos_pk");

                entity.ToTable("libres_articulos");

                entity.Property(e => e.ArticuloId)
                    .HasColumnName("articulo_id")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.Articulo)
                    .WithOne(p => p.LibresArticulos)
                    .HasForeignKey<LibresArticulos>(d => d.ArticuloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("articulos_a_libres");
            });

            modelBuilder.Entity<LibresCargosCc>(entity =>
            {
                entity.HasKey(e => e.DoctoCcId)
                    .HasName("libres_cargos_cc_pk");

                entity.ToTable("libres_cargos_cc");

                entity.Property(e => e.DoctoCcId)
                    .HasColumnName("docto_cc_id")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.DoctoCc)
                    .WithOne(p => p.LibresCargosCc)
                    .HasForeignKey<LibresCargosCc>(d => d.DoctoCcId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_cc_a_libres_cargos");
            });

            modelBuilder.Entity<LibresCargosCp>(entity =>
            {
                entity.HasKey(e => e.DoctoCpId)
                    .HasName("libres_cargos_cp_pk");

                entity.ToTable("libres_cargos_cp");

                entity.Property(e => e.DoctoCpId)
                    .HasColumnName("docto_cp_id")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.DoctoCp)
                    .WithOne(p => p.LibresCargosCp)
                    .HasForeignKey<LibresCargosCp>(d => d.DoctoCpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_cp_a_libres_cargos");
            });

            modelBuilder.Entity<LibresCargosPerCc>(entity =>
            {
                entity.HasKey(e => e.CargoPeriodId)
                    .HasName("libres_cargos_per_cc_pk");

                entity.ToTable("libres_cargos_per_cc");

                entity.Property(e => e.CargoPeriodId)
                    .HasColumnName("cargo_period_id")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.CargoPeriod)
                    .WithOne(p => p.LibresCargosPerCc)
                    .HasForeignKey<LibresCargosPerCc>(d => d.CargoPeriodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cargos_per_cc_a_libres");
            });

            modelBuilder.Entity<LibresClientes>(entity =>
            {
                entity.HasKey(e => e.ClienteId)
                    .HasName("libres_clientes_pk");

                entity.ToTable("libres_clientes");

                entity.Property(e => e.ClienteId)
                    .HasColumnName("cliente_id")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.Cliente)
                    .WithOne(p => p.LibresClientes)
                    .HasForeignKey<LibresClientes>(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("clientes_a_libres");
            });

            modelBuilder.Entity<LibresComCm>(entity =>
            {
                entity.HasKey(e => e.DoctoCmId)
                    .HasName("libres_com_cm_pk");

                entity.ToTable("libres_com_cm");

                entity.Property(e => e.DoctoCmId)
                    .HasColumnName("docto_cm_id")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.DoctoCm)
                    .WithOne(p => p.LibresComCm)
                    .HasForeignKey<LibresComCm>(d => d.DoctoCmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_cm_a_libres_com");
            });

            modelBuilder.Entity<LibresCotVe>(entity =>
            {
                entity.HasKey(e => e.DoctoVeId)
                    .HasName("libres_cot_ve_pk");

                entity.ToTable("libres_cot_ve");

                entity.Property(e => e.DoctoVeId)
                    .HasColumnName("docto_ve_id")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.DoctoVe)
                    .WithOne(p => p.LibresCotVe)
                    .HasForeignKey<LibresCotVe>(d => d.DoctoVeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_ve_a_libres_cot");
            });

            modelBuilder.Entity<LibresCreditosCc>(entity =>
            {
                entity.HasKey(e => e.DoctoCcId)
                    .HasName("libres_creditos_cc_pk");

                entity.ToTable("libres_creditos_cc");

                entity.Property(e => e.DoctoCcId)
                    .HasColumnName("docto_cc_id")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.DoctoCc)
                    .WithOne(p => p.LibresCreditosCc)
                    .HasForeignKey<LibresCreditosCc>(d => d.DoctoCcId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_cc_a_libres_creditos");
            });

            modelBuilder.Entity<LibresCreditosCp>(entity =>
            {
                entity.HasKey(e => e.DoctoCpId)
                    .HasName("libres_creditos_cp_pk");

                entity.ToTable("libres_creditos_cp");

                entity.Property(e => e.DoctoCpId)
                    .HasColumnName("docto_cp_id")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.DoctoCp)
                    .WithOne(p => p.LibresCreditosCp)
                    .HasForeignKey<LibresCreditosCp>(d => d.DoctoCpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_cp_a_libres_creditos");
            });

            modelBuilder.Entity<LibresCtasBan>(entity =>
            {
                entity.HasKey(e => e.CuentaBanId)
                    .HasName("libres_ctas_ban_pk");

                entity.ToTable("libres_ctas_ban");

                entity.Property(e => e.CuentaBanId)
                    .HasColumnName("cuenta_ban_id")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.CuentaBan)
                    .WithOne(p => p.LibresCtasBan)
                    .HasForeignKey<LibresCtasBan>(d => d.CuentaBanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ctaban_a_libres");
            });

            modelBuilder.Entity<LibresCuentasCo>(entity =>
            {
                entity.HasKey(e => e.CuentaId)
                    .HasName("libres_cuentas_co_pk");

                entity.ToTable("libres_cuentas_co");

                entity.Property(e => e.CuentaId)
                    .HasColumnName("cuenta_id")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.Cuenta)
                    .WithOne(p => p.LibresCuentasCo)
                    .HasForeignKey<LibresCuentasCo>(d => d.CuentaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cuentas_co_a_libres");
            });

            modelBuilder.Entity<LibresDevcomCm>(entity =>
            {
                entity.HasKey(e => e.DoctoCmId)
                    .HasName("libres_devcom_cm_pk");

                entity.ToTable("libres_devcom_cm");

                entity.Property(e => e.DoctoCmId)
                    .HasColumnName("docto_cm_id")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.DoctoCm)
                    .WithOne(p => p.LibresDevcomCm)
                    .HasForeignKey<LibresDevcomCm>(d => d.DoctoCmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_cm_a_libres_devcom");
            });

            modelBuilder.Entity<LibresDevfacVe>(entity =>
            {
                entity.HasKey(e => e.DoctoVeId)
                    .HasName("libres_devfac_ve_pk");

                entity.ToTable("libres_devfac_ve");

                entity.Property(e => e.DoctoVeId)
                    .HasColumnName("docto_ve_id")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.DoctoVe)
                    .WithOne(p => p.LibresDevfacVe)
                    .HasForeignKey<LibresDevfacVe>(d => d.DoctoVeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_ve_a_libres_devfac");
            });

            modelBuilder.Entity<LibresDevrecCm>(entity =>
            {
                entity.HasKey(e => e.DoctoCmId)
                    .HasName("libres_devrec_cm_pk");

                entity.ToTable("libres_devrec_cm");

                entity.Property(e => e.DoctoCmId)
                    .HasColumnName("docto_cm_id")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.DoctoCm)
                    .WithOne(p => p.LibresDevrecCm)
                    .HasForeignKey<LibresDevrecCm>(d => d.DoctoCmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_cm_a_libres_devrec");
            });

            modelBuilder.Entity<LibresDevremVe>(entity =>
            {
                entity.HasKey(e => e.DoctoVeId)
                    .HasName("libres_devrem_ve_pk");

                entity.ToTable("libres_devrem_ve");

                entity.Property(e => e.DoctoVeId)
                    .HasColumnName("docto_ve_id")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.DoctoVe)
                    .WithOne(p => p.LibresDevremVe)
                    .HasForeignKey<LibresDevremVe>(d => d.DoctoVeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_ve_a_libres_devrem");
            });

            modelBuilder.Entity<LibresEmpleados>(entity =>
            {
                entity.HasKey(e => e.EmpleadoId)
                    .HasName("libres_empleados_pk");

                entity.ToTable("libres_empleados");

                entity.Property(e => e.EmpleadoId)
                    .HasColumnName("empleado_id")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.Empleado)
                    .WithOne(p => p.LibresEmpleados)
                    .HasForeignKey<LibresEmpleados>(d => d.EmpleadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("empleados_a_libres");
            });

            modelBuilder.Entity<LibresEntradasIn>(entity =>
            {
                entity.HasKey(e => e.DoctoInId)
                    .HasName("libres_entradas_in_pk");

                entity.ToTable("libres_entradas_in");

                entity.Property(e => e.DoctoInId)
                    .HasColumnName("docto_in_id")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.DoctoIn)
                    .WithOne(p => p.LibresEntradasIn)
                    .HasForeignKey<LibresEntradasIn>(d => d.DoctoInId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_in_a_libres_entradas");
            });

            modelBuilder.Entity<LibresFacVe>(entity =>
            {
                entity.HasKey(e => e.DoctoVeId)
                    .HasName("libres_fac_ve_pk");

                entity.ToTable("libres_fac_ve");

                entity.Property(e => e.DoctoVeId)
                    .HasColumnName("docto_ve_id")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.DoctoVe)
                    .WithOne(p => p.LibresFacVe)
                    .HasForeignKey<LibresFacVe>(d => d.DoctoVeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_ve_a_libres_fac");
            });

            modelBuilder.Entity<LibresInvfis>(entity =>
            {
                entity.HasKey(e => e.DoctoInvfisId)
                    .HasName("libres_invfis_pk");

                entity.ToTable("libres_invfis");

                entity.Property(e => e.DoctoInvfisId)
                    .HasColumnName("docto_invfis_id")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.DoctoInvfis)
                    .WithOne(p => p.LibresInvfis)
                    .HasForeignKey<LibresInvfis>(d => d.DoctoInvfisId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_invfis_a_libres");
            });

            modelBuilder.Entity<LibresOcoCm>(entity =>
            {
                entity.HasKey(e => e.DoctoCmId)
                    .HasName("libres_oco_cm_pk");

                entity.ToTable("libres_oco_cm");

                entity.Property(e => e.DoctoCmId)
                    .HasColumnName("docto_cm_id")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.DoctoCm)
                    .WithOne(p => p.LibresOcoCm)
                    .HasForeignKey<LibresOcoCm>(d => d.DoctoCmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_cm_a_libres_oco");
            });

            modelBuilder.Entity<LibresOrdvtaPv>(entity =>
            {
                entity.HasKey(e => e.DoctoPvId)
                    .HasName("libres_ordvta_pv_pk");

                entity.ToTable("libres_ordvta_pv");

                entity.Property(e => e.DoctoPvId)
                    .HasColumnName("docto_pv_id")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.DoctoPv)
                    .WithOne(p => p.LibresOrdvtaPv)
                    .HasForeignKey<LibresOrdvtaPv>(d => d.DoctoPvId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_pv_a_libres_ordvta");
            });

            modelBuilder.Entity<LibresPedVe>(entity =>
            {
                entity.HasKey(e => e.DoctoVeId)
                    .HasName("libres_ped_ve_pk");

                entity.ToTable("libres_ped_ve");

                entity.Property(e => e.DoctoVeId)
                    .HasColumnName("docto_ve_id")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.DoctoVe)
                    .WithOne(p => p.LibresPedVe)
                    .HasForeignKey<LibresPedVe>(d => d.DoctoVeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_ve_a_libres_ped");
            });

            modelBuilder.Entity<LibresPolCo>(entity =>
            {
                entity.HasKey(e => e.DoctoCoId)
                    .HasName("libres_pol_co_pk");

                entity.ToTable("libres_pol_co");

                entity.Property(e => e.DoctoCoId)
                    .HasColumnName("docto_co_id")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.DoctoCo)
                    .WithOne(p => p.LibresPolCo)
                    .HasForeignKey<LibresPolCo>(d => d.DoctoCoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_co_a_libres_pol");
            });

            modelBuilder.Entity<LibresProveedor>(entity =>
            {
                entity.HasKey(e => e.ProveedorId)
                    .HasName("libres_proveedor_pk");

                entity.ToTable("libres_proveedor");

                entity.Property(e => e.ProveedorId)
                    .HasColumnName("proveedor_id")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.Proveedor)
                    .WithOne(p => p.LibresProveedor)
                    .HasForeignKey<LibresProveedor>(d => d.ProveedorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("proveedores_a_libres");
            });

            modelBuilder.Entity<LibresRecCm>(entity =>
            {
                entity.HasKey(e => e.DoctoCmId)
                    .HasName("libres_rec_cm_pk");

                entity.ToTable("libres_rec_cm");

                entity.Property(e => e.DoctoCmId)
                    .HasColumnName("docto_cm_id")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.DoctoCm)
                    .WithOne(p => p.LibresRecCm)
                    .HasForeignKey<LibresRecCm>(d => d.DoctoCmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_cm_a_libres_rec");
            });

            modelBuilder.Entity<LibresRemVe>(entity =>
            {
                entity.HasKey(e => e.DoctoVeId)
                    .HasName("libres_rem_ve_pk");

                entity.ToTable("libres_rem_ve");

                entity.Property(e => e.DoctoVeId)
                    .HasColumnName("docto_ve_id")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.DoctoVe)
                    .WithOne(p => p.LibresRemVe)
                    .HasForeignKey<LibresRemVe>(d => d.DoctoVeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_ve_a_libres_rem");
            });

            modelBuilder.Entity<LibresSalidasIn>(entity =>
            {
                entity.HasKey(e => e.DoctoInId)
                    .HasName("libres_salidas_in_pk");

                entity.ToTable("libres_salidas_in");

                entity.Property(e => e.DoctoInId)
                    .HasColumnName("docto_in_id")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.DoctoIn)
                    .WithOne(p => p.LibresSalidasIn)
                    .HasForeignKey<LibresSalidasIn>(d => d.DoctoInId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_in_a_libres_salidas");
            });

            modelBuilder.Entity<LineasArticulos>(entity =>
            {
                entity.HasKey(e => e.LineaArticuloId)
                    .HasName("lineas_articulos_pk");

                entity.ToTable("lineas_articulos");

                entity.HasIndex(e => e.Nombre)
                    .HasName("lineas_articulos_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.LineaArticuloId)
                    .HasColumnName("linea_articulo_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AplicarFactorVenta)
                    .IsRequired()
                    .HasColumnName("aplicar_factor_venta")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CuentaAlmacen)
                    .HasColumnName("cuenta_almacen")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaCompras)
                    .HasColumnName("cuenta_compras")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaCostoVenta)
                    .HasColumnName("cuenta_costo_venta")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaDevolCompras)
                    .HasColumnName("cuenta_devol_compras")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaDevolVentas)
                    .HasColumnName("cuenta_devol_ventas")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaVentas)
                    .HasColumnName("cuenta_ventas")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EsPredet)
                    .HasColumnName("es_predet")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FactorVenta)
                    .HasColumnName("factor_venta")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.GrupoLineaId).HasColumnName("grupo_linea_id");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.GrupoLinea)
                    .WithMany(p => p.LineasArticulos)
                    .HasForeignKey(d => d.GrupoLineaId)
                    .HasConstraintName("grupos_a_lineas");
            });

            modelBuilder.Entity<LineasArticulosWeb>(entity =>
            {
                entity.HasKey(e => e.LineaArticuloWebId)
                    .HasName("lineas_articulos_web_pk");

                entity.ToTable("lineas_articulos_web");

                entity.HasIndex(e => new { e.ClaveSis, e.Politica, e.LineaArticuloId })
                    .HasName("lineas_articulos_web_ak1")
                    .IsUnique()
                    .HasFilter("([clave_sis] IS NOT NULL AND [politica] IS NOT NULL AND [linea_articulo_id] IS NOT NULL)");

                entity.Property(e => e.LineaArticuloWebId)
                    .HasColumnName("linea_articulo_web_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Accion)
                    .HasColumnName("accion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaveSis)
                    .HasColumnName("clave_sis")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LineaArticuloId).HasColumnName("linea_articulo_id");

                entity.Property(e => e.Politica)
                    .HasColumnName("politica")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.LineaArticulo)
                    .WithMany(p => p.LineasArticulosWeb)
                    .HasForeignKey(d => d.LineaArticuloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("lineas_a_lns_web");
            });

            modelBuilder.Entity<ListaElimHist>(entity =>
            {
                entity.HasKey(e => new { e.ClaveSis, e.TipoElem, e.ElemId })
                    .HasName("lista_elim_hist_pk");

                entity.ToTable("lista_elim_hist");

                entity.Property(e => e.ClaveSis)
                    .HasColumnName("clave_sis")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoElem)
                    .HasColumnName("tipo_elem")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ElemId).HasColumnName("elem_id");

                entity.Property(e => e.Refer)
                    .HasColumnName("refer")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ListasAtributos>(entity =>
            {
                entity.HasKey(e => e.ListaAtribId)
                    .HasName("listas_atrib_pk");

                entity.ToTable("listas_atributos");

                entity.HasIndex(e => new { e.AtributoId, e.ValorDesplegado })
                    .HasName("listas_atrib_ak1")
                    .IsUnique()
                    .HasFilter("([atributo_id] IS NOT NULL AND [valor_desplegado] IS NOT NULL)");

                entity.Property(e => e.ListaAtribId)
                    .HasColumnName("lista_atrib_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AtributoId).HasColumnName("atributo_id");

                entity.Property(e => e.Posicion).HasColumnName("posicion");

                entity.Property(e => e.ValorDesplegado)
                    .IsRequired()
                    .HasColumnName("valor_desplegado")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Atributo)
                    .WithMany(p => p.ListasAtributos)
                    .HasForeignKey(d => d.AtributoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("atrib_a_lista");
            });

            modelBuilder.Entity<LugaresExpedicion>(entity =>
            {
                entity.HasKey(e => e.LugarExpedicionId)
                    .HasName("lugares_expedicion_pk");

                entity.ToTable("lugares_expedicion");

                entity.HasIndex(e => e.Nombre)
                    .HasName("lugares_expedicion_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.LugarExpedicionId)
                    .HasColumnName("lugar_expedicion_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Calle)
                    .HasColumnName("calle")
                    .HasMaxLength(430)
                    .IsUnicode(false);

                entity.Property(e => e.CiudadId).HasColumnName("ciudad_id");

                entity.Property(e => e.CodigoPostal)
                    .HasColumnName("codigo_postal")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Colonia)
                    .HasColumnName("colonia")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ColoniaClaveFiscal)
                    .HasColumnName("colonia_clave_fiscal")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.EsPpal)
                    .IsRequired()
                    .HasColumnName("es_ppal")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCalle)
                    .HasColumnName("nombre_calle")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NumExterior)
                    .HasColumnName("num_exterior")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumInterior)
                    .HasColumnName("num_interior")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Poblacion)
                    .HasColumnName("poblacion")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PoblacionClaveFiscal)
                    .HasColumnName("poblacion_clave_fiscal")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Referencia)
                    .HasColumnName("referencia")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.ZonaHoraria)
                    .HasColumnName("zona_horaria")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.HasOne(d => d.Ciudad)
                    .WithMany(p => p.LugaresExpedicion)
                    .HasForeignKey(d => d.CiudadId)
                    .HasConstraintName("ciudades_a_lugares_exped");
            });

            modelBuilder.Entity<MensajesGuids>(entity =>
            {
                entity.HasKey(e => e.MensajeGuid)
                    .HasName("mensajes_guids_pk");

                entity.ToTable("mensajes_guids");

                entity.Property(e => e.MensajeGuid)
                    .HasColumnName("mensaje_guid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");
            });

            modelBuilder.Entity<Monedas>(entity =>
            {
                entity.HasKey(e => e.MonedaId)
                    .HasName("monedas_pk");

                entity.ToTable("monedas");

                entity.HasIndex(e => e.Nombre)
                    .HasName("monedas_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.MonedaId)
                    .HasColumnName("moneda_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClaveFiscal)
                    .IsRequired()
                    .HasColumnName("clave_fiscal")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EsMonedaLocal)
                    .HasColumnName("es_moneda_local")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EsPredet)
                    .HasColumnName("es_predet")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Simbolo)
                    .IsRequired()
                    .HasColumnName("simbolo")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TextoImpteLetra)
                    .HasColumnName("texto_impte_letra")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MovtosAhorroEmp>(entity =>
            {
                entity.HasKey(e => e.MovtoAhorroEmpId)
                    .HasName("movtos_ahorro_emp_pk");

                entity.ToTable("movtos_ahorro_emp");

                entity.HasIndex(e => new { e.EmpleadoId, e.ConceptoNoId, e.Fecha, e.TipoMovto })
                    .HasName("movtos_ahorro_emp_ak1")
                    .IsUnique()
                    .HasFilter("([empleado_id] IS NOT NULL AND [concepto_no_id] IS NOT NULL AND [fecha] IS NOT NULL AND [tipo_movto] IS NOT NULL)");

                entity.Property(e => e.MovtoAhorroEmpId)
                    .HasColumnName("movto_ahorro_emp_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConceptoNoId).HasColumnName("concepto_no_id");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EmpleadoId).HasColumnName("empleado_id");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.FormaEmitida)
                    .IsRequired()
                    .HasColumnName("forma_emitida")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Importe)
                    .HasColumnName("importe")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.TipoMovto)
                    .IsRequired()
                    .HasColumnName("tipo_movto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('R')");

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.Empleado)
                    .WithMany(p => p.MovtosAhorroEmp)
                    .HasForeignKey(d => d.EmpleadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("emp_a_movtos_aho_emp");
            });

            modelBuilder.Entity<MovtosCajas>(entity =>
            {
                entity.HasKey(e => e.MovtoCajaId)
                    .HasName("movtos_cajas_pk");

                entity.ToTable("movtos_cajas");

                entity.HasIndex(e => new { e.CajaId, e.FechaHoraCreacion })
                    .HasName("movtos_cajas_ak1")
                    .IsUnique()
                    .HasFilter("([caja_id] IS NOT NULL AND [fecha_hora_creacion] IS NOT NULL)");

                entity.HasIndex(e => new { e.TipoMovto, e.FechaHoraCreacion })
                    .HasName("movtos_cajas_ie1");

                entity.Property(e => e.MovtoCajaId)
                    .HasColumnName("movto_caja_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CajaId).HasColumnName("caja_id");

                entity.Property(e => e.CajerosHabilitados)
                    .IsRequired()
                    .HasColumnName("cajeros_habilitados")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('T')");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date")
                    .HasDefaultValueSql("('TODAY')");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.FormaEmitida)
                    .IsRequired()
                    .HasColumnName("forma_emitida")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hora)
                    .HasColumnName("hora")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TipoMovto)
                    .IsRequired()
                    .HasColumnName("tipo_movto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.Caja)
                    .WithMany(p => p.MovtosCajas)
                    .HasForeignKey(d => d.CajaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cajas_a_movtos_cajas");
            });

            modelBuilder.Entity<MovtosCajasCajeros>(entity =>
            {
                entity.HasKey(e => e.MovtoCajaCjoId)
                    .HasName("movtos_cajas_cajeros_pk");

                entity.ToTable("movtos_cajas_cajeros");

                entity.HasIndex(e => new { e.MovtoCajaId, e.CajeroId })
                    .HasName("movtos_cajas_cajeros_ak1")
                    .IsUnique()
                    .HasFilter("([movto_caja_id] IS NOT NULL AND [cajero_id] IS NOT NULL)");

                entity.Property(e => e.MovtoCajaCjoId)
                    .HasColumnName("movto_caja_cjo_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CajeroId).HasColumnName("cajero_id");

                entity.Property(e => e.MovtoCajaId).HasColumnName("movto_caja_id");

                entity.HasOne(d => d.Cajero)
                    .WithMany(p => p.MovtosCajasCajeros)
                    .HasForeignKey(d => d.CajeroId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cajeros_a_mov_cajas_cjos");

                entity.HasOne(d => d.MovtoCaja)
                    .WithMany(p => p.MovtosCajasCajeros)
                    .HasForeignKey(d => d.MovtoCajaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("movtos_cajas_a_cjos");
            });

            modelBuilder.Entity<MovtosCajasFondo>(entity =>
            {
                entity.HasKey(e => e.MovtoCajaFondoId)
                    .HasName("movtos_cajas_fondo_pk");

                entity.ToTable("movtos_cajas_fondo");

                entity.HasIndex(e => new { e.MovtoCajaId, e.FormaCobroId })
                    .HasName("movtos_cajas_fondo_ak1")
                    .IsUnique()
                    .HasFilter("([movto_caja_id] IS NOT NULL AND [forma_cobro_id] IS NOT NULL)");

                entity.Property(e => e.MovtoCajaFondoId)
                    .HasColumnName("movto_caja_fondo_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.FormaCobroId).HasColumnName("forma_cobro_id");

                entity.Property(e => e.Importe)
                    .HasColumnName("importe")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.MovtoCajaId).HasColumnName("movto_caja_id");

                entity.HasOne(d => d.FormaCobro)
                    .WithMany(p => p.MovtosCajasFondo)
                    .HasForeignKey(d => d.FormaCobroId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("formas_cobro_a_mov_cajas_det");

                entity.HasOne(d => d.MovtoCaja)
                    .WithMany(p => p.MovtosCajasFondo)
                    .HasForeignKey(d => d.MovtoCajaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("movtos_cajas_a_det");
            });

            modelBuilder.Entity<MovtosEfvoCaja>(entity =>
            {
                entity.HasKey(e => e.DoctoPvCobroId)
                    .HasName("movtos_efvo_caja_pk");

                entity.ToTable("movtos_efvo_caja");

                entity.Property(e => e.DoctoPvCobroId)
                    .HasColumnName("docto_pv_cobro_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CajaId).HasColumnName("caja_id");

                entity.Property(e => e.FormaCobroId).HasColumnName("forma_cobro_id");

                entity.Property(e => e.Importe)
                    .HasColumnName("importe")
                    .HasColumnType("decimal(15, 2)");

                entity.HasOne(d => d.Caja)
                    .WithMany(p => p.MovtosEfvoCaja)
                    .HasForeignKey(d => d.CajaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cajas_a_movtos_efvo");

                entity.HasOne(d => d.DoctoPvCobro)
                    .WithOne(p => p.MovtosEfvoCaja)
                    .HasForeignKey<MovtosEfvoCaja>(d => d.DoctoPvCobroId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_pv_cob_a_movtos_efvo");

                entity.HasOne(d => d.FormaCobro)
                    .WithMany(p => p.MovtosEfvoCaja)
                    .HasForeignKey(d => d.FormaCobroId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("formas_cob_a_movtos_efvo");
            });

            modelBuilder.Entity<NivelesArticulos>(entity =>
            {
                entity.HasKey(e => e.NivelArtId)
                    .HasName("niveles_articulos_pk");

                entity.ToTable("niveles_articulos");

                entity.HasIndex(e => new { e.ArticuloId, e.AlmacenId })
                    .HasName("niveles_articulos_ak1")
                    .IsUnique()
                    .HasFilter("([articulo_id] IS NOT NULL AND [almacen_id] IS NOT NULL)");

                entity.Property(e => e.NivelArtId)
                    .HasColumnName("nivel_art_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AlmacenId).HasColumnName("almacen_id");

                entity.Property(e => e.ArticuloId).HasColumnName("articulo_id");

                entity.Property(e => e.InventarioMaximo)
                    .HasColumnName("inventario_maximo")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.InventarioMinimo)
                    .HasColumnName("inventario_minimo")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Localizacion)
                    .HasColumnName("localizacion")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PuntoReorden)
                    .HasColumnName("punto_reorden")
                    .HasColumnType("decimal(18, 5)");

                entity.HasOne(d => d.Almacen)
                    .WithMany(p => p.NivelesArticulos)
                    .HasForeignKey(d => d.AlmacenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("almacenes_a_niveles");

                entity.HasOne(d => d.Articulo)
                    .WithMany(p => p.NivelesArticulos)
                    .HasForeignKey(d => d.ArticuloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("arts_a_niveles");
            });

            modelBuilder.Entity<Nominas>(entity =>
            {
                entity.HasKey(e => e.NominaId)
                    .HasName("nominas_pk");

                entity.ToTable("nominas");

                entity.HasIndex(e => new { e.FrepagId, e.Fecha, e.TipoNom })
                    .HasName("nominas_ak1")
                    .IsUnique()
                    .HasFilter("([frepag_id] IS NOT NULL AND [fecha] IS NOT NULL AND [tipo_nom] IS NOT NULL)");

                entity.Property(e => e.NominaId)
                    .HasColumnName("nomina_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aplicado)
                    .IsRequired()
                    .HasColumnName("aplicado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ConceptoAguiId).HasColumnName("concepto_agui_id");

                entity.Property(e => e.ConceptoIndemId).HasColumnName("concepto_indem_id");

                entity.Property(e => e.ConceptoPmaantId).HasColumnName("concepto_pmaant_id");

                entity.Property(e => e.ConceptoPmavacId).HasColumnName("concepto_pmavac_id");

                entity.Property(e => e.ConceptoPtuId).HasColumnName("concepto_ptu_id");

                entity.Property(e => e.Contabilizado)
                    .IsRequired()
                    .HasColumnName("contabilizado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DiasACot)
                    .HasColumnName("dias_a_cot")
                    .HasColumnType("decimal(7, 4)");

                entity.Property(e => e.DiasPeriodo)
                    .HasColumnName("dias_periodo")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DiasTrabMinPtu)
                    .HasColumnName("dias_trab_min_ptu")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FaltasAgui)
                    .HasColumnName("faltas_agui")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.FechaInicial)
                    .HasColumnName("fecha_inicial")
                    .HasColumnType("date");

                entity.Property(e => e.FechaPago)
                    .HasColumnName("fecha_pago")
                    .HasColumnType("date");

                entity.Property(e => e.FrepagId).HasColumnName("frepag_id");

                entity.Property(e => e.HorasPeriodo)
                    .HasColumnName("horas_periodo")
                    .HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ImporteRepartoPtu)
                    .HasColumnName("importe_reparto_ptu")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.IngresoMaxPtu)
                    .HasColumnName("ingreso_max_ptu")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.IntegBa)
                    .IsRequired()
                    .HasColumnName("integ_ba")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MetodoAgui)
                    .HasColumnName("metodo_agui")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('F')");

                entity.Property(e => e.PctjeIngresosPtu)
                    .HasColumnName("pctje_ingresos_ptu")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.SoloSalarioFinal)
                    .IsRequired()
                    .HasColumnName("solo_salario_final")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SuspenderConrep)
                    .IsRequired()
                    .HasColumnName("suspender_conrep")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoNom)
                    .HasColumnName("tipo_nom")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.TipoPago)
                    .HasColumnName("tipo_pago")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoProceso)
                    .HasColumnName("tipo_proceso")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.Frepag)
                    .WithMany(p => p.Nominas)
                    .HasForeignKey(d => d.FrepagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frepag_a_nominas");
            });

            modelBuilder.Entity<OfertasMm>(entity =>
            {
                entity.HasKey(e => e.OfertaMmId)
                    .HasName("ofertas_mm_pk");

                entity.ToTable("ofertas_mm");

                entity.HasIndex(e => e.Nombre)
                    .HasName("ofertas_mm_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.OfertaMmId)
                    .HasColumnName("oferta_mm_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AplicarHorario)
                    .IsRequired()
                    .HasColumnName("aplicar_horario")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EsPermanente)
                    .IsRequired()
                    .HasColumnName("es_permanente")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaFinVigencia)
                    .HasColumnName("fecha_fin_vigencia")
                    .HasColumnType("date");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.FechaIniVigencia)
                    .HasColumnName("fecha_ini_vigencia")
                    .HasColumnType("date");

                entity.Property(e => e.Habilitada)
                    .IsRequired()
                    .HasColumnName("habilitada")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HoraFin).HasColumnName("hora_fin");

                entity.Property(e => e.HoraIni).HasColumnName("hora_ini");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PctjeDscto)
                    .HasColumnName("pctje_dscto")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.Posicion).HasColumnName("posicion");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("tipo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UnidadesCompra)
                    .HasColumnName("unidades_compra")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.UnidadesMax)
                    .HasColumnName("unidades_max")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.UsoMaximo).HasColumnName("uso_maximo");

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OfertasMmDet>(entity =>
            {
                entity.HasKey(e => e.OfertaMmDetId)
                    .HasName("ofertas_mm_det_pk");

                entity.ToTable("ofertas_mm_det");

                entity.Property(e => e.OfertaMmDetId)
                    .HasColumnName("oferta_mm_det_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArticuloId).HasColumnName("articulo_id");

                entity.Property(e => e.ClasificadorId).HasColumnName("clasificador_id");

                entity.Property(e => e.EsRequisito)
                    .IsRequired()
                    .HasColumnName("es_requisito")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OfertaMmId).HasColumnName("oferta_mm_id");

                entity.Property(e => e.PctjeDscto)
                    .HasColumnName("pctje_dscto")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.PrecioEspecial)
                    .HasColumnName("precio_especial")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TipoDscto)
                    .HasColumnName("tipo_dscto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UnidadesMaximas)
                    .HasColumnName("unidades_maximas")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.UnidadesMinimas)
                    .HasColumnName("unidades_minimas")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ValorClasifId).HasColumnName("valor_clasif_id");

                entity.HasOne(d => d.Articulo)
                    .WithMany(p => p.OfertasMmDet)
                    .HasForeignKey(d => d.ArticuloId)
                    .HasConstraintName("arts_a_ofertas_mm_det");

                entity.HasOne(d => d.Clasificador)
                    .WithMany(p => p.OfertasMmDet)
                    .HasForeignKey(d => d.ClasificadorId)
                    .HasConstraintName("clasif_a_ofertas_mm_det");

                entity.HasOne(d => d.OfertaMm)
                    .WithMany(p => p.OfertasMmDet)
                    .HasForeignKey(d => d.OfertaMmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ofertas_mm_a_det");

                entity.HasOne(d => d.ValorClasif)
                    .WithMany(p => p.OfertasMmDet)
                    .HasForeignKey(d => d.ValorClasifId)
                    .HasConstraintName("clasif_val_a_ofertas_mm_det");
            });

            modelBuilder.Entity<PagosNomina>(entity =>
            {
                entity.HasKey(e => e.PagoNominaId)
                    .HasName("pagos_nomina_pk");

                entity.ToTable("pagos_nomina");

                entity.HasIndex(e => new { e.EmpleadoId, e.Fecha })
                    .HasName("pagos_nomina_ie1");

                entity.HasIndex(e => new { e.NominaId, e.EmpleadoId })
                    .HasName("pagos_nomina_uq1")
                    .IsUnique()
                    .HasFilter("([nomina_id] IS NOT NULL AND [empleado_id] IS NOT NULL)");

                entity.Property(e => e.PagoNominaId)
                    .HasColumnName("pago_nomina_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aplicado)
                    .IsRequired()
                    .HasColumnName("aplicado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BaseImptoEstatal)
                    .HasColumnName("base_impto_estatal")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.BasePtu)
                    .HasColumnName("base_ptu")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.CasAplicado)
                    .HasColumnName("cas_aplicado")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.CfdiCertificado)
                    .IsRequired()
                    .HasColumnName("cfdi_certificado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ContabilizadoBa)
                    .IsRequired()
                    .HasColumnName("contabilizado_ba")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CuentaBanId).HasColumnName("cuenta_ban_id");

                entity.Property(e => e.DeptoNoId).HasColumnName("depto_no_id");

                entity.Property(e => e.DiasAusImss).HasColumnName("dias_aus_imss");

                entity.Property(e => e.DiasCot)
                    .HasColumnName("dias_cot")
                    .HasColumnType("decimal(9, 4)");

                entity.Property(e => e.DiasIncap).HasColumnName("dias_incap");

                entity.Property(e => e.DiasTrab)
                    .HasColumnName("dias_trab")
                    .HasColumnType("decimal(7, 2)");

                entity.Property(e => e.DiasVac)
                    .HasColumnName("dias_vac")
                    .HasColumnType("decimal(7, 2)");

                entity.Property(e => e.EmailEnvio)
                    .HasColumnName("email_envio")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EmpleadoId).HasColumnName("empleado_id");

                entity.Property(e => e.Enviado)
                    .IsRequired()
                    .HasColumnName("enviado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Faltas)
                    .IsRequired()
                    .HasColumnName("faltas")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FaltasDec)
                    .HasColumnName("faltas_dec")
                    .HasColumnType("decimal(7, 2)");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraEnvio).HasColumnName("fecha_hora_envio");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.FormaEmitida)
                    .IsRequired()
                    .HasColumnName("forma_emitida")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FormaPago)
                    .IsRequired()
                    .HasColumnName("forma_pago")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('E')");

                entity.Property(e => e.HorasEsp)
                    .IsRequired()
                    .HasColumnName("horas_esp")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HorasEspDec)
                    .HasColumnName("horas_esp_dec")
                    .HasColumnType("decimal(7, 2)");

                entity.Property(e => e.HorasExt)
                    .IsRequired()
                    .HasColumnName("horas_ext")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HorasExtDec)
                    .HasColumnName("horas_ext_dec")
                    .HasColumnType("decimal(7, 2)");

                entity.Property(e => e.HorasExtExced)
                    .HasColumnName("horas_ext_exced")
                    .HasColumnType("decimal(7, 2)");

                entity.Property(e => e.HorasTrab)
                    .HasColumnName("horas_trab")
                    .HasColumnType("decimal(7, 2)");

                entity.Property(e => e.ImporteHorasExtExced)
                    .HasColumnName("importe_horas_ext_exced")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.IntegBa)
                    .IsRequired()
                    .HasColumnName("integ_ba")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Jornada)
                    .HasColumnName("jornada")
                    .HasColumnType("decimal(4, 2)");

                entity.Property(e => e.NominaId).HasColumnName("nomina_id");

                entity.Property(e => e.NumCheque)
                    .HasColumnName("num_cheque")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NumCtabanPagoElect)
                    .HasColumnName("num_ctaban_pago_elect")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PagoElectGenerado)
                    .IsRequired()
                    .HasColumnName("pago_elect_generado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PuestoNoId).HasColumnName("puesto_no_id");

                entity.Property(e => e.SalarioInteg)
                    .HasColumnName("salario_integ")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.SbcDin)
                    .HasColumnName("sbc_din")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.SbcExced)
                    .HasColumnName("sbc_exced")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.SbcInfon)
                    .HasColumnName("sbc_infon")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.SbcIvCv)
                    .HasColumnName("sbc_iv_cv")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.SbcRetiro)
                    .HasColumnName("sbc_retiro")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.SbcRiesgo)
                    .HasColumnName("sbc_riesgo")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.SbcSmdf)
                    .HasColumnName("sbc_smdf")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.TipoNom)
                    .IsRequired()
                    .HasColumnName("tipo_nom")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoPago)
                    .IsRequired()
                    .HasColumnName("tipo_pago")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoSalario)
                    .IsRequired()
                    .HasColumnName("tipo_salario")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.TotalOtrosPagos)
                    .HasColumnName("total_otros_pagos")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.TotalOtrosPagosInfo)
                    .HasColumnName("total_otros_pagos_info")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.TotalPercep)
                    .HasColumnName("total_percep")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.TotalPercepEspecie)
                    .HasColumnName("total_percep_especie")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.TotalPercepExen)
                    .HasColumnName("total_percep_exen")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.TotalPercepGrav)
                    .HasColumnName("total_percep_grav")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.TotalPercepNoAcum)
                    .HasColumnName("total_percep_no_acum")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.TotalReten)
                    .HasColumnName("total_reten")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.TotalRetenDeduc)
                    .HasColumnName("total_reten_deduc")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.TotalTipoA)
                    .HasColumnName("total_tipo_a")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.TotalTipoB)
                    .HasColumnName("total_tipo_b")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.TotalTipoC)
                    .HasColumnName("total_tipo_c")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.CuentaBan)
                    .WithMany(p => p.PagosNomina)
                    .HasForeignKey(d => d.CuentaBanId)
                    .HasConstraintName("ctaban_a_pag_nom");

                entity.HasOne(d => d.DeptoNo)
                    .WithMany(p => p.PagosNomina)
                    .HasForeignKey(d => d.DeptoNoId)
                    .HasConstraintName("deptos_a_pagos");

                entity.HasOne(d => d.Empleado)
                    .WithMany(p => p.PagosNomina)
                    .HasForeignKey(d => d.EmpleadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("emp_a_pag_nom");

                entity.HasOne(d => d.Nomina)
                    .WithMany(p => p.PagosNomina)
                    .HasForeignKey(d => d.NominaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("nom_a_pag_nom");

                entity.HasOne(d => d.PuestoNo)
                    .WithMany(p => p.PagosNomina)
                    .HasForeignKey(d => d.PuestoNoId)
                    .HasConstraintName("puestos_a_pagos");
            });

            modelBuilder.Entity<PagosNominaCancelados>(entity =>
            {
                entity.HasKey(e => e.PagoNominaCanceladoId)
                    .HasName("pagos_nomina_cancelados_pk");

                entity.ToTable("pagos_nomina_cancelados");

                entity.Property(e => e.PagoNominaCanceladoId)
                    .HasColumnName("pago_nomina_cancelado_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EmpleadoId).HasColumnName("empleado_id");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.FrepagId).HasColumnName("frepag_id");

                entity.Property(e => e.TipoNom)
                    .IsRequired()
                    .HasColumnName("tipo_nom")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Empleado)
                    .WithMany(p => p.PagosNominaCancelados)
                    .HasForeignKey(d => d.EmpleadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("empleados_a_pagos_nom_cance");

                entity.HasOne(d => d.Frepag)
                    .WithMany(p => p.PagosNominaCancelados)
                    .HasForeignKey(d => d.FrepagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frepag_a_pagos_nom_cance");
            });

            modelBuilder.Entity<PagosNominaDet>(entity =>
            {
                entity.HasKey(e => e.PagoNominaDetId)
                    .HasName("pagos_nomina_det_pk");

                entity.ToTable("pagos_nomina_det");

                entity.HasIndex(e => new { e.EmpleadoId, e.Fecha })
                    .HasName("pagos_nomina_det_ie1");

                entity.Property(e => e.PagoNominaDetId)
                    .HasColumnName("pago_nomina_det_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Acumulable)
                    .HasColumnName("acumulable")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AhorroEmpresa)
                    .HasColumnName("ahorro_empresa")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Aplicado)
                    .HasColumnName("aplicado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ConceptoNoId).HasColumnName("concepto_no_id");

                entity.Property(e => e.Cuota)
                    .HasColumnName("cuota")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.EmpleadoId).HasColumnName("empleado_id");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.Importe)
                    .HasColumnName("importe")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ImporteAhorroEmpresa)
                    .HasColumnName("importe_ahorro_empresa")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ImporteExento)
                    .HasColumnName("importe_exento")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ImporteGravable)
                    .HasColumnName("importe_gravable")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.PagoNominaId).HasColumnName("pago_nomina_id");

                entity.Property(e => e.PrestamoEmpId).HasColumnName("prestamo_emp_id");

                entity.Property(e => e.TipoOtrosPagosSat).HasColumnName("tipo_otros_pagos_sat");

                entity.Property(e => e.Unidades)
                    .HasColumnName("unidades")
                    .HasColumnType("decimal(15, 2)");

                entity.HasOne(d => d.Empleado)
                    .WithMany(p => p.PagosNominaDet)
                    .HasForeignKey(d => d.EmpleadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("emp_a_pag_nom_det");

                entity.HasOne(d => d.PagoNomina)
                    .WithMany(p => p.PagosNominaDet)
                    .HasForeignKey(d => d.PagoNominaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pag_nom_a_det");

                entity.HasOne(d => d.PrestamoEmp)
                    .WithMany(p => p.PagosNominaDet)
                    .HasForeignKey(d => d.PrestamoEmpId)
                    .HasConstraintName("ptmo_emp_a_pag_nom_det");
            });

            modelBuilder.Entity<PagosNominaVac>(entity =>
            {
                entity.HasKey(e => e.PagoNominaVacId)
                    .HasName("pagos_nomina_vac_pk");

                entity.ToTable("pagos_nomina_vac");

                entity.Property(e => e.PagoNominaVacId)
                    .HasColumnName("pago_nomina_vac_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aplicado)
                    .IsRequired()
                    .HasColumnName("aplicado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Dias)
                    .HasColumnName("dias")
                    .HasColumnType("decimal(7, 2)");

                entity.Property(e => e.PagoNominaId).HasColumnName("pago_nomina_id");

                entity.Property(e => e.VacacionesId).HasColumnName("vacaciones_id");

                entity.HasOne(d => d.PagoNomina)
                    .WithMany(p => p.PagosNominaVac)
                    .HasForeignKey(d => d.PagoNominaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pagos_nom_a_pagos_nom_vac");

                entity.HasOne(d => d.Vacaciones)
                    .WithMany(p => p.PagosNominaVac)
                    .HasForeignKey(d => d.VacacionesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("vacaciones_a_pagos_nom_vac");
            });

            modelBuilder.Entity<Paises>(entity =>
            {
                entity.HasKey(e => e.PaisId)
                    .HasName("paises_pk");

                entity.ToTable("paises");

                entity.HasIndex(e => e.Nombre)
                    .HasName("paises_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.PaisId)
                    .HasColumnName("pais_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClaveFiscal)
                    .HasColumnName("clave_fiscal")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EsPredet)
                    .HasColumnName("es_predet")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreAbrev)
                    .HasColumnName("nombre_abrev")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PedidosWeb>(entity =>
            {
                entity.HasKey(e => e.PedidoWebId)
                    .HasName("pedidos_web_pk");

                entity.ToTable("pedidos_web");

                entity.HasIndex(e => e.FolioMsp)
                    .HasName("pedidos_web_ak2")
                    .IsUnique()
                    .HasFilter("([folio_msp] IS NOT NULL)");

                entity.HasIndex(e => new { e.ClaveSis, e.DoctoWebId })
                    .HasName("pedidos_web_ak1")
                    .IsUnique()
                    .HasFilter("([clave_sis] IS NOT NULL AND [docto_web_id] IS NOT NULL)");

                entity.Property(e => e.PedidoWebId)
                    .HasColumnName("pedido_web_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClaveSis)
                    .IsRequired()
                    .HasColumnName("clave_sis")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DoctoWebId)
                    .IsRequired()
                    .HasColumnName("docto_web_id")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FolioMsp)
                    .HasColumnName("folio_msp")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Pedimentos>(entity =>
            {
                entity.HasKey(e => e.PedimentoId)
                    .HasName("pedimentos_pk");

                entity.ToTable("pedimentos");

                entity.HasIndex(e => e.Clave)
                    .HasName("pedimentos_ak1")
                    .IsUnique()
                    .HasFilter("([clave] IS NOT NULL)");

                entity.Property(e => e.PedimentoId)
                    .HasColumnName("pedimento_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aduana)
                    .HasColumnName("aduana")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AduanaId).HasColumnName("aduana_id");

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasColumnName("clave")
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.HasOne(d => d.AduanaNavigation)
                    .WithMany(p => p.Pedimentos)
                    .HasForeignKey(d => d.AduanaId)
                    .HasConstraintName("aduanas_a_pedimentos");
            });

            modelBuilder.Entity<PeriodosVac>(entity =>
            {
                entity.HasKey(e => e.PeriodoVacId)
                    .HasName("periodos_vac_pk");

                entity.ToTable("periodos_vac");

                entity.HasIndex(e => new { e.EmpleadoId, e.FechaInicial })
                    .HasName("periodos_vac_ak1")
                    .IsUnique()
                    .HasFilter("([empleado_id] IS NOT NULL AND [fecha_inicial] IS NOT NULL)");

                entity.Property(e => e.PeriodoVacId)
                    .HasColumnName("periodo_vac_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Dias)
                    .HasColumnName("dias")
                    .HasColumnType("decimal(7, 2)");

                entity.Property(e => e.DiasCalc)
                    .HasColumnName("dias_calc")
                    .HasColumnType("decimal(7, 2)");

                entity.Property(e => e.EmpleadoId).HasColumnName("empleado_id");

                entity.Property(e => e.Estatus)
                    .IsRequired()
                    .HasColumnName("estatus")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.FechaCaducidad)
                    .HasColumnName("fecha_caducidad")
                    .HasColumnType("date");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.FechaInicial)
                    .HasColumnName("fecha_inicial")
                    .HasColumnType("date");

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.Empleado)
                    .WithMany(p => p.PeriodosVac)
                    .HasForeignKey(d => d.EmpleadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("emp_a_periodo_vac");
            });

            modelBuilder.Entity<PlanesVisitas>(entity =>
            {
                entity.HasKey(e => e.PlanVisitasId)
                    .HasName("planes_visitas_pk");

                entity.ToTable("planes_visitas");

                entity.HasIndex(e => e.Nombre)
                    .HasName("planes_visitas_ie1");

                entity.Property(e => e.PlanVisitasId)
                    .HasColumnName("plan_visitas_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AgenteId).HasColumnName("agente_id");

                entity.Property(e => e.FechaFinal)
                    .HasColumnName("fecha_final")
                    .HasColumnType("date");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.FechaInicial)
                    .HasColumnName("fecha_inicial")
                    .HasColumnType("date");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.VersionRegistro).HasColumnName("version_registro");

                entity.HasOne(d => d.Agente)
                    .WithMany(p => p.PlanesVisitas)
                    .HasForeignKey(d => d.AgenteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("agentes_a_planes_visitas");
            });

            modelBuilder.Entity<PlanesVisitasDet>(entity =>
            {
                entity.HasKey(e => e.PlanVisitasDetId)
                    .HasName("planes_visitas_det_pk");

                entity.ToTable("planes_visitas_det");

                entity.HasIndex(e => new { e.PlanVisitasId, e.VisitaId })
                    .HasName("planes_visitas_det_ak1")
                    .IsUnique()
                    .HasFilter("([plan_visitas_id] IS NOT NULL AND [visita_id] IS NOT NULL)");

                entity.Property(e => e.PlanVisitasDetId)
                    .HasColumnName("plan_visitas_det_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.OrdenEjecucion).HasColumnName("orden_ejecucion");

                entity.Property(e => e.PlanVisitasId).HasColumnName("plan_visitas_id");

                entity.Property(e => e.VisitaId).HasColumnName("visita_id");

                entity.HasOne(d => d.PlanVisitas)
                    .WithMany(p => p.PlanesVisitasDet)
                    .HasForeignKey(d => d.PlanVisitasId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("planes_visitas_a_det");

                entity.HasOne(d => d.Visita)
                    .WithMany(p => p.PlanesVisitasDet)
                    .HasForeignKey(d => d.VisitaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("visitas_a_planes_visitas_det");
            });

            modelBuilder.Entity<PlantillasPolCo>(entity =>
            {
                entity.HasKey(e => e.PlantillaPolCoId)
                    .HasName("plantillas_pol_pk");

                entity.ToTable("plantillas_pol_co");

                entity.HasIndex(e => e.Nombre)
                    .HasName("plantillas_pol_co_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.PlantillaPolCoId)
                    .HasColumnName("plantilla_pol_co_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Naturaleza)
                    .IsRequired()
                    .HasColumnName("naturaleza")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('E')");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoPolizaId).HasColumnName("tipo_poliza_id");

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.TipoPoliza)
                    .WithMany(p => p.PlantillasPolCo)
                    .HasForeignKey(d => d.TipoPolizaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tippol_a_plantillas_pol_co");
            });

            modelBuilder.Entity<PlantillasPolCoDet>(entity =>
            {
                entity.HasKey(e => e.PlantillaPolCoDetId)
                    .HasName("plantillas_pol_co_det_pk");

                entity.ToTable("plantillas_pol_co_det");

                entity.Property(e => e.PlantillaPolCoDetId)
                    .HasColumnName("plantilla_pol_co_det_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CuentaId).HasColumnName("cuenta_id");

                entity.Property(e => e.DeptoCoId).HasColumnName("depto_co_id");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Formula)
                    .IsRequired()
                    .HasColumnName("formula")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PlantillaPolCoId).HasColumnName("plantilla_pol_co_id");

                entity.Property(e => e.Posicion).HasColumnName("posicion");

                entity.Property(e => e.Refer)
                    .HasColumnName("refer")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TipoAsiento)
                    .IsRequired()
                    .HasColumnName("tipo_asiento")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('C')");

                entity.Property(e => e.TipoCuenta)
                    .IsRequired()
                    .HasColumnName("tipo_cuenta")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Cuenta)
                    .WithMany(p => p.PlantillasPolCoDet)
                    .HasForeignKey(d => d.CuentaId)
                    .HasConstraintName("ctas_co_a_plantillas_pol_det");

                entity.HasOne(d => d.DeptoCo)
                    .WithMany(p => p.PlantillasPolCoDet)
                    .HasForeignKey(d => d.DeptoCoId)
                    .HasConstraintName("deptos_co_a_plantillas_pol_det");

                entity.HasOne(d => d.PlantillaPolCo)
                    .WithMany(p => p.PlantillasPolCoDet)
                    .HasForeignKey(d => d.PlantillaPolCoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plantillas_pol_a_det");
            });

            modelBuilder.Entity<PlazosCondPag>(entity =>
            {
                entity.HasKey(e => e.PlazoCondPagId)
                    .HasName("plazos_cond_pag_pk");

                entity.ToTable("plazos_cond_pag");

                entity.HasIndex(e => new { e.CondPagoId, e.DiasPlazo })
                    .HasName("plazos_cond_pag_ak1")
                    .IsUnique()
                    .HasFilter("([cond_pago_id] IS NOT NULL AND [dias_plazo] IS NOT NULL)");

                entity.Property(e => e.PlazoCondPagId)
                    .HasColumnName("plazo_cond_pag_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CondPagoId).HasColumnName("cond_pago_id");

                entity.Property(e => e.DiasPlazo).HasColumnName("dias_plazo");

                entity.Property(e => e.PctjeVen)
                    .HasColumnName("pctje_ven")
                    .HasColumnType("decimal(9, 6)");

                entity.HasOne(d => d.CondPago)
                    .WithMany(p => p.PlazosCondPag)
                    .HasForeignKey(d => d.CondPagoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cond_pag_a_plazos");
            });

            modelBuilder.Entity<PlazosCondPagCp>(entity =>
            {
                entity.HasKey(e => e.PlazoCondPagId)
                    .HasName("plazos_cond_pag_cp_pk");

                entity.ToTable("plazos_cond_pag_cp");

                entity.HasIndex(e => new { e.CondPagoId, e.DiasPlazo })
                    .HasName("plazos_cond_pag_cp_ak1")
                    .IsUnique()
                    .HasFilter("([cond_pago_id] IS NOT NULL AND [dias_plazo] IS NOT NULL)");

                entity.Property(e => e.PlazoCondPagId)
                    .HasColumnName("plazo_cond_pag_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CondPagoId).HasColumnName("cond_pago_id");

                entity.Property(e => e.DiasPlazo).HasColumnName("dias_plazo");

                entity.Property(e => e.PctjeVen)
                    .HasColumnName("pctje_ven")
                    .HasColumnType("decimal(9, 6)");

                entity.HasOne(d => d.CondPago)
                    .WithMany(p => p.PlazosCondPagCp)
                    .HasForeignKey(d => d.CondPagoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cond_pag_cp_a_plazos");
            });

            modelBuilder.Entity<PoliticasComisionesCobradores>(entity =>
            {
                entity.HasKey(e => e.PoliticaComisCobId)
                    .HasName("pol_comis_cob_pk");

                entity.ToTable("politicas_comisiones_cobradores");

                entity.HasIndex(e => e.Nombre)
                    .HasName("pol_comis_cob_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.PoliticaComisCobId)
                    .HasColumnName("politica_comis_cob_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EsPredet)
                    .HasColumnName("es_predet")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PctjeEnSaldoVencido)
                    .HasColumnName("pctje_en_saldo_vencido")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.PctjeEnSaldoXven)
                    .HasColumnName("pctje_en_saldo_xven")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.TipoCalculo)
                    .HasColumnName("tipo_calculo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PoliticasComisionesVendedores>(entity =>
            {
                entity.HasKey(e => e.PoliticaComisVenId)
                    .HasName("pol_comis_ven_pk");

                entity.ToTable("politicas_comisiones_vendedores");

                entity.HasIndex(e => e.Nombre)
                    .HasName("pol_comis_ven_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.PoliticaComisVenId)
                    .HasColumnName("politica_comis_ven_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Comision)
                    .HasColumnName("comision")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.EsPredet)
                    .HasColumnName("es_predet")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCalculo)
                    .IsRequired()
                    .HasColumnName("tipo_calculo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PoliticasDsctosArtCli>(entity =>
            {
                entity.HasKey(e => e.PoliticaDsctoArtCliId)
                    .HasName("politicas_dsctos_art_cli_pk");

                entity.ToTable("politicas_dsctos_art_cli");

                entity.HasIndex(e => e.Nombre)
                    .HasName("politicas_dsctos_art_cli_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.PoliticaDsctoArtCliId)
                    .HasColumnName("politica_dscto_art_cli_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descuento)
                    .HasColumnName("descuento")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.EsDsctoExclusivo)
                    .HasColumnName("es_dscto_exclusivo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EsPredet)
                    .HasColumnName("es_predet")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PoliticasDsctosMaximos>(entity =>
            {
                entity.HasKey(e => e.PoliticaDsctoMaximoId)
                    .HasName("politicas_dsctos_maximos_pk");

                entity.ToTable("politicas_dsctos_maximos");

                entity.HasIndex(e => e.Nombre)
                    .HasName("politicas_dsctos_maximos_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.PoliticaDsctoMaximoId)
                    .HasColumnName("politica_dscto_maximo_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DescuentoMaximo)
                    .HasColumnName("descuento_maximo")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.EsPermanente)
                    .HasColumnName("es_permanente")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaFinVigencia)
                    .HasColumnName("fecha_fin_vigencia")
                    .HasColumnType("date");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.FechaIniVigencia)
                    .HasColumnName("fecha_ini_vigencia")
                    .HasColumnType("date");

                entity.Property(e => e.Habilitada)
                    .HasColumnName("habilitada")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PoliticasDsctosPromoProv>(entity =>
            {
                entity.HasKey(e => e.PolDsctoPromoProvId)
                    .HasName("pol_dsctos_promo_prov_pk");

                entity.ToTable("politicas_dsctos_promo_prov");

                entity.HasIndex(e => new { e.ProveedorId, e.Nombre })
                    .HasName("pol_dsctos_promo_prov_ak1")
                    .IsUnique()
                    .HasFilter("([proveedor_id] IS NOT NULL AND [nombre] IS NOT NULL)");

                entity.Property(e => e.PolDsctoPromoProvId)
                    .HasColumnName("pol_dscto_promo_prov_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descuento)
                    .HasColumnName("descuento")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.EsDsctoExclusivo)
                    .HasColumnName("es_dscto_exclusivo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EsPermanente)
                    .HasColumnName("es_permanente")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaFinVigencia)
                    .HasColumnName("fecha_fin_vigencia")
                    .HasColumnType("date");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.FechaIniVigencia)
                    .HasColumnName("fecha_ini_vigencia")
                    .HasColumnType("date");

                entity.Property(e => e.Habilitada)
                    .HasColumnName("habilitada")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProveedorId).HasColumnName("proveedor_id");

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.Proveedor)
                    .WithMany(p => p.PoliticasDsctosPromoProv)
                    .HasForeignKey(d => d.ProveedorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("prov_a_pol_dsctos_promo");
            });

            modelBuilder.Entity<PoliticasDsctosPromocion>(entity =>
            {
                entity.HasKey(e => e.PoliticaDsctoPromoId)
                    .HasName("politicas_dsctos_promo_pk");

                entity.ToTable("politicas_dsctos_promocion");

                entity.HasIndex(e => e.Nombre)
                    .HasName("politicas_dsctos_promo_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.PoliticaDsctoPromoId)
                    .HasColumnName("politica_dscto_promo_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AplicarHorario)
                    .HasColumnName("aplicar_horario")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descuento)
                    .HasColumnName("descuento")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.EsDsctoExclusivo)
                    .HasColumnName("es_dscto_exclusivo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EsPermanente)
                    .HasColumnName("es_permanente")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaFinVigencia)
                    .HasColumnName("fecha_fin_vigencia")
                    .HasColumnType("date");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.FechaIniVigencia)
                    .HasColumnName("fecha_ini_vigencia")
                    .HasColumnType("date");

                entity.Property(e => e.Habilitada)
                    .HasColumnName("habilitada")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HoraFin).HasColumnName("hora_fin");

                entity.Property(e => e.HoraIni).HasColumnName("hora_ini");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PoliticasDsctosVolProv>(entity =>
            {
                entity.HasKey(e => e.PolDsctoVolProvId)
                    .HasName("pol_dsctos_vol_prov_pk");

                entity.ToTable("politicas_dsctos_vol_prov");

                entity.HasIndex(e => new { e.ProveedorId, e.Nombre })
                    .HasName("pol_dsctos_vol_prov_ak1")
                    .IsUnique()
                    .HasFilter("([proveedor_id] IS NOT NULL AND [nombre] IS NOT NULL)");

                entity.Property(e => e.PolDsctoVolProvId)
                    .HasColumnName("pol_dscto_vol_prov_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EsDsctoExclusivo)
                    .HasColumnName("es_dscto_exclusivo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EsPermanente)
                    .HasColumnName("es_permanente")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaFinVigencia)
                    .HasColumnName("fecha_fin_vigencia")
                    .HasColumnType("date");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.FechaIniVigencia)
                    .HasColumnName("fecha_ini_vigencia")
                    .HasColumnType("date");

                entity.Property(e => e.Habilitada)
                    .HasColumnName("habilitada")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProveedorId).HasColumnName("proveedor_id");

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.Proveedor)
                    .WithMany(p => p.PoliticasDsctosVolProv)
                    .HasForeignKey(d => d.ProveedorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("prov_a_pol_dsctos_vol");
            });

            modelBuilder.Entity<PoliticasDsctosVolumen>(entity =>
            {
                entity.HasKey(e => e.PoliticaDsctoVolumenId)
                    .HasName("politicas_dsctos_volumen_pk");

                entity.ToTable("politicas_dsctos_volumen");

                entity.HasIndex(e => e.Nombre)
                    .HasName("politicas_dsctos_volumen_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.PoliticaDsctoVolumenId)
                    .HasColumnName("politica_dscto_volumen_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EsDsctoExclusivo)
                    .HasColumnName("es_dscto_exclusivo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EsPermanente)
                    .HasColumnName("es_permanente")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaFinVigencia)
                    .HasColumnName("fecha_fin_vigencia")
                    .HasColumnType("date");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.FechaIniVigencia)
                    .HasColumnName("fecha_ini_vigencia")
                    .HasColumnType("date");

                entity.Property(e => e.Habilitada)
                    .HasColumnName("habilitada")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PoliticasPreciosClientes>(entity =>
            {
                entity.HasKey(e => e.PoliticaPreciosCliId)
                    .HasName("politicas_precios_clientes_pk");

                entity.ToTable("politicas_precios_clientes");

                entity.HasIndex(e => e.Nombre)
                    .HasName("politicas_precios_clientes_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.PoliticaPreciosCliId)
                    .HasColumnName("politica_precios_cli_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EsPermanente)
                    .HasColumnName("es_permanente")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaFinVigencia)
                    .HasColumnName("fecha_fin_vigencia")
                    .HasColumnType("date");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.FechaIniVigencia)
                    .HasColumnName("fecha_ini_vigencia")
                    .HasColumnType("date");

                entity.Property(e => e.Habilitada)
                    .HasColumnName("habilitada")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PoliticaDsctoArtCliId).HasColumnName("politica_dscto_art_cli_id");

                entity.Property(e => e.PrecioEmpresaId).HasColumnName("precio_empresa_id");

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.PoliticaDsctoArtCli)
                    .WithMany(p => p.PoliticasPreciosClientes)
                    .HasForeignKey(d => d.PoliticaDsctoArtCliId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dsctos_art_cli_a_pcios_cli_glob");

                entity.HasOne(d => d.PrecioEmpresa)
                    .WithMany(p => p.PoliticasPreciosClientes)
                    .HasForeignKey(d => d.PrecioEmpresaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("precios_emp_a_precios_cli_glob");
            });

            modelBuilder.Entity<PoliticasPreciosProv>(entity =>
            {
                entity.HasKey(e => e.PoliticaPreciosProvId)
                    .HasName("politicas_precios_prov_pk");

                entity.ToTable("politicas_precios_prov");

                entity.HasIndex(e => new { e.ProveedorId, e.Nombre })
                    .HasName("politicas_precios_prov_ak1")
                    .IsUnique()
                    .HasFilter("([proveedor_id] IS NOT NULL AND [nombre] IS NOT NULL)");

                entity.Property(e => e.PoliticaPreciosProvId)
                    .HasColumnName("politica_precios_prov_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descuento)
                    .HasColumnName("descuento")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.EsDsctoExclusivo)
                    .HasColumnName("es_dscto_exclusivo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EsPermanente)
                    .HasColumnName("es_permanente")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaFinVigencia)
                    .HasColumnName("fecha_fin_vigencia")
                    .HasColumnType("date");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.FechaIniVigencia)
                    .HasColumnName("fecha_ini_vigencia")
                    .HasColumnType("date");

                entity.Property(e => e.Habilitada)
                    .HasColumnName("habilitada")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrecioProvId).HasColumnName("precio_prov_id");

                entity.Property(e => e.ProveedorId).HasColumnName("proveedor_id");

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.PrecioProv)
                    .WithMany(p => p.PoliticasPreciosProv)
                    .HasForeignKey(d => d.PrecioProvId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("precios_pro_a_pol_precios");

                entity.HasOne(d => d.Proveedor)
                    .WithMany(p => p.PoliticasPreciosProv)
                    .HasForeignKey(d => d.ProveedorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("prov_a_pol_precios");
            });

            modelBuilder.Entity<Polizas>(entity =>
            {
                entity.HasKey(e => e.PolizaId)
                    .HasName("polizas_pk");

                entity.ToTable("polizas");

                entity.HasIndex(e => new { e.ProcesoId, e.DoctoId, e.Cuenta, e.TipoAsiento, e.Refer })
                    .HasName("polizas_ak1")
                    .IsUnique()
                    .HasFilter("([proceso_id] IS NOT NULL AND [docto_id] IS NOT NULL AND [cuenta] IS NOT NULL AND [tipo_asiento] IS NOT NULL AND [refer] IS NOT NULL)");

                entity.Property(e => e.PolizaId)
                    .HasColumnName("poliza_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cuenta)
                    .IsRequired()
                    .HasColumnName("cuenta")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DoctoId).HasColumnName("docto_id");

                entity.Property(e => e.ExtraInfo)
                    .HasColumnName("extra_info")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Importe)
                    .HasColumnName("importe")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.NumAsiento).HasColumnName("num_asiento");

                entity.Property(e => e.ProcesoId).HasColumnName("proceso_id");

                entity.Property(e => e.Refer)
                    .IsRequired()
                    .HasColumnName("refer")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TipoAsiento)
                    .IsRequired()
                    .HasColumnName("tipo_asiento")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PolizasCfdi>(entity =>
            {
                entity.HasKey(e => new { e.PolizaId, e.CfdiId })
                    .HasName("polizas_cfdi_pk");

                entity.ToTable("polizas_cfdi");

                entity.Property(e => e.PolizaId).HasColumnName("poliza_id");

                entity.Property(e => e.CfdiId).HasColumnName("cfdi_id");

                entity.HasOne(d => d.Cfdi)
                    .WithMany(p => p.PolizasCfdi)
                    .HasForeignKey(d => d.CfdiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("repositorio_cfdi_a_polizas_cfdi");

                entity.HasOne(d => d.Poliza)
                    .WithMany(p => p.PolizasCfdi)
                    .HasForeignKey(d => d.PolizaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("polizas_a_cfdi");
            });

            modelBuilder.Entity<PreciosArticulos>(entity =>
            {
                entity.HasKey(e => e.PrecioArticuloId)
                    .HasName("precios_articulos_pk");

                entity.ToTable("precios_articulos");

                entity.HasIndex(e => new { e.ArticuloId, e.PrecioEmpresaId })
                    .HasName("precios_articulos_ak1")
                    .IsUnique()
                    .HasFilter("([articulo_id] IS NOT NULL AND [precio_empresa_id] IS NOT NULL)");

                entity.Property(e => e.PrecioArticuloId)
                    .HasColumnName("precio_articulo_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArticuloId).HasColumnName("articulo_id");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Margen)
                    .HasColumnName("margen")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.MonedaId).HasColumnName("moneda_id");

                entity.Property(e => e.Precio)
                    .HasColumnName("precio")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.PrecioEmpresaId).HasColumnName("precio_empresa_id");

                entity.HasOne(d => d.Articulo)
                    .WithMany(p => p.PreciosArticulos)
                    .HasForeignKey(d => d.ArticuloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("arts_a_precios_art");

                entity.HasOne(d => d.Moneda)
                    .WithMany(p => p.PreciosArticulos)
                    .HasForeignKey(d => d.MonedaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("monedas_a_precios_articulos");

                entity.HasOne(d => d.PrecioEmpresa)
                    .WithMany(p => p.PreciosArticulos)
                    .HasForeignKey(d => d.PrecioEmpresaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("precios_emp_a_precios_arts");
            });

            modelBuilder.Entity<PreciosCliCli>(entity =>
            {
                entity.HasKey(e => e.PrecioCliCliId)
                    .HasName("precios_cli_cli_pk");

                entity.ToTable("precios_cli_cli");

                entity.HasIndex(e => new { e.PoliticaPreciosCliId, e.ClienteId })
                    .HasName("precios_cli_cli_ak1")
                    .IsUnique()
                    .HasFilter("([politica_precios_cli_id] IS NOT NULL AND [cliente_id] IS NOT NULL)");

                entity.Property(e => e.PrecioCliCliId)
                    .HasColumnName("precio_cli_cli_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClaveCliente)
                    .HasColumnName("clave_cliente")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteId).HasColumnName("cliente_id");

                entity.Property(e => e.PoliticaDsctoArtCliId).HasColumnName("politica_dscto_art_cli_id");

                entity.Property(e => e.PoliticaPreciosCliId).HasColumnName("politica_precios_cli_id");

                entity.Property(e => e.PrecioEmpresaId).HasColumnName("precio_empresa_id");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.PreciosCliCli)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("clientes_a_precios_cli_cli");

                entity.HasOne(d => d.PoliticaDsctoArtCli)
                    .WithMany(p => p.PreciosCliCli)
                    .HasForeignKey(d => d.PoliticaDsctoArtCliId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dsctos_art_cli_a_pcios_cli_cli");

                entity.HasOne(d => d.PoliticaPreciosCli)
                    .WithMany(p => p.PreciosCliCli)
                    .HasForeignKey(d => d.PoliticaPreciosCliId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("clientes_con_precio_cli");

                entity.HasOne(d => d.PrecioEmpresa)
                    .WithMany(p => p.PreciosCliCli)
                    .HasForeignKey(d => d.PrecioEmpresaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("precios_emp_a_precios_cli_cli");
            });

            modelBuilder.Entity<PreciosCliTipo>(entity =>
            {
                entity.HasKey(e => e.PrecioCliTipoId)
                    .HasName("precios_cli_tipo_pk");

                entity.ToTable("precios_cli_tipo");

                entity.HasIndex(e => new { e.PoliticaPreciosCliId, e.TipoClienteId })
                    .HasName("precios_cli_tipo_ak1")
                    .IsUnique()
                    .HasFilter("([politica_precios_cli_id] IS NOT NULL AND [tipo_cliente_id] IS NOT NULL)");

                entity.Property(e => e.PrecioCliTipoId)
                    .HasColumnName("precio_cli_tipo_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.PoliticaDsctoArtCliId).HasColumnName("politica_dscto_art_cli_id");

                entity.Property(e => e.PoliticaPreciosCliId).HasColumnName("politica_precios_cli_id");

                entity.Property(e => e.PrecioEmpresaId).HasColumnName("precio_empresa_id");

                entity.Property(e => e.TipoClienteId).HasColumnName("tipo_cliente_id");

                entity.HasOne(d => d.PoliticaDsctoArtCli)
                    .WithMany(p => p.PreciosCliTipo)
                    .HasForeignKey(d => d.PoliticaDsctoArtCliId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dsctos_art_cli_a_pcios_cli_tipo");

                entity.HasOne(d => d.PoliticaPreciosCli)
                    .WithMany(p => p.PreciosCliTipo)
                    .HasForeignKey(d => d.PoliticaPreciosCliId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tipos_con_precio_cli");

                entity.HasOne(d => d.PrecioEmpresa)
                    .WithMany(p => p.PreciosCliTipo)
                    .HasForeignKey(d => d.PrecioEmpresaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("precios_emp_a_precios_cli_tipo");

                entity.HasOne(d => d.TipoCliente)
                    .WithMany(p => p.PreciosCliTipo)
                    .HasForeignKey(d => d.TipoClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tipos_a_precios_cli_tipo");
            });

            modelBuilder.Entity<PreciosCliZona>(entity =>
            {
                entity.HasKey(e => e.PrecioCliZonaId)
                    .HasName("precios_cli_zona_pk");

                entity.ToTable("precios_cli_zona");

                entity.HasIndex(e => new { e.PoliticaPreciosCliId, e.ZonaClienteId })
                    .HasName("precios_cli_zona_ak1")
                    .IsUnique()
                    .HasFilter("([politica_precios_cli_id] IS NOT NULL AND [zona_cliente_id] IS NOT NULL)");

                entity.Property(e => e.PrecioCliZonaId)
                    .HasColumnName("precio_cli_zona_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.PoliticaDsctoArtCliId).HasColumnName("politica_dscto_art_cli_id");

                entity.Property(e => e.PoliticaPreciosCliId).HasColumnName("politica_precios_cli_id");

                entity.Property(e => e.PrecioEmpresaId).HasColumnName("precio_empresa_id");

                entity.Property(e => e.ZonaClienteId).HasColumnName("zona_cliente_id");

                entity.HasOne(d => d.PoliticaDsctoArtCli)
                    .WithMany(p => p.PreciosCliZona)
                    .HasForeignKey(d => d.PoliticaDsctoArtCliId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dsctos_art_cli_a_pcios_cli_zona");

                entity.HasOne(d => d.PoliticaPreciosCli)
                    .WithMany(p => p.PreciosCliZona)
                    .HasForeignKey(d => d.PoliticaPreciosCliId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("zonas_con_precio_cli");

                entity.HasOne(d => d.PrecioEmpresa)
                    .WithMany(p => p.PreciosCliZona)
                    .HasForeignKey(d => d.PrecioEmpresaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("precios_emp_a_precios_cli_zona");

                entity.HasOne(d => d.ZonaCliente)
                    .WithMany(p => p.PreciosCliZona)
                    .HasForeignKey(d => d.ZonaClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("zonas_a_precios_cli_zona");
            });

            modelBuilder.Entity<PreciosCompra>(entity =>
            {
                entity.HasKey(e => e.PrecioCompraId)
                    .HasName("precios_compra_pk");

                entity.ToTable("precios_compra");

                entity.HasIndex(e => new { e.ArticuloId, e.ProveedorId })
                    .HasName("precios_compra_ak1")
                    .IsUnique()
                    .HasFilter("([articulo_id] IS NOT NULL AND [proveedor_id] IS NOT NULL)");

                entity.HasIndex(e => new { e.ProveedorId, e.ArticuloId })
                    .HasName("precios_compra_ie1");

                entity.HasIndex(e => new { e.ProveedorId, e.ClaveArtProv })
                    .HasName("precios_compra_ie2");

                entity.Property(e => e.PrecioCompraId)
                    .HasColumnName("precio_compra_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArticuloId).HasColumnName("articulo_id");

                entity.Property(e => e.ClaveArtProv)
                    .HasColumnName("clave_art_prov")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClaveArticulo)
                    .HasColumnName("clave_articulo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClaveProv)
                    .HasColumnName("clave_prov")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ContenidoUnidadCompra)
                    .HasColumnName("contenido_unidad_compra")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.DiasEntregaProm).HasColumnName("dias_entrega_prom");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.FechaPrecioUltCompra)
                    .HasColumnName("fecha_precio_ult_compra")
                    .HasColumnType("date");

                entity.Property(e => e.Notas)
                    .HasColumnName("notas")
                    .IsUnicode(false);

                entity.Property(e => e.NumCompras).HasColumnName("num_compras");

                entity.Property(e => e.PrioridadCompra)
                    .IsRequired()
                    .HasColumnName("prioridad_compra")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('2')");

                entity.Property(e => e.ProveedorId).HasColumnName("proveedor_id");

                entity.Property(e => e.TotDiasEntrega).HasColumnName("tot_dias_entrega");

                entity.Property(e => e.UnidadCompra)
                    .HasColumnName("unidad_compra")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UnidadesMinUcom)
                    .HasColumnName("unidades_min_ucom")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.UnidadesMinUven)
                    .HasColumnName("unidades_min_uven")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.Articulo)
                    .WithMany(p => p.PreciosCompra)
                    .HasForeignKey(d => d.ArticuloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("arts_a_precios_compra");

                entity.HasOne(d => d.Proveedor)
                    .WithMany(p => p.PreciosCompra)
                    .HasForeignKey(d => d.ProveedorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("prov_a_precios_compra");
            });

            modelBuilder.Entity<PreciosCompraDet>(entity =>
            {
                entity.HasKey(e => e.PrecioCompraDetId)
                    .HasName("precios_compra_det_pk");

                entity.ToTable("precios_compra_det");

                entity.HasIndex(e => new { e.PrecioCompraId, e.PrecioProvId })
                    .HasName("precios_compra_det_ak1")
                    .IsUnique()
                    .HasFilter("([precio_compra_id] IS NOT NULL AND [precio_prov_id] IS NOT NULL)");

                entity.Property(e => e.PrecioCompraDetId)
                    .HasColumnName("precio_compra_det_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.MonedaId).HasColumnName("moneda_id");

                entity.Property(e => e.PrecioCompraId).HasColumnName("precio_compra_id");

                entity.Property(e => e.PrecioProvId).HasColumnName("precio_prov_id");

                entity.Property(e => e.PrecioUcom)
                    .HasColumnName("precio_ucom")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.PrecioUven)
                    .HasColumnName("precio_uven")
                    .HasColumnType("decimal(18, 6)");

                entity.HasOne(d => d.Moneda)
                    .WithMany(p => p.PreciosCompraDet)
                    .HasForeignKey(d => d.MonedaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("monedas_a_precios_compra_det");

                entity.HasOne(d => d.PrecioCompra)
                    .WithMany(p => p.PreciosCompraDet)
                    .HasForeignKey(d => d.PrecioCompraId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("precios_compra_a_det");

                entity.HasOne(d => d.PrecioProv)
                    .WithMany(p => p.PreciosCompraDet)
                    .HasForeignKey(d => d.PrecioProvId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("precios_prov_a_precios_det");
            });

            modelBuilder.Entity<PreciosEmpresa>(entity =>
            {
                entity.HasKey(e => e.PrecioEmpresaId)
                    .HasName("precios_empresa_pk");

                entity.ToTable("precios_empresa");

                entity.HasIndex(e => e.Nombre)
                    .HasName("precios_empresa_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.PrecioEmpresaId)
                    .HasColumnName("precio_empresa_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdInterno)
                    .HasColumnName("id_interno")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Posicion).HasColumnName("posicion");
            });

            modelBuilder.Entity<PreciosProv>(entity =>
            {
                entity.HasKey(e => e.PrecioProvId)
                    .HasName("precios_prov_pk");

                entity.ToTable("precios_prov");

                entity.HasIndex(e => new { e.ProveedorId, e.Nombre })
                    .HasName("precios_prov_ak1")
                    .IsUnique()
                    .HasFilter("([proveedor_id] IS NOT NULL AND [nombre] IS NOT NULL)");

                entity.Property(e => e.PrecioProvId)
                    .HasColumnName("precio_prov_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdInterno)
                    .HasColumnName("id_interno")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ProveedorId).HasColumnName("proveedor_id");

                entity.HasOne(d => d.Proveedor)
                    .WithMany(p => p.PreciosProv)
                    .HasForeignKey(d => d.ProveedorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("prov_a_precios_prov");
            });

            modelBuilder.Entity<PrestamosEmp>(entity =>
            {
                entity.HasKey(e => e.PrestamoEmpId)
                    .HasName("prestamos_emp_pk");

                entity.ToTable("prestamos_emp");

                entity.HasIndex(e => new { e.EmpleadoId, e.ConceptoNoId, e.Fecha })
                    .HasName("prestamos_emp_ak1")
                    .IsUnique()
                    .HasFilter("([empleado_id] IS NOT NULL AND [concepto_no_id] IS NOT NULL AND [fecha] IS NOT NULL)");

                entity.Property(e => e.PrestamoEmpId)
                    .HasColumnName("prestamo_emp_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConceptoNoId).HasColumnName("concepto_no_id");

                entity.Property(e => e.CuentaContable)
                    .HasColumnName("cuenta_contable")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Cuota)
                    .HasColumnName("cuota")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EmpleadoId).HasColumnName("empleado_id");

                entity.Property(e => e.Estatus)
                    .IsRequired()
                    .HasColumnName("estatus")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.FechaFin)
                    .HasColumnName("fecha_fin")
                    .HasColumnType("date");

                entity.Property(e => e.FechaHoraCancelacion).HasColumnName("fecha_hora_cancelacion");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.FechaIniRet)
                    .HasColumnName("fecha_ini_ret")
                    .HasColumnType("date");

                entity.Property(e => e.Importe)
                    .HasColumnName("importe")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.UsuarioAutCancelacion)
                    .HasColumnName("usuario_aut_cancelacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCancelacion)
                    .HasColumnName("usuario_cancelacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.Empleado)
                    .WithMany(p => p.PrestamosEmp)
                    .HasForeignKey(d => d.EmpleadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("emp_a_ptmo_emp");
            });

            modelBuilder.Entity<Presupuestos>(entity =>
            {
                entity.HasKey(e => e.PptoId)
                    .HasName("presupuestos_pk");

                entity.ToTable("presupuestos");

                entity.HasIndex(e => new { e.Ejer, e.CuentaId, e.DeptoCoId })
                    .HasName("presupuestos_ak1")
                    .IsUnique()
                    .HasFilter("([ejer] IS NOT NULL AND [cuenta_id] IS NOT NULL AND [depto_co_id] IS NOT NULL)");

                entity.Property(e => e.PptoId)
                    .HasColumnName("ppto_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CuentaId).HasColumnName("cuenta_id");

                entity.Property(e => e.DeptoCoId).HasColumnName("depto_co_id");

                entity.Property(e => e.Ejer).HasColumnName("ejer");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Ppto01)
                    .HasColumnName("ppto01")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Ppto02)
                    .HasColumnName("ppto02")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Ppto03)
                    .HasColumnName("ppto03")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Ppto04)
                    .HasColumnName("ppto04")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Ppto05)
                    .HasColumnName("ppto05")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Ppto06)
                    .HasColumnName("ppto06")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Ppto07)
                    .HasColumnName("ppto07")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Ppto08)
                    .HasColumnName("ppto08")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Ppto09)
                    .HasColumnName("ppto09")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Ppto10)
                    .HasColumnName("ppto10")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Ppto11)
                    .HasColumnName("ppto11")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Ppto12)
                    .HasColumnName("ppto12")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cuenta)
                    .WithMany(p => p.Presupuestos)
                    .HasForeignKey(d => d.CuentaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cuentas_co_a_pptos");

                entity.HasOne(d => d.DeptoCo)
                    .WithMany(p => p.Presupuestos)
                    .HasForeignKey(d => d.DeptoCoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("deptos_co_a_pptos");
            });

            modelBuilder.Entity<ProrrateosDet>(entity =>
            {
                entity.HasKey(e => new { e.CuentaId, e.CuentaDetId, e.DeptoCoId })
                    .HasName("prorrateos_det_pk");

                entity.ToTable("prorrateos_det");

                entity.Property(e => e.CuentaId).HasColumnName("cuenta_id");

                entity.Property(e => e.CuentaDetId).HasColumnName("cuenta_det_id");

                entity.Property(e => e.DeptoCoId).HasColumnName("depto_co_id");

                entity.Property(e => e.Pctje)
                    .HasColumnName("pctje")
                    .HasColumnType("decimal(9, 6)");

                entity.HasOne(d => d.CuentaDet)
                    .WithMany(p => p.ProrrateosDetCuentaDet)
                    .HasForeignKey(d => d.CuentaDetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cuentas_a_prorrat_det");

                entity.HasOne(d => d.Cuenta)
                    .WithMany(p => p.ProrrateosDetCuenta)
                    .HasForeignKey(d => d.CuentaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cuentas_a_prorrat");

                entity.HasOne(d => d.DeptoCo)
                    .WithMany(p => p.ProrrateosDet)
                    .HasForeignKey(d => d.DeptoCoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("deptos_a_prorrat");
            });

            modelBuilder.Entity<Proveedores>(entity =>
            {
                entity.HasKey(e => e.ProveedorId)
                    .HasName("proveedores_pk");

                entity.ToTable("proveedores");

                entity.HasIndex(e => e.Nombre)
                    .HasName("proveedores_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.ProveedorId)
                    .HasColumnName("proveedor_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActividadPrincipal)
                    .HasColumnName("actividad_principal")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Calle)
                    .HasColumnName("calle")
                    .HasMaxLength(430)
                    .IsUnicode(false);

                entity.Property(e => e.CargaImpuestos)
                    .HasColumnName("carga_impuestos")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CausaSusp)
                    .HasColumnName("causa_susp")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CiudadId).HasColumnName("ciudad_id");

                entity.Property(e => e.CodigoPostal)
                    .HasColumnName("codigo_postal")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Colonia)
                    .HasColumnName("colonia")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ConceptoBaId).HasColumnName("concepto_ba_id");

                entity.Property(e => e.CondPagoId).HasColumnName("cond_pago_id");

                entity.Property(e => e.Contacto1)
                    .HasColumnName("contacto1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contacto2)
                    .HasColumnName("contacto2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaAnticipos)
                    .HasColumnName("cuenta_anticipos")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaCxp)
                    .HasColumnName("cuenta_cxp")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoId).HasColumnName("estado_id");

                entity.Property(e => e.Estatus)
                    .HasColumnName("estatus")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Extranjero)
                    .HasColumnName("extranjero")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.FechaSusp)
                    .HasColumnName("fecha_susp")
                    .HasColumnType("date");

                entity.Property(e => e.FormatosEmail)
                    .HasColumnName("formatos_email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LimiteCredito)
                    .HasColumnName("limite_credito")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.MonedaId).HasColumnName("moneda_id");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCalle)
                    .HasColumnName("nombre_calle")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Notas)
                    .HasColumnName("notas")
                    .IsUnicode(false);

                entity.Property(e => e.NumExterior)
                    .HasColumnName("num_exterior")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumInterior)
                    .HasColumnName("num_interior")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaisId).HasColumnName("pais_id");

                entity.Property(e => e.Poblacion)
                    .HasColumnName("poblacion")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Referencia)
                    .HasColumnName("referencia")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RetenerImpuestos)
                    .HasColumnName("retener_impuestos")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RfcCurp)
                    .HasColumnName("rfc_curp")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.SujetoIeps)
                    .IsRequired()
                    .HasColumnName("sujeto_ieps")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TaxId)
                    .HasColumnName("tax_id")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono1)
                    .HasColumnName("telefono1")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono2)
                    .HasColumnName("telefono2")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.TipoProvId).HasColumnName("tipo_prov_id");

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.ViaEmbarqueId).HasColumnName("via_embarque_id");

                entity.HasOne(d => d.Ciudad)
                    .WithMany(p => p.Proveedores)
                    .HasForeignKey(d => d.CiudadId)
                    .HasConstraintName("ciudades_a_prov");

                entity.HasOne(d => d.ConceptoBa)
                    .WithMany(p => p.Proveedores)
                    .HasForeignKey(d => d.ConceptoBaId)
                    .HasConstraintName("concep_ba_a_prov");

                entity.HasOne(d => d.CondPago)
                    .WithMany(p => p.Proveedores)
                    .HasForeignKey(d => d.CondPagoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cond_pago_a_prov");

                entity.HasOne(d => d.Moneda)
                    .WithMany(p => p.Proveedores)
                    .HasForeignKey(d => d.MonedaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("monedas_a_prov");

                entity.HasOne(d => d.TipoProv)
                    .WithMany(p => p.Proveedores)
                    .HasForeignKey(d => d.TipoProvId)
                    .HasConstraintName("tipos_prov_a_prov");

                entity.HasOne(d => d.ViaEmbarque)
                    .WithMany(p => p.Proveedores)
                    .HasForeignKey(d => d.ViaEmbarqueId)
                    .HasConstraintName("via_emb_a_prov");
            });

            modelBuilder.Entity<PuestosNo>(entity =>
            {
                entity.HasKey(e => e.PuestoNoId)
                    .HasName("puestos_no_pk");

                entity.ToTable("puestos_no");

                entity.HasIndex(e => e.Nombre)
                    .HasName("puestos_no_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.PuestoNoId)
                    .HasColumnName("puesto_no_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EsPredet)
                    .HasColumnName("es_predet")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SueldoDiario)
                    .HasColumnName("sueldo_diario")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.SueldoDiarioMax)
                    .HasColumnName("sueldo_diario_max")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RazonesVisInef>(entity =>
            {
                entity.HasKey(e => e.RazonVisInefId)
                    .HasName("razones_vis_inef_pk");

                entity.ToTable("razones_vis_inef");

                entity.HasIndex(e => e.Nombre)
                    .HasName("razones_vis_inef_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.RazonVisInefId)
                    .HasColumnName("razon_vis_inef_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EsPredet)
                    .HasColumnName("es_predet")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.VersionRegistro).HasColumnName("version_registro");
            });

            modelBuilder.Entity<Recordatorios>(entity =>
            {
                entity.HasKey(e => e.RecordatorioId)
                    .HasName("recordatorios_pk");

                entity.ToTable("recordatorios");

                entity.HasIndex(e => e.Descripcion)
                    .HasName("recordatorios_ak1")
                    .IsUnique()
                    .HasFilter("([descripcion] IS NOT NULL)");

                entity.Property(e => e.RecordatorioId)
                    .HasColumnName("recordatorio_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RedondeoPrecios>(entity =>
            {
                entity.HasKey(e => e.RedondeoPrecioId)
                    .HasName("redondeo_precios_pk");

                entity.ToTable("redondeo_precios");

                entity.HasIndex(e => e.PrecioMaximo)
                    .HasName("redondeo_precios_ak1")
                    .IsUnique()
                    .HasFilter("([precio_maximo] IS NOT NULL)");

                entity.Property(e => e.RedondeoPrecioId)
                    .HasColumnName("redondeo_precio_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.FactorRedondeo)
                    .HasColumnName("factor_redondeo")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.PrecioMaximo)
                    .HasColumnName("precio_maximo")
                    .HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<RegPatronales>(entity =>
            {
                entity.HasKey(e => e.RegPatronalId)
                    .HasName("reg_patronal_id_pk");

                entity.ToTable("reg_patronales");

                entity.HasIndex(e => e.NumRegPatronal)
                    .HasName("reg_patronales_uq1")
                    .IsUnique()
                    .HasFilter("([num_reg_patronal] IS NOT NULL)");

                entity.Property(e => e.RegPatronalId)
                    .HasColumnName("reg_patronal_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CiudadId).HasColumnName("ciudad_id");

                entity.Property(e => e.ClaseRiesgoSat)
                    .HasColumnName("clase_riesgo_sat")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.NumGuia)
                    .HasColumnName("num_guia")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.NumRegPatronal)
                    .IsRequired()
                    .HasColumnName("num_reg_patronal")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaRiesgo)
                    .HasColumnName("prima_riesgo")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.TipoIsnId).HasColumnName("tipo_isn_id");

                entity.HasOne(d => d.Ciudad)
                    .WithMany(p => p.RegPatronales)
                    .HasForeignKey(d => d.CiudadId)
                    .HasConstraintName("ciudades_a_reg_patronales");

                entity.HasOne(d => d.TipoIsn)
                    .WithMany(p => p.RegPatronales)
                    .HasForeignKey(d => d.TipoIsnId)
                    .HasConstraintName("tipos_isn_a_reg_patronales");
            });

            modelBuilder.Entity<Registry>(entity =>
            {
                entity.HasKey(e => e.ElementoId)
                    .HasName("registry_pk");

                entity.ToTable("registry");

                entity.HasIndex(e => new { e.PadreId, e.Nombre })
                    .HasName("registry_ak1")
                    .IsUnique()
                    .HasFilter("([padre_id] IS NOT NULL AND [nombre] IS NOT NULL)");

                entity.Property(e => e.ElementoId)
                    .HasColumnName("elemento_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PadreId).HasColumnName("padre_id");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("tipo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ValorBlob)
                    .HasColumnName("valor_blob")
                    .IsUnicode(false);

                entity.Property(e => e.ValorMemo)
                    .HasColumnName("valor_memo")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RepositorioCfdi>(entity =>
            {
                entity.HasKey(e => e.CfdiId)
                    .HasName("repositorio_cfdi_pk");

                entity.ToTable("repositorio_cfdi");

                entity.HasIndex(e => e.Fecha)
                    .HasName("repositorio_cfdi_ie1");

                entity.HasIndex(e => e.Nombre)
                    .HasName("repositorio_cfdi_ie3");

                entity.HasIndex(e => e.ReferGrupo)
                    .HasName("repositorio_cfdi_ie4");

                entity.HasIndex(e => e.Rfc)
                    .HasName("repositorio_cfdi_ie2");

                entity.HasIndex(e => e.Uuid)
                    .HasName("repositorio_cfdi_uq1")
                    .IsUnique()
                    .HasFilter("([uuid] IS NOT NULL)");

                entity.Property(e => e.CfdiId)
                    .HasColumnName("cfdi_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CfdiSustitutoId).HasColumnName("cfdi_sustituto_id");

                entity.Property(e => e.EsParcialidad)
                    .IsRequired()
                    .HasColumnName("es_parcialidad")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EsSustituto)
                    .IsRequired()
                    .HasColumnName("es_sustituto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.FechaCancelacion)
                    .HasColumnName("fecha_cancelacion")
                    .HasColumnType("date");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Folio)
                    .HasColumnName("folio")
                    .HasMaxLength(65)
                    .IsUnicode(false);

                entity.Property(e => e.Importe)
                    .HasColumnName("importe")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ModalidadFacturacion)
                    .IsRequired()
                    .HasColumnName("modalidad_facturacion")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Moneda)
                    .IsRequired()
                    .HasColumnName("moneda")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Naturaleza)
                    .IsRequired()
                    .HasColumnName("naturaleza")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('E')");

                entity.Property(e => e.NomArch)
                    .HasColumnName("nom_arch")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReferGrupo)
                    .HasColumnName("refer_grupo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Rfc)
                    .HasColumnName("rfc")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.SelloValidado)
                    .IsRequired()
                    .HasColumnName("sello_validado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Taxid)
                    .HasColumnName("taxid")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TipoCambio)
                    .HasColumnName("tipo_cambio")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.TipoComprobante)
                    .IsRequired()
                    .HasColumnName("tipo_comprobante")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('I')");

                entity.Property(e => e.TipoDoctoMsp)
                    .HasColumnName("tipo_docto_msp")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioValSello)
                    .HasColumnName("usuario_val_sello")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.Uuid)
                    .IsRequired()
                    .HasColumnName("uuid")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasColumnName("version")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Xml)
                    .HasColumnName("xml")
                    .IsUnicode(false);

                entity.HasOne(d => d.CfdiSustituto)
                    .WithMany(p => p.InverseCfdiSustituto)
                    .HasForeignKey(d => d.CfdiSustitutoId)
                    .HasConstraintName("rep_cfdi_a_cfdi_sustituto");
            });

            modelBuilder.Entity<ResumenElimHistIn>(entity =>
            {
                entity.HasKey(e => new { e.AlmacenId, e.ArticuloId })
                    .HasName("resumen_elim_hist_in_pk");

                entity.ToTable("resumen_elim_hist_in");

                entity.Property(e => e.AlmacenId).HasColumnName("almacen_id");

                entity.Property(e => e.ArticuloId).HasColumnName("articulo_id");

                entity.Property(e => e.TotCosto)
                    .HasColumnName("tot_costo")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.TotUnid)
                    .HasColumnName("tot_unid")
                    .HasColumnType("decimal(18, 5)");
            });

            modelBuilder.Entity<RolesClavesArticulos>(entity =>
            {
                entity.HasKey(e => e.RolClaveArtId)
                    .HasName("roles_claves_art_pk");

                entity.ToTable("roles_claves_articulos");

                entity.HasIndex(e => e.Nombre)
                    .HasName("roles_claves_art_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.RolClaveArtId)
                    .HasColumnName("rol_clave_art_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EsGtin)
                    .HasColumnName("es_gtin")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EsPpal)
                    .HasColumnName("es_ppal")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RolesClavesClientes>(entity =>
            {
                entity.HasKey(e => e.RolClaveCliId)
                    .HasName("roles_claves_cli_pk");

                entity.ToTable("roles_claves_clientes");

                entity.HasIndex(e => e.Nombre)
                    .HasName("roles_claves_cli_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.RolClaveCliId)
                    .HasColumnName("rol_clave_cli_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EsGln)
                    .HasColumnName("es_gln")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EsPpal)
                    .HasColumnName("es_ppal")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RolesClavesEmpleados>(entity =>
            {
                entity.HasKey(e => e.RolClaveEmpId)
                    .HasName("roles_claves_emp_pk");

                entity.ToTable("roles_claves_empleados");

                entity.HasIndex(e => e.Nombre)
                    .HasName("roles_claves_emp_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.RolClaveEmpId)
                    .HasColumnName("rol_clave_emp_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EsPpal)
                    .HasColumnName("es_ppal")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RolesClavesProveedores>(entity =>
            {
                entity.HasKey(e => e.RolClaveProvId)
                    .HasName("roles_claves_prov_pk");

                entity.ToTable("roles_claves_proveedores");

                entity.HasIndex(e => e.Nombre)
                    .HasName("roles_claves_prov_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.RolClaveProvId)
                    .HasColumnName("rol_clave_prov_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EsPpal)
                    .HasColumnName("es_ppal")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RolesImagenesActivosFijos>(entity =>
            {
                entity.HasKey(e => e.RolImagenActfijoId)
                    .HasName("roles_imagenes_actfijos_pk");

                entity.ToTable("roles_imagenes_activos_fijos");

                entity.HasIndex(e => e.Nombre)
                    .HasName("roles_imagenes_actfijos_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.RolImagenActfijoId)
                    .HasColumnName("rol_imagen_actfijo_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EsPpal)
                    .HasColumnName("es_ppal")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RolesImagenesArticulos>(entity =>
            {
                entity.HasKey(e => e.RolImagenArtId)
                    .HasName("roles_imagenes_art_pk");

                entity.ToTable("roles_imagenes_articulos");

                entity.HasIndex(e => e.Nombre)
                    .HasName("roles_imagenes_art_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.RolImagenArtId)
                    .HasColumnName("rol_imagen_art_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EsPpal)
                    .HasColumnName("es_ppal")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RolesImagenesClientes>(entity =>
            {
                entity.HasKey(e => e.RolImagenCliId)
                    .HasName("roles_imagenes_cli_pk");

                entity.ToTable("roles_imagenes_clientes");

                entity.HasIndex(e => e.Nombre)
                    .HasName("roles_imagenes_cli_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.RolImagenCliId)
                    .HasColumnName("rol_imagen_cli_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EsPpal)
                    .HasColumnName("es_ppal")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RolesImagenesEmpleados>(entity =>
            {
                entity.HasKey(e => e.RolImagenEmpId)
                    .HasName("roles_imagenes_emp_pk");

                entity.ToTable("roles_imagenes_empleados");

                entity.HasIndex(e => e.Nombre)
                    .HasName("roles_imagenes_emp_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.RolImagenEmpId)
                    .HasColumnName("rol_imagen_emp_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EsPpal)
                    .HasColumnName("es_ppal")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RolesImagenesProveedores>(entity =>
            {
                entity.HasKey(e => e.RolImagenProvId)
                    .HasName("roles_imagenes_prov_pk");

                entity.ToTable("roles_imagenes_proveedores");

                entity.HasIndex(e => e.Nombre)
                    .HasName("roles_imagenes_prov_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.RolImagenProvId)
                    .HasColumnName("rol_imagen_prov_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EsPpal)
                    .HasColumnName("es_ppal")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Rutas>(entity =>
            {
                entity.HasKey(e => e.RutaId)
                    .HasName("rutas_pk");

                entity.ToTable("rutas");

                entity.HasIndex(e => e.Clave)
                    .HasName("rutas_ak2")
                    .IsUnique()
                    .HasFilter("([clave] IS NOT NULL)");

                entity.HasIndex(e => e.Nombre)
                    .HasName("rutas_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.RutaId)
                    .HasColumnName("ruta_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AgenteId).HasColumnName("agente_id");

                entity.Property(e => e.Clave)
                    .HasColumnName("clave")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Estatus)
                    .IsRequired()
                    .HasColumnName("estatus")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.GrupoRutasId).HasColumnName("grupo_rutas_id");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.VersionRegistro).HasColumnName("version_registro");

                entity.HasOne(d => d.Agente)
                    .WithMany(p => p.Rutas)
                    .HasForeignKey(d => d.AgenteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("agentes_a_rutas");

                entity.HasOne(d => d.GrupoRutas)
                    .WithMany(p => p.Rutas)
                    .HasForeignKey(d => d.GrupoRutasId)
                    .HasConstraintName("grupos_rutas_a_rutas");
            });

            modelBuilder.Entity<RutasDet>(entity =>
            {
                entity.HasKey(e => e.RutaDetId)
                    .HasName("rutas_det_pk");

                entity.ToTable("rutas_det");

                entity.HasIndex(e => new { e.RutaId, e.Dia, e.ClienteId })
                    .HasName("rutas_det_ak1")
                    .IsUnique()
                    .HasFilter("([ruta_id] IS NOT NULL AND [dia] IS NOT NULL AND [cliente_id] IS NOT NULL)");

                entity.Property(e => e.RutaDetId)
                    .HasColumnName("ruta_det_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClaveCliente)
                    .HasColumnName("clave_cliente")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteId).HasColumnName("cliente_id");

                entity.Property(e => e.Dia).HasColumnName("dia");

                entity.Property(e => e.DiaPosicion).HasColumnName("dia_posicion");

                entity.Property(e => e.RutaId).HasColumnName("ruta_id");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.RutasDet)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("clientes_a_rutas_det");

                entity.HasOne(d => d.Ruta)
                    .WithMany(p => p.RutasDet)
                    .HasForeignKey(d => d.RutaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("rutas_a_det");
            });

            modelBuilder.Entity<SalariosMin>(entity =>
            {
                entity.HasKey(e => e.SalarioMinId)
                    .HasName("salarios_min_pk");

                entity.ToTable("salarios_min");

                entity.HasIndex(e => new { e.Zona, e.FechaVigencia })
                    .HasName("salarios_min_ak1")
                    .IsUnique()
                    .HasFilter("([zona] IS NOT NULL AND [fecha_vigencia] IS NOT NULL)");

                entity.Property(e => e.SalarioMinId)
                    .HasColumnName("salario_min_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.FechaVigencia)
                    .HasColumnName("fecha_vigencia")
                    .HasColumnType("date");

                entity.Property(e => e.SalarioDiario)
                    .HasColumnName("salario_diario")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Zona)
                    .HasColumnName("zona")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('A')");
            });

            modelBuilder.Entity<SaldosBa>(entity =>
            {
                entity.HasKey(e => new { e.CuentaBanId, e.Ano, e.Mes })
                    .HasName("saldos_ba_pk");

                entity.ToTable("saldos_ba");

                entity.HasIndex(e => new { e.CuentaBanId, e.Anomes })
                    .HasName("saldos_ba_ie1");

                entity.Property(e => e.CuentaBanId).HasColumnName("cuenta_ban_id");

                entity.Property(e => e.Ano).HasColumnName("ano");

                entity.Property(e => e.Mes).HasColumnName("mes");

                entity.Property(e => e.Anomes).HasColumnName("anomes");

                entity.Property(e => e.Depositos)
                    .HasColumnName("depositos")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Retiros)
                    .HasColumnName("retiros")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.SaldoFinal)
                    .HasColumnName("saldo_final")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.UltimoDia).HasColumnName("ultimo_dia");

                entity.HasOne(d => d.CuentaBan)
                    .WithMany(p => p.SaldosBa)
                    .HasForeignKey(d => d.CuentaBanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ctaban_a_saldos");
            });

            modelBuilder.Entity<SaldosCc>(entity =>
            {
                entity.HasKey(e => new { e.ClienteId, e.Ano, e.Mes })
                    .HasName("saldos_cc_pk");

                entity.ToTable("saldos_cc");

                entity.Property(e => e.ClienteId).HasColumnName("cliente_id");

                entity.Property(e => e.Ano).HasColumnName("ano");

                entity.Property(e => e.Mes).HasColumnName("mes");

                entity.Property(e => e.CargosCxc)
                    .HasColumnName("cargos_cxc")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.CargosXacr)
                    .HasColumnName("cargos_xacr")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.CreditosCxc)
                    .HasColumnName("creditos_cxc")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.CreditosCxcXlib)
                    .HasColumnName("creditos_cxc_xlib")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.CreditosXacr)
                    .HasColumnName("creditos_xacr")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.CreditosXacrXlib)
                    .HasColumnName("creditos_xacr_xlib")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.UltimoDia).HasColumnName("ultimo_dia");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.SaldosCc)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cli_a_saldos");
            });

            modelBuilder.Entity<SaldosCo>(entity =>
            {
                entity.HasKey(e => new { e.CuentaId, e.DeptoCoId, e.Ano, e.Mes })
                    .HasName("saldos_co_pk");

                entity.ToTable("saldos_co");

                entity.Property(e => e.CuentaId).HasColumnName("cuenta_id");

                entity.Property(e => e.DeptoCoId).HasColumnName("depto_co_id");

                entity.Property(e => e.Ano).HasColumnName("ano");

                entity.Property(e => e.Mes).HasColumnName("mes");

                entity.Property(e => e.Abonos)
                    .HasColumnName("abonos")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Anomes).HasColumnName("anomes");

                entity.Property(e => e.Cargos)
                    .HasColumnName("cargos")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.SaldoFinal)
                    .HasColumnName("saldo_final")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.UltimoDia).HasColumnName("ultimo_dia");

                entity.HasOne(d => d.Cuenta)
                    .WithMany(p => p.SaldosCo)
                    .HasForeignKey(d => d.CuentaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cuentas_co_a_saldos");

                entity.HasOne(d => d.DeptoCo)
                    .WithMany(p => p.SaldosCo)
                    .HasForeignKey(d => d.DeptoCoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("deptos_co_a_saldos");
            });

            modelBuilder.Entity<SaldosCp>(entity =>
            {
                entity.HasKey(e => new { e.ProveedorId, e.Ano, e.Mes })
                    .HasName("saldos_cp_pk");

                entity.ToTable("saldos_cp");

                entity.Property(e => e.ProveedorId).HasColumnName("proveedor_id");

                entity.Property(e => e.Ano).HasColumnName("ano");

                entity.Property(e => e.Mes).HasColumnName("mes");

                entity.Property(e => e.CargosAnticipos)
                    .HasColumnName("cargos_anticipos")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.CargosCxp)
                    .HasColumnName("cargos_cxp")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.CreditosAnticipos)
                    .HasColumnName("creditos_anticipos")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.CreditosCxp)
                    .HasColumnName("creditos_cxp")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.UltimoDia).HasColumnName("ultimo_dia");

                entity.HasOne(d => d.Proveedor)
                    .WithMany(p => p.SaldosCp)
                    .HasForeignKey(d => d.ProveedorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("prov_a_saldos");
            });

            modelBuilder.Entity<SaldosEdofin>(entity =>
            {
                entity.HasKey(e => new { e.TipoReg, e.CuentaJt, e.DeptoCoId })
                    .HasName("saldos_edofin_pk");

                entity.ToTable("saldos_edofin");

                entity.Property(e => e.TipoReg)
                    .HasColumnName("tipo_reg")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CuentaJt)
                    .HasColumnName("cuenta_jt")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DeptoCoId).HasColumnName("depto_co_id");

                entity.Property(e => e.Mnet01)
                    .HasColumnName("mnet01")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Mnet02)
                    .HasColumnName("mnet02")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Mnet03)
                    .HasColumnName("mnet03")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Mnet04)
                    .HasColumnName("mnet04")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Mnet05)
                    .HasColumnName("mnet05")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Mnet06)
                    .HasColumnName("mnet06")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Mnet07)
                    .HasColumnName("mnet07")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Mnet08)
                    .HasColumnName("mnet08")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Mnet09)
                    .HasColumnName("mnet09")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Mnet10)
                    .HasColumnName("mnet10")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Mnet11)
                    .HasColumnName("mnet11")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Mnet12)
                    .HasColumnName("mnet12")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.MnetPer1)
                    .HasColumnName("mnet_per1")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.MnetPer2)
                    .HasColumnName("mnet_per2")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.MnetPerh)
                    .HasColumnName("mnet_perh")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Naturaleza)
                    .HasColumnName("naturaleza")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SaldoIniEjerPer1)
                    .HasColumnName("saldo_ini_ejer_per1")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.SaldoIniEjerPer2)
                    .HasColumnName("saldo_ini_ejer_per2")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.SaldoIniEjerPerh)
                    .HasColumnName("saldo_ini_ejer_perh")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.SaldoIniPer1)
                    .HasColumnName("saldo_ini_per1")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.SaldoIniPer2)
                    .HasColumnName("saldo_ini_per2")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.SaldoIniPerh)
                    .HasColumnName("saldo_ini_perh")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.DeptoCo)
                    .WithMany(p => p.SaldosEdofin)
                    .HasForeignKey(d => d.DeptoCoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("deptos_co_a_sdos_edofin");
            });

            modelBuilder.Entity<SaldosIn>(entity =>
            {
                entity.HasKey(e => new { e.ArticuloId, e.AlmacenId, e.Ano, e.Mes })
                    .HasName("saldos_in_pk");

                entity.ToTable("saldos_in");

                entity.Property(e => e.ArticuloId).HasColumnName("articulo_id");

                entity.Property(e => e.AlmacenId).HasColumnName("almacen_id");

                entity.Property(e => e.Ano).HasColumnName("ano");

                entity.Property(e => e.Mes).HasColumnName("mes");

                entity.Property(e => e.EntradasCosto)
                    .HasColumnName("entradas_costo")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.EntradasUnidades)
                    .HasColumnName("entradas_unidades")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.SalidasCosto)
                    .HasColumnName("salidas_costo")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.SalidasUnidades)
                    .HasColumnName("salidas_unidades")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.UltimoDia).HasColumnName("ultimo_dia");

                entity.HasOne(d => d.Almacen)
                    .WithMany(p => p.SaldosIn)
                    .HasForeignKey(d => d.AlmacenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("alm_a_saldos_in");

                entity.HasOne(d => d.Articulo)
                    .WithMany(p => p.SaldosIn)
                    .HasForeignKey(d => d.ArticuloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("arts_a_saldos_in");
            });

            modelBuilder.Entity<Semaforos>(entity =>
            {
                entity.HasKey(e => e.ClaveSemaf)
                    .HasName("semaforos_pk");

                entity.ToTable("semaforos");

                entity.Property(e => e.ClaveSemaf)
                    .HasColumnName("clave_semaf")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .HasColumnName("usuario")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SnubeComandosAgente>(entity =>
            {
                entity.HasKey(e => e.SnubeComandoAgenteId)
                    .HasName("snube_comandos_agente_pk");

                entity.ToTable("snube_comandos_agente");

                entity.Property(e => e.SnubeComandoAgenteId)
                    .HasColumnName("snube_comando_agente_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.ObjJson)
                    .IsRequired()
                    .HasColumnName("obj_json")
                    .IsUnicode(false);

                entity.Property(e => e.Origen)
                    .IsRequired()
                    .HasColumnName("origen")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Prioridad)
                    .HasColumnName("prioridad")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Procesado)
                    .IsRequired()
                    .HasColumnName("procesado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Resultado)
                    .HasColumnName("resultado")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SnubeConciliacionInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("snube_conciliacion_info");

                entity.Property(e => e.NomColumna)
                    .IsRequired()
                    .HasColumnName("nom_columna")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.SnubeMapeoId).HasColumnName("snube_mapeo_id");

                entity.Property(e => e.Valor)
                    .IsRequired()
                    .HasColumnName("valor")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.SnubeMapeo)
                    .WithMany()
                    .HasForeignKey(d => d.SnubeMapeoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("snube_mapeos_a_info");
            });

            modelBuilder.Entity<SnubeEventosTemp>(entity =>
            {
                entity.HasKey(e => e.SnubeEventoTempId)
                    .HasName("snube_eventos_temp_pk");

                entity.ToTable("snube_eventos_temp");

                entity.Property(e => e.SnubeEventoTempId)
                    .HasColumnName("snube_evento_temp_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ElementoId).HasColumnName("elemento_id");

                entity.Property(e => e.ElementoId2)
                    .HasColumnName("elemento_id2")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.NomTabla)
                    .IsRequired()
                    .HasColumnName("nom_tabla")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.ProcesoId).HasColumnName("proceso_id");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("tipo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SnubeGttEventos>(entity =>
            {
                entity.HasKey(e => e.SnubeGttEventoId)
                    .HasName("snube_gtt_eventos_pk");

                entity.ToTable("snube_gtt_eventos");

                entity.HasIndex(e => new { e.NomTabla, e.ProcesoId, e.ElementoId })
                    .HasName("snube_gtt_eventos_ak1")
                    .IsUnique()
                    .HasFilter("([nom_tabla] IS NOT NULL AND [proceso_id] IS NOT NULL AND [elemento_id] IS NOT NULL)");

                entity.Property(e => e.SnubeGttEventoId)
                    .HasColumnName("snube_gtt_evento_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ElementoId).HasColumnName("elemento_id");

                entity.Property(e => e.ElementoId2)
                    .HasColumnName("elemento_id2")
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.Property(e => e.NomTabla)
                    .IsRequired()
                    .HasColumnName("nom_tabla")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.ProcesoId).HasColumnName("proceso_id");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("tipo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SnubeMapeos>(entity =>
            {
                entity.HasKey(e => e.SnubeMapeoId)
                    .HasName("snube_mapeos_pk1");

                entity.ToTable("snube_mapeos");

                entity.HasIndex(e => e.ObjLocalId)
                    .HasName("snube_mapeos_ie2");

                entity.HasIndex(e => e.ObjSnubeId)
                    .HasName("snube_mapeos_ie1");

                entity.Property(e => e.SnubeMapeoId)
                    .HasColumnName("snube_mapeo_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.NomTabla)
                    .IsRequired()
                    .HasColumnName("nom_tabla")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.ObjLocalId).HasColumnName("obj_local_id");

                entity.Property(e => e.ObjSnubeId).HasColumnName("obj_snube_id");
            });

            modelBuilder.Entity<SnubeSucursales>(entity =>
            {
                entity.HasKey(e => e.SnubeSucursalId)
                    .HasName("snube_sucursales_pk");

                entity.ToTable("snube_sucursales");

                entity.HasIndex(e => e.Nombre)
                    .HasName("snube_sucursales_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.SnubeSucursalId)
                    .HasColumnName("snube_sucursal_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactoCorreo)
                    .HasColumnName("contacto_correo")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ContactoNombre)
                    .HasColumnName("contacto_nombre")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasColumnName("direccion")
                    .HasMaxLength(430)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasMaxLength(35)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SnubeSucursalesConsultas>(entity =>
            {
                entity.HasKey(e => e.SnubeSucursalId)
                    .HasName("snube_sucursales_consultas_pk");

                entity.ToTable("snube_sucursales_consultas");

                entity.Property(e => e.SnubeSucursalId)
                    .HasColumnName("snube_sucursal_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConsultarExistencia)
                    .IsRequired()
                    .HasColumnName("consultar_existencia")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Posicion).HasColumnName("posicion");

                entity.HasOne(d => d.SnubeSucursal)
                    .WithOne(p => p.SnubeSucursalesConsultas)
                    .HasForeignKey<SnubeSucursalesConsultas>(d => d.SnubeSucursalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("snube_sucursales_a_consultas");
            });

            modelBuilder.Entity<SnubeSucursalesDispersion>(entity =>
            {
                entity.HasKey(e => e.SnubeSucursalDispId)
                    .HasName("snube_sucursales_dispersion_pk");

                entity.ToTable("snube_sucursales_dispersion");

                entity.HasIndex(e => new { e.SnubeSucursalId, e.Tipo, e.ElementoId })
                    .HasName("snube_sucursales_dispersion_ak1")
                    .IsUnique()
                    .HasFilter("([snube_sucursal_id] IS NOT NULL AND [tipo] IS NOT NULL AND [elemento_id] IS NOT NULL)");

                entity.Property(e => e.SnubeSucursalDispId)
                    .HasColumnName("snube_sucursal_disp_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ElementoId).HasColumnName("elemento_id");

                entity.Property(e => e.SnubeSucursalId).HasColumnName("snube_sucursal_id");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("tipo")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.SnubeSucursal)
                    .WithMany(p => p.SnubeSucursalesDispersion)
                    .HasForeignKey(d => d.SnubeSucursalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("snube_sucursales_a_disp");
            });

            modelBuilder.Entity<SnubeSucursalesLlaves>(entity =>
            {
                entity.HasKey(e => e.SnubeSucursalId)
                    .HasName("snube_sucursales_llaves_pk1");

                entity.ToTable("snube_sucursales_llaves");

                entity.Property(e => e.SnubeSucursalId)
                    .HasColumnName("snube_sucursal_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApiToken)
                    .IsRequired()
                    .HasColumnName("api_token")
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.SnubeSucursal)
                    .WithOne(p => p.SnubeSucursalesLlaves)
                    .HasForeignKey<SnubeSucursalesLlaves>(d => d.SnubeSucursalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("snube_sucursales_a_llaves");
            });

            modelBuilder.Entity<SubMovtosCc>(entity =>
            {
                entity.HasKey(e => new { e.DoctoCcId, e.SubMovtoId })
                    .HasName("sub_movtos_cc_pk");

                entity.ToTable("sub_movtos_cc");

                entity.Property(e => e.DoctoCcId).HasColumnName("docto_cc_id");

                entity.Property(e => e.SubMovtoId).HasColumnName("sub_movto_id");

                entity.HasOne(d => d.DoctoCc)
                    .WithMany(p => p.SubMovtosCcDoctoCc)
                    .HasForeignKey(d => d.DoctoCcId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("movtos_con_submovtos_cc");

                entity.HasOne(d => d.SubMovto)
                    .WithMany(p => p.SubMovtosCcSubMovto)
                    .HasForeignKey(d => d.SubMovtoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sub_movtos_ids_cc");
            });

            modelBuilder.Entity<SubMovtosCp>(entity =>
            {
                entity.HasKey(e => new { e.DoctoCpId, e.SubMovtoId })
                    .HasName("sub_movtos_cp_pk");

                entity.ToTable("sub_movtos_cp");

                entity.Property(e => e.DoctoCpId).HasColumnName("docto_cp_id");

                entity.Property(e => e.SubMovtoId).HasColumnName("sub_movto_id");

                entity.HasOne(d => d.DoctoCp)
                    .WithMany(p => p.SubMovtosCpDoctoCp)
                    .HasForeignKey(d => d.DoctoCpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("movtos_con_submovtos_cp");

                entity.HasOne(d => d.SubMovto)
                    .WithMany(p => p.SubMovtosCpSubMovto)
                    .HasForeignKey(d => d.SubMovtoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sub_movtos_ids_cp");
            });

            modelBuilder.Entity<SubMovtosIn>(entity =>
            {
                entity.HasKey(e => new { e.DoctoInDetId, e.SubMovtoId })
                    .HasName("sub_movtos_in_pk");

                entity.ToTable("sub_movtos_in");

                entity.Property(e => e.DoctoInDetId).HasColumnName("docto_in_det_id");

                entity.Property(e => e.SubMovtoId).HasColumnName("sub_movto_id");

                entity.HasOne(d => d.DoctoInDet)
                    .WithMany(p => p.SubMovtosInDoctoInDet)
                    .HasForeignKey(d => d.DoctoInDetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("movtos_con_submovtos");

                entity.HasOne(d => d.SubMovto)
                    .WithMany(p => p.SubMovtosInSubMovto)
                    .HasForeignKey(d => d.SubMovtoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sub_movtos_ids");
            });

            modelBuilder.Entity<SubMovtosPv>(entity =>
            {
                entity.HasKey(e => new { e.DoctoPvDetId, e.SubMovtoPvId })
                    .HasName("sub_movtos_pv_pk");

                entity.ToTable("sub_movtos_pv");

                entity.Property(e => e.DoctoPvDetId).HasColumnName("docto_pv_det_id");

                entity.Property(e => e.SubMovtoPvId).HasColumnName("sub_movto_pv_id");

                entity.HasOne(d => d.DoctoPvDet)
                    .WithMany(p => p.SubMovtosPvDoctoPvDet)
                    .HasForeignKey(d => d.DoctoPvDetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("movtos_pv_con_submovtos");

                entity.HasOne(d => d.SubMovtoPv)
                    .WithMany(p => p.SubMovtosPvSubMovtoPv)
                    .HasForeignKey(d => d.SubMovtoPvId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sub_movtos_pv_ids");
            });

            modelBuilder.Entity<SubMovtosVe>(entity =>
            {
                entity.HasKey(e => new { e.DoctoVeDetId, e.SubMovtoVeId })
                    .HasName("sub_movtos_ve_pk");

                entity.ToTable("sub_movtos_ve");

                entity.Property(e => e.DoctoVeDetId).HasColumnName("docto_ve_det_id");

                entity.Property(e => e.SubMovtoVeId).HasColumnName("sub_movto_ve_id");

                entity.HasOne(d => d.DoctoVeDet)
                    .WithMany(p => p.SubMovtosVeDoctoVeDet)
                    .HasForeignKey(d => d.DoctoVeDetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("movtos_ve_con_submovtos");

                entity.HasOne(d => d.SubMovtoVe)
                    .WithMany(p => p.SubMovtosVeSubMovtoVe)
                    .HasForeignKey(d => d.SubMovtoVeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sub_movtos_ve_ids");
            });

            modelBuilder.Entity<SubcontratosEmp>(entity =>
            {
                entity.HasKey(e => e.SubcontratoEmpId)
                    .HasName("subcontratos_emp_pk");

                entity.ToTable("subcontratos_emp");

                entity.Property(e => e.SubcontratoEmpId)
                    .HasColumnName("subcontrato_emp_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EmpleadoId).HasColumnName("empleado_id");

                entity.Property(e => e.PorcentajeTiempo)
                    .HasColumnName("porcentaje_tiempo")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.TerceroCoId).HasColumnName("tercero_co_id");

                entity.HasOne(d => d.Empleado)
                    .WithMany(p => p.SubcontratosEmp)
                    .HasForeignKey(d => d.EmpleadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("emp_a_subcontratos");

                entity.HasOne(d => d.TerceroCo)
                    .WithMany(p => p.SubcontratosEmp)
                    .HasForeignKey(d => d.TerceroCoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("terceros_a_subcontratos");
            });

            modelBuilder.Entity<Sucursales>(entity =>
            {
                entity.HasKey(e => e.SucursalId)
                    .HasName("sucursales_pk");

                entity.ToTable("sucursales");

                entity.HasIndex(e => new { e.ClaveSistema, e.NombreCorto })
                    .HasName("sucursales_ak1")
                    .IsUnique()
                    .HasFilter("([clave_sistema] IS NOT NULL AND [nombre_corto] IS NOT NULL)");

                entity.Property(e => e.SucursalId)
                    .HasColumnName("sucursal_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Activa)
                    .IsRequired()
                    .HasColumnName("activa")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClaveSistema)
                    .IsRequired()
                    .HasColumnName("clave_sistema")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombreCorto)
                    .IsRequired()
                    .HasColumnName("nombre_corto")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TablasNo>(entity =>
            {
                entity.HasKey(e => e.TablaNoId)
                    .HasName("tablas_no_pk");

                entity.ToTable("tablas_no");

                entity.HasIndex(e => e.Nombre)
                    .HasName("tablas_no_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.TablaNoId)
                    .HasColumnName("tabla_no_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Ano).HasColumnName("ano");

                entity.Property(e => e.EsPredet)
                    .HasColumnName("es_predet")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoTablaNoId).HasColumnName("tipo_tabla_no_id");

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.TipoTablaNo)
                    .WithMany(p => p.TablasNo)
                    .HasForeignKey(d => d.TipoTablaNoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tipos_tablas_a_tablas_no");
            });

            modelBuilder.Entity<TablasNoDet>(entity =>
            {
                entity.HasKey(e => e.TablaNoDetId)
                    .HasName("tablas_no_det_pk");

                entity.ToTable("tablas_no_det");

                entity.HasIndex(e => new { e.TablaNoId, e.LimiteInferior })
                    .HasName("tablas_no_det_ak1")
                    .IsUnique()
                    .HasFilter("([tabla_no_id] IS NOT NULL AND [limite_inferior] IS NOT NULL)");

                entity.Property(e => e.TablaNoDetId)
                    .HasColumnName("tabla_no_det_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cuota1)
                    .HasColumnName("cuota1")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Cuota2)
                    .HasColumnName("cuota2")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.LimiteInferior)
                    .HasColumnName("limite_inferior")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Pctje1)
                    .HasColumnName("pctje1")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.TablaNoId).HasColumnName("tabla_no_id");

                entity.HasOne(d => d.TablaNo)
                    .WithMany(p => p.TablasNoDet)
                    .HasForeignKey(d => d.TablaNoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tablas_no_a_det");
            });

            modelBuilder.Entity<TempVentasDesgl>(entity =>
            {
                entity.HasKey(e => new { e.ProcesoId, e.ObjetoId })
                    .HasName("temp_ventas_desgl_pk");

                entity.ToTable("temp_ventas_desgl");

                entity.Property(e => e.ProcesoId).HasColumnName("proceso_id");

                entity.Property(e => e.ObjetoId).HasColumnName("objeto_id");

                entity.Property(e => e.Importe1)
                    .HasColumnName("importe1")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Importe2)
                    .HasColumnName("importe2")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Unidades1)
                    .HasColumnName("unidades1")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Unidades2)
                    .HasColumnName("unidades2")
                    .HasColumnType("decimal(18, 5)");
            });

            modelBuilder.Entity<TercerosCo>(entity =>
            {
                entity.HasKey(e => e.TerceroCoId)
                    .HasName("terceros_co_pk");

                entity.ToTable("terceros_co");

                entity.HasIndex(e => e.Nombre)
                    .HasName("terceros_co_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.HasIndex(e => e.Rfc)
                    .HasName("terceros_co_ak2")
                    .IsUnique()
                    .HasFilter("([rfc] IS NOT NULL)");

                entity.Property(e => e.TerceroCoId)
                    .HasColumnName("tercero_co_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CuentaCxcCuadreDeptoId).HasColumnName("cuenta_cxc_cuadre_depto_id");

                entity.Property(e => e.CuentaCxcCuadreId).HasColumnName("cuenta_cxc_cuadre_id");

                entity.Property(e => e.CuentaCxcDeptoId).HasColumnName("cuenta_cxc_depto_id");

                entity.Property(e => e.CuentaCxcId).HasColumnName("cuenta_cxc_id");

                entity.Property(e => e.CuentaCxpCuadreDeptoId).HasColumnName("cuenta_cxp_cuadre_depto_id");

                entity.Property(e => e.CuentaCxpCuadreId).HasColumnName("cuenta_cxp_cuadre_id");

                entity.Property(e => e.CuentaCxpDeptoId).HasColumnName("cuenta_cxp_depto_id");

                entity.Property(e => e.CuentaCxpId).HasColumnName("cuenta_cxp_id");

                entity.Property(e => e.DescPolizaCompras)
                    .HasColumnName("desc_poliza_compras")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DescPolizaVentas)
                    .HasColumnName("desc_poliza_ventas")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EsCliente)
                    .IsRequired()
                    .HasColumnName("es_cliente")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EsContratante)
                    .IsRequired()
                    .HasColumnName("es_contratante")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EsProveedor)
                    .IsRequired()
                    .HasColumnName("es_proveedor")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.IvaPredetDiotId).HasColumnName("iva_predet_diot_id");

                entity.Property(e => e.NacionalidadDiot)
                    .HasColumnName("nacionalidad_diot")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OperacionPredetDiot)
                    .HasColumnName("operacion_predet_diot")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PaisResidenciaDiot)
                    .HasColumnName("pais_residencia_diot")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Rfc)
                    .HasColumnName("rfc")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.TaxIdDiot)
                    .HasColumnName("tax_id_diot")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("tipo")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoPolizaComprasId).HasColumnName("tipo_poliza_compras_id");

                entity.Property(e => e.TipoPolizaVentasId).HasColumnName("tipo_poliza_ventas_id");

                entity.Property(e => e.UltBanco)
                    .HasColumnName("ult_banco")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.UltCuentaBan)
                    .HasColumnName("ult_cuenta_ban")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UltNomBancoExt)
                    .HasColumnName("ult_nom_banco_ext")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.CuentaCxcCuadreDepto)
                    .WithMany(p => p.TercerosCoCuentaCxcCuadreDepto)
                    .HasForeignKey(d => d.CuentaCxcCuadreDeptoId)
                    .HasConstraintName("deptos_co_a_cxc_cuadre_depto");

                entity.HasOne(d => d.CuentaCxcCuadre)
                    .WithMany(p => p.TercerosCoCuentaCxcCuadre)
                    .HasForeignKey(d => d.CuentaCxcCuadreId)
                    .HasConstraintName("ctas_co_a_cuenta_cxc_cuadre");

                entity.HasOne(d => d.CuentaCxcDepto)
                    .WithMany(p => p.TercerosCoCuentaCxcDepto)
                    .HasForeignKey(d => d.CuentaCxcDeptoId)
                    .HasConstraintName("deptos_co_a_cxc_depto");

                entity.HasOne(d => d.CuentaCxc)
                    .WithMany(p => p.TercerosCoCuentaCxc)
                    .HasForeignKey(d => d.CuentaCxcId)
                    .HasConstraintName("ctas_co_a_cuenta_cxc");

                entity.HasOne(d => d.CuentaCxpCuadreDepto)
                    .WithMany(p => p.TercerosCoCuentaCxpCuadreDepto)
                    .HasForeignKey(d => d.CuentaCxpCuadreDeptoId)
                    .HasConstraintName("deptos_co_a_cxp_cuadre_depto");

                entity.HasOne(d => d.CuentaCxpCuadre)
                    .WithMany(p => p.TercerosCoCuentaCxpCuadre)
                    .HasForeignKey(d => d.CuentaCxpCuadreId)
                    .HasConstraintName("ctas_co_a_cuenta_cxp_cuadre");

                entity.HasOne(d => d.CuentaCxpDepto)
                    .WithMany(p => p.TercerosCoCuentaCxpDepto)
                    .HasForeignKey(d => d.CuentaCxpDeptoId)
                    .HasConstraintName("deptos_co_a_cxp_depto");

                entity.HasOne(d => d.CuentaCxp)
                    .WithMany(p => p.TercerosCoCuentaCxp)
                    .HasForeignKey(d => d.CuentaCxpId)
                    .HasConstraintName("ctas_co_a_cuenta_cxp");

                entity.HasOne(d => d.IvaPredetDiot)
                    .WithMany(p => p.TercerosCo)
                    .HasForeignKey(d => d.IvaPredetDiotId)
                    .HasConstraintName("impuestos_a_terceros");

                entity.HasOne(d => d.TipoPolizaCompras)
                    .WithMany(p => p.TercerosCoTipoPolizaCompras)
                    .HasForeignKey(d => d.TipoPolizaComprasId)
                    .HasConstraintName("tippol_a_tipo_poliza_compras");

                entity.HasOne(d => d.TipoPolizaVentas)
                    .WithMany(p => p.TercerosCoTipoPolizaVentas)
                    .HasForeignKey(d => d.TipoPolizaVentasId)
                    .HasConstraintName("tippol_a_tipo_poliza_ventas");
            });

            modelBuilder.Entity<TiposBitacoras>(entity =>
            {
                entity.HasKey(e => e.TipoBitacoraId)
                    .HasName("tipos_bitacoras_pk");

                entity.ToTable("tipos_bitacoras");

                entity.HasIndex(e => e.Clave)
                    .HasName("tipos_bitacoras_uq2")
                    .IsUnique()
                    .HasFilter("([clave] IS NOT NULL)");

                entity.HasIndex(e => e.Nombre)
                    .HasName("tipos_bitacoras_uq1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.TipoBitacoraId)
                    .HasColumnName("tipo_bitacora_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasColumnName("clave")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TiposClientes>(entity =>
            {
                entity.HasKey(e => e.TipoClienteId)
                    .HasName("tipos_clientes_pk");

                entity.ToTable("tipos_clientes");

                entity.HasIndex(e => e.Nombre)
                    .HasName("tipos_clientes_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.TipoClienteId)
                    .HasColumnName("tipo_cliente_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CuentaAnticipos)
                    .HasColumnName("cuenta_anticipos")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaCxc)
                    .HasColumnName("cuenta_cxc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EsPredet)
                    .HasColumnName("es_predet")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TiposContratosLft>(entity =>
            {
                entity.HasKey(e => e.TipoContLftId)
                    .HasName("tipo_contratos_lft_pk");

                entity.ToTable("tipos_contratos_lft");

                entity.HasIndex(e => e.Nombre)
                    .HasName("tipos_contratos_lft_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.TipoContLftId)
                    .HasColumnName("tipo_cont_lft_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EsTiempoDeterm)
                    .IsRequired()
                    .HasColumnName("es_tiempo_determ")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TiposCtasBan>(entity =>
            {
                entity.HasKey(e => e.TipoCtabanId)
                    .HasName("tipos_ctas_ban_pk");

                entity.ToTable("tipos_ctas_ban");

                entity.HasIndex(e => e.Nombre)
                    .HasName("tipos_ctas_ban_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.TipoCtabanId)
                    .HasColumnName("tipo_ctaban_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EsPredet)
                    .HasColumnName("es_predet")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TiposDispositivos>(entity =>
            {
                entity.HasKey(e => e.TipoDispId)
                    .HasName("tipos_dispositivos_pk");

                entity.ToTable("tipos_dispositivos");

                entity.Property(e => e.TipoDispId)
                    .HasColumnName("tipo_disp_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdInterno)
                    .IsRequired()
                    .HasColumnName("id_interno")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TiposImpuestos>(entity =>
            {
                entity.HasKey(e => e.TipoImptoId)
                    .HasName("tipos_impuestos_pk");

                entity.ToTable("tipos_impuestos");

                entity.HasIndex(e => e.Nombre)
                    .HasName("tipos_impuestos_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.TipoImptoId)
                    .HasColumnName("tipo_impto_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EsPredet)
                    .HasColumnName("es_predet")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.GravaOtrosImptos)
                    .HasColumnName("grava_otros_imptos")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdInterno)
                    .HasColumnName("id_interno")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("tipo")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('I')");

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TiposIsn>(entity =>
            {
                entity.HasKey(e => e.TipoIsnId)
                    .HasName("tipos_isn_pk");

                entity.ToTable("tipos_isn");

                entity.HasIndex(e => e.Nombre)
                    .HasName("tipos_isn_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.TipoIsnId)
                    .HasColumnName("tipo_isn_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PctjeImpuesto)
                    .HasColumnName("pctje_impuesto")
                    .HasColumnType("decimal(9, 6)");

                entity.Property(e => e.TablaNoId).HasColumnName("tabla_no_id");

                entity.Property(e => e.TipoCalc)
                    .IsRequired()
                    .HasColumnName("tipo_calc")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.TablaNo)
                    .WithMany(p => p.TiposIsn)
                    .HasForeignKey(d => d.TablaNoId)
                    .HasConstraintName("tablas_a_tipos_isn");
            });

            modelBuilder.Entity<TiposPolizas>(entity =>
            {
                entity.HasKey(e => e.TipoPolizaId)
                    .HasName("tipos_polizas_pk");

                entity.ToTable("tipos_polizas");

                entity.HasIndex(e => e.Clave)
                    .HasName("tipos_polizas_ak2")
                    .IsUnique()
                    .HasFilter("([clave] IS NOT NULL)");

                entity.HasIndex(e => e.Nombre)
                    .HasName("tipos_polizas_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.TipoPolizaId)
                    .HasColumnName("tipo_poliza_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Clave)
                    .IsRequired()
                    .HasColumnName("clave")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EsPredet)
                    .HasColumnName("es_predet")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PolSinCfdi)
                    .IsRequired()
                    .HasColumnName("pol_sin_cfdi")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('S')");

                entity.Property(e => e.Prefijo)
                    .HasColumnName("prefijo")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TipoConsec)
                    .IsRequired()
                    .HasColumnName("tipo_consec")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoFiscal)
                    .HasColumnName("tipo_fiscal")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TiposPolizasDet>(entity =>
            {
                entity.HasKey(e => e.TipoPolizaDetId)
                    .HasName("tipos_polizas_det_pk");

                entity.ToTable("tipos_polizas_det");

                entity.HasIndex(e => new { e.TipoPolizaId, e.Ano, e.Mes })
                    .HasName("tipos_polizas_det_ak")
                    .IsUnique()
                    .HasFilter("([tipo_poliza_id] IS NOT NULL AND [ano] IS NOT NULL AND [mes] IS NOT NULL)");

                entity.Property(e => e.TipoPolizaDetId)
                    .HasColumnName("tipo_poliza_det_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Ano).HasColumnName("ano");

                entity.Property(e => e.Consecutivo).HasColumnName("consecutivo");

                entity.Property(e => e.Mes).HasColumnName("mes");

                entity.Property(e => e.TipoPolizaId).HasColumnName("tipo_poliza_id");

                entity.HasOne(d => d.TipoPoliza)
                    .WithMany(p => p.TiposPolizasDet)
                    .HasForeignKey(d => d.TipoPolizaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tipos_polizas_a_det");
            });

            modelBuilder.Entity<TiposProv>(entity =>
            {
                entity.HasKey(e => e.TipoProvId)
                    .HasName("tipos_prov_pk");

                entity.ToTable("tipos_prov");

                entity.HasIndex(e => e.Nombre)
                    .HasName("tipos_prov_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.TipoProvId)
                    .HasColumnName("tipo_prov_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CuentaAnticipos)
                    .HasColumnName("cuenta_anticipos")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaCxp)
                    .HasColumnName("cuenta_cxp")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EsPredet)
                    .HasColumnName("es_predet")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TiposTablasNo>(entity =>
            {
                entity.HasKey(e => e.TipoTablaNoId)
                    .HasName("tipos_tablas_no_pk");

                entity.ToTable("tipos_tablas_no");

                entity.Property(e => e.TipoTablaNoId)
                    .HasColumnName("tipo_tabla_no_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Escalable)
                    .HasColumnName("escalable")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdInterno)
                    .HasColumnName("id_interno")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PregAno)
                    .HasColumnName("preg_ano")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VariasPorAno)
                    .HasColumnName("varias_por_ano")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TraspasosBa>(entity =>
            {
                entity.HasKey(e => e.DoctoBaRetId)
                    .HasName("traspasos_ba_pk");

                entity.ToTable("traspasos_ba");

                entity.HasIndex(e => e.DoctoBaDepId)
                    .HasName("traspasos_ba_ie1");

                entity.Property(e => e.DoctoBaRetId)
                    .HasColumnName("docto_ba_ret_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConceptoBaId).HasColumnName("concepto_ba_id");

                entity.Property(e => e.CuentaBanId).HasColumnName("cuenta_ban_id");

                entity.Property(e => e.DoctoBaDepId).HasColumnName("docto_ba_dep_id");

                entity.Property(e => e.FechaAplic)
                    .HasColumnName("fecha_aplic")
                    .HasColumnType("date");

                entity.Property(e => e.Importe)
                    .HasColumnName("importe")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Refer)
                    .HasColumnName("refer")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoCambio)
                    .HasColumnName("tipo_cambio")
                    .HasColumnType("decimal(18, 6)");

                entity.HasOne(d => d.ConceptoBa)
                    .WithMany(p => p.TraspasosBa)
                    .HasForeignKey(d => d.ConceptoBaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("concep_a_trasp_ba");

                entity.HasOne(d => d.CuentaBan)
                    .WithMany(p => p.TraspasosBa)
                    .HasForeignKey(d => d.CuentaBanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ctaban_a_trasp_ba");

                entity.HasOne(d => d.DoctoBaDep)
                    .WithMany(p => p.TraspasosBaDoctoBaDep)
                    .HasForeignKey(d => d.DoctoBaDepId)
                    .HasConstraintName("doctos_ba_a_trasp_dep");

                entity.HasOne(d => d.DoctoBaRet)
                    .WithOne(p => p.TraspasosBaDoctoBaRet)
                    .HasForeignKey<TraspasosBa>(d => d.DoctoBaRetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_ba_a_trasp_ret");
            });

            modelBuilder.Entity<UnidadesVenta>(entity =>
            {
                entity.HasKey(e => e.UnidadVentaId)
                    .HasName("unidades_venta_pk");

                entity.ToTable("unidades_venta");

                entity.HasIndex(e => e.UnidadVenta)
                    .HasName("unidades_venta_ak1")
                    .IsUnique()
                    .HasFilter("([unidad_venta] IS NOT NULL)");

                entity.Property(e => e.UnidadVentaId)
                    .HasColumnName("unidad_venta_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClaveSat)
                    .HasColumnName("clave_sat")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SimboloSat)
                    .HasColumnName("simbolo_sat")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UnidadVenta)
                    .IsRequired()
                    .HasColumnName("unidad_venta")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UsosAnticiposCc>(entity =>
            {
                entity.HasKey(e => new { e.AnticipoCcId, e.DoctoCcId })
                    .HasName("usos_anticipos_pk");

                entity.ToTable("usos_anticipos_cc");

                entity.HasIndex(e => new { e.AnticipoCcId, e.Fecha })
                    .HasName("usos_anticipos_cc_ie1");

                entity.Property(e => e.AnticipoCcId).HasColumnName("anticipo_cc_id");

                entity.Property(e => e.DoctoCcId).HasColumnName("docto_cc_id");

                entity.Property(e => e.DoctoCcAcrId).HasColumnName("docto_cc_acr_id");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.FechaHora).HasColumnName("fecha_hora");

                entity.Property(e => e.Importe)
                    .HasColumnName("importe")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Impuesto)
                    .HasColumnName("impuesto")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.PorDepositar)
                    .IsRequired()
                    .HasColumnName("por_depositar")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoUso)
                    .IsRequired()
                    .HasColumnName("tipo_uso")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.AnticipoCc)
                    .WithMany(p => p.UsosAnticiposCc)
                    .HasForeignKey(d => d.AnticipoCcId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("anticipos_cc_a_usos_anticipos");

                entity.HasOne(d => d.DoctoCcAcr)
                    .WithMany(p => p.UsosAnticiposCcDoctoCcAcr)
                    .HasForeignKey(d => d.DoctoCcAcrId)
                    .HasConstraintName("doc_cc_a_usos_ant_doc_acr");

                entity.HasOne(d => d.DoctoCc)
                    .WithMany(p => p.UsosAnticiposCcDoctoCc)
                    .HasForeignKey(d => d.DoctoCcId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doc_cc_a_usos_ant_doc_padre");
            });

            modelBuilder.Entity<UsosCapasCostos>(entity =>
            {
                entity.HasKey(e => new { e.DoctoInDetId, e.CapaId })
                    .HasName("usos_capas_costos_pk");

                entity.ToTable("usos_capas_costos");

                entity.Property(e => e.DoctoInDetId).HasColumnName("docto_in_det_id");

                entity.Property(e => e.CapaId).HasColumnName("capa_id");

                entity.Property(e => e.TipoUso)
                    .IsRequired()
                    .HasColumnName("tipo_uso")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Unidades)
                    .HasColumnName("unidades")
                    .HasColumnType("decimal(18, 5)");

                entity.Property(e => e.ValorTotal)
                    .HasColumnName("valor_total")
                    .HasColumnType("decimal(15, 2)");

                entity.HasOne(d => d.Capa)
                    .WithMany(p => p.UsosCapasCostos)
                    .HasForeignKey(d => d.CapaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("capas_costos_a_usos");

                entity.HasOne(d => d.DoctoInDet)
                    .WithMany(p => p.UsosCapasCostos)
                    .HasForeignKey(d => d.DoctoInDetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_det_a_usos_costos");
            });

            modelBuilder.Entity<UsosCapasPedimentos>(entity =>
            {
                entity.HasKey(e => new { e.DoctoInDetId, e.CapaPedimentoId })
                    .HasName("usos_capas_pedimentos_pk");

                entity.ToTable("usos_capas_pedimentos");

                entity.Property(e => e.DoctoInDetId).HasColumnName("docto_in_det_id");

                entity.Property(e => e.CapaPedimentoId).HasColumnName("capa_pedimento_id");

                entity.Property(e => e.TipoUso)
                    .IsRequired()
                    .HasColumnName("tipo_uso")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Unidades)
                    .HasColumnName("unidades")
                    .HasColumnType("decimal(18, 5)");

                entity.HasOne(d => d.CapaPedimento)
                    .WithMany(p => p.UsosCapasPedimentos)
                    .HasForeignKey(d => d.CapaPedimentoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("capas_pedimentos_a_usos");

                entity.HasOne(d => d.DoctoInDet)
                    .WithMany(p => p.UsosCapasPedimentos)
                    .HasForeignKey(d => d.DoctoInDetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_det_a_usos_pedimentos");
            });

            modelBuilder.Entity<UsosFoliosFiscales>(entity =>
            {
                entity.HasKey(e => e.UsoFolioId)
                    .HasName("usos_folios_fiscales_pk");

                entity.ToTable("usos_folios_fiscales");

                entity.HasIndex(e => e.Fecha)
                    .HasName("usos_folios_fiscales_ie1");

                entity.HasIndex(e => new { e.Sistema, e.DoctoId })
                    .HasName("usos_folios_fiscales_ie2");

                entity.Property(e => e.UsoFolioId)
                    .HasColumnName("uso_folio_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CfdiId).HasColumnName("cfdi_id");

                entity.Property(e => e.DoctoId).HasColumnName("docto_id");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.FechaHoraTimbrado)
                    .HasColumnName("fecha_hora_timbrado")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Folio).HasColumnName("folio");

                entity.Property(e => e.FoliosFiscalesId).HasColumnName("folios_fiscales_id");

                entity.Property(e => e.ProvCert)
                    .HasColumnName("prov_cert")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sistema)
                    .IsRequired()
                    .HasColumnName("sistema")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Uuid)
                    .HasColumnName("uuid")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Xml)
                    .HasColumnName("xml")
                    .IsUnicode(false);

                entity.HasOne(d => d.Cfdi)
                    .WithMany(p => p.UsosFoliosFiscales)
                    .HasForeignKey(d => d.CfdiId)
                    .HasConstraintName("repos_cfdi_a_usos_fol_fis");

                entity.HasOne(d => d.FoliosFiscales)
                    .WithMany(p => p.UsosFoliosFiscales)
                    .HasForeignKey(d => d.FoliosFiscalesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("folios_fiscales_a_uso");
            });

            modelBuilder.Entity<UsosFoliosFiscalesCancelados>(entity =>
            {
                entity.HasKey(e => e.UsoFolioId)
                    .HasName("usos_folios_fis_cance_pk");

                entity.ToTable("usos_folios_fiscales_cancelados");

                entity.HasIndex(e => e.FechaCancelacion)
                    .HasName("usos_folios_fis_cance_ie1");

                entity.Property(e => e.UsoFolioId)
                    .HasColumnName("uso_folio_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.FechaCancelacion)
                    .HasColumnName("fecha_cancelacion")
                    .HasColumnType("date");

                entity.Property(e => e.FechaHoraCancelacionCfdi).HasColumnName("fecha_hora_cancelacion_cfdi");

                entity.Property(e => e.ProvCancelacion)
                    .HasColumnName("prov_cancelacion")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.XmlAcuse)
                    .HasColumnName("xml_acuse")
                    .IsUnicode(false);

                entity.HasOne(d => d.UsoFolio)
                    .WithOne(p => p.UsosFoliosFiscalesCancelados)
                    .HasForeignKey<UsosFoliosFiscalesCancelados>(d => d.UsoFolioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("usos_folios_fis_a_cance");
            });

            modelBuilder.Entity<UsosPeriodosVac>(entity =>
            {
                entity.HasKey(e => e.UsoPeriodoVacId)
                    .HasName("usos_periodos_vac_pk");

                entity.ToTable("usos_periodos_vac");

                entity.Property(e => e.UsoPeriodoVacId)
                    .HasColumnName("uso_periodo_vac_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Dias)
                    .HasColumnName("dias")
                    .HasColumnType("decimal(7, 2)");

                entity.Property(e => e.PeriodoVacId).HasColumnName("periodo_vac_id");

                entity.Property(e => e.VacacionesId).HasColumnName("vacaciones_id");

                entity.HasOne(d => d.PeriodoVac)
                    .WithMany(p => p.UsosPeriodosVac)
                    .HasForeignKey(d => d.PeriodoVacId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("periodo_vac_a_usos_per_vac");

                entity.HasOne(d => d.Vacaciones)
                    .WithMany(p => p.UsosPeriodosVac)
                    .HasForeignKey(d => d.VacacionesId)
                    .HasConstraintName("vacaciones_a_usos_per_vac");
            });

            modelBuilder.Entity<Vacaciones>(entity =>
            {
                entity.ToTable("vacaciones");

                entity.HasIndex(e => new { e.EmpleadoId, e.FechaInicial })
                    .HasName("vacaciones_ak1")
                    .IsUnique()
                    .HasFilter("([empleado_id] IS NOT NULL AND [fecha_inicial] IS NOT NULL)");

                entity.HasIndex(e => new { e.EmpleadoId, e.Estatus, e.FechaInicial })
                    .HasName("vacaciones_ie1");

                entity.Property(e => e.VacacionesId)
                    .HasColumnName("vacaciones_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Dias)
                    .HasColumnName("dias")
                    .HasColumnType("decimal(7, 2)");

                entity.Property(e => e.EmpleadoId).HasColumnName("empleado_id");

                entity.Property(e => e.Estatus)
                    .IsRequired()
                    .HasColumnName("estatus")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.FechaInicial)
                    .HasColumnName("fecha_inicial")
                    .HasColumnType("date");

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.Empleado)
                    .WithMany(p => p.Vacaciones)
                    .HasForeignKey(d => d.EmpleadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("emp_a_vacaciones");
            });

            modelBuilder.Entity<ValoresAtribArtsVariantes>(entity =>
            {
                entity.HasKey(e => e.ValorAtribId)
                    .HasName("valores_atrib_arts_vars_pk");

                entity.ToTable("valores_atrib_arts_variantes");

                entity.HasIndex(e => new { e.AtribId, e.Valor })
                    .HasName("valores_atrib_arts_vars_ak1")
                    .IsUnique()
                    .HasFilter("([atrib_id] IS NOT NULL AND [valor] IS NOT NULL)");

                entity.Property(e => e.ValorAtribId)
                    .HasColumnName("valor_atrib_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AtribId).HasColumnName("atrib_id");

                entity.Property(e => e.Posicion).HasColumnName("posicion");

                entity.Property(e => e.Valor)
                    .IsRequired()
                    .HasColumnName("valor")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Atrib)
                    .WithMany(p => p.ValoresAtribArtsVariantes)
                    .HasForeignKey(d => d.AtribId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("atrib_arts_variantes_a_valores");
            });

            modelBuilder.Entity<VariantesArts>(entity =>
            {
                entity.HasKey(e => e.VarianteId)
                    .HasName("variantes_arts_pk");

                entity.ToTable("variantes_arts");

                entity.HasIndex(e => e.ArtHijoVarId)
                    .HasName("variantes_arts_uq1")
                    .IsUnique()
                    .HasFilter("([art_hijo_var_id] IS NOT NULL)");

                entity.Property(e => e.VarianteId)
                    .HasColumnName("variante_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArtHijoVarId).HasColumnName("art_hijo_var_id");

                entity.Property(e => e.ArtPadreVarId).HasColumnName("art_padre_var_id");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ArtHijoVar)
                    .WithOne(p => p.VariantesArts)
                    .HasForeignKey<VariantesArts>(d => d.ArtHijoVarId)
                    .HasConstraintName("articulos_a_variantes");

                entity.HasOne(d => d.ArtPadreVar)
                    .WithMany(p => p.VariantesArts)
                    .HasForeignKey(d => d.ArtPadreVarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("arts_var_a_variantes");
            });

            modelBuilder.Entity<VariantesArtsDet>(entity =>
            {
                entity.HasKey(e => e.VarianteDetId)
                    .HasName("variantes_arts_det_pk");

                entity.ToTable("variantes_arts_det");

                entity.Property(e => e.VarianteDetId)
                    .HasColumnName("variante_det_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ValorAtribId).HasColumnName("valor_atrib_id");

                entity.Property(e => e.VarianteId).HasColumnName("variante_id");

                entity.HasOne(d => d.ValorAtrib)
                    .WithMany(p => p.VariantesArtsDet)
                    .HasForeignKey(d => d.ValorAtribId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("val_atrib_a_var_det");

                entity.HasOne(d => d.Variante)
                    .WithMany(p => p.VariantesArtsDet)
                    .HasForeignKey(d => d.VarianteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("variantes_art_a_det");
            });

            modelBuilder.Entity<VencimientosCargosCc>(entity =>
            {
                entity.HasKey(e => new { e.DoctoCcId, e.FechaVencimiento })
                    .HasName("ven_cargos_cc_pk");

                entity.ToTable("vencimientos_cargos_cc");

                entity.Property(e => e.DoctoCcId).HasColumnName("docto_cc_id");

                entity.Property(e => e.FechaVencimiento)
                    .HasColumnName("fecha_vencimiento")
                    .HasColumnType("date");

                entity.Property(e => e.PctjeVen)
                    .HasColumnName("pctje_ven")
                    .HasColumnType("decimal(9, 6)");

                entity.HasOne(d => d.DoctoCc)
                    .WithMany(p => p.VencimientosCargosCc)
                    .HasForeignKey(d => d.DoctoCcId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_cc_a_vencim");
            });

            modelBuilder.Entity<VencimientosCargosCm>(entity =>
            {
                entity.HasKey(e => new { e.DoctoCmId, e.FechaVencimiento })
                    .HasName("ven_cargos_cm_pk");

                entity.ToTable("vencimientos_cargos_cm");

                entity.Property(e => e.DoctoCmId).HasColumnName("docto_cm_id");

                entity.Property(e => e.FechaVencimiento)
                    .HasColumnName("fecha_vencimiento")
                    .HasColumnType("date");

                entity.Property(e => e.PctjeVen)
                    .HasColumnName("pctje_ven")
                    .HasColumnType("decimal(9, 6)");

                entity.HasOne(d => d.DoctoCm)
                    .WithMany(p => p.VencimientosCargosCm)
                    .HasForeignKey(d => d.DoctoCmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_cm_a_vencim");
            });

            modelBuilder.Entity<VencimientosCargosCp>(entity =>
            {
                entity.HasKey(e => new { e.DoctoCpId, e.FechaVencimiento })
                    .HasName("ven_cargos_cp_pk");

                entity.ToTable("vencimientos_cargos_cp");

                entity.Property(e => e.DoctoCpId).HasColumnName("docto_cp_id");

                entity.Property(e => e.FechaVencimiento)
                    .HasColumnName("fecha_vencimiento")
                    .HasColumnType("date");

                entity.Property(e => e.PctjeVen)
                    .HasColumnName("pctje_ven")
                    .HasColumnType("decimal(9, 6)");

                entity.HasOne(d => d.DoctoCp)
                    .WithMany(p => p.VencimientosCargosCp)
                    .HasForeignKey(d => d.DoctoCpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_cp_a_vencim");
            });

            modelBuilder.Entity<VencimientosCargosPendCc>(entity =>
            {
                entity.HasKey(e => new { e.FechaVencimiento, e.DoctoPendCcId })
                    .HasName("ven_cargos_pend_cc_pk");

                entity.ToTable("vencimientos_cargos_pend_cc");

                entity.Property(e => e.FechaVencimiento)
                    .HasColumnName("fecha_vencimiento")
                    .HasColumnType("date");

                entity.Property(e => e.DoctoPendCcId).HasColumnName("docto_pend_cc_id");

                entity.Property(e => e.PctjeVen)
                    .HasColumnName("pctje_ven")
                    .HasColumnType("decimal(9, 6)");

                entity.HasOne(d => d.DoctoPendCc)
                    .WithMany(p => p.VencimientosCargosPendCc)
                    .HasForeignKey(d => d.DoctoPendCcId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_pend_cc_a_vencim");
            });

            modelBuilder.Entity<VencimientosCargosVe>(entity =>
            {
                entity.HasKey(e => new { e.DoctoVeId, e.FechaVencimiento })
                    .HasName("ven_cargos_ve_pk");

                entity.ToTable("vencimientos_cargos_ve");

                entity.Property(e => e.DoctoVeId).HasColumnName("docto_ve_id");

                entity.Property(e => e.FechaVencimiento)
                    .HasColumnName("fecha_vencimiento")
                    .HasColumnType("date");

                entity.Property(e => e.PctjeVen)
                    .HasColumnName("pctje_ven")
                    .HasColumnType("decimal(9, 6)");

                entity.HasOne(d => d.DoctoVe)
                    .WithMany(p => p.VencimientosCargosVe)
                    .HasForeignKey(d => d.DoctoVeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("doctos_ve_a_vencim");
            });

            modelBuilder.Entity<Vendedores>(entity =>
            {
                entity.HasKey(e => e.VendedorId)
                    .HasName("vendedores_pk");

                entity.ToTable("vendedores");

                entity.HasIndex(e => e.Nombre)
                    .HasName("vendedores_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.VendedorId)
                    .HasColumnName("vendedor_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EsPredet)
                    .HasColumnName("es_predet")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PoliticaComisVenId).HasColumnName("politica_comis_ven_id");

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.PoliticaComisVen)
                    .WithMany(p => p.Vendedores)
                    .HasForeignKey(d => d.PoliticaComisVenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("politicas_comis_a_ven");
            });

            modelBuilder.Entity<VersionesDb>(entity =>
            {
                entity.HasKey(e => e.VersionDb)
                    .HasName("versiones_db_pk");

                entity.ToTable("versiones_db");

                entity.Property(e => e.VersionDb)
                    .HasColumnName("version_db")
                    .ValueGeneratedNever();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.PasoActual).HasColumnName("paso_actual");
            });

            modelBuilder.Entity<ViasEmbarque>(entity =>
            {
                entity.HasKey(e => e.ViaEmbarqueId)
                    .HasName("vias_embarque_pk");

                entity.ToTable("vias_embarque");

                entity.HasIndex(e => e.Nombre)
                    .HasName("vias_embarque_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.ViaEmbarqueId)
                    .HasColumnName("via_embarque_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EsPredet)
                    .HasColumnName("es_predet")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViaticosNo>(entity =>
            {
                entity.HasKey(e => e.ViaticoNoId)
                    .HasName("viaticos_no_pk");

                entity.ToTable("viaticos_no");

                entity.HasIndex(e => e.Fecha)
                    .HasName("viaticos_no_ie1");

                entity.Property(e => e.ViaticoNoId)
                    .HasColumnName("viatico_no_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DoctoComprobacionesId).HasColumnName("docto_comprobaciones_id");

                entity.Property(e => e.EmailEnvio)
                    .HasColumnName("email_envio")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EmpleadoId).HasColumnName("empleado_id");

                entity.Property(e => e.Enviado)
                    .IsRequired()
                    .HasColumnName("enviado")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estatus)
                    .IsRequired()
                    .HasColumnName("estatus")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraEnvio).HasColumnName("fecha_hora_envio");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.FormaEmitida)
                    .IsRequired()
                    .HasColumnName("forma_emitida")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Observaciones)
                    .HasColumnName("observaciones")
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.HasOne(d => d.Empleado)
                    .WithMany(p => p.ViaticosNo)
                    .HasForeignKey(d => d.EmpleadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("emp_a_viaticos_no");
            });

            modelBuilder.Entity<ViaticosNoCancelados>(entity =>
            {
                entity.HasKey(e => e.ViaticoNoCanceladoId)
                    .HasName("viaticos_no_cancelados_pk");

                entity.ToTable("viaticos_no_cancelados");

                entity.Property(e => e.ViaticoNoCanceladoId)
                    .HasColumnName("viatico_no_cancelado_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EmpleadoId).HasColumnName("empleado_id");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.TipoCancelacion)
                    .IsRequired()
                    .HasColumnName("tipo_cancelacion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ViaticoNoId).HasColumnName("viatico_no_id");

                entity.HasOne(d => d.Empleado)
                    .WithMany(p => p.ViaticosNoCancelados)
                    .HasForeignKey(d => d.EmpleadoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("empleados_a_viaticos_no_cance");

                entity.HasOne(d => d.ViaticoNo)
                    .WithMany(p => p.ViaticosNoCancelados)
                    .HasForeignKey(d => d.ViaticoNoId)
                    .HasConstraintName("viaticos_a_viaticos_no_cance");
            });

            modelBuilder.Entity<ViaticosNoDet>(entity =>
            {
                entity.HasKey(e => e.ViaticoNoDetId)
                    .HasName("viaticos_no_det_pk");

                entity.ToTable("viaticos_no_det");

                entity.Property(e => e.ViaticoNoDetId)
                    .HasColumnName("viatico_no_det_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.Importe)
                    .HasColumnName("importe")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.IncluirEnCfdi)
                    .HasColumnName("incluir_en_cfdi")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Observaciones)
                    .HasColumnName("observaciones")
                    .IsUnicode(false);

                entity.Property(e => e.PrestamoEmpId).HasColumnName("prestamo_emp_id");

                entity.Property(e => e.Referencia)
                    .HasColumnName("referencia")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TipoComprobacion)
                    .HasColumnName("tipo_comprobacion")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('D')");

                entity.Property(e => e.TipoMovto)
                    .IsRequired()
                    .HasColumnName("tipo_movto")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('E')");

                entity.Property(e => e.ViaticoNoId).HasColumnName("viatico_no_id");

                entity.HasOne(d => d.PrestamoEmp)
                    .WithMany(p => p.ViaticosNoDet)
                    .HasForeignKey(d => d.PrestamoEmpId)
                    .HasConstraintName("ptmo_emp_a_viatico_no_det");

                entity.HasOne(d => d.ViaticoNo)
                    .WithMany(p => p.ViaticosNoDet)
                    .HasForeignKey(d => d.ViaticoNoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("viaticos_no_a_det");
            });

            modelBuilder.Entity<Visitas>(entity =>
            {
                entity.HasKey(e => e.VisitaId)
                    .HasName("visitas_pk");

                entity.ToTable("visitas");

                entity.HasIndex(e => new { e.AgenteId, e.ClienteId, e.FechaHoraRealIni })
                    .HasName("visitas_ie1");

                entity.Property(e => e.VisitaId)
                    .HasColumnName("visita_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AgenteId).HasColumnName("agente_id");

                entity.Property(e => e.ClaveCliente)
                    .HasColumnName("clave_cliente")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClienteId).HasColumnName("cliente_id");

                entity.Property(e => e.Estatus)
                    .IsRequired()
                    .HasColumnName("estatus")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraRealFin).HasColumnName("fecha_hora_real_fin");

                entity.Property(e => e.FechaHoraRealIni).HasColumnName("fecha_hora_real_ini");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.FechaPlaneada)
                    .HasColumnName("fecha_planeada")
                    .HasColumnType("date");

                entity.Property(e => e.ImporteCobros)
                    .HasColumnName("importe_cobros")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.ImportePedidos)
                    .HasColumnName("importe_pedidos")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Observaciones)
                    .HasColumnName("observaciones")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RazonVisInefId).HasColumnName("razon_vis_inef_id");

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.VersionRegistro).HasColumnName("version_registro");

                entity.HasOne(d => d.Agente)
                    .WithMany(p => p.Visitas)
                    .HasForeignKey(d => d.AgenteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("agentes_a_visitas");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Visitas)
                    .HasForeignKey(d => d.ClienteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("clientes_a_visitas");

                entity.HasOne(d => d.RazonVisInef)
                    .WithMany(p => p.Visitas)
                    .HasForeignKey(d => d.RazonVisInefId)
                    .HasConstraintName("razones_vis_inef_a_visitas");
            });

            modelBuilder.Entity<ZonasClientes>(entity =>
            {
                entity.HasKey(e => e.ZonaClienteId)
                    .HasName("zonas_clientes_pk");

                entity.ToTable("zonas_clientes");

                entity.HasIndex(e => e.Nombre)
                    .HasName("zonas_clientes_ak1")
                    .IsUnique()
                    .HasFilter("([nombre] IS NOT NULL)");

                entity.Property(e => e.ZonaClienteId)
                    .HasColumnName("zona_cliente_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CuentaAnticipos)
                    .HasColumnName("cuenta_anticipos")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaCxc)
                    .HasColumnName("cuenta_cxc")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EsPredet)
                    .HasColumnName("es_predet")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaHoraCreacion).HasColumnName("fecha_hora_creacion");

                entity.Property(e => e.FechaHoraUltModif).HasColumnName("fecha_hora_ult_modif");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutCreacion)
                    .HasColumnName("usuario_aut_creacion")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioAutModif)
                    .HasColumnName("usuario_aut_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasColumnName("usuario_creador")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioUltModif)
                    .HasColumnName("usuario_ult_modif")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
