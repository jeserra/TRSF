using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DoctosCmProeve
    {
        public int DoctoCmId { get; set; }
        public string Nombre { get; set; }
        public string Calle { get; set; }
        public string NombreCalle { get; set; }
        public string NumExterior { get; set; }
        public string NumInterior { get; set; }
        public string Colonia { get; set; }
        public string Poblacion { get; set; }
        public string Referencia { get; set; }
        public int CiudadId { get; set; }
        public int EstadoId { get; set; }
        public string CodigoPostal { get; set; }
        public int PaisId { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string RfcCurp { get; set; }
        public string Contacto { get; set; }

        public virtual Ciudades Ciudad { get; set; }
        public virtual DoctosCm DoctoCm { get; set; }
        public virtual Estados Estado { get; set; }
        public virtual Paises Pais { get; set; }
    }
}
