using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class Recordatorios
    {
        public Recordatorios()
        {
            DoctosCoDet = new HashSet<DoctosCoDet>();
        }

        public int RecordatorioId { get; set; }
        public string Descripcion { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual ICollection<DoctosCoDet> DoctosCoDet { get; set; }
    }
}
