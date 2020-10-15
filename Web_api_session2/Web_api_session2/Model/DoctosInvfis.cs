using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DoctosInvfis
    {
        public DoctosInvfis()
        {
            DoctosInvfisDet = new HashSet<DoctosInvfisDet>();
        }

        public int DoctoInvfisId { get; set; }
        public int AlmacenId { get; set; }
        public string Folio { get; set; }
        public DateTime Fecha { get; set; }
        public string Cancelado { get; set; }
        public string Aplicado { get; set; }
        public string Descripcion { get; set; }
        public int? DoctoInIdEnt { get; set; }
        public int? DoctoInIdSal { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }
        public string UsuarioCancelacion { get; set; }
        public DateTime? FechaHoraCancelacion { get; set; }
        public string UsuarioAutCancelacion { get; set; }

        public virtual Almacenes Almacen { get; set; }
        public virtual DoctosIn DoctoInIdEntNavigation { get; set; }
        public virtual DoctosIn DoctoInIdSalNavigation { get; set; }
        public virtual LibresInvfis LibresInvfis { get; set; }
        public virtual ICollection<DoctosInvfisDet> DoctosInvfisDet { get; set; }
    }
}
