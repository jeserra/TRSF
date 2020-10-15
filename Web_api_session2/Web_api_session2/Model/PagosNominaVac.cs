using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class PagosNominaVac
    {
        public int PagoNominaVacId { get; set; }
        public int PagoNominaId { get; set; }
        public int VacacionesId { get; set; }
        public decimal Dias { get; set; }
        public string Aplicado { get; set; }

        public virtual PagosNomina PagoNomina { get; set; }
        public virtual Vacaciones Vacaciones { get; set; }
    }
}
