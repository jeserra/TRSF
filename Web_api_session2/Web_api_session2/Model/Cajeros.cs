using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class Cajeros
    {
        public Cajeros()
        {
            CajasCajeros = new HashSet<CajasCajeros>();
            DoctosPv = new HashSet<DoctosPv>();
            DoctosPvDetTranElect = new HashSet<DoctosPvDetTranElect>();
            MovtosCajasCajeros = new HashSet<MovtosCajasCajeros>();
        }

        public int CajeroId { get; set; }
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public string OperarCajas { get; set; }
        public string AbrirCajas { get; set; }
        public string ReportesDelDia { get; set; }
        public string ReportesCajaAbierta { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual ICollection<CajasCajeros> CajasCajeros { get; set; }
        public virtual ICollection<DoctosPv> DoctosPv { get; set; }
        public virtual ICollection<DoctosPvDetTranElect> DoctosPvDetTranElect { get; set; }
        public virtual ICollection<MovtosCajasCajeros> MovtosCajasCajeros { get; set; }
    }
}
