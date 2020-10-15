using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class Monedas
    {
        public Monedas()
        {
            Clientes = new HashSet<Clientes>();
            CuentasBancarias = new HashSet<CuentasBancarias>();
            DoctosBa = new HashSet<DoctosBa>();
            DoctosCm = new HashSet<DoctosCm>();
            DoctosCo = new HashSet<DoctosCo>();
            DoctosCoDet = new HashSet<DoctosCoDet>();
            DoctosPv = new HashSet<DoctosPv>();
            DoctosVe = new HashSet<DoctosVe>();
            FormasCobro = new HashSet<FormasCobro>();
            FormasCobroCc = new HashSet<FormasCobroCc>();
            HistoriaCambiaria = new HashSet<HistoriaCambiaria>();
            PreciosArticulos = new HashSet<PreciosArticulos>();
            PreciosCompraDet = new HashSet<PreciosCompraDet>();
            Proveedores = new HashSet<Proveedores>();
        }

        public int MonedaId { get; set; }
        public string Nombre { get; set; }
        public string TextoImpteLetra { get; set; }
        public string Simbolo { get; set; }
        public string ClaveFiscal { get; set; }
        public string EsMonedaLocal { get; set; }
        public string EsPredet { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual ICollection<Clientes> Clientes { get; set; }
        public virtual ICollection<CuentasBancarias> CuentasBancarias { get; set; }
        public virtual ICollection<DoctosBa> DoctosBa { get; set; }
        public virtual ICollection<DoctosCm> DoctosCm { get; set; }
        public virtual ICollection<DoctosCo> DoctosCo { get; set; }
        public virtual ICollection<DoctosCoDet> DoctosCoDet { get; set; }
        public virtual ICollection<DoctosPv> DoctosPv { get; set; }
        public virtual ICollection<DoctosVe> DoctosVe { get; set; }
        public virtual ICollection<FormasCobro> FormasCobro { get; set; }
        public virtual ICollection<FormasCobroCc> FormasCobroCc { get; set; }
        public virtual ICollection<HistoriaCambiaria> HistoriaCambiaria { get; set; }
        public virtual ICollection<PreciosArticulos> PreciosArticulos { get; set; }
        public virtual ICollection<PreciosCompraDet> PreciosCompraDet { get; set; }
        public virtual ICollection<Proveedores> Proveedores { get; set; }
    }
}
