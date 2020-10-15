using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class RepositorioCfdi
    {
        public RepositorioCfdi()
        {
            CfdRecibidos = new HashSet<CfdRecibidos>();
            DoctosCc = new HashSet<DoctosCc>();
            DoctosCoCfdi = new HashSet<DoctosCoCfdi>();
            DoctosProcCancel = new HashSet<DoctosProcCancel>();
            DoctosVe = new HashSet<DoctosVe>();
            InverseCfdiSustituto = new HashSet<RepositorioCfdi>();
            PolizasCfdi = new HashSet<PolizasCfdi>();
            UsosFoliosFiscales = new HashSet<UsosFoliosFiscales>();
        }

        public int CfdiId { get; set; }
        public string ModalidadFacturacion { get; set; }
        public string Version { get; set; }
        public string Uuid { get; set; }
        public string Naturaleza { get; set; }
        public string TipoComprobante { get; set; }
        public string TipoDoctoMsp { get; set; }
        public string Folio { get; set; }
        public DateTime Fecha { get; set; }
        public string Rfc { get; set; }
        public string Taxid { get; set; }
        public string Nombre { get; set; }
        public decimal? Importe { get; set; }
        public string Moneda { get; set; }
        public decimal? TipoCambio { get; set; }
        public string EsParcialidad { get; set; }
        public string NomArch { get; set; }
        public string Xml { get; set; }
        public string ReferGrupo { get; set; }
        public DateTime? FechaCancelacion { get; set; }
        public string SelloValidado { get; set; }
        public string UsuarioValSello { get; set; }
        public int? CfdiSustitutoId { get; set; }
        public string EsSustituto { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual RepositorioCfdi CfdiSustituto { get; set; }
        public virtual ICollection<CfdRecibidos> CfdRecibidos { get; set; }
        public virtual ICollection<DoctosCc> DoctosCc { get; set; }
        public virtual ICollection<DoctosCoCfdi> DoctosCoCfdi { get; set; }
        public virtual ICollection<DoctosProcCancel> DoctosProcCancel { get; set; }
        public virtual ICollection<DoctosVe> DoctosVe { get; set; }
        public virtual ICollection<RepositorioCfdi> InverseCfdiSustituto { get; set; }
        public virtual ICollection<PolizasCfdi> PolizasCfdi { get; set; }
        public virtual ICollection<UsosFoliosFiscales> UsosFoliosFiscales { get; set; }
    }
}
