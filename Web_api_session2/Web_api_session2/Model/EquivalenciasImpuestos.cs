using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class EquivalenciasImpuestos
    {
        public EquivalenciasImpuestos()
        {
            EquivalenciasImpuestosDet = new HashSet<EquivalenciasImpuestosDet>();
        }

        public int EquivImptosId { get; set; }
        public DateTime FechaInicio { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual ICollection<EquivalenciasImpuestosDet> EquivalenciasImpuestosDet { get; set; }
    }
}
