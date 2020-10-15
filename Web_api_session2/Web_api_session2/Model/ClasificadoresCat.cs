using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ClasificadoresCat
    {
        public ClasificadoresCat()
        {
            ClasificadoresCatValores = new HashSet<ClasificadoresCatValores>();
            OfertasMmDet = new HashSet<OfertasMmDet>();
        }

        public int ClasificadorId { get; set; }
        public string TipoObjeto { get; set; }
        public string Nombre { get; set; }
        public string NombreAbrev { get; set; }
        public string Descripcion { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual ICollection<ClasificadoresCatValores> ClasificadoresCatValores { get; set; }
        public virtual ICollection<OfertasMmDet> OfertasMmDet { get; set; }
    }
}
