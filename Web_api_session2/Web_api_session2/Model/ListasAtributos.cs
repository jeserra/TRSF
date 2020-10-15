using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ListasAtributos
    {
        public int ListaAtribId { get; set; }
        public int AtributoId { get; set; }
        public string ValorDesplegado { get; set; }
        public short? Posicion { get; set; }

        public virtual Atributos Atributo { get; set; }
    }
}
