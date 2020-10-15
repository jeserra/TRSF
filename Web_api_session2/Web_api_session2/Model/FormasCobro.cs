using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class FormasCobro
    {
        public FormasCobro()
        {
            Cajas = new HashSet<Cajas>();
            DoctosPvCobros = new HashSet<DoctosPvCobros>();
            DoctosPvTranPendTc = new HashSet<DoctosPvTranPendTc>();
            FormasCobroDenom = new HashSet<FormasCobroDenom>();
            FormasCobroRefer = new HashSet<FormasCobroRefer>();
            MovtosCajasFondo = new HashSet<MovtosCajasFondo>();
            MovtosEfvoCaja = new HashSet<MovtosEfvoCaja>();
        }

        public int FormaCobroId { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public int MonedaId { get; set; }
        public string AutorizacionNecesaria { get; set; }
        public decimal? AutorizacionDesde { get; set; }
        public string CobrarEnExceso { get; set; }
        public string DarCambio { get; set; }
        public string AbrirCajon { get; set; }
        public string ContarEnCorte { get; set; }
        public string ClaveFiscal { get; set; }
        public string IdInterno { get; set; }
        public string CuentaContable { get; set; }
        public string AutorizacionTarjeta { get; set; }
        public string AfiliacionAtc { get; set; }
        public string AfiliacionAmexAtc { get; set; }
        public string UrlServicioAtc { get; set; }
        public string UserNameAtc { get; set; }
        public string UserPswAtc { get; set; }
        public string AutomAtc { get; set; }
        public short? NumMesesPromoAtc { get; set; }
        public string ListaMesesPromoAtc { get; set; }
        public string AlarmaExcesoEfectivo { get; set; }
        public decimal? LimiteEfectivo { get; set; }
        public string DetenerVentaExcesoEfectivo { get; set; }
        public string UsarDenominaciones { get; set; }
        public string OrdenDenominaciones { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual Monedas Moneda { get; set; }
        public virtual ICollection<Cajas> Cajas { get; set; }
        public virtual ICollection<DoctosPvCobros> DoctosPvCobros { get; set; }
        public virtual ICollection<DoctosPvTranPendTc> DoctosPvTranPendTc { get; set; }
        public virtual ICollection<FormasCobroDenom> FormasCobroDenom { get; set; }
        public virtual ICollection<FormasCobroRefer> FormasCobroRefer { get; set; }
        public virtual ICollection<MovtosCajasFondo> MovtosCajasFondo { get; set; }
        public virtual ICollection<MovtosEfvoCaja> MovtosEfvoCaja { get; set; }
    }
}
