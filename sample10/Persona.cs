using System;

namespace sample10
{

    public class Persona : IComparable
    {
        public string Name {get;set;}
        public int id {get;set;}
        public int CompareTo(object obj)
        {
            if (this.id > ((Persona) obj).id)
                return 1;
            else 
                return 0;
        }
      

    }

}