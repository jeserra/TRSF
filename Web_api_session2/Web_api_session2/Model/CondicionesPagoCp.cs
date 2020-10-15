using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class CondicionesPagoCp
    {
        public CondicionesPagoCp()
        {
            DoctosCm = new HashSet<DoctosCm>();
            DoctosCp = new HashSet<DoctosCp>();
            PlazosCondPagCp = new HashSet<PlazosCondPagCp>();
            Proveedores = new HashSet<Proveedores>();
        }

        public int CondPagoId { get; set; }
        public string Nombre { get; set; }
        public decimal? PctjeDsctoPpag { get; set; }
        public short? DiasPpag { get; set; }
        public string EsPredet { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual ICollection<DoctosCm> DoctosCm { get; set; }
        public virtual ICollection<DoctosCp> DoctosCp { get; set; }
        public virtual ICollection<PlazosCondPagCp> PlazosCondPagCp { get; set; }
        public virtual ICollection<Proveedores> Proveedores { get; set; }
    }
}
