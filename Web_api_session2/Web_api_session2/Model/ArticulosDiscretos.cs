using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ArticulosDiscretos
    {
        public ArticulosDiscretos()
        {
            CapasPedimentos = new HashSet<CapasPedimentos>();
            DesgloseEnDiscretos = new HashSet<DesgloseEnDiscretos>();
            DesgloseEnDiscretosCm = new HashSet<DesgloseEnDiscretosCm>();
            DesgloseEnDiscretosInvfis = new HashSet<DesgloseEnDiscretosInvfis>();
            DesgloseEnDiscretosPv = new HashSet<DesgloseEnDiscretosPv>();
            DesgloseEnDiscretosVe = new HashSet<DesgloseEnDiscretosVe>();
            ExisDiscretos = new HashSet<ExisDiscretos>();
        }

        public int ArtDiscretoId { get; set; }
        public string Clave { get; set; }
        public int ArticuloId { get; set; }
        public string Tipo { get; set; }
        public DateTime? Fecha { get; set; }

        public virtual Articulos Articulo { get; set; }
        public virtual ICollection<CapasPedimentos> CapasPedimentos { get; set; }
        public virtual ICollection<DesgloseEnDiscretos> DesgloseEnDiscretos { get; set; }
        public virtual ICollection<DesgloseEnDiscretosCm> DesgloseEnDiscretosCm { get; set; }
        public virtual ICollection<DesgloseEnDiscretosInvfis> DesgloseEnDiscretosInvfis { get; set; }
        public virtual ICollection<DesgloseEnDiscretosPv> DesgloseEnDiscretosPv { get; set; }
        public virtual ICollection<DesgloseEnDiscretosVe> DesgloseEnDiscretosVe { get; set; }
        public virtual ICollection<ExisDiscretos> ExisDiscretos { get; set; }
    }
}
