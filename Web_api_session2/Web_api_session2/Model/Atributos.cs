using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class Atributos
    {
        public Atributos()
        {
            ListasAtributos = new HashSet<ListasAtributos>();
        }

        public int AtributoId { get; set; }
        public string Nombre { get; set; }
        public string NombreColumna { get; set; }
        public string ClaveObjeto { get; set; }
        public short Posicion { get; set; }
        public string Tipo { get; set; }
        public short? Longitud { get; set; }
        public short? Escala { get; set; }
        public decimal? ValorMinimo { get; set; }
        public decimal? ValorMaximo { get; set; }
        public decimal? ValorDefaultNumerico { get; set; }
        public string ValorDefaultCaracter { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<ListasAtributos> ListasAtributos { get; set; }
    }
}
