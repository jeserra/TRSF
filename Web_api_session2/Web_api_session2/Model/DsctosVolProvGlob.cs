using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DsctosVolProvGlob
    {
        public int DsctoVolProvGlobId { get; set; }
        public int PolDsctoVolProvId { get; set; }
        public decimal? Unidades { get; set; }
        public decimal? Descuento { get; set; }

        public virtual PoliticasDsctosVolProv PolDsctoVolProv { get; set; }
    }
}
