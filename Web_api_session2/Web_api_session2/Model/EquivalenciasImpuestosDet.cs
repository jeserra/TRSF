using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class EquivalenciasImpuestosDet
    {
        public int EquivImptosDetId { get; set; }
        public int EquivImptosId { get; set; }
        public int ImpuestoNuevoId { get; set; }
        public int? ImpuestoAnteriorId { get; set; }

        public virtual EquivalenciasImpuestos EquivImptos { get; set; }
        public virtual Impuestos ImpuestoAnterior { get; set; }
        public virtual Impuestos ImpuestoNuevo { get; set; }
    }
}
