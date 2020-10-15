using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class OfertasMm
    {
        public OfertasMm()
        {
            OfertasMmDet = new HashSet<OfertasMmDet>();
        }

        public int OfertaMmId { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Habilitada { get; set; }
        public string EsPermanente { get; set; }
        public DateTime? FechaIniVigencia { get; set; }
        public DateTime? FechaFinVigencia { get; set; }
        public string AplicarHorario { get; set; }
        public TimeSpan? HoraIni { get; set; }
        public TimeSpan? HoraFin { get; set; }
        public short UsoMaximo { get; set; }
        public decimal UnidadesCompra { get; set; }
        public decimal UnidadesMax { get; set; }
        public decimal PctjeDscto { get; set; }
        public int Posicion { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual ICollection<OfertasMmDet> OfertasMmDet { get; set; }
    }
}
