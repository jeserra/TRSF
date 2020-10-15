using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class AnticiposCc
    {
        public AnticiposCc()
        {
            UsosAnticiposCc = new HashSet<UsosAnticiposCc>();
        }

        public int AnticipoCcId { get; set; }
        public int ClienteId { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public string Estatus { get; set; }
        public string Folio { get; set; }
        public string TieneImpuesto { get; set; }

        public virtual Clientes Cliente { get; set; }
        public virtual ICollection<UsosAnticiposCc> UsosAnticiposCc { get; set; }
    }
}
