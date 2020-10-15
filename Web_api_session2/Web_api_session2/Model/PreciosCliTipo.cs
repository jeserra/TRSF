using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class PreciosCliTipo
    {
        public int PrecioCliTipoId { get; set; }
        public int PoliticaPreciosCliId { get; set; }
        public int TipoClienteId { get; set; }
        public int PrecioEmpresaId { get; set; }
        public int PoliticaDsctoArtCliId { get; set; }

        public virtual PoliticasDsctosArtCli PoliticaDsctoArtCli { get; set; }
        public virtual PoliticasPreciosClientes PoliticaPreciosCli { get; set; }
        public virtual PreciosEmpresa PrecioEmpresa { get; set; }
        public virtual TiposClientes TipoCliente { get; set; }
    }
}
