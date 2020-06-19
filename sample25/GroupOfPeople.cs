using System;
using System.Collections.Generic;
using System.Linq;
namespace sample25 
{
    public class GroupOfPeople:IDisposable
    {
        static GroupOfPeople groupOfPeople ;

        public static GroupOfPeople GetInstance ()
        {
            if (groupOfPeople == null)
                groupOfPeople = new GroupOfPeople();
            return groupOfPeople;
        }

        private GroupOfPeople ()
        {
            ListofPeople = new List<Person> () 
            {
                new Person() { LastName = "Serrano", IdPerson = 1},
                new Person() {LastName = "Dominguez", IdPerson = 2}
            };
        }

        public List<Person> ListofPeople {get; private set;}

         public int DoubleCountPeople {get  => ListofPeople.Count * 2;}

        public int CountPeople 
        {
            get 
            {
                return ListofPeople.Count;
            }
        }

      /*  public bool IsSleeping ()
        {
             
            if (CountSheeps() == 0)
                return true;
            else 
                return false;

            // Or 

            //return CountSheeps() == 0;
        } */

        public bool IsSleeping =>  CountSheeps() == 0;
        private int CountSheeps ()
        {
            foreach(var item in ListofPeople)
            {
                Console.WriteLine($"{item.LastName} count 100 sheeps ");
            }
            return 0; 
        }


        public void Sing ()
        {
            foreach(var item in ListofPeople)
            {
                Console.WriteLine($"{item.LastName} sing la cucaracha");
            }
            return;
        }

        public Person GetPersonById (int id )
        {
            return ListofPeople.Where (x=> x.IdPerson == id).First();
        }

        public void ModifyCounter (ref int counter)
        {
            counter += ListofPeople.Count;
        }

        public void Dispose()
        {
            Console.WriteLine("Disponsed list");
            ListofPeople = null;
        }
    }
}