using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class PlantillasPolCo
    {
        public PlantillasPolCo()
        {
            PlantillasPolCoDet = new HashSet<PlantillasPolCoDet>();
        }

        public int PlantillaPolCoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Naturaleza { get; set; }
        public int TipoPolizaId { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual TiposPolizas TipoPoliza { get; set; }
        public virtual ICollection<PlantillasPolCoDet> PlantillasPolCoDet { get; set; }
    }
}
