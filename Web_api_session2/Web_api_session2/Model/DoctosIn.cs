using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DoctosIn
    {
        public DoctosIn()
        {
            DoctosInDet = new HashSet<DoctosInDet>();
            DoctosInvfisDoctoInIdEntNavigation = new HashSet<DoctosInvfis>();
            DoctosInvfisDoctoInIdSalNavigation = new HashSet<DoctosInvfis>();
        }

        public int DoctoInId { get; set; }
        public int AlmacenId { get; set; }
        public int ConceptoInId { get; set; }
        public string Folio { get; set; }
        public string NaturalezaConcepto { get; set; }
        public DateTime Fecha { get; set; }
        public int? AlmacenDestinoId { get; set; }
        public int? CentroCostoId { get; set; }
        public string Cancelado { get; set; }
        public string Aplicado { get; set; }
        public string Descripcion { get; set; }
        public string CuentaConcepto { get; set; }
        public string FormaEmitida { get; set; }
        public string Contabilizado { get; set; }
        public string SistemaOrigen { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }
        public string UsuarioCancelacion { get; set; }
        public DateTime? FechaHoraCancelacion { get; set; }
        public string UsuarioAutCancelacion { get; set; }

        public virtual Almacenes Almacen { get; set; }
        public virtual Almacenes AlmacenDestino { get; set; }
        public virtual CentrosCosto CentroCosto { get; set; }
        public virtual LibresEntradasIn LibresEntradasIn { get; set; }
        public virtual LibresSalidasIn LibresSalidasIn { get; set; }
        public virtual ICollection<DoctosInDet> DoctosInDet { get; set; }
        public virtual ICollection<DoctosInvfis> DoctosInvfisDoctoInIdEntNavigation { get; set; }
        public virtual ICollection<DoctosInvfis> DoctosInvfisDoctoInIdSalNavigation { get; set; }
    }
}
