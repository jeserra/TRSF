using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DoctosPvLigas
    {
        public DoctosPvLigas()
        {
            DoctosPvLigasDet = new HashSet<DoctosPvLigasDet>();
        }

        public int DoctoPvLigaId { get; set; }
        public int DoctoPvFteId { get; set; }
        public int DoctoPvDestId { get; set; }

        public virtual DoctosPv DoctoPvDest { get; set; }
        public virtual DoctosPv DoctoPvFte { get; set; }
        public virtual ICollection<DoctosPvLigasDet> DoctosPvLigasDet { get; set; }
    }
}
