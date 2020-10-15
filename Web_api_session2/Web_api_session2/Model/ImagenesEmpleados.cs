using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ImagenesEmpleados
    {
        public int ImagenEmpleadoId { get; set; }
        public int EmpleadoId { get; set; }
        public int RolImagenEmpId { get; set; }
        public string Imagen { get; set; }

        public virtual Empleados Empleado { get; set; }
    }
}
