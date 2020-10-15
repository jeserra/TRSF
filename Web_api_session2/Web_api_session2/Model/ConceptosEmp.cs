using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ConceptosEmp
    {
        public int ConcepEmpId { get; set; }
        public int EmpleadoId { get; set; }
        public int ConceptoNoId { get; set; }
        public decimal Cuota { get; set; }
        public decimal AhorroEmpresa { get; set; }
        public string Vigencia { get; set; }
        public DateTime? FechaIniVigencia { get; set; }
        public DateTime? FechaFinVigencia { get; set; }
        public string Suspendido { get; set; }
        public string CuentaContable { get; set; }

        public virtual Empleados Empleado { get; set; }
    }
}
