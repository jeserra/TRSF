using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class Impuestos
    {
        public Impuestos()
        {
            CargosPeriodicosCcImpuestoIsrRet = new HashSet<CargosPeriodicosCc>();
            CargosPeriodicosCcImpuestoIvaRet = new HashSet<CargosPeriodicosCc>();
            CargosPeriodicosCcImpuestoNavigation = new HashSet<CargosPeriodicosCc>();
            DoctosCmImpuestoSustituido = new HashSet<DoctosCm>();
            DoctosCmImpuestoSustituto = new HashSet<DoctosCm>();
            DoctosPvImpuestoSustituido = new HashSet<DoctosPv>();
            DoctosPvImpuestoSustituto = new HashSet<DoctosPv>();
            DoctosVeImpuestoSustituido = new HashSet<DoctosVe>();
            DoctosVeImpuestoSustituto = new HashSet<DoctosVe>();
            EquivalenciasImpuestosDetImpuestoAnterior = new HashSet<EquivalenciasImpuestosDet>();
            EquivalenciasImpuestosDetImpuestoNuevo = new HashSet<EquivalenciasImpuestosDet>();
            ImportesDoctosCcImptos = new HashSet<ImportesDoctosCcImptos>();
            ImportesDoctosCpImptos = new HashSet<ImportesDoctosCpImptos>();
            ImpuestosArticulos = new HashSet<ImpuestosArticulos>();
            ImpuestosDoctosCm = new HashSet<ImpuestosDoctosCm>();
            ImpuestosDoctosCmDet = new HashSet<ImpuestosDoctosCmDet>();
            ImpuestosDoctosPv = new HashSet<ImpuestosDoctosPv>();
            ImpuestosDoctosPvDet = new HashSet<ImpuestosDoctosPvDet>();
            ImpuestosDoctosVe = new HashSet<ImpuestosDoctosVe>();
            ImpuestosDoctosVeDet = new HashSet<ImpuestosDoctosVeDet>();
            TercerosCo = new HashSet<TercerosCo>();
        }

        public int ImpuestoId { get; set; }
        public int TipoImptoId { get; set; }
        public string Nombre { get; set; }
        public string TipoCalc { get; set; }
        public decimal? PctjeImpuesto { get; set; }
        public decimal? ImporteUnitario { get; set; }
        public string UnidadImpto { get; set; }
        public string EsPredet { get; set; }
        public string CuentaEnVentas { get; set; }
        public string CuentaEnCompras { get; set; }
        public string TipoIva { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual TiposImpuestos TipoImpto { get; set; }
        public virtual ICollection<CargosPeriodicosCc> CargosPeriodicosCcImpuestoIsrRet { get; set; }
        public virtual ICollection<CargosPeriodicosCc> CargosPeriodicosCcImpuestoIvaRet { get; set; }
        public virtual ICollection<CargosPeriodicosCc> CargosPeriodicosCcImpuestoNavigation { get; set; }
        public virtual ICollection<DoctosCm> DoctosCmImpuestoSustituido { get; set; }
        public virtual ICollection<DoctosCm> DoctosCmImpuestoSustituto { get; set; }
        public virtual ICollection<DoctosPv> DoctosPvImpuestoSustituido { get; set; }
        public virtual ICollection<DoctosPv> DoctosPvImpuestoSustituto { get; set; }
        public virtual ICollection<DoctosVe> DoctosVeImpuestoSustituido { get; set; }
        public virtual ICollection<DoctosVe> DoctosVeImpuestoSustituto { get; set; }
        public virtual ICollection<EquivalenciasImpuestosDet> EquivalenciasImpuestosDetImpuestoAnterior { get; set; }
        public virtual ICollection<EquivalenciasImpuestosDet> EquivalenciasImpuestosDetImpuestoNuevo { get; set; }
        public virtual ICollection<ImportesDoctosCcImptos> ImportesDoctosCcImptos { get; set; }
        public virtual ICollection<ImportesDoctosCpImptos> ImportesDoctosCpImptos { get; set; }
        public virtual ICollection<ImpuestosArticulos> ImpuestosArticulos { get; set; }
        public virtual ICollection<ImpuestosDoctosCm> ImpuestosDoctosCm { get; set; }
        public virtual ICollection<ImpuestosDoctosCmDet> ImpuestosDoctosCmDet { get; set; }
        public virtual ICollection<ImpuestosDoctosPv> ImpuestosDoctosPv { get; set; }
        public virtual ICollection<ImpuestosDoctosPvDet> ImpuestosDoctosPvDet { get; set; }
        public virtual ICollection<ImpuestosDoctosVe> ImpuestosDoctosVe { get; set; }
        public virtual ICollection<ImpuestosDoctosVeDet> ImpuestosDoctosVeDet { get; set; }
        public virtual ICollection<TercerosCo> TercerosCo { get; set; }
    }
}
