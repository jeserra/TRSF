using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class RegPatronales
    {
        public RegPatronales()
        {
            Empleados = new HashSet<Empleados>();
            ExcepGenerales = new HashSet<ExcepGenerales>();
            IncidenciasNuevoRegPatronal = new HashSet<Incidencias>();
            IncidenciasRegPatronal = new HashSet<Incidencias>();
        }

        public int RegPatronalId { get; set; }
        public string NumRegPatronal { get; set; }
        public string Descripcion { get; set; }
        public string ClaseRiesgoSat { get; set; }
        public decimal PrimaRiesgo { get; set; }
        public string NumGuia { get; set; }
        public int? CiudadId { get; set; }
        public int? TipoIsnId { get; set; }

        public virtual Ciudades Ciudad { get; set; }
        public virtual TiposIsn TipoIsn { get; set; }
        public virtual ICollection<Empleados> Empleados { get; set; }
        public virtual ICollection<ExcepGenerales> ExcepGenerales { get; set; }
        public virtual ICollection<Incidencias> IncidenciasNuevoRegPatronal { get; set; }
        public virtual ICollection<Incidencias> IncidenciasRegPatronal { get; set; }
    }
}
