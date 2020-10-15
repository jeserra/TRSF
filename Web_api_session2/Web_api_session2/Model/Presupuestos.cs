using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class Presupuestos
    {
        public int PptoId { get; set; }
        public int Ejer { get; set; }
        public int CuentaId { get; set; }
        public int DeptoCoId { get; set; }
        public decimal? Ppto01 { get; set; }
        public decimal? Ppto02 { get; set; }
        public decimal? Ppto03 { get; set; }
        public decimal? Ppto04 { get; set; }
        public decimal? Ppto05 { get; set; }
        public decimal? Ppto06 { get; set; }
        public decimal? Ppto07 { get; set; }
        public decimal? Ppto08 { get; set; }
        public decimal? Ppto09 { get; set; }
        public decimal? Ppto10 { get; set; }
        public decimal? Ppto11 { get; set; }
        public decimal? Ppto12 { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual CuentasCo Cuenta { get; set; }
        public virtual DeptosCo DeptoCo { get; set; }
    }
}
