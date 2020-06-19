using System;

namespace sample25 
{
    public class Person 
    {
        /*private int _idPerson; 

        public int IdPerson 
        {
            get 
            {
                return _idPerson;
            }

            set 
            { 
                _idPerson = value;
            }
        } */ 

        protected string Name {get;set;}
        public  int IdPerson {get;set;}
        internal string LastName {get;set;}



    }
}