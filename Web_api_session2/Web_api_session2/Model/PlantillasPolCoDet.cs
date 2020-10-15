using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class PlantillasPolCoDet
    {
        public int PlantillaPolCoDetId { get; set; }
        public int PlantillaPolCoId { get; set; }
        public string TipoAsiento { get; set; }
        public string TipoCuenta { get; set; }
        public int? CuentaId { get; set; }
        public int? DeptoCoId { get; set; }
        public string Refer { get; set; }
        public string Descripcion { get; set; }
        public string Formula { get; set; }
        public int? Posicion { get; set; }

        public virtual CuentasCo Cuenta { get; set; }
        public virtual DeptosCo DeptoCo { get; set; }
        public virtual PlantillasPolCo PlantillaPolCo { get; set; }
    }
}
