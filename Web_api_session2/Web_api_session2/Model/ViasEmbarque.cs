using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ViasEmbarque
    {
        public ViasEmbarque()
        {
            DirsClientes = new HashSet<DirsClientes>();
            DoctosCm = new HashSet<DoctosCm>();
            DoctosVe = new HashSet<DoctosVe>();
            Proveedores = new HashSet<Proveedores>();
        }

        public int ViaEmbarqueId { get; set; }
        public string Nombre { get; set; }
        public string EsPredet { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual ICollection<DirsClientes> DirsClientes { get; set; }
        public virtual ICollection<DoctosCm> DoctosCm { get; set; }
        public virtual ICollection<DoctosVe> DoctosVe { get; set; }
        public virtual ICollection<Proveedores> Proveedores { get; set; }
    }
}
