using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class EdosctaBa
    {
        public EdosctaBa()
        {
            EdosctaBaDet = new HashSet<EdosctaBaDet>();
        }

        public int EdoctaBaId { get; set; }
        public int CuentaBanId { get; set; }
        public DateTime FechaIni { get; set; }
        public DateTime FechaFin { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual CuentasBancarias CuentaBan { get; set; }
        public virtual ICollection<EdosctaBaDet> EdosctaBaDet { get; set; }
    }
}
