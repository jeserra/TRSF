using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class MovtosCajas
    {
        public MovtosCajas()
        {
            MovtosCajasCajeros = new HashSet<MovtosCajasCajeros>();
            MovtosCajasFondo = new HashSet<MovtosCajasFondo>();
        }

        public int MovtoCajaId { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public string TipoMovto { get; set; }
        public int CajaId { get; set; }
        public string CajerosHabilitados { get; set; }
        public string FormaEmitida { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual Cajas Caja { get; set; }
        public virtual ICollection<MovtosCajasCajeros> MovtosCajasCajeros { get; set; }
        public virtual ICollection<MovtosCajasFondo> MovtosCajasFondo { get; set; }
    }
}
