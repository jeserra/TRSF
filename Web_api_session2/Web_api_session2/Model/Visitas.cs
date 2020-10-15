using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class Visitas
    {
        public Visitas()
        {
            PlanesVisitasDet = new HashSet<PlanesVisitasDet>();
        }

        public int VisitaId { get; set; }
        public int AgenteId { get; set; }
        public int ClienteId { get; set; }
        public string ClaveCliente { get; set; }
        public DateTime? FechaPlaneada { get; set; }
        public DateTime FechaHoraRealIni { get; set; }
        public DateTime? FechaHoraRealFin { get; set; }
        public string Estatus { get; set; }
        public int? RazonVisInefId { get; set; }
        public string Observaciones { get; set; }
        public decimal? ImporteCobros { get; set; }
        public decimal? ImportePedidos { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }
        public int? VersionRegistro { get; set; }

        public virtual Agentes Agente { get; set; }
        public virtual Clientes Cliente { get; set; }
        public virtual RazonesVisInef RazonVisInef { get; set; }
        public virtual ICollection<PlanesVisitasDet> PlanesVisitasDet { get; set; }
    }
}
