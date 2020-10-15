using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class PagosNomina
    {
        public PagosNomina()
        {
            PagosNominaDet = new HashSet<PagosNominaDet>();
            PagosNominaVac = new HashSet<PagosNominaVac>();
        }

        public int PagoNominaId { get; set; }
        public int NominaId { get; set; }
        public int EmpleadoId { get; set; }
        public int? PuestoNoId { get; set; }
        public int? DeptoNoId { get; set; }
        public decimal Jornada { get; set; }
        public string TipoSalario { get; set; }
        public decimal? SalarioInteg { get; set; }
        public decimal DiasTrab { get; set; }
        public decimal HorasTrab { get; set; }
        public decimal DiasVac { get; set; }
        public decimal DiasCot { get; set; }
        public string Faltas { get; set; }
        public decimal FaltasDec { get; set; }
        public int DiasAusImss { get; set; }
        public int DiasIncap { get; set; }
        public string HorasExt { get; set; }
        public decimal HorasExtDec { get; set; }
        public decimal HorasExtExced { get; set; }
        public decimal? ImporteHorasExtExced { get; set; }
        public string HorasEsp { get; set; }
        public decimal HorasEspDec { get; set; }
        public decimal? SbcSmdf { get; set; }
        public decimal? SbcExced { get; set; }
        public decimal? SbcDin { get; set; }
        public decimal? SbcIvCv { get; set; }
        public decimal? SbcRetiro { get; set; }
        public decimal? SbcRiesgo { get; set; }
        public decimal? SbcInfon { get; set; }
        public decimal? TotalPercep { get; set; }
        public decimal? TotalReten { get; set; }
        public decimal? TotalPercepEspecie { get; set; }
        public decimal? TotalRetenDeduc { get; set; }
        public decimal? TotalPercepGrav { get; set; }
        public decimal? TotalPercepExen { get; set; }
        public decimal? TotalPercepNoAcum { get; set; }
        public decimal? TotalTipoA { get; set; }
        public decimal? TotalTipoB { get; set; }
        public decimal? TotalTipoC { get; set; }
        public decimal? TotalOtrosPagos { get; set; }
        public decimal? TotalOtrosPagosInfo { get; set; }
        public decimal? BasePtu { get; set; }
        public decimal? BaseImptoEstatal { get; set; }
        public decimal? CasAplicado { get; set; }
        public DateTime Fecha { get; set; }
        public string TipoNom { get; set; }
        public string FormaPago { get; set; }
        public string TipoPago { get; set; }
        public string Aplicado { get; set; }
        public string Enviado { get; set; }
        public string FormaEmitida { get; set; }
        public DateTime? FechaHoraEnvio { get; set; }
        public string EmailEnvio { get; set; }
        public string CfdiCertificado { get; set; }
        public string IntegBa { get; set; }
        public string ContabilizadoBa { get; set; }
        public int? CuentaBanId { get; set; }
        public string NumCheque { get; set; }
        public string PagoElectGenerado { get; set; }
        public string NumCtabanPagoElect { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual CuentasBancarias CuentaBan { get; set; }
        public virtual DeptosNo DeptoNo { get; set; }
        public virtual Empleados Empleado { get; set; }
        public virtual Nominas Nomina { get; set; }
        public virtual PuestosNo PuestoNo { get; set; }
        public virtual ICollection<PagosNominaDet> PagosNominaDet { get; set; }
        public virtual ICollection<PagosNominaVac> PagosNominaVac { get; set; }
    }
}
