using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class TiposPolizas
    {
        public TiposPolizas()
        {
            ConceptosBa = new HashSet<ConceptosBa>();
            DoctosCo = new HashSet<DoctosCo>();
            PlantillasPolCo = new HashSet<PlantillasPolCo>();
            TercerosCoTipoPolizaCompras = new HashSet<TercerosCo>();
            TercerosCoTipoPolizaVentas = new HashSet<TercerosCo>();
            TiposPolizasDet = new HashSet<TiposPolizasDet>();
        }

        public int TipoPolizaId { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public string TipoConsec { get; set; }
        public string Prefijo { get; set; }
        public string TipoFiscal { get; set; }
        public string PolSinCfdi { get; set; }
        public string EsPredet { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual ICollection<ConceptosBa> ConceptosBa { get; set; }
        public virtual ICollection<DoctosCo> DoctosCo { get; set; }
        public virtual ICollection<PlantillasPolCo> PlantillasPolCo { get; set; }
        public virtual ICollection<TercerosCo> TercerosCoTipoPolizaCompras { get; set; }
        public virtual ICollection<TercerosCo> TercerosCoTipoPolizaVentas { get; set; }
        public virtual ICollection<TiposPolizasDet> TiposPolizasDet { get; set; }
    }
}
