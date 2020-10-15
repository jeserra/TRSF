using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class FormatosTicketsDet
    {
        public int FormatoTicketDetId { get; set; }
        public int FormatoTicketId { get; set; }
        public string Comando { get; set; }
        public int Columna { get; set; }
        public int Columna2 { get; set; }
        public int Columna3 { get; set; }
        public string Letrero { get; set; }
        public int? ComandoTipoDispId { get; set; }
        public int Posicion { get; set; }

        public virtual ComandosTiposDispositivos ComandoTipoDisp { get; set; }
    }
}
