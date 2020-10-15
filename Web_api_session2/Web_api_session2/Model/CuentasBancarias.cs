using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class CuentasBancarias
    {
        public CuentasBancarias()
        {
            DepositosCc = new HashSet<DepositosCc>();
            DoctosBa = new HashSet<DoctosBa>();
            DoctosCc = new HashSet<DoctosCc>();
            DoctosCoDetInfoBan = new HashSet<DoctosCoDetInfoBan>();
            DoctosCpInfoBan = new HashSet<DoctosCpInfoBan>();
            EdosctaBa = new HashSet<EdosctaBa>();
            EdosctaBaDet = new HashSet<EdosctaBaDet>();
            GruposPagosElect = new HashSet<GruposPagosElect>();
            PagosNomina = new HashSet<PagosNomina>();
            SaldosBa = new HashSet<SaldosBa>();
            TraspasosBa = new HashSet<TraspasosBa>();
        }

        public int CuentaBanId { get; set; }
        public string Nombre { get; set; }
        public int BancoId { get; set; }
        public string Sucursal { get; set; }
        public string NumCuenta { get; set; }
        public string Clabe { get; set; }
        public string ChequeAutom { get; set; }
        public string SigCheque { get; set; }
        public int? TipoCtabanId { get; set; }
        public int MonedaId { get; set; }
        public string Conciliar { get; set; }
        public short DigitosConci { get; set; }
        public DateTime? FechaIniConci { get; set; }
        public DateTime? FechaUltConci { get; set; }
        public string CuentaContable { get; set; }
        public string EsPredet { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual Bancos Banco { get; set; }
        public virtual Monedas Moneda { get; set; }
        public virtual TiposCtasBan TipoCtaban { get; set; }
        public virtual LibresCtasBan LibresCtasBan { get; set; }
        public virtual ICollection<DepositosCc> DepositosCc { get; set; }
        public virtual ICollection<DoctosBa> DoctosBa { get; set; }
        public virtual ICollection<DoctosCc> DoctosCc { get; set; }
        public virtual ICollection<DoctosCoDetInfoBan> DoctosCoDetInfoBan { get; set; }
        public virtual ICollection<DoctosCpInfoBan> DoctosCpInfoBan { get; set; }
        public virtual ICollection<EdosctaBa> EdosctaBa { get; set; }
        public virtual ICollection<EdosctaBaDet> EdosctaBaDet { get; set; }
        public virtual ICollection<GruposPagosElect> GruposPagosElect { get; set; }
        public virtual ICollection<PagosNomina> PagosNomina { get; set; }
        public virtual ICollection<SaldosBa> SaldosBa { get; set; }
        public virtual ICollection<TraspasosBa> TraspasosBa { get; set; }
    }
}
