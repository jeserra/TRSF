using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ClavesEmpleados
    {
        public int ClaveEmpleadoId { get; set; }
        public string ClaveEmpleado { get; set; }
        public int EmpleadoId { get; set; }
        public int RolClaveEmpId { get; set; }

        public virtual Empleados Empleado { get; set; }
    }
}
