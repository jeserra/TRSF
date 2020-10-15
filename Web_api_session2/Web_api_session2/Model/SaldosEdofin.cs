using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class SaldosEdofin
    {
        public string TipoReg { get; set; }
        public string CuentaJt { get; set; }
        public int DeptoCoId { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Naturaleza { get; set; }
        public decimal? SaldoIniEjerPer1 { get; set; }
        public decimal? SaldoIniPer1 { get; set; }
        public decimal? MnetPer1 { get; set; }
        public decimal? SaldoIniEjerPer2 { get; set; }
        public decimal? SaldoIniPer2 { get; set; }
        public decimal? MnetPer2 { get; set; }
        public decimal? SaldoIniEjerPerh { get; set; }
        public decimal? SaldoIniPerh { get; set; }
        public decimal? MnetPerh { get; set; }
        public decimal? Mnet01 { get; set; }
        public decimal? Mnet02 { get; set; }
        public decimal? Mnet03 { get; set; }
        public decimal? Mnet04 { get; set; }
        public decimal? Mnet05 { get; set; }
        public decimal? Mnet06 { get; set; }
        public decimal? Mnet07 { get; set; }
        public decimal? Mnet08 { get; set; }
        public decimal? Mnet09 { get; set; }
        public decimal? Mnet10 { get; set; }
        public decimal? Mnet11 { get; set; }
        public decimal? Mnet12 { get; set; }

        public virtual DeptosCo DeptoCo { get; set; }
    }
}
