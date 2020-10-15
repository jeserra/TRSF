using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ComandosTiposDispositivos
    {
        public ComandosTiposDispositivos()
        {
            ComandosDispositivos = new HashSet<ComandosDispositivos>();
            FormatosTicketsDet = new HashSet<FormatosTicketsDet>();
        }

        public int ComandoTipoDispId { get; set; }
        public int TipoDispId { get; set; }
        public string Nombre { get; set; }
        public int Posicion { get; set; }
        public string IdInterno { get; set; }

        public virtual TiposDispositivos TipoDisp { get; set; }
        public virtual ICollection<ComandosDispositivos> ComandosDispositivos { get; set; }
        public virtual ICollection<FormatosTicketsDet> FormatosTicketsDet { get; set; }
    }
}
