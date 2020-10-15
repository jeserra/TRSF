using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class UsosCapasPedimentos
    {
        public int DoctoInDetId { get; set; }
        public int CapaPedimentoId { get; set; }
        public decimal? Unidades { get; set; }
        public string TipoUso { get; set; }

        public virtual CapasPedimentos CapaPedimento { get; set; }
        public virtual DoctosInDet DoctoInDet { get; set; }
    }
}
