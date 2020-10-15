using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class FormasCobroRefer
    {
        public FormasCobroRefer()
        {
            DoctosPvCobrosRefer = new HashSet<DoctosPvCobrosRefer>();
        }

        public int FormaCobroReferId { get; set; }
        public int FormaCobroId { get; set; }
        public string Nombre { get; set; }
        public string Requerida { get; set; }
        public string ImprimirEnTickets { get; set; }
        public string ImprimirEnReportes { get; set; }
        public short Posicion { get; set; }
        public string Habilitada { get; set; }
        public string IdInterno { get; set; }

        public virtual FormasCobro FormaCobro { get; set; }
        public virtual ICollection<DoctosPvCobrosRefer> DoctosPvCobrosRefer { get; set; }
    }
}
