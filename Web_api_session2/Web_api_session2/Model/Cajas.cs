using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class Cajas
    {
        public Cajas()
        {
            CajasCajeros = new HashSet<CajasCajeros>();
            DispositivosCajas = new HashSet<DispositivosCajas>();
            DoctosPv = new HashSet<DoctosPv>();
            DoctosPvDetTranElect = new HashSet<DoctosPvDetTranElect>();
            FoliosCajas = new HashSet<FoliosCajas>();
            MovtosCajas = new HashSet<MovtosCajas>();
            MovtosEfvoCaja = new HashSet<MovtosEfvoCaja>();
        }

        public int CajaId { get; set; }
        public string Nombre { get; set; }
        public int AlmacenId { get; set; }
        public string ModificarAlmacen { get; set; }
        public string VentasDesde { get; set; }
        public string PermiteCobrar { get; set; }
        public string PausaTerminarVenta { get; set; }
        public int? FormaCobroPredetId { get; set; }
        public int? ImagenesCajaId { get; set; }
        public string ManejarVendedores { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual Almacenes Almacen { get; set; }
        public virtual FormasCobro FormaCobroPredet { get; set; }
        public virtual ImagenesCajas ImagenesCaja { get; set; }
        public virtual DoctosPvTranPendTc DoctosPvTranPendTc { get; set; }
        public virtual ICollection<CajasCajeros> CajasCajeros { get; set; }
        public virtual ICollection<DispositivosCajas> DispositivosCajas { get; set; }
        public virtual ICollection<DoctosPv> DoctosPv { get; set; }
        public virtual ICollection<DoctosPvDetTranElect> DoctosPvDetTranElect { get; set; }
        public virtual ICollection<FoliosCajas> FoliosCajas { get; set; }
        public virtual ICollection<MovtosCajas> MovtosCajas { get; set; }
        public virtual ICollection<MovtosEfvoCaja> MovtosEfvoCaja { get; set; }
    }
}
