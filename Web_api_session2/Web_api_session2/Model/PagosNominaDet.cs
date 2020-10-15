using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class PagosNominaDet
    {
        public int PagoNominaDetId { get; set; }
        public int PagoNominaId { get; set; }
        public int ConceptoNoId { get; set; }
        public decimal Cuota { get; set; }
        public decimal AhorroEmpresa { get; set; }
        public int? PrestamoEmpId { get; set; }
        public decimal? Unidades { get; set; }
        public decimal? Importe { get; set; }
        public decimal? ImporteGravable { get; set; }
        public decimal? ImporteExento { get; set; }
        public short? TipoOtrosPagosSat { get; set; }
        public decimal? ImporteAhorroEmpresa { get; set; }
        public string Acumulable { get; set; }
        public int EmpleadoId { get; set; }
        public DateTime Fecha { get; set; }
        public string Aplicado { get; set; }

        public virtual Empleados Empleado { get; set; }
        public virtual PagosNomina PagoNomina { get; set; }
        public virtual PrestamosEmp PrestamoEmp { get; set; }
    }
}
