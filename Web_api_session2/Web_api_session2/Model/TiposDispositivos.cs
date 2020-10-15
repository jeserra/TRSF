using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class TiposDispositivos
    {
        public TiposDispositivos()
        {
            ComandosTiposDispositivos = new HashSet<ComandosTiposDispositivos>();
            Dispositivos = new HashSet<Dispositivos>();
            DispositivosCajas = new HashSet<DispositivosCajas>();
        }

        public int TipoDispId { get; set; }
        public string Nombre { get; set; }
        public string IdInterno { get; set; }

        public virtual ICollection<ComandosTiposDispositivos> ComandosTiposDispositivos { get; set; }
        public virtual ICollection<Dispositivos> Dispositivos { get; set; }
        public virtual ICollection<DispositivosCajas> DispositivosCajas { get; set; }
    }
}
