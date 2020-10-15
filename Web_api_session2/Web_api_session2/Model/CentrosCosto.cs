﻿using System;
using System.Collections.Generic;

namespace Web_api_session2.Model
{
    public partial class CentrosCosto
    {
        public CentrosCosto()
        {
            DoctosIn = new HashSet<DoctosIn>();
            DoctosInDet = new HashSet<DoctosInDet>();
        }

        public int CentroCostoId { get; set; }
        public string Nombre { get; set; }
        public string EsPredet { get; set; }
        public string UsuarioCreador { get; set; }
        public DateTime? FechaHoraCreacion { get; set; }
        public string UsuarioAutCreacion { get; set; }
        public string UsuarioUltModif { get; set; }
        public DateTime? FechaHoraUltModif { get; set; }
        public string UsuarioAutModif { get; set; }

        public virtual ICollection<DoctosIn> DoctosIn { get; set; }
        public virtual ICollection<DoctosInDet> DoctosInDet { get; set; }
    }
}
