using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ActivosFijos
    {
        public ActivosFijos()
        {
            ImagenesActivosFijos = new HashSet<ImagenesActivosFijos>();
        }

        public int ActivoFijoId { get; set; }
        public string Nombre { get; set; }
        public int GrupoActfijoId { get; set; }
        public DateTime FechaAdq { get; set; }
        public decimal? ValorAdq { get; set; }
        public string Estatus { get; set; }
        public DateTime? FechaBaja { get; set; }
        public string CausaBaja { get; set; }
        public string Notas { get; set; }
        public string Depcon { get; set; }
        public DateTime? FechaIniDepcon { get; set; }
        public decimal? PctjeDepcon { get; set; }
        public DateTime? FechaFinDepcon { get; set; }
        public string CrearPolizasDepcon { get; set; }
        public int? CuentaDepconDepId { get; set; }
        public int? DeptoDepconDepId { get; set; }
        public int? CuentaDepconGasId { get; set; }
        public int? DeptoDepconGasId { get; set; }
        public string Depfis { get; set; }
        public DateTime? FechaIniDepfis { get; set; }
        public decimal? PctjeDepfis { get; set; }
        public DateTime? FechaFinDepfis { get; set; }
        public decimal? ValorDepfis { get; set; }
        public string DeducInmed { get; set; }
        public DateTime? FechaIniDeducInmed { get; set; }
        public decimal? PctjeDeducInmed { get; set; }
        public string CrearPolizasDepfis { get; set; }
        public int? CuentaDepfisDepId { get; set; }
        public int? DeptoDepfisDepId { get; set; }
        public int? CuentaDepfisGasId { get; set; }
        public int? DeptoDepfisGasId { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual CuentasCo CuentaDepconDep { get; set; }
        public virtual CuentasCo CuentaDepconGas { get; set; }
        public virtual CuentasCo CuentaDepfisDep { get; set; }
        public virtual CuentasCo CuentaDepfisGas { get; set; }
        public virtual DeptosCo DeptoDepconDep { get; set; }
        public virtual DeptosCo DeptoDepconGas { get; set; }
        public virtual DeptosCo DeptoDepfisDep { get; set; }
        public virtual DeptosCo DeptoDepfisGas { get; set; }
        public virtual GruposActivosFijos GrupoActfijo { get; set; }
        public virtual LibresActFijos LibresActFijos { get; set; }
        public virtual ICollection<ImagenesActivosFijos> ImagenesActivosFijos { get; set; }
    }
}
