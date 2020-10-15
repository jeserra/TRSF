using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class SnubeMapeos
    {
        public int SnubeMapeoId { get; set; }
        public string NomTabla { get; set; }
        public int ObjSnubeId { get; set; }
        public int? ObjLocalId { get; set; }
    }
}
