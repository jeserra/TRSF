using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DesgloseEnPedimentos
    {
        public int DoctoInDetId { get; set; }
        public int PedimentoId { get; set; }

        public virtual DoctosInDet DoctoInDet { get; set; }
        public virtual Pedimentos Pedimento { get; set; }
    }
}
