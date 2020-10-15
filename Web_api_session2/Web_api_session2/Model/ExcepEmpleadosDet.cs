using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ExcepEmpleadosDet
    {
        public int ExcepEmpDetId { get; set; }
        public int ExcepEmpId { get; set; }
        public int ConceptoNoId { get; set; }
        public decimal Cuota { get; set; }
        public decimal? SubemCausado { get; set; }
        public decimal AhorroEmpresa { get; set; }
        public string Activo { get; set; }
        public string EsPeriodico { get; set; }
        public int? PrestamoEmpId { get; set; }
        public string IdInterno { get; set; }

        public virtual ExcepEmpleados ExcepEmp { get; set; }
        public virtual PrestamosEmp PrestamoEmp { get; set; }
    }
}
