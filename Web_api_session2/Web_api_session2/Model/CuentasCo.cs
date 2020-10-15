using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class CuentasCo
    {
        public CuentasCo()
        {
            ActivosFijosCuentaDepconDep = new HashSet<ActivosFijos>();
            ActivosFijosCuentaDepconGas = new HashSet<ActivosFijos>();
            ActivosFijosCuentaDepfisDep = new HashSet<ActivosFijos>();
            ActivosFijosCuentaDepfisGas = new HashSet<ActivosFijos>();
            DoctosCoDet = new HashSet<DoctosCoDet>();
            FormatosEdofinDet = new HashSet<FormatosEdofinDet>();
            InverseCuentaPadre = new HashSet<CuentasCo>();
            PlantillasPolCoDet = new HashSet<PlantillasPolCoDet>();
            Presupuestos = new HashSet<Presupuestos>();
            ProrrateosDetCuenta = new HashSet<ProrrateosDet>();
            ProrrateosDetCuentaDet = new HashSet<ProrrateosDet>();
            SaldosCo = new HashSet<SaldosCo>();
            TercerosCoCuentaCxc = new HashSet<TercerosCo>();
            TercerosCoCuentaCxcCuadre = new HashSet<TercerosCo>();
            TercerosCoCuentaCxp = new HashSet<TercerosCo>();
            TercerosCoCuentaCxpCuadre = new HashSet<TercerosCo>();
        }

        public int CuentaId { get; set; }
        public int CuentaPadreId { get; set; }
        public string CuentaPt { get; set; }
        public string CuentaJt { get; set; }
        public int Subcuenta { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Naturaleza { get; set; }
        public string CuentaFiscalPt { get; set; }
        public string CuentaFiscalJt { get; set; }
        public string Notas { get; set; }
        public string EsProrrateo { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual CuentasCo CuentaPadre { get; set; }
        public virtual CuentasCoDiot CuentasCoDiot { get; set; }
        public virtual LibresCuentasCo LibresCuentasCo { get; set; }
        public virtual ICollection<ActivosFijos> ActivosFijosCuentaDepconDep { get; set; }
        public virtual ICollection<ActivosFijos> ActivosFijosCuentaDepconGas { get; set; }
        public virtual ICollection<ActivosFijos> ActivosFijosCuentaDepfisDep { get; set; }
        public virtual ICollection<ActivosFijos> ActivosFijosCuentaDepfisGas { get; set; }
        public virtual ICollection<DoctosCoDet> DoctosCoDet { get; set; }
        public virtual ICollection<FormatosEdofinDet> FormatosEdofinDet { get; set; }
        public virtual ICollection<CuentasCo> InverseCuentaPadre { get; set; }
        public virtual ICollection<PlantillasPolCoDet> PlantillasPolCoDet { get; set; }
        public virtual ICollection<Presupuestos> Presupuestos { get; set; }
        public virtual ICollection<ProrrateosDet> ProrrateosDetCuenta { get; set; }
        public virtual ICollection<ProrrateosDet> ProrrateosDetCuentaDet { get; set; }
        public virtual ICollection<SaldosCo> SaldosCo { get; set; }
        public virtual ICollection<TercerosCo> TercerosCoCuentaCxc { get; set; }
        public virtual ICollection<TercerosCo> TercerosCoCuentaCxcCuadre { get; set; }
        public virtual ICollection<TercerosCo> TercerosCoCuentaCxp { get; set; }
        public virtual ICollection<TercerosCo> TercerosCoCuentaCxpCuadre { get; set; }
    }
}
