using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DirsClientes
    {
        public DirsClientes()
        {
            DoctosPv = new HashSet<DoctosPv>();
            DoctosTr = new HashSet<DoctosTr>();
            DoctosVeDirCli = new HashSet<DoctosVe>();
            DoctosVeDirConsig = new HashSet<DoctosVe>();
        }

        public int DirCliId { get; set; }
        public int ClienteId { get; set; }
        public string NombreConsig { get; set; }
        public string Calle { get; set; }
        public string NombreCalle { get; set; }
        public string NumExterior { get; set; }
        public string NumInterior { get; set; }
        public string Colonia { get; set; }
        public string ColoniaClaveFiscal { get; set; }
        public string Poblacion { get; set; }
        public string PoblacionClaveFiscal { get; set; }
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
        public string Contacto { get; set; }
        public int? ViaEmbarqueId { get; set; }
        public string EsDirPpal { get; set; }
        public string UsarParaEnvios { get; set; }
        public string UsarParaFacturar { get; set; }
        public string Gln { get; set; }

        public virtual Ciudades Ciudad { get; set; }
        public virtual Clientes Cliente { get; set; }
        public virtual ViasEmbarque ViaEmbarque { get; set; }
        public virtual ICollection<DoctosPv> DoctosPv { get; set; }
        public virtual ICollection<DoctosTr> DoctosTr { get; set; }
        public virtual ICollection<DoctosVe> DoctosVeDirCli { get; set; }
        public virtual ICollection<DoctosVe> DoctosVeDirConsig { get; set; }
    }
}
