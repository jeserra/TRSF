using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class FormasCobroClientes
    {
        public int FormaCobroCliId { get; set; }
        public int ClienteId { get; set; }
        public string ClaveSistema { get; set; }
        public int FormaCobroId { get; set; }
        public string NumCtaPago { get; set; }
        public int? BancoId { get; set; }
        public string UltUtilizada { get; set; }

        public virtual Bancos Banco { get; set; }
        public virtual Clientes Cliente { get; set; }
    }
}
