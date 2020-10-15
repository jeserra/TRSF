using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class Bancos
    {
        public Bancos()
        {
            CuentasBancarias = new HashSet<CuentasBancarias>();
            DoctosCcInfoBan = new HashSet<DoctosCcInfoBan>();
            FormasCobroClientes = new HashSet<FormasCobroClientes>();
        }

        public int BancoId { get; set; }
        public string Nombre { get; set; }
        public string Rfc { get; set; }
        public string ClaveFiscal { get; set; }
        public string EsPredet { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual ICollection<CuentasBancarias> CuentasBancarias { get; set; }
        public virtual ICollection<DoctosCcInfoBan> DoctosCcInfoBan { get; set; }
        public virtual ICollection<FormasCobroClientes> FormasCobroClientes { get; set; }
    }
}
