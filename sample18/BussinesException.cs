using System;

namespace sample18 
{
    public class BussinesException : Exception
    {
        public BussinesException( string message, int idError) :base(message)
        {

        }

        public int IDError {get;set;}
         public BussinesException() :base("Custom exception")
        {

        }
    }
}