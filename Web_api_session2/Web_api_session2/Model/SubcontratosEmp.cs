using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class SubcontratosEmp
    {
        public int SubcontratoEmpId { get; set; }
        public int EmpleadoId { get; set; }
        public int TerceroCoId { get; set; }
        public decimal PorcentajeTiempo { get; set; }

        public virtual Empleados Empleado { get; set; }
        public virtual TercerosCo TerceroCo { get; set; }
    }
}
