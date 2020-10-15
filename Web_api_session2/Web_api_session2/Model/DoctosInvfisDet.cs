using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DoctosInvfisDet
    {
        public DoctosInvfisDet()
        {
            DesgloseEnDiscretosInvfis = new HashSet<DesgloseEnDiscretosInvfis>();
        }

        public int DoctoInvfisDetId { get; set; }
        public int DoctoInvfisId { get; set; }
        public string ClaveArticulo { get; set; }
        public int ArticuloId { get; set; }
        public decimal? Unidades { get; set; }
        public int? DoctoInDetIdEnt { get; set; }
        public int? DoctoInDetIdSal { get; set; }

        public virtual Articulos Articulo { get; set; }
        public virtual DoctosInDet DoctoInDetIdEntNavigation { get; set; }
        public virtual DoctosInDet DoctoInDetIdSalNavigation { get; set; }
        public virtual DoctosInvfis DoctoInvfis { get; set; }
        public virtual ICollection<DesgloseEnDiscretosInvfis> DesgloseEnDiscretosInvfis { get; set; }
    }
}
