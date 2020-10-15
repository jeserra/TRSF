using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DoctosCc
    {
        public DoctosCc()
        {
            DepositosCcDet = new HashSet<DepositosCcDet>();
            ImportesDoctosCcDoctoCc = new HashSet<ImportesDoctosCc>();
            ImportesDoctosCcDoctoCcAcr = new HashSet<ImportesDoctosCc>();
            ImportesDoctosPendCc = new HashSet<ImportesDoctosPendCc>();
            SubMovtosCcDoctoCc = new HashSet<SubMovtosCc>();
            SubMovtosCcSubMovto = new HashSet<SubMovtosCc>();
            UsosAnticiposCcDoctoCc = new HashSet<UsosAnticiposCc>();
            UsosAnticiposCcDoctoCcAcr = new HashSet<UsosAnticiposCc>();
            VencimientosCargosCc = new HashSet<VencimientosCargosCc>();
        }

        public int DoctoCcId { get; set; }
        public int ConceptoCcId { get; set; }
        public string Folio { get; set; }
        public string NaturalezaConcepto { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public string ClaveCliente { get; set; }
        public decimal? ImporteCobro { get; set; }
        public int ClienteId { get; set; }
        public decimal? TipoCambio { get; set; }
        public string Cancelado { get; set; }
        public string Aplicado { get; set; }
        public string Descripcion { get; set; }
        public int? LugarExpedicionId { get; set; }
        public string CuentaConcepto { get; set; }
        public int? CobradorId { get; set; }
        public string FormaEmitida { get; set; }
        public string Contabilizado { get; set; }
        public string ContabilizadoGyp { get; set; }
        public int? CondPagoId { get; set; }
        public DateTime? FechaDsctoPpag { get; set; }
        public decimal? PctjeDsctoPpag { get; set; }
        public string FacturaMostrador { get; set; }
        public string SistemaOrigen { get; set; }
        public string Estatus { get; set; }
        public string EstatusAnt { get; set; }
        public DateTime? FechaAplicacion { get; set; }
        public string EsCfd { get; set; }
        public string TieneAnticipo { get; set; }
        public string ModalidadFacturacion { get; set; }
        public string Enviado { get; set; }
        public DateTime? FechaHoraEnvio { get; set; }
        public string EmailEnvio { get; set; }
        public string CfdiCertificado { get; set; }
        public string UsoCfdi { get; set; }
        public string MetodoPagoSat { get; set; }
        public string IntegBa { get; set; }
        public string ContabilizadoBa { get; set; }
        public int? CuentaBanId { get; set; }
        public string ReferMovtoBancario { get; set; }
        public int? CfdiAsociadoId { get; set; }
        public string MetodoPagoCfdiAsociado { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }
        public string UsuarioCancelacion { get; set; }
        public DateTime? FechaHoraCancelacion { get; set; }
        public string UsuarioAutCancelacion { get; set; }

        public virtual RepositorioCfdi CfdiAsociado { get; set; }
        public virtual Clientes Cliente { get; set; }
        public virtual Cobradores Cobrador { get; set; }
        public virtual ConceptosCc ConceptoCc { get; set; }
        public virtual CondicionesPago CondPago { get; set; }
        public virtual CuentasBancarias CuentaBan { get; set; }
        public virtual DoctosCcInfoBan DoctosCcInfoBan { get; set; }
        public virtual LibresCargosCc LibresCargosCc { get; set; }
        public virtual LibresCreditosCc LibresCreditosCc { get; set; }
        public virtual ICollection<DepositosCcDet> DepositosCcDet { get; set; }
        public virtual ICollection<ImportesDoctosCc> ImportesDoctosCcDoctoCc { get; set; }
        public virtual ICollection<ImportesDoctosCc> ImportesDoctosCcDoctoCcAcr { get; set; }
        public virtual ICollection<ImportesDoctosPendCc> ImportesDoctosPendCc { get; set; }
        public virtual ICollection<SubMovtosCc> SubMovtosCcDoctoCc { get; set; }
        public virtual ICollection<SubMovtosCc> SubMovtosCcSubMovto { get; set; }
        public virtual ICollection<UsosAnticiposCc> UsosAnticiposCcDoctoCc { get; set; }
        public virtual ICollection<UsosAnticiposCc> UsosAnticiposCcDoctoCcAcr { get; set; }
        public virtual ICollection<VencimientosCargosCc> VencimientosCargosCc { get; set; }
    }
}
