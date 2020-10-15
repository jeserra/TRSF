using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class SnubeComandosAgente
    {
        public int SnubeComandoAgenteId { get; set; }
        public string ObjJson { get; set; }
        public string Procesado { get; set; }
        public short? Prioridad { get; set; }
        public string Origen { get; set; }
        public string Resultado { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
    }
}
