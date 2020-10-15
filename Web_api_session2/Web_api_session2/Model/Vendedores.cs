using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class Vendedores
    {
        public Vendedores()
        {
            Agentes = new HashSet<Agentes>();
            Clientes = new HashSet<Clientes>();
            DoctosPv = new HashSet<DoctosPv>();
            DoctosPvDet = new HashSet<DoctosPvDet>();
            DoctosVe = new HashSet<DoctosVe>();
        }

        public int VendedorId { get; set; }
        public string Nombre { get; set; }
        public int PoliticaComisVenId { get; set; }
        public string EsPredet { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual PoliticasComisionesVendedores PoliticaComisVen { get; set; }
        public virtual ICollection<Agentes> Agentes { get; set; }
        public virtual ICollection<Clientes> Clientes { get; set; }
        public virtual ICollection<DoctosPv> DoctosPv { get; set; }
        public virtual ICollection<DoctosPvDet> DoctosPvDet { get; set; }
        public virtual ICollection<DoctosVe> DoctosVe { get; set; }
    }
}
