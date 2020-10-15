using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DoctosTr
    {
        public DoctosTr()
        {
            DoctosTrDet = new HashSet<DoctosTrDet>();
        }

        public int DoctoTrId { get; set; }
        public string Folio { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public string ClaveCliente { get; set; }
        public int? ClienteId { get; set; }
        public int? DirCliId { get; set; }
        public int? LugarExpedicionId { get; set; }
        public string ClaveSis { get; set; }
        public int? DoctoOrigenId { get; set; }
        public string Cancelado { get; set; }
        public string Descripcion { get; set; }
        public string FormaEmitida { get; set; }
        public string Enviado { get; set; }
        public DateTime? FechaHoraEnvio { get; set; }
        public string EmailEnvio { get; set; }
        public string CfdiCertificado { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }
        public string UsuarioCancelacion { get; set; }
        public DateTime? FechaHoraCancelacion { get; set; }
        public string UsuarioAutCancelacion { get; set; }

        public virtual Clientes Cliente { get; set; }
        public virtual DirsClientes DirCli { get; set; }
        public virtual ICollection<DoctosTrDet> DoctosTrDet { get; set; }
    }
}
