﻿using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class LibresComCm
    {
        public int DoctoCmId { get; set; }

        public virtual DoctosCm DoctoCm { get; set; }
    }
}
