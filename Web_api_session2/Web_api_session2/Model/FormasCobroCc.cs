using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class FormasCobroCc
    {
        public FormasCobroCc()
        {
            DepositosCc = new HashSet<DepositosCc>();
        }

        public int FormaCobroCcId { get; set; }
        public string Nombre { get; set; }
        public int MonedaId { get; set; }
        public int DiasTransito { get; set; }
        public string ManejoRefer { get; set; }
        public string ReferObligatoria { get; set; }
        public string ClaveFiscal { get; set; }
        public string EsPredet { get; set; }
        public string RegistraInfoBan { get; set; }
        public int? ConceptoBaId { get; set; }
        public string DescripcionMovtoBa { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual ConceptosBa ConceptoBa { get; set; }
        public virtual Monedas Moneda { get; set; }
        public virtual ICollection<DepositosCc> DepositosCc { get; set; }
    }
}
