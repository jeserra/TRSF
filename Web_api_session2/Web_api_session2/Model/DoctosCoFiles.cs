using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DoctosCoFiles
    {
        public int DoctoCoFileId { get; set; }
        public int DoctoCoId { get; set; }
        public string FileName { get; set; }
        public int FileSize { get; set; }
        public DateTime FileDate { get; set; }
        public string FileStream { get; set; }

        public virtual DoctosCo DoctoCo { get; set; }
    }
}
