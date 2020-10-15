using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class LugaresExpedicion
    {
        public int LugarExpedicionId { get; set; }
        public string Nombre { get; set; }
        public string ZonaHoraria { get; set; }
        public string EsPpal { get; set; }
        public string Calle { get; set; }
        public string NombreCalle { get; set; }
        public string NumExterior { get; set; }
        public string NumInterior { get; set; }
        public string Colonia { get; set; }
        public string ColoniaClaveFiscal { get; set; }
        public string Poblacion { get; set; }
        public string PoblacionClaveFiscal { get; set; }
        public string Referencia { get; set; }
        public int? CiudadId { get; set; }
        public string CodigoPostal { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual Ciudades Ciudad { get; set; }
    }
}
