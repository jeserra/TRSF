using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class CapasCostos
    {
        public CapasCostos()
        {
            UsosCapasCostos = new HashSet<UsosCapasCostos>();
        }

        public int CapaId { get; set; }
        public int ArticuloId { get; set; }
        public int AlmacenId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal? Existencia { get; set; }
        public decimal? ValorTotal { get; set; }
        public string CapaAgotada { get; set; }

        public virtual Almacenes Almacen { get; set; }
        public virtual Articulos Articulo { get; set; }
        public virtual ICollection<UsosCapasCostos> UsosCapasCostos { get; set; }
    }
}
