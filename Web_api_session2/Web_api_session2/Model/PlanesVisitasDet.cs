using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class PlanesVisitasDet
    {
        public int PlanVisitasDetId { get; set; }
        public int PlanVisitasId { get; set; }
        public int VisitaId { get; set; }
        public int OrdenEjecucion { get; set; }

        public virtual PlanesVisitas PlanVisitas { get; set; }
        public virtual Visitas Visita { get; set; }
    }
}
