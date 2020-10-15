using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class EspecsEdofin
    {
        public int EspecEdofinId { get; set; }
        public string Nombre { get; set; }
        public int FormatoEdofinId { get; set; }
        public int DeptoCoId { get; set; }
        public string Contenido { get; set; }
        public string Variacion { get; set; }
        public string ColumnaVar { get; set; }
        public string SelImpresion { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual DeptosCo DeptoCo { get; set; }
        public virtual FormatosEdofin FormatoEdofin { get; set; }
    }
}
