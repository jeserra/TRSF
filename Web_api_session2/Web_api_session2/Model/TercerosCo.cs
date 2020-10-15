using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class TercerosCo
    {
        public TercerosCo()
        {
            DoctosBaInfoBan = new HashSet<DoctosBaInfoBan>();
            DoctosCoDetDiot = new HashSet<DoctosCoDetDiot>();
            DoctosCoDetInfoBan = new HashSet<DoctosCoDetInfoBan>();
            SubcontratosEmp = new HashSet<SubcontratosEmp>();
        }

        public int TerceroCoId { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Rfc { get; set; }
        public string EsProveedor { get; set; }
        public int? CuentaCxpId { get; set; }
        public int? CuentaCxpDeptoId { get; set; }
        public int? CuentaCxpCuadreId { get; set; }
        public int? CuentaCxpCuadreDeptoId { get; set; }
        public int? TipoPolizaComprasId { get; set; }
        public string DescPolizaCompras { get; set; }
        public string TaxIdDiot { get; set; }
        public string PaisResidenciaDiot { get; set; }
        public string NacionalidadDiot { get; set; }
        public string OperacionPredetDiot { get; set; }
        public int? IvaPredetDiotId { get; set; }
        public string EsCliente { get; set; }
        public int? CuentaCxcId { get; set; }
        public int? CuentaCxcDeptoId { get; set; }
        public int? CuentaCxcCuadreId { get; set; }
        public int? CuentaCxcCuadreDeptoId { get; set; }
        public int? TipoPolizaVentasId { get; set; }
        public string DescPolizaVentas { get; set; }
        public string EsContratante { get; set; }
        public string UltCuentaBan { get; set; }
        public string UltBanco { get; set; }
        public string UltNomBancoExt { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual CuentasCo CuentaCxc { get; set; }
        public virtual CuentasCo CuentaCxcCuadre { get; set; }
        public virtual DeptosCo CuentaCxcCuadreDepto { get; set; }
        public virtual DeptosCo CuentaCxcDepto { get; set; }
        public virtual CuentasCo CuentaCxp { get; set; }
        public virtual CuentasCo CuentaCxpCuadre { get; set; }
        public virtual DeptosCo CuentaCxpCuadreDepto { get; set; }
        public virtual DeptosCo CuentaCxpDepto { get; set; }
        public virtual Impuestos IvaPredetDiot { get; set; }
        public virtual TiposPolizas TipoPolizaCompras { get; set; }
        public virtual TiposPolizas TipoPolizaVentas { get; set; }
        public virtual ICollection<DoctosBaInfoBan> DoctosBaInfoBan { get; set; }
        public virtual ICollection<DoctosCoDetDiot> DoctosCoDetDiot { get; set; }
        public virtual ICollection<DoctosCoDetInfoBan> DoctosCoDetInfoBan { get; set; }
        public virtual ICollection<SubcontratosEmp> SubcontratosEmp { get; set; }
    }
}
