using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class PlanesVisitas
    {
        public PlanesVisitas()
        {
            PlanesVisitasDet = new HashSet<PlanesVisitasDet>();
        }

        public int PlanVisitasId { get; set; }
        public int AgenteId { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }
        public string Nombre { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }
        public int? VersionRegistro { get; set; }

        public virtual Agentes Agente { get; set; }
        public virtual ICollection<PlanesVisitasDet> PlanesVisitasDet { get; set; }
    }
}
