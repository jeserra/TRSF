using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ArticulosClientes
    {
        public int ArtCliId { get; set; }
        public string ClaveArticulo { get; set; }
        public int ArticuloId { get; set; }
        public int ClienteId { get; set; }
        public string ClaveArtCli { get; set; }
        public string CamposAddenda { get; set; }

        public virtual Articulos Articulo { get; set; }
        public virtual Clientes Cliente { get; set; }
    }
}
