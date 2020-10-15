using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class LibresEmpleados
    {
        public int EmpleadoId { get; set; }

        public virtual Empleados Empleado { get; set; }
    }
}
