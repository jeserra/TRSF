using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class CondicionesPago
    {
        public CondicionesPago()
        {
            CargosPeriodicosCc = new HashSet<CargosPeriodicosCc>();
            Clientes = new HashSet<Clientes>();
            DoctosCc = new HashSet<DoctosCc>();
            DoctosPendCc = new HashSet<DoctosPendCc>();
            DoctosVe = new HashSet<DoctosVe>();
            PlazosCondPag = new HashSet<PlazosCondPag>();
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

        public virtual ICollection<CargosPeriodicosCc> CargosPeriodicosCc { get; set; }
        public virtual ICollection<Clientes> Clientes { get; set; }
        public virtual ICollection<DoctosCc> DoctosCc { get; set; }
        public virtual ICollection<DoctosPendCc> DoctosPendCc { get; set; }
        public virtual ICollection<DoctosVe> DoctosVe { get; set; }
        public virtual ICollection<PlazosCondPag> PlazosCondPag { get; set; }
    }
}
