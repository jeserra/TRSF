using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class TiposImpuestos
    {
        public TiposImpuestos()
        {
            Impuestos = new HashSet<Impuestos>();
            ImpuestosGravadosTipoImpto = new HashSet<ImpuestosGravados>();
            ImpuestosGravadosTipoImptoGravado = new HashSet<ImpuestosGravados>();
        }

        public int TipoImptoId { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string GravaOtrosImptos { get; set; }
        public string IdInterno { get; set; }
        public string EsPredet { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual ICollection<Impuestos> Impuestos { get; set; }
        public virtual ICollection<ImpuestosGravados> ImpuestosGravadosTipoImpto { get; set; }
        public virtual ICollection<ImpuestosGravados> ImpuestosGravadosTipoImptoGravado { get; set; }
    }
}
