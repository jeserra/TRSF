using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DepositosCcDet
    {
        public int DepositoCcDetId { get; set; }
        public int DepositoCcId { get; set; }
        public int DoctoCcId { get; set; }

        public virtual DepositosCc DepositoCc { get; set; }
        public virtual DoctosCc DoctoCc { get; set; }
    }
}
