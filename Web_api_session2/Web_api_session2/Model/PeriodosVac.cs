﻿using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class PeriodosVac
    {
        public PeriodosVac()
        {
            UsosPeriodosVac = new HashSet<UsosPeriodosVac>();
        }

        public int PeriodoVacId { get; set; }
        public int EmpleadoId { get; set; }
        public DateTime FechaInicial { get; set; }
        public decimal DiasCalc { get; set; }
        public decimal Dias { get; set; }
        public DateTime? FechaCaducidad { get; set; }
        public string Estatus { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual Empleados Empleado { get; set; }
        public virtual ICollection<UsosPeriodosVac> UsosPeriodosVac { get; set; }
    }
}
