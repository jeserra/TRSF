using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class TiposIsn
    {
        public TiposIsn()
        {
            RegPatronales = new HashSet<RegPatronales>();
        }

        public int TipoIsnId { get; set; }
        public string Nombre { get; set; }
        public string TipoCalc { get; set; }
        public decimal? PctjeImpuesto { get; set; }
        public int? TablaNoId { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual TablasNo TablaNo { get; set; }
        public virtual ICollection<RegPatronales> RegPatronales { get; set; }
    }
}
