using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class Clientes
    {
        public Clientes()
        {
            AnticiposCc = new HashSet<AnticiposCc>();
            ArticulosClientes = new HashSet<ArticulosClientes>();
            CargosPeriodicosCc = new HashSet<CargosPeriodicosCc>();
            ClavesClientes = new HashSet<ClavesClientes>();
            ComisVenCli = new HashSet<ComisVenCli>();
            DirsClientes = new HashSet<DirsClientes>();
            DoctosCc = new HashSet<DoctosCc>();
            DoctosPendCc = new HashSet<DoctosPendCc>();
            DoctosPvCliente = new HashSet<DoctosPv>();
            DoctosPvClienteFac = new HashSet<DoctosPv>();
            DoctosTr = new HashSet<DoctosTr>();
            DoctosVe = new HashSet<DoctosVe>();
            FormasCobroClientes = new HashSet<FormasCobroClientes>();
            ImagenesClientes = new HashSet<ImagenesClientes>();
            PreciosCliCli = new HashSet<PreciosCliCli>();
            RutasDet = new HashSet<RutasDet>();
            SaldosCc = new HashSet<SaldosCc>();
            Visitas = new HashSet<Visitas>();
        }

        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Contacto1 { get; set; }
        public string Contacto2 { get; set; }
        public string Estatus { get; set; }
        public string CausaSusp { get; set; }
        public DateTime? FechaSusp { get; set; }
        public string CobrarImpuestos { get; set; }
        public string RetieneImpuestos { get; set; }
        public string SujetoIeps { get; set; }
        public string GenerarIntereses { get; set; }
        public string EmitirEdocta { get; set; }
        public decimal? LimiteCredito { get; set; }
        public int MonedaId { get; set; }
        public int CondPagoId { get; set; }
        public int? TipoClienteId { get; set; }
        public int? ZonaClienteId { get; set; }
        public int? CobradorId { get; set; }
        public int? VendedorId { get; set; }
        public string Notas { get; set; }
        public string CuentaCxc { get; set; }
        public string CuentaAnticipos { get; set; }
        public string FormatosEmail { get; set; }
        public string ReceptorCfd { get; set; }
        public string NumProvCliente { get; set; }
        public string CamposAddenda { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual Cobradores Cobrador { get; set; }
        public virtual CondicionesPago CondPago { get; set; }
        public virtual Monedas Moneda { get; set; }
        public virtual TiposClientes TipoCliente { get; set; }
        public virtual Vendedores Vendedor { get; set; }
        public virtual ZonasClientes ZonaCliente { get; set; }
        public virtual LibresClientes LibresClientes { get; set; }
        public virtual ICollection<AnticiposCc> AnticiposCc { get; set; }
        public virtual ICollection<ArticulosClientes> ArticulosClientes { get; set; }
        public virtual ICollection<CargosPeriodicosCc> CargosPeriodicosCc { get; set; }
        public virtual ICollection<ClavesClientes> ClavesClientes { get; set; }
        public virtual ICollection<ComisVenCli> ComisVenCli { get; set; }
        public virtual ICollection<DirsClientes> DirsClientes { get; set; }
        public virtual ICollection<DoctosCc> DoctosCc { get; set; }
        public virtual ICollection<DoctosPendCc> DoctosPendCc { get; set; }
        public virtual ICollection<DoctosPv> DoctosPvCliente { get; set; }
        public virtual ICollection<DoctosPv> DoctosPvClienteFac { get; set; }
        public virtual ICollection<DoctosTr> DoctosTr { get; set; }
        public virtual ICollection<DoctosVe> DoctosVe { get; set; }
        public virtual ICollection<FormasCobroClientes> FormasCobroClientes { get; set; }
        public virtual ICollection<ImagenesClientes> ImagenesClientes { get; set; }
        public virtual ICollection<PreciosCliCli> PreciosCliCli { get; set; }
        public virtual ICollection<RutasDet> RutasDet { get; set; }
        public virtual ICollection<SaldosCc> SaldosCc { get; set; }
        public virtual ICollection<Visitas> Visitas { get; set; }
    }
}
