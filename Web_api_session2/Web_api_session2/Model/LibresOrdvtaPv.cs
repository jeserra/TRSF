using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class LibresOrdvtaPv
    {
        public int DoctoPvId { get; set; }

        public virtual DoctosPv DoctoPv { get; set; }
    }
}
