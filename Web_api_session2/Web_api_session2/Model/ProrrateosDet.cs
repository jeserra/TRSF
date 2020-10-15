using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ProrrateosDet
    {
        public int CuentaId { get; set; }
        public int CuentaDetId { get; set; }
        public int DeptoCoId { get; set; }
        public decimal? Pctje { get; set; }

        public virtual CuentasCo Cuenta { get; set; }
        public virtual CuentasCo CuentaDet { get; set; }
        public virtual DeptosCo DeptoCo { get; set; }
    }
}
