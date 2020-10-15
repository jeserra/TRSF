using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ConceptosCc
    {
        public ConceptosCc()
        {
            CargosPeriodicosCc = new HashSet<CargosPeriodicosCc>();
            DoctosCc = new HashSet<DoctosCc>();
            DoctosPendCc = new HashSet<DoctosPendCc>();
            ImportesDoctosPendCc = new HashSet<ImportesDoctosPendCc>();
        }

        public int ConceptoCcId { get; set; }
        public string Nombre { get; set; }
        public string NombreAbrev { get; set; }
        public string Naturaleza { get; set; }
        public string ModalidadFacturacion { get; set; }
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
        public string IntegrarComis { get; set; }
        public string AplicarDsctoPpag { get; set; }
        public string AplicarInteresMor { get; set; }
        public string CrearPolizas { get; set; }
        public string CuentaContable { get; set; }
        public string PregCuenta { get; set; }
        public string TipoPoliza { get; set; }
        public string DescripcionPoliza { get; set; }
        public string ClaveProdservSat { get; set; }
        public string NumCtaPredial { get; set; }
        public string DescripcionInmueble { get; set; }
        public string DescConcepXml { get; set; }
        public string ClaveUmedSat { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual ICollection<CargosPeriodicosCc> CargosPeriodicosCc { get; set; }
        public virtual ICollection<DoctosCc> DoctosCc { get; set; }
        public virtual ICollection<DoctosPendCc> DoctosPendCc { get; set; }
        public virtual ICollection<ImportesDoctosPendCc> ImportesDoctosPendCc { get; set; }
    }
}
