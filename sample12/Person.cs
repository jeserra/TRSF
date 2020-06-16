using System;

namespace sample12 
{

    public partial class Person 
    {
        public string Name {get;set;}
        public string LastName {get;set;}

        public string FullName {get => $"{Name} {LastName}";}

        partial void ScreamText ();
    }
}