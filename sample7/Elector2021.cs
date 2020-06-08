namespace sample7
{
    public class Elector2021:Ciudadano
    {
        public void SetData(string nombre, string apellido, string IFEID)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.IFEID = IFEID;
            this.OldIFEID = IFEID;
            //this.IdSupervisor = "Fix";
        }
    }
}