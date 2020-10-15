using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DoctosPvDet
    {
        public DoctosPvDet()
        {
            DesgloseEnDiscretosPv = new HashSet<DesgloseEnDiscretosPv>();
            DoctosPvLigasDetDoctoPvDetDest = new HashSet<DoctosPvLigasDet>();
            DoctosPvLigasDetDoctoPvDetFte = new HashSet<DoctosPvLigasDet>();
            SubMovtosPvDoctoPvDet = new HashSet<SubMovtosPv>();
            SubMovtosPvSubMovtoPv = new HashSet<SubMovtosPv>();
        }

        public int DoctoPvDetId { get; set; }
        public int DoctoPvId { get; set; }
        public string ClaveArticulo { get; set; }
        public int ArticuloId { get; set; }
        public decimal? Unidades { get; set; }
        public decimal? UnidadesDev { get; set; }
        public string TipoContabUnid { get; set; }
        public decimal? PrecioUnitario { get; set; }
        public decimal? PrecioUnitarioImpto { get; set; }
        public decimal? ImpuestoPorUnidad { get; set; }
        public decimal? PctjeDscto { get; set; }
        public decimal? PrecioTotalNeto { get; set; }
        public string PrecioModificado { get; set; }
        public int? VendedorId { get; set; }
        public decimal? PctjeComis { get; set; }
        public string Rol { get; set; }
        public string Notas { get; set; }
        public string EsTranElect { get; set; }
        public string EstatusTranElect { get; set; }
        public int Posicion { get; set; }
        public decimal? DsctoArt { get; set; }
        public decimal? DsctoExtra { get; set; }

        public virtual Articulos Articulo { get; set; }
        public virtual DoctosPv DoctoPv { get; set; }
        public virtual Vendedores Vendedor { get; set; }
        public virtual DoctosPvDetTranElect DoctosPvDetTranElect { get; set; }
        public virtual ICollection<DesgloseEnDiscretosPv> DesgloseEnDiscretosPv { get; set; }
        public virtual ICollection<DoctosPvLigasDet> DoctosPvLigasDetDoctoPvDetDest { get; set; }
        public virtual ICollection<DoctosPvLigasDet> DoctosPvLigasDetDoctoPvDetFte { get; set; }
        public virtual ICollection<SubMovtosPv> SubMovtosPvDoctoPvDet { get; set; }
        public virtual ICollection<SubMovtosPv> SubMovtosPvSubMovtoPv { get; set; }
    }
}
