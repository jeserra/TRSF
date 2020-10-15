using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class Dispositivos
    {
        public Dispositivos()
        {
            ComandosDispositivos = new HashSet<ComandosDispositivos>();
            DispositivosCajas = new HashSet<DispositivosCajas>();
        }

        public int DispositivoId { get; set; }
        public int TipoDispId { get; set; }
        public string Nombre { get; set; }
        public string EsPredet { get; set; }
        public string TipoPuerto { get; set; }
        public int BitsSegundo { get; set; }
        public short BitsDatos { get; set; }
        public string Paridad { get; set; }
        public string BitsParada { get; set; }
        public string ControlFlujo { get; set; }
        public string MsgTorrAbierta1 { get; set; }
        public string MsgTorrAbierta2 { get; set; }
        public string MsgTorrTotal1 { get; set; }
        public string MsgTorrTotal2 { get; set; }
        public string MsgTorrCambio2 { get; set; }
        public string MsgTorrCerrada1 { get; set; }
        public string MsgTorrCerrada2 { get; set; }
        public short InicioPeso { get; set; }
        public short BytePesoInestable { get; set; }
        public short BitPesoInestable { get; set; }
        public short BytePesoExcedido { get; set; }
        public short BitPesoExcedido { get; set; }
        public short BytePesoNegativo { get; set; }
        public short BitPesoNegativo { get; set; }
        public string EsPinpad { get; set; }
        public string ModeloPinpad { get; set; }
        public string AutorizadorTarjeta { get; set; }
        public string ImpresoraIntegrada { get; set; }
        public int? VersionRegistro { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual TiposDispositivos TipoDisp { get; set; }
        public virtual ICollection<ComandosDispositivos> ComandosDispositivos { get; set; }
        public virtual ICollection<DispositivosCajas> DispositivosCajas { get; set; }
    }
}
