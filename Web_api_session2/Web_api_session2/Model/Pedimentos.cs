using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class Pedimentos
    {
        public Pedimentos()
        {
            CapasPedimentos = new HashSet<CapasPedimentos>();
            DesgloseEnPedimentos = new HashSet<DesgloseEnPedimentos>();
            DoctosCm = new HashSet<DoctosCm>();
        }

        public int PedimentoId { get; set; }
        public string Clave { get; set; }
        public DateTime? Fecha { get; set; }
        public string Aduana { get; set; }
        public int? AduanaId { get; set; }

        public virtual Aduanas AduanaNavigation { get; set; }
        public virtual ICollection<CapasPedimentos> CapasPedimentos { get; set; }
        public virtual ICollection<DesgloseEnPedimentos> DesgloseEnPedimentos { get; set; }
        public virtual ICollection<DoctosCm> DoctosCm { get; set; }
    }
}
