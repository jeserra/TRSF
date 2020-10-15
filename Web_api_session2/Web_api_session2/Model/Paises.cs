using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class Paises
    {
        public Paises()
        {
            DoctosCmProeve = new HashSet<DoctosCmProeve>();
            Estados = new HashSet<Estados>();
        }

        public int PaisId { get; set; }
        public string Nombre { get; set; }
        public string NombreAbrev { get; set; }
        public string ClaveFiscal { get; set; }
        public string EsPredet { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual ICollection<DoctosCmProeve> DoctosCmProeve { get; set; }
        public virtual ICollection<Estados> Estados { get; set; }
    }
}
