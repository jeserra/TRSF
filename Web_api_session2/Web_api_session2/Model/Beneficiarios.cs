using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class Beneficiarios
    {
        public Beneficiarios()
        {
            DoctosBa = new HashSet<DoctosBa>();
            DoctosCoDetInfoBan = new HashSet<DoctosCoDetInfoBan>();
            DoctosCpInfoBan = new HashSet<DoctosCpInfoBan>();
        }

        public int BeneficiarioId { get; set; }
        public string Nombre { get; set; }
        public string Rfc { get; set; }
        public string UltCuentaBan { get; set; }
        public string UltBanco { get; set; }
        public string UltNomBancoExt { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual ICollection<DoctosBa> DoctosBa { get; set; }
        public virtual ICollection<DoctosCoDetInfoBan> DoctosCoDetInfoBan { get; set; }
        public virtual ICollection<DoctosCpInfoBan> DoctosCpInfoBan { get; set; }
    }
}
