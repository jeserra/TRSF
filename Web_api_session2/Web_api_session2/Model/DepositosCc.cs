using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DepositosCc
    {
        public DepositosCc()
        {
            DepositosCcDet = new HashSet<DepositosCcDet>();
        }

        public int DepositoCcId { get; set; }
        public DateTime Fecha { get; set; }
        public int FormaCobroCcId { get; set; }
        public int CuentaBanId { get; set; }
        public string ReferMovtoBancario { get; set; }
        public string Descripcion { get; set; }
        public decimal? Importe { get; set; }
        public decimal? TipoCambio { get; set; }
        public string Aplicado { get; set; }
        public string Estatus { get; set; }
        public string FormaEmitida { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }
        public string UsuarioCancelacion { get; set; }
        public DateTime? FechaHoraCancelacion { get; set; }
        public string UsuarioAutCancelacion { get; set; }

        public virtual CuentasBancarias CuentaBan { get; set; }
        public virtual FormasCobroCc FormaCobroCc { get; set; }
        public virtual ICollection<DepositosCcDet> DepositosCcDet { get; set; }
    }
}
