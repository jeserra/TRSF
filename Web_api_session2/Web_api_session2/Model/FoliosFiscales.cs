using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class FoliosFiscales
    {
        public FoliosFiscales()
        {
            UsosFoliosFiscales = new HashSet<UsosFoliosFiscales>();
        }

        public int FoliosFiscalesId { get; set; }
        public string Serie { get; set; }
        public int? FolioIni { get; set; }
        public int? FolioFin { get; set; }
        public int? UltimoUtilizado { get; set; }
        public string NumAprobacion { get; set; }
        public short? AnoAprobacion { get; set; }
        public string ModalidadFacturacion { get; set; }
        public DateTime? FechaAprobacion { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string ImagenCbb { get; set; }

        public virtual ICollection<UsosFoliosFiscales> UsosFoliosFiscales { get; set; }
    }
}
