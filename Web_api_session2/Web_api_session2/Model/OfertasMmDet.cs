using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class OfertasMmDet
    {
        public int OfertaMmDetId { get; set; }
        public int OfertaMmId { get; set; }
        public string EsRequisito { get; set; }
        public int? ArticuloId { get; set; }
        public int? ClasificadorId { get; set; }
        public int? ValorClasifId { get; set; }
        public decimal UnidadesMinimas { get; set; }
        public decimal UnidadesMaximas { get; set; }
        public string TipoDscto { get; set; }
        public decimal PctjeDscto { get; set; }
        public decimal PrecioEspecial { get; set; }

        public virtual Articulos Articulo { get; set; }
        public virtual ClasificadoresCat Clasificador { get; set; }
        public virtual OfertasMm OfertaMm { get; set; }
        public virtual ClasificadoresCatValores ValorClasif { get; set; }
    }
}
