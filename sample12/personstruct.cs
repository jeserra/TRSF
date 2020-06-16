using System;

namespace sample12 
{
    public struct PersonStruct
    {
          public string Name {get;set;}
        public string LastName {get;set;}

        public void Present ()
        {
            Console.WriteLine ($"I am {FullName}");
        }
        public string FullName {get => $"{Name} {LastName}";}
    }
}