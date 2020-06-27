using System;
using sample30;
namespace sample30.ReglasSerpientes
{
    public class ReglaMeta : IRegla
    {
        public ReglaMeta(int casillaMeta)
        {
            this.CasillaMeta = casillaMeta;
        }
        private int CasillaMeta {get;set;}
        public bool EsCasillaEspecial(int casillaActual, out int nuevaCasilla)
        {
            nuevaCasilla = casillaActual;
             if(casillaActual > CasillaMeta)
             {
                 nuevaCasilla = CasillaMeta - (casillaActual - CasillaMeta);
                 return true;
             }
             else return false;
        }
    }
}