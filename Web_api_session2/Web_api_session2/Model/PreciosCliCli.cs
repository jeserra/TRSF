using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class PreciosCliCli
    {
        public int PrecioCliCliId { get; set; }
        public int PoliticaPreciosCliId { get; set; }
        public string ClaveCliente { get; set; }
        public int ClienteId { get; set; }
        public int PrecioEmpresaId { get; set; }
        public int PoliticaDsctoArtCliId { get; set; }

        public virtual Clientes Cliente { get; set; }
        public virtual PoliticasDsctosArtCli PoliticaDsctoArtCli { get; set; }
        public virtual PoliticasPreciosClientes PoliticaPreciosCli { get; set; }
        public virtual PreciosEmpresa PrecioEmpresa { get; set; }
    }
}
