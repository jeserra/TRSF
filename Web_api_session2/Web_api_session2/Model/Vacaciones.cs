using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class Vacaciones
    {
        public Vacaciones()
        {
            PagosNominaVac = new HashSet<PagosNominaVac>();
            UsosPeriodosVac = new HashSet<UsosPeriodosVac>();
        }

        public int VacacionesId { get; set; }
        public int EmpleadoId { get; set; }
        public DateTime FechaInicial { get; set; }
        public decimal Dias { get; set; }
        public string Descripcion { get; set; }
        public string Estatus { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual Empleados Empleado { get; set; }
        public virtual ICollection<PagosNominaVac> PagosNominaVac { get; set; }
        public virtual ICollection<UsosPeriodosVac> UsosPeriodosVac { get; set; }
    }
}
