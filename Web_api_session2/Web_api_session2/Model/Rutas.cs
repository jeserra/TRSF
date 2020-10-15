using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class Rutas
    {
        public Rutas()
        {
            RutasDet = new HashSet<RutasDet>();
        }

        public int RutaId { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public string Estatus { get; set; }
        public int AgenteId { get; set; }
        public int? GrupoRutasId { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioAutModif { get; set; }
        public int? VersionRegistro { get; set; }

        public virtual Agentes Agente { get; set; }
        public virtual GruposRutas GrupoRutas { get; set; }
        public virtual ICollection<RutasDet> RutasDet { get; set; }
    }
}
