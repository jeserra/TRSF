using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class Ciudades
    {
        public Ciudades()
        {
            Aduanas = new HashSet<Aduanas>();
            Almacenes = new HashSet<Almacenes>();
            DirsClientes = new HashSet<DirsClientes>();
            DoctosCmProeve = new HashSet<DoctosCmProeve>();
            EmpleadosCiudad = new HashSet<Empleados>();
            EmpleadosCiudadNacimiento = new HashSet<Empleados>();
            LugaresExpedicion = new HashSet<LugaresExpedicion>();
            Proveedores = new HashSet<Proveedores>();
            RegPatronales = new HashSet<RegPatronales>();
        }

        public int CiudadId { get; set; }
        public string Nombre { get; set; }
        public string ClaveFiscal { get; set; }
        public string EsPredet { get; set; }
        public int EstadoId { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual Estados Estado { get; set; }
        public virtual ICollection<Aduanas> Aduanas { get; set; }
        public virtual ICollection<Almacenes> Almacenes { get; set; }
        public virtual ICollection<DirsClientes> DirsClientes { get; set; }
        public virtual ICollection<DoctosCmProeve> DoctosCmProeve { get; set; }
        public virtual ICollection<Empleados> EmpleadosCiudad { get; set; }
        public virtual ICollection<Empleados> EmpleadosCiudadNacimiento { get; set; }
        public virtual ICollection<LugaresExpedicion> LugaresExpedicion { get; set; }
        public virtual ICollection<Proveedores> Proveedores { get; set; }
        public virtual ICollection<RegPatronales> RegPatronales { get; set; }
    }
}
