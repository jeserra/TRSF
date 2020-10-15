using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DoctosVeLigasDet
    {
        public int DoctoVeLigaId { get; set; }
        public int DoctoVeDetFteId { get; set; }
        public int DoctoVeDetDestId { get; set; }

        public virtual DoctosVeDet DoctoVeDetDest { get; set; }
        public virtual DoctosVeDet DoctoVeDetFte { get; set; }
        public virtual DoctosVeLigas DoctoVeLiga { get; set; }
    }
}
