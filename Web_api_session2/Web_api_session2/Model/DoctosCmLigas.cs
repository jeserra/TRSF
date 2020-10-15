using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DoctosCmLigas
    {
        public DoctosCmLigas()
        {
            DoctosCmLigasDet = new HashSet<DoctosCmLigasDet>();
        }

        public int DoctoCmLigaId { get; set; }
        public int DoctoCmFteId { get; set; }
        public int DoctoCmDestId { get; set; }

        public virtual DoctosCm DoctoCmDest { get; set; }
        public virtual DoctosCm DoctoCmFte { get; set; }
        public virtual ICollection<DoctosCmLigasDet> DoctosCmLigasDet { get; set; }
    }
}
