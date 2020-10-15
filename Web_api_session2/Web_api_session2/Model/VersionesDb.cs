using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class VersionesDb
    {
        public int VersionDb { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public short PasoActual { get; set; }
    }
}
