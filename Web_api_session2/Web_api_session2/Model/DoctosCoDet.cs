using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DoctosCoDet
    {
        public DoctosCoDet()
        {
            DoctosCoDetCfdi = new HashSet<DoctosCoDetCfdi>();
            DoctosCoDetInfoBan = new HashSet<DoctosCoDetInfoBan>();
        }

        public int DoctoCoDetId { get; set; }
        public int DoctoCoId { get; set; }
        public int? CuentaId { get; set; }
        public int DeptoCoId { get; set; }
        public string TipoAsiento { get; set; }
        public decimal? Importe { get; set; }
        public decimal? ImporteMn { get; set; }
        public string Refer { get; set; }
        public string Descripcion { get; set; }
        public int Posicion { get; set; }
        public int? RecordatorioId { get; set; }
        public DateTime Fecha { get; set; }
        public string Cancelado { get; set; }
        public string Aplicado { get; set; }
        public string Ajuste { get; set; }
        public int MonedaId { get; set; }

        public virtual CuentasCo Cuenta { get; set; }
        public virtual DeptosCo DeptoCo { get; set; }
        public virtual DoctosCo DoctoCo { get; set; }
        public virtual Monedas Moneda { get; set; }
        public virtual Recordatorios Recordatorio { get; set; }
        public virtual DoctosCoDetDiot DoctosCoDetDiot { get; set; }
        public virtual ICollection<DoctosCoDetCfdi> DoctosCoDetCfdi { get; set; }
        public virtual ICollection<DoctosCoDetInfoBan> DoctosCoDetInfoBan { get; set; }
    }
}
