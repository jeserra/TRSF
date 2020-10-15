using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DoctosVeLigas
    {
        public DoctosVeLigas()
        {
            DoctosVeLigasDet = new HashSet<DoctosVeLigasDet>();
        }

        public int DoctoVeLigaId { get; set; }
        public int DoctoVeFteId { get; set; }
        public int DoctoVeDestId { get; set; }

        public virtual DoctosVe DoctoVeDest { get; set; }
        public virtual DoctosVe DoctoVeFte { get; set; }
        public virtual ICollection<DoctosVeLigasDet> DoctosVeLigasDet { get; set; }
    }
}
