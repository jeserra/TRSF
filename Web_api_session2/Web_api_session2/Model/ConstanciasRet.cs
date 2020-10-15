using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ConstanciasRet
    {
        public int ConstanciaRetId { get; set; }
        public string ClaveProv { get; set; }
        public int ProveedorId { get; set; }
        public string TipoConstancia { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }
        public TimeSpan Hora { get; set; }
        public int? LugarExpedicionId { get; set; }
        public decimal BaseGravable { get; set; }
        public decimal IvaRetenido { get; set; }
        public decimal IsrRetenido { get; set; }
        public string EsManual { get; set; }
        public string Cancelado { get; set; }
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

        public virtual Proveedores Proveedor { get; set; }
    }
}
