using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class UsosPeriodosVac
    {
        public int UsoPeriodoVacId { get; set; }
        public int PeriodoVacId { get; set; }
        public int? VacacionesId { get; set; }
        public decimal Dias { get; set; }

        public virtual PeriodosVac PeriodoVac { get; set; }
        public virtual Vacaciones Vacaciones { get; set; }
    }
}
