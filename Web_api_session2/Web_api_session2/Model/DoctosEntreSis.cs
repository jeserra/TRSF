using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DoctosEntreSis
    {
        public int DoctoDestId { get; set; }
        public string ClaveSisDest { get; set; }
        public string ClaveSisFte { get; set; }
        public int DoctoFteId { get; set; }
        public string TipoDocto { get; set; }
    }
}
