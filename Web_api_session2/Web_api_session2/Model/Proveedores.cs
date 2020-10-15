using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class Proveedores
    {
        public Proveedores()
        {
            ClavesProveedores = new HashSet<ClavesProveedores>();
            ConstanciasRet = new HashSet<ConstanciasRet>();
            DoctosCm = new HashSet<DoctosCm>();
            DoctosCp = new HashSet<DoctosCp>();
            ImagenesProveedores = new HashSet<ImagenesProveedores>();
            PoliticasDsctosPromoProv = new HashSet<PoliticasDsctosPromoProv>();
            PoliticasDsctosVolProv = new HashSet<PoliticasDsctosVolProv>();
            PoliticasPreciosProv = new HashSet<PoliticasPreciosProv>();
            PreciosCompra = new HashSet<PreciosCompra>();
            PreciosProv = new HashSet<PreciosProv>();
            SaldosCp = new HashSet<SaldosCp>();
        }

        public int ProveedorId { get; set; }
        public string Nombre { get; set; }
        public string Contacto1 { get; set; }
        public string Contacto2 { get; set; }
        public string Calle { get; set; }
        public string NombreCalle { get; set; }
        public string NumExterior { get; set; }
        public string NumInterior { get; set; }
        public string Colonia { get; set; }
        public string Poblacion { get; set; }
        public string Referencia { get; set; }
        public int? CiudadId { get; set; }
        public int? EstadoId { get; set; }
        public string CodigoPostal { get; set; }
        public int? PaisId { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string RfcCurp { get; set; }
        public string TaxId { get; set; }
        public int? ViaEmbarqueId { get; set; }
        public string Estatus { get; set; }
        public string CausaSusp { get; set; }
        public DateTime? FechaSusp { get; set; }
        public string CargaImpuestos { get; set; }
        public string RetenerImpuestos { get; set; }
        public string SujetoIeps { get; set; }
        public string Extranjero { get; set; }
        public decimal? LimiteCredito { get; set; }
        public int MonedaId { get; set; }
        public int CondPagoId { get; set; }
        public int? TipoProvId { get; set; }
        public string Notas { get; set; }
        public string CuentaCxp { get; set; }
        public string CuentaAnticipos { get; set; }
        public int? ConceptoBaId { get; set; }
        public string FormatosEmail { get; set; }
        public string ActividadPrincipal { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual Ciudades Ciudad { get; set; }
        public virtual ConceptosBa ConceptoBa { get; set; }
        public virtual CondicionesPagoCp CondPago { get; set; }
        public virtual Monedas Moneda { get; set; }
        public virtual TiposProv TipoProv { get; set; }
        public virtual ViasEmbarque ViaEmbarque { get; set; }
        public virtual CertCfdProv CertCfdProv { get; set; }
        public virtual LibresProveedor LibresProveedor { get; set; }
        public virtual ICollection<ClavesProveedores> ClavesProveedores { get; set; }
        public virtual ICollection<ConstanciasRet> ConstanciasRet { get; set; }
        public virtual ICollection<DoctosCm> DoctosCm { get; set; }
        public virtual ICollection<DoctosCp> DoctosCp { get; set; }
        public virtual ICollection<ImagenesProveedores> ImagenesProveedores { get; set; }
        public virtual ICollection<PoliticasDsctosPromoProv> PoliticasDsctosPromoProv { get; set; }
        public virtual ICollection<PoliticasDsctosVolProv> PoliticasDsctosVolProv { get; set; }
        public virtual ICollection<PoliticasPreciosProv> PoliticasPreciosProv { get; set; }
        public virtual ICollection<PreciosCompra> PreciosCompra { get; set; }
        public virtual ICollection<PreciosProv> PreciosProv { get; set; }
        public virtual ICollection<SaldosCp> SaldosCp { get; set; }
    }
}
