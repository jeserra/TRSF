using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class CuentasNo
    {
        public int ConceptoNoId { get; set; }
        public int DeptoNoId { get; set; }
        public string CuentaContable { get; set; }

        public virtual DeptosNo DeptoNo { get; set; }
    }
}
