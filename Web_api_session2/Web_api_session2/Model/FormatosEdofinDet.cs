using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class FormatosEdofinDet
    {
        public int FormatoEdofinDetId { get; set; }
        public int FormatoEdofinId { get; set; }
        public string Comando { get; set; }
        public int Nivel { get; set; }
        public int Columna { get; set; }
        public string Letrero { get; set; }
        public string Notas { get; set; }
        public string CuentaPtIni { get; set; }
        public string CuentaPtFin { get; set; }
        public string CuentaJtIni { get; set; }
        public string CuentaJtFin { get; set; }
        public string Impacum { get; set; }
        public string Naturaleza { get; set; }
        public string EstiloFuenteLet { get; set; }
        public string SubrayarLet { get; set; }
        public string EstiloFuenteImptes { get; set; }
        public string SubrayarImptes { get; set; }
        public int Posicion { get; set; }
        public int? CuentaId { get; set; }
        public int? GrupoCuentasId { get; set; }

        public virtual CuentasCo Cuenta { get; set; }
        public virtual FormatosEdofin FormatoEdofin { get; set; }
        public virtual GruposCuentas GrupoCuentas { get; set; }
    }
}
