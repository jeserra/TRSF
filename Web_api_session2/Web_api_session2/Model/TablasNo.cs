using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class TablasNo
    {
        public TablasNo()
        {
            Empleados = new HashSet<Empleados>();
            TablasNoDet = new HashSet<TablasNoDet>();
            TiposIsn = new HashSet<TiposIsn>();
        }

        public int TablaNoId { get; set; }
        public string Nombre { get; set; }
        public int TipoTablaNoId { get; set; }
        public short Ano { get; set; }
        public string EsPredet { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual TiposTablasNo TipoTablaNo { get; set; }
        public virtual ICollection<Empleados> Empleados { get; set; }
        public virtual ICollection<TablasNoDet> TablasNoDet { get; set; }
        public virtual ICollection<TiposIsn> TiposIsn { get; set; }
    }
}
