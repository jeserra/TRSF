using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class UsosCapasCostos
    {
        public int DoctoInDetId { get; set; }
        public int CapaId { get; set; }
        public decimal? Unidades { get; set; }
        public decimal? ValorTotal { get; set; }
        public string TipoUso { get; set; }

        public virtual CapasCostos Capa { get; set; }
        public virtual DoctosInDet DoctoInDet { get; set; }
    }
}
