using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class Almacenes
    {
        public Almacenes()
        {
            Agentes = new HashSet<Agentes>();
            Cajas = new HashSet<Cajas>();
            CapasCostos = new HashSet<CapasCostos>();
            CapasPedimentos = new HashSet<CapasPedimentos>();
            CompromArticulos = new HashSet<CompromArticulos>();
            DoctosCm = new HashSet<DoctosCm>();
            DoctosInAlmacen = new HashSet<DoctosIn>();
            DoctosInAlmacenDestino = new HashSet<DoctosIn>();
            DoctosInDet = new HashSet<DoctosInDet>();
            DoctosInvfis = new HashSet<DoctosInvfis>();
            DoctosPvAlmacen = new HashSet<DoctosPv>();
            DoctosPvAlmacenIdFacGlobalNavigation = new HashSet<DoctosPv>();
            DoctosVe = new HashSet<DoctosVe>();
            ExisDiscretos = new HashSet<ExisDiscretos>();
            NivelesArticulos = new HashSet<NivelesArticulos>();
            SaldosIn = new HashSet<SaldosIn>();
        }

        public int AlmacenId { get; set; }
        public string Nombre { get; set; }
        public string NombreAbrev { get; set; }
        public string EsPpal { get; set; }
        public string EsPredet { get; set; }
        public string Calle { get; set; }
        public string NombreCalle { get; set; }
        public string NumExterior { get; set; }
        public string NumInterior { get; set; }
        public string Colonia { get; set; }
        public string Poblacion { get; set; }
        public string Referencia { get; set; }
        public int? CiudadId { get; set; }
        public string CodigoPostal { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string CuentaAlmacen { get; set; }
        public string CuentaCostoVenta { get; set; }
        public string CuentaVentas { get; set; }
        public string CuentaDevolVentas { get; set; }
        public string CuentaCompras { get; set; }
        public string CuentaDevolCompras { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }

        public virtual Ciudades CiudadNavigation { get; set; }
        public virtual ICollection<Agentes> Agentes { get; set; }
        public virtual ICollection<Cajas> Cajas { get; set; }
        public virtual ICollection<CapasCostos> CapasCostos { get; set; }
        public virtual ICollection<CapasPedimentos> CapasPedimentos { get; set; }
        public virtual ICollection<CompromArticulos> CompromArticulos { get; set; }
        public virtual ICollection<DoctosCm> DoctosCm { get; set; }
        public virtual ICollection<DoctosIn> DoctosInAlmacen { get; set; }
        public virtual ICollection<DoctosIn> DoctosInAlmacenDestino { get; set; }
        public virtual ICollection<DoctosInDet> DoctosInDet { get; set; }
        public virtual ICollection<DoctosInvfis> DoctosInvfis { get; set; }
        public virtual ICollection<DoctosPv> DoctosPvAlmacen { get; set; }
        public virtual ICollection<DoctosPv> DoctosPvAlmacenIdFacGlobalNavigation { get; set; }
        public virtual ICollection<DoctosVe> DoctosVe { get; set; }
        public virtual ICollection<ExisDiscretos> ExisDiscretos { get; set; }
        public virtual ICollection<NivelesArticulos> NivelesArticulos { get; set; }
        public virtual ICollection<SaldosIn> SaldosIn { get; set; }
    }
}
