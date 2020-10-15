using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ExcepGenerales
    {
        public int ExcepGralId { get; set; }
        public int NominaId { get; set; }
        public int ConceptoNoId { get; set; }
        public string Tipo { get; set; }
        public decimal Cuota { get; set; }
        public decimal AhorroEmpresa { get; set; }
        public string UnDepto { get; set; }
        public int? DeptoNoId { get; set; }
        public string UnRegPatronal { get; set; }
        public string UnPuesto { get; set; }
        public int? PuestoNoId { get; set; }
        public int? RegPatronalId { get; set; }
        public string AplicarExcepIndiv { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual DeptosNo DeptoNo { get; set; }
        public virtual Nominas Nomina { get; set; }
        public virtual PuestosNo PuestoNo { get; set; }
        public virtual RegPatronales RegPatronal { get; set; }
    }
}
