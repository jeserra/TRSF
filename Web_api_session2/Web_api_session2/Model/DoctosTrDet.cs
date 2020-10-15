using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DoctosTrDet
    {
        public DoctosTrDet()
        {
            InverseMovtoJuegoPadre = new HashSet<DoctosTrDet>();
        }

        public int DoctoTrDetId { get; set; }
        public int DoctoTrId { get; set; }
        public int DoctoOrigenDetId { get; set; }
        public string ClaveArticulo { get; set; }
        public int ArticuloId { get; set; }
        public decimal Unidades { get; set; }
        public string Rol { get; set; }
        public int? MovtoJuegoPadreId { get; set; }
        public int Posicion { get; set; }

        public virtual Articulos Articulo { get; set; }
        public virtual DoctosTr DoctoTr { get; set; }
        public virtual DoctosTrDet MovtoJuegoPadre { get; set; }
        public virtual ICollection<DoctosTrDet> InverseMovtoJuegoPadre { get; set; }
    }
}
