using System;

namespace sample12
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Lalo";
            person.LastName ="Serrano";
            person.Present();

            PersonStruct person1 = new PersonStruct();
            person1.Name = "Juan";
            person1.LastName ="Camaney";
            person1.Present();
            
        }
    }
}
