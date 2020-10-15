using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ViaticosNo
    {
        public ViaticosNo()
        {
            ViaticosNoCancelados = new HashSet<ViaticosNoCancelados>();
            ViaticosNoDet = new HashSet<ViaticosNoDet>();
        }

        public int ViaticoNoId { get; set; }
        public int EmpleadoId { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public string Estatus { get; set; }
        public string Observaciones { get; set; }
        public int? DoctoComprobacionesId { get; set; }
        public string FormaEmitida { get; set; }
        public string Enviado { get; set; }
        public DateTime? FechaHoraEnvio { get; set; }
        public string EmailEnvio { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual Empleados Empleado { get; set; }
        public virtual ICollection<ViaticosNoCancelados> ViaticosNoCancelados { get; set; }
        public virtual ICollection<ViaticosNoDet> ViaticosNoDet { get; set; }
    }
}
