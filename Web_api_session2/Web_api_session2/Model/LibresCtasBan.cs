using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class LibresCtasBan
    {
        public int CuentaBanId { get; set; }

        public virtual CuentasBancarias CuentaBan { get; set; }
    }
}
