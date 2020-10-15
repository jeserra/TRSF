using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ConceptosCp
    {
        public ConceptosCp()
        {
            DoctosCp = new HashSet<DoctosCp>();
        }

        public int ConceptoCpId { get; set; }
        public string Nombre { get; set; }
        public string NombreAbrev { get; set; }
        public string Naturaleza { get; set; }
        public string FolioAutom { get; set; }
        public string SigFolio { get; set; }
        public string Tipo { get; set; }
        public string EsPredef { get; set; }
        public string EsPredet { get; set; }
        public string IdInterno { get; set; }
        public string AplicarImpuesto { get; set; }
        public string AfectoAIetu { get; set; }
        public string RetenerIva { get; set; }
        public string RetenerIsr { get; set; }
        public string GenerarConstancias { get; set; }
        public string TipoConstancia { get; set; }
        public string AplicarDsctoPpag { get; set; }
        public string EsBancarizado { get; set; }
        public string CrearPolizas { get; set; }
        public string CuentaContable { get; set; }
        public string PregCuenta { get; set; }
        public string TipoPoliza { get; set; }
        public string DescripcionPoliza { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual ICollection<DoctosCp> DoctosCp { get; set; }
    }
}
