using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class Nominas
    {
        public Nominas()
        {
            ExcepEmpleados = new HashSet<ExcepEmpleados>();
            ExcepGenerales = new HashSet<ExcepGenerales>();
            PagosNomina = new HashSet<PagosNomina>();
        }

        public int NominaId { get; set; }
        public int FrepagId { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaPago { get; set; }
        public DateTime FechaInicial { get; set; }
        public string TipoNom { get; set; }
        public string SuspenderConrep { get; set; }
        public decimal DiasPeriodo { get; set; }
        public string SoloSalarioFinal { get; set; }
        public decimal DiasACot { get; set; }
        public string TipoPago { get; set; }
        public decimal HorasPeriodo { get; set; }
        public string TipoProceso { get; set; }
        public int? ConceptoAguiId { get; set; }
        public string MetodoAgui { get; set; }
        public string FaltasAgui { get; set; }
        public int? ConceptoPtuId { get; set; }
        public decimal? ImporteRepartoPtu { get; set; }
        public decimal? PctjeIngresosPtu { get; set; }
        public short? DiasTrabMinPtu { get; set; }
        public decimal? IngresoMaxPtu { get; set; }
        public int? ConceptoPmavacId { get; set; }
        public int? ConceptoIndemId { get; set; }
        public int? ConceptoPmaantId { get; set; }
        public string Aplicado { get; set; }
        public string Contabilizado { get; set; }
        public string IntegBa { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual FrecuenciasPago Frepag { get; set; }
        public virtual ICollection<ExcepEmpleados> ExcepEmpleados { get; set; }
        public virtual ICollection<ExcepGenerales> ExcepGenerales { get; set; }
        public virtual ICollection<PagosNomina> PagosNomina { get; set; }
    }
}
