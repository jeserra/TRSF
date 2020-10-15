using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class TiposTablasNo
    {
        public TiposTablasNo()
        {
            TablasNo = new HashSet<TablasNo>();
        }

        public int TipoTablaNoId { get; set; }
        public string Nombre { get; set; }
        public string IdInterno { get; set; }
        public string PregAno { get; set; }
        public string VariasPorAno { get; set; }
        public string Escalable { get; set; }

        public virtual ICollection<TablasNo> TablasNo { get; set; }
    }
}
