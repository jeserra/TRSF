using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class UsosFoliosFiscales
    {
        public int UsoFolioId { get; set; }
        public int FoliosFiscalesId { get; set; }
        public int? Folio { get; set; }
        public DateTime Fecha { get; set; }
        public string Sistema { get; set; }
        public int DoctoId { get; set; }
        public string Xml { get; set; }
        public string ProvCert { get; set; }
        public string FechaHoraTimbrado { get; set; }
        public string Uuid { get; set; }
        public int? CfdiId { get; set; }

        public virtual RepositorioCfdi Cfdi { get; set; }
        public virtual FoliosFiscales FoliosFiscales { get; set; }
        public virtual UsosFoliosFiscalesCancelados UsosFoliosFiscalesCancelados { get; set; }
    }
}
