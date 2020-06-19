using System;

namespace sample25
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.IdPerson = 100;
            student.LastName = "Serrano";
            using (var list =  GroupOfPeople.GetInstance())
            { 
                foreach(var item in list.ListofPeople )
                {
                    Console.WriteLine ("" + item.LastName + " " + item.IdPerson.ToString());
                    Console.WriteLine (" {0} {1}", item.LastName, item.IdPerson);
                    Console.WriteLine($" {item.LastName} {item.IdPerson}" );
                }

                
                Console.WriteLine(list.CountPeople);
                Console.WriteLine(list.DoubleCountPeople);

                list.Sing();
                _ = list.IsSleeping;

                var person = list.GetPersonById(1);
                Console.WriteLine($" {person.LastName} {person.IdPerson}" );

                int contador = 100;
                list.ModifyCounter(ref contador);
                Console.WriteLine(contador);
            }

            


             string numero = "-a10";
             Int32.TryParse(numero, out int result );

             Console.WriteLine(result);

             int a ;
            
             {
                     int b = 3;
                    a = 2;
                    for(int i = 1; i<= 10; i++)
                        a*=2 + b;
             };

            
             Console.WriteLine(a);

        }
    }
}
