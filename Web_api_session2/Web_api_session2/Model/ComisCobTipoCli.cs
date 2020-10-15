using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ComisCobTipoCli
    {
        public int ComisCobTipoCliId { get; set; }
        public int PoliticaComisCobId { get; set; }
        public int TipoClienteId { get; set; }
        public decimal? PctjeEnSaldoXven { get; set; }
        public decimal? PctjeEnSaldoVencido { get; set; }

        public virtual PoliticasComisionesCobradores PoliticaComisCob { get; set; }
        public virtual TiposClientes TipoCliente { get; set; }
    }
}
