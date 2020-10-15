using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DoctosCmDet
    {
        public DoctosCmDet()
        {
            DesgloseEnDiscretosCm = new HashSet<DesgloseEnDiscretosCm>();
            DoctosCmLigasDetDoctoCmDetDest = new HashSet<DoctosCmLigasDet>();
            DoctosCmLigasDetDoctoCmDetFte = new HashSet<DoctosCmLigasDet>();
        }

        public int DoctoCmDetId { get; set; }
        public int DoctoCmId { get; set; }
        public string ClaveArticulo { get; set; }
        public int ArticuloId { get; set; }
        public decimal? Unidades { get; set; }
        public decimal? UnidadesRecDev { get; set; }
        public decimal? UnidadesARec { get; set; }
        public string Umed { get; set; }
        public decimal? ContenidoUmed { get; set; }
        public decimal? PrecioUnitario { get; set; }
        public decimal? PctjeDscto { get; set; }
        public decimal? PctjeDsctoPro { get; set; }
        public decimal? PctjeDsctoVol { get; set; }
        public decimal? PctjeDsctoPromo { get; set; }
        public decimal? DsctoArt { get; set; }
        public decimal? DsctoExtra { get; set; }
        public decimal? PrecioTotalNeto { get; set; }
        public decimal? PctjeArancel { get; set; }
        public string Notas { get; set; }
        public int? Posicion { get; set; }

        public virtual Articulos Articulo { get; set; }
        public virtual DoctosCm DoctoCm { get; set; }
        public virtual ICollection<DesgloseEnDiscretosCm> DesgloseEnDiscretosCm { get; set; }
        public virtual ICollection<DoctosCmLigasDet> DoctosCmLigasDetDoctoCmDetDest { get; set; }
        public virtual ICollection<DoctosCmLigasDet> DoctosCmLigasDetDoctoCmDetFte { get; set; }
    }
}
