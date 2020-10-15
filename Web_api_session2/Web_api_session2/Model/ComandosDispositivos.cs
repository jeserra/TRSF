using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class ComandosDispositivos
    {
        public int ComandoDispId { get; set; }
        public int DispositivoId { get; set; }
        public int ComandoTipoDispId { get; set; }
        public string Secuencia { get; set; }

        public virtual ComandosTiposDispositivos ComandoTipoDisp { get; set; }
        public virtual Dispositivos Dispositivo { get; set; }
    }
}
