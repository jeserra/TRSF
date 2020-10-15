using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class TiposContratosLft
    {
        public TiposContratosLft()
        {
            ContratosLft = new HashSet<ContratosLft>();
        }

        public int TipoContLftId { get; set; }
        public string Nombre { get; set; }
        public string EsTiempoDeterm { get; set; }

        public virtual ICollection<ContratosLft> ContratosLft { get; set; }
    }
}
