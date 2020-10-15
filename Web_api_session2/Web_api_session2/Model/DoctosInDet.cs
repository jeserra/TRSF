using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DoctosInDet
    {
        public DoctosInDet()
        {
            DesgloseEnDiscretos = new HashSet<DesgloseEnDiscretos>();
            DesgloseEnPedimentos = new HashSet<DesgloseEnPedimentos>();
            DoctosInvfisDetDoctoInDetIdEntNavigation = new HashSet<DoctosInvfisDet>();
            DoctosInvfisDetDoctoInDetIdSalNavigation = new HashSet<DoctosInvfisDet>();
            SubMovtosInDoctoInDet = new HashSet<SubMovtosIn>();
            SubMovtosInSubMovto = new HashSet<SubMovtosIn>();
            UsosCapasCostos = new HashSet<UsosCapasCostos>();
            UsosCapasPedimentos = new HashSet<UsosCapasPedimentos>();
        }

        public int DoctoInDetId { get; set; }
        public int DoctoInId { get; set; }
        public int AlmacenId { get; set; }
        public int ConceptoInId { get; set; }
        public string ClaveArticulo { get; set; }
        public int ArticuloId { get; set; }
        public string TipoMovto { get; set; }
        public decimal? Unidades { get; set; }
        public decimal? CostoUnitario { get; set; }
        public decimal? CostoTotal { get; set; }
        public string MetodoCosteo { get; set; }
        public string Cancelado { get; set; }
        public string Aplicado { get; set; }
        public string CosteoPend { get; set; }
        public string PedimentoPend { get; set; }
        public string Rol { get; set; }
        public DateTime Fecha { get; set; }
        public int? CentroCostoId { get; set; }

        public virtual Almacenes Almacen { get; set; }
        public virtual Articulos Articulo { get; set; }
        public virtual CentrosCosto CentroCosto { get; set; }
        public virtual DoctosIn DoctoIn { get; set; }
        public virtual ICollection<DesgloseEnDiscretos> DesgloseEnDiscretos { get; set; }
        public virtual ICollection<DesgloseEnPedimentos> DesgloseEnPedimentos { get; set; }
        public virtual ICollection<DoctosInvfisDet> DoctosInvfisDetDoctoInDetIdEntNavigation { get; set; }
        public virtual ICollection<DoctosInvfisDet> DoctosInvfisDetDoctoInDetIdSalNavigation { get; set; }
        public virtual ICollection<SubMovtosIn> SubMovtosInDoctoInDet { get; set; }
        public virtual ICollection<SubMovtosIn> SubMovtosInSubMovto { get; set; }
        public virtual ICollection<UsosCapasCostos> UsosCapasCostos { get; set; }
        public virtual ICollection<UsosCapasPedimentos> UsosCapasPedimentos { get; set; }
    }
}
