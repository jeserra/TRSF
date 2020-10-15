using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class Registry
    {
        public int ElementoId { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public int PadreId { get; set; }
        public string Valor { get; set; }
        public string ValorBlob { get; set; }
        public string ValorMemo { get; set; }
    }
}
