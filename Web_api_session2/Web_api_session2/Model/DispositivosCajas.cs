using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class DispositivosCajas
    {
        public string DispCajaId { get; set; }
        public int CajaId { get; set; }
        public int TipoDispId { get; set; }
        public int? DispositivoId { get; set; }
        public string TipoManejo { get; set; }
        public string Impresora { get; set; }
        public short NumPuerto { get; set; }
        public string Habilitado { get; set; }

        public virtual Cajas Caja { get; set; }
        public virtual Dispositivos Dispositivo { get; set; }
        public virtual TiposDispositivos TipoDisp { get; set; }
    }
}
