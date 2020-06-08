namespace sample7
{
    public class Ciudadano
    {
        // publico accesible para cualquier clase
        public string Nombre {get;set;}
        public string Apellido {get;set;}

        // Accesible solo para clases hijo 
        protected string IFEID {get;set;}

        // Accesible solo para clases dentro del mismo ensamblado
        internal string OldIFEID {get;set;}

        private string IdSupervisor {get;set;}

    }
}