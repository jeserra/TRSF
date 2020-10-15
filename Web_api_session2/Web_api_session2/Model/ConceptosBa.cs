using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ConceptosBa
    {
        public ConceptosBa()
        {
            DoctosBa = new HashSet<DoctosBa>();
            FormasCobroCc = new HashSet<FormasCobroCc>();
            Proveedores = new HashSet<Proveedores>();
            TraspasosBa = new HashSet<TraspasosBa>();
        }

        public int ConceptoBaId { get; set; }
        public string Nombre { get; set; }
        public string NombreAbrev { get; set; }
        public string Naturaleza { get; set; }
        public short DiasTransito { get; set; }
        public string PregBeneficiario { get; set; }
        public string TipoMovFiscal { get; set; }
        public string PregPoliza { get; set; }
        public int? TipoPolizaId { get; set; }
        public string EsPredef { get; set; }
        public string EsPredet { get; set; }
        public string IdInterno { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual TiposPolizas TipoPoliza { get; set; }
        public virtual ICollection<DoctosBa> DoctosBa { get; set; }
        public virtual ICollection<FormasCobroCc> FormasCobroCc { get; set; }
        public virtual ICollection<Proveedores> Proveedores { get; set; }
        public virtual ICollection<TraspasosBa> TraspasosBa { get; set; }
    }
}
