using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DoctosVeDet
    {
        public DoctosVeDet()
        {
            DesgloseEnDiscretosVe = new HashSet<DesgloseEnDiscretosVe>();
            DoctosVeLigasDetDoctoVeDetDest = new HashSet<DoctosVeLigasDet>();
            DoctosVeLigasDetDoctoVeDetFte = new HashSet<DoctosVeLigasDet>();
            SubMovtosVeDoctoVeDet = new HashSet<SubMovtosVe>();
            SubMovtosVeSubMovtoVe = new HashSet<SubMovtosVe>();
        }

        public int DoctoVeDetId { get; set; }
        public int DoctoVeId { get; set; }
        public string ClaveArticulo { get; set; }
        public int ArticuloId { get; set; }
        public decimal? Unidades { get; set; }
        public decimal? UnidadesComprom { get; set; }
        public decimal? UnidadesSurtDev { get; set; }
        public decimal? UnidadesASurtir { get; set; }
        public decimal? PrecioUnitario { get; set; }
        public decimal? PctjeDscto { get; set; }
        public decimal? DsctoArt { get; set; }
        public decimal? PctjeDsctoCli { get; set; }
        public decimal? DsctoExtra { get; set; }
        public decimal? PctjeDsctoVol { get; set; }
        public decimal? PctjeDsctoPromo { get; set; }
        public decimal? PrecioTotalNeto { get; set; }
        public decimal? PctjeComis { get; set; }
        public string Rol { get; set; }
        public string Notas { get; set; }
        public int Posicion { get; set; }

        public virtual Articulos Articulo { get; set; }
        public virtual DoctosVe DoctoVe { get; set; }
        public virtual ICollection<DesgloseEnDiscretosVe> DesgloseEnDiscretosVe { get; set; }
        public virtual ICollection<DoctosVeLigasDet> DoctosVeLigasDetDoctoVeDetDest { get; set; }
        public virtual ICollection<DoctosVeLigasDet> DoctosVeLigasDetDoctoVeDetFte { get; set; }
        public virtual ICollection<SubMovtosVe> SubMovtosVeDoctoVeDet { get; set; }
        public virtual ICollection<SubMovtosVe> SubMovtosVeSubMovtoVe { get; set; }
    }
}
