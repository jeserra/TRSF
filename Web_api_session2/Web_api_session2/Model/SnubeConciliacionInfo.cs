using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class SnubeConciliacionInfo
    {
        public int SnubeMapeoId { get; set; }
        public string NomColumna { get; set; }
        public string Valor { get; set; }

        public virtual SnubeMapeos SnubeMapeo { get; set; }
    }
}
