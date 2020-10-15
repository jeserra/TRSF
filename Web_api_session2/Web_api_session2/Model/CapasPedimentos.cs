using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class CapasPedimentos
    {
        public CapasPedimentos()
        {
            UsosCapasPedimentos = new HashSet<UsosCapasPedimentos>();
        }

        public int CapaPedimentoId { get; set; }
        public int PedimentoId { get; set; }
        public int ArticuloId { get; set; }
        public int? ArtDiscretoId { get; set; }
        public int AlmacenId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? Existencia { get; set; }
        public string CapaAgotada { get; set; }

        public virtual Almacenes Almacen { get; set; }
        public virtual ArticulosDiscretos ArtDiscreto { get; set; }
        public virtual Articulos Articulo { get; set; }
        public virtual Pedimentos Pedimento { get; set; }
        public virtual ICollection<UsosCapasPedimentos> UsosCapasPedimentos { get; set; }
    }
}
