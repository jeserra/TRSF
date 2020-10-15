using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DoctosVeCamposAddenda
    {
        public int DoctoVeId { get; set; }
        public string CamposAddenda { get; set; }

        public virtual DoctosVe DoctoVe { get; set; }
    }
}
