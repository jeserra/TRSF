using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class Estados
    {
        public Estados()
        {
            Ciudades = new HashSet<Ciudades>();
            DoctosCmProeve = new HashSet<DoctosCmProeve>();
        }

        public int EstadoId { get; set; }
        public string Nombre { get; set; }
        public string NombreAbrev { get; set; }
        public string ClaveFiscal { get; set; }
        public string EsPredet { get; set; }
        public int PaisId { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual Paises Pais { get; set; }
        public virtual ICollection<Ciudades> Ciudades { get; set; }
        public virtual ICollection<DoctosCmProeve> DoctosCmProeve { get; set; }
    }
}
