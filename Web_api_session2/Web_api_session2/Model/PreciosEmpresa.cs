using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class PreciosEmpresa
    {
        public PreciosEmpresa()
        {
            PoliticasPreciosClientes = new HashSet<PoliticasPreciosClientes>();
            PreciosArticulos = new HashSet<PreciosArticulos>();
            PreciosCliCli = new HashSet<PreciosCliCli>();
            PreciosCliTipo = new HashSet<PreciosCliTipo>();
            PreciosCliZona = new HashSet<PreciosCliZona>();
        }

        public int PrecioEmpresaId { get; set; }
        public string Nombre { get; set; }
        public string IdInterno { get; set; }
        public short Posicion { get; set; }

        public virtual ICollection<PoliticasPreciosClientes> PoliticasPreciosClientes { get; set; }
        public virtual ICollection<PreciosArticulos> PreciosArticulos { get; set; }
        public virtual ICollection<PreciosCliCli> PreciosCliCli { get; set; }
        public virtual ICollection<PreciosCliTipo> PreciosCliTipo { get; set; }
        public virtual ICollection<PreciosCliZona> PreciosCliZona { get; set; }
    }
}
