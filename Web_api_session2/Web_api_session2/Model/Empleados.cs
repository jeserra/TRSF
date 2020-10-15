using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class Empleados
    {
        public Empleados()
        {
            ClavesEmpleados = new HashSet<ClavesEmpleados>();
            ConceptosEmp = new HashSet<ConceptosEmp>();
            ContratosLft = new HashSet<ContratosLft>();
            EstatusAsimilados = new HashSet<EstatusAsimilados>();
            ExcepEmpleados = new HashSet<ExcepEmpleados>();
            ImagenesEmpleados = new HashSet<ImagenesEmpleados>();
            Incapacidades = new HashSet<Incapacidades>();
            Incidencias = new HashSet<Incidencias>();
            MovtosAhorroEmp = new HashSet<MovtosAhorroEmp>();
            PagosNomina = new HashSet<PagosNomina>();
            PagosNominaCancelados = new HashSet<PagosNominaCancelados>();
            PagosNominaDet = new HashSet<PagosNominaDet>();
            PeriodosVac = new HashSet<PeriodosVac>();
            PrestamosEmp = new HashSet<PrestamosEmp>();
            SubcontratosEmp = new HashSet<SubcontratosEmp>();
            Vacaciones = new HashSet<Vacaciones>();
            ViaticosNo = new HashSet<ViaticosNo>();
            ViaticosNoCancelados = new HashSet<ViaticosNoCancelados>();
        }

        public int EmpleadoId { get; set; }
        public int Numero { get; set; }
        public string NombreCompleto { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Nombres { get; set; }
        public string Regimen { get; set; }
        public int? PuestoNoId { get; set; }
        public int? DeptoNoId { get; set; }
        public int FrepagId { get; set; }
        public int RegPatronalId { get; set; }
        public string FormaPago { get; set; }
        public string Contrato { get; set; }
        public decimal DiasHrsJsr { get; set; }
        public string Horario { get; set; }
        public string Turno { get; set; }
        public decimal Jornada { get; set; }
        public string RegimenFiscal { get; set; }
        public string ContratoSat { get; set; }
        public string JornadaSat { get; set; }
        public string EsSindicalizado { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Estatus { get; set; }
        public string ZonaSalmin { get; set; }
        public int TablaAntigId { get; set; }
        public string TipoSalario { get; set; }
        public decimal? PctjeInteg { get; set; }
        public decimal? SalarioDiario { get; set; }
        public decimal? SalarioHora { get; set; }
        public decimal? SalarioInteg { get; set; }
        public string Ptu { get; set; }
        public string Imss { get; set; }
        public string Cas { get; set; }
        public string Infonavit { get; set; }
        public string Pensionado { get; set; }
        public string TipoPension { get; set; }
        public string DeshabImptos { get; set; }
        public string CalcIsrAnual { get; set; }
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
        public string Email { get; set; }
        public string Sexo { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public int? CiudadNacimientoId { get; set; }
        public string EstadoCivil { get; set; }
        public short NumHijos { get; set; }
        public string NombrePadre { get; set; }
        public string NombreMadre { get; set; }
        public string Rfc { get; set; }
        public string Curp { get; set; }
        public string RegImss { get; set; }
        public string OtroReg { get; set; }
        public string UnidadMedica { get; set; }
        public int? GrupoPagoElectId { get; set; }
        public string TipoCtabanPagoElect { get; set; }
        public string NumCtabanPagoElect { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual Ciudades Ciudad { get; set; }
        public virtual Ciudades CiudadNacimiento { get; set; }
        public virtual DeptosNo DeptoNo { get; set; }
        public virtual FrecuenciasPago Frepag { get; set; }
        public virtual GruposPagosElect GrupoPagoElect { get; set; }
        public virtual PuestosNo PuestoNo { get; set; }
        public virtual RegPatronales RegPatronal { get; set; }
        public virtual TablasNo TablaAntig { get; set; }
        public virtual LibresEmpleados LibresEmpleados { get; set; }
        public virtual ICollection<ClavesEmpleados> ClavesEmpleados { get; set; }
        public virtual ICollection<ConceptosEmp> ConceptosEmp { get; set; }
        public virtual ICollection<ContratosLft> ContratosLft { get; set; }
        public virtual ICollection<EstatusAsimilados> EstatusAsimilados { get; set; }
        public virtual ICollection<ExcepEmpleados> ExcepEmpleados { get; set; }
        public virtual ICollection<ImagenesEmpleados> ImagenesEmpleados { get; set; }
        public virtual ICollection<Incapacidades> Incapacidades { get; set; }
        public virtual ICollection<Incidencias> Incidencias { get; set; }
        public virtual ICollection<MovtosAhorroEmp> MovtosAhorroEmp { get; set; }
        public virtual ICollection<PagosNomina> PagosNomina { get; set; }
        public virtual ICollection<PagosNominaCancelados> PagosNominaCancelados { get; set; }
        public virtual ICollection<PagosNominaDet> PagosNominaDet { get; set; }
        public virtual ICollection<PeriodosVac> PeriodosVac { get; set; }
        public virtual ICollection<PrestamosEmp> PrestamosEmp { get; set; }
        public virtual ICollection<SubcontratosEmp> SubcontratosEmp { get; set; }
        public virtual ICollection<Vacaciones> Vacaciones { get; set; }
        public virtual ICollection<ViaticosNo> ViaticosNo { get; set; }
        public virtual ICollection<ViaticosNoCancelados> ViaticosNoCancelados { get; set; }
    }
}
