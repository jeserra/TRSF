using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class Aduanas
    {
        public Aduanas()
        {
            Pedimentos = new HashSet<Pedimentos>();
        }

        public int AduanaId { get; set; }
        public string Nombre { get; set; }
        public int CiudadId { get; set; }
        public string Gln { get; set; }
        public string EsPredet { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual Ciudades Ciudad { get; set; }
        public virtual ICollection<Pedimentos> Pedimentos { get; set; }
    }
}
