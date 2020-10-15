using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class UsosFoliosFiscalesCancelados
    {
        public int UsoFolioId { get; set; }
        public DateTime FechaCancelacion { get; set; }
        public string ProvCancelacion { get; set; }
        public DateTime? FechaHoraCancelacionCfdi { get; set; }
        public string XmlAcuse { get; set; }

        public virtual UsosFoliosFiscales UsoFolio { get; set; }
    }
}
