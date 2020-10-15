using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class FrecuenciasPago
    {
        public FrecuenciasPago()
        {
            Empleados = new HashSet<Empleados>();
            Nominas = new HashSet<Nominas>();
            PagosNominaCancelados = new HashSet<PagosNominaCancelados>();
        }

        public int FrepagId { get; set; }
        public string Nombre { get; set; }
        public decimal DiasPeriodo { get; set; }
        public decimal DiasACot { get; set; }
        public string TipoPago { get; set; }
        public decimal HorasPeriodo { get; set; }
        public string PeriodicidadSat { get; set; }
        public string TipoProceso { get; set; }
        public string SeptimoDia { get; set; }
        public decimal DiasNetos { get; set; }
        public string DesglSeptimo { get; set; }
        public string IncapSeptimo { get; set; }
        public string TarifaIsr { get; set; }
        public decimal PeriodoTablaIsr { get; set; }
        public string HacerAjuste { get; set; }
        public string HacerDevol { get; set; }
        public string CalcIsr { get; set; }
        public string CalcImss { get; set; }
        public string CuentaPagosEfectivo { get; set; }
        public string CuentaPagosTrans { get; set; }
        public string CuentaPagosEspecie { get; set; }
        public string TipoPoliza { get; set; }
        public string DescripcionPoliza { get; set; }
        public string EsPredet { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual ICollection<Empleados> Empleados { get; set; }
        public virtual ICollection<Nominas> Nominas { get; set; }
        public virtual ICollection<PagosNominaCancelados> PagosNominaCancelados { get; set; }
    }
}
