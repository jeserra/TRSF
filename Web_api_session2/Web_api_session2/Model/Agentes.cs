using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class Agentes
    {
        public Agentes()
        {
            PlanesVisitas = new HashSet<PlanesVisitas>();
            Rutas = new HashSet<Rutas>();
            Visitas = new HashSet<Visitas>();
        }

        public int AgenteId { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public string Usuario { get; set; }
        public string RegistraPedidos { get; set; }
        public string RegistraCobros { get; set; }
        public int? AlmacenId { get; set; }
        public int? VendedorId { get; set; }
        public int? CobradorId { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioAutModif { get; set; }
        public int? VersionRegistro { get; set; }

        public virtual Almacenes Almacen { get; set; }
        public virtual Cobradores Cobrador { get; set; }
        public virtual Vendedores Vendedor { get; set; }
        public virtual ICollection<PlanesVisitas> PlanesVisitas { get; set; }
        public virtual ICollection<Rutas> Rutas { get; set; }
        public virtual ICollection<Visitas> Visitas { get; set; }
    }
}
