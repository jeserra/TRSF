using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DeptosCo
    {
        public DeptosCo()
        {
            ActivosFijosDeptoDepconDep = new HashSet<ActivosFijos>();
            ActivosFijosDeptoDepconGas = new HashSet<ActivosFijos>();
            ActivosFijosDeptoDepfisDep = new HashSet<ActivosFijos>();
            ActivosFijosDeptoDepfisGas = new HashSet<ActivosFijos>();
            DoctosCoDet = new HashSet<DoctosCoDet>();
            EspecsEdofin = new HashSet<EspecsEdofin>();
            PlantillasPolCoDet = new HashSet<PlantillasPolCoDet>();
            Presupuestos = new HashSet<Presupuestos>();
            ProrrateosDet = new HashSet<ProrrateosDet>();
            SaldosCo = new HashSet<SaldosCo>();
            SaldosEdofin = new HashSet<SaldosEdofin>();
            TercerosCoCuentaCxcCuadreDepto = new HashSet<TercerosCo>();
            TercerosCoCuentaCxcDepto = new HashSet<TercerosCo>();
            TercerosCoCuentaCxpCuadreDepto = new HashSet<TercerosCo>();
            TercerosCoCuentaCxpDepto = new HashSet<TercerosCo>();
        }

        public int DeptoCoId { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public string EsPredet { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual ICollection<ActivosFijos> ActivosFijosDeptoDepconDep { get; set; }
        public virtual ICollection<ActivosFijos> ActivosFijosDeptoDepconGas { get; set; }
        public virtual ICollection<ActivosFijos> ActivosFijosDeptoDepfisDep { get; set; }
        public virtual ICollection<ActivosFijos> ActivosFijosDeptoDepfisGas { get; set; }
        public virtual ICollection<DoctosCoDet> DoctosCoDet { get; set; }
        public virtual ICollection<EspecsEdofin> EspecsEdofin { get; set; }
        public virtual ICollection<PlantillasPolCoDet> PlantillasPolCoDet { get; set; }
        public virtual ICollection<Presupuestos> Presupuestos { get; set; }
        public virtual ICollection<ProrrateosDet> ProrrateosDet { get; set; }
        public virtual ICollection<SaldosCo> SaldosCo { get; set; }
        public virtual ICollection<SaldosEdofin> SaldosEdofin { get; set; }
        public virtual ICollection<TercerosCo> TercerosCoCuentaCxcCuadreDepto { get; set; }
        public virtual ICollection<TercerosCo> TercerosCoCuentaCxcDepto { get; set; }
        public virtual ICollection<TercerosCo> TercerosCoCuentaCxpCuadreDepto { get; set; }
        public virtual ICollection<TercerosCo> TercerosCoCuentaCxpDepto { get; set; }
    }
}
