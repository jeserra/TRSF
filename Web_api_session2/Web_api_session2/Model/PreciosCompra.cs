using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class PreciosCompra
    {
        public PreciosCompra()
        {
            PreciosCompraDet = new HashSet<PreciosCompraDet>();
        }

        public int PrecioCompraId { get; set; }
        public string ClaveArticulo { get; set; }
        public int ArticuloId { get; set; }
        public string ClaveProv { get; set; }
        public int ProveedorId { get; set; }
        public string UnidadCompra { get; set; }
        public decimal? ContenidoUnidadCompra { get; set; }
        public decimal? UnidadesMinUven { get; set; }
        public decimal? UnidadesMinUcom { get; set; }
        public string ClaveArtProv { get; set; }
        public string PrioridadCompra { get; set; }
        public string Notas { get; set; }
        public int NumCompras { get; set; }
        public int TotDiasEntrega { get; set; }
        public int? DiasEntregaProm { get; set; }
        public DateTime? FechaPrecioUltCompra { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual Articulos Articulo { get; set; }
        public virtual Proveedores Proveedor { get; set; }
        public virtual ICollection<PreciosCompraDet> PreciosCompraDet { get; set; }
    }
}
