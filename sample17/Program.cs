using System;
using System.Collections.Generic;

namespace sample17
{
    class Program
    {
        static void Main(string[] args)
        {
            List<House> houses = new List<House>();
            houses.Add(new House () { IdHouse =10, Description = "Casa en playa"});
            houses.Add(new House () { IdHouse =20, Description = "Casa en montania"});
            houses.Add(new House () { IdHouse =30, Description = "Casa en bosque"});
            houses.Add(new House () { IdHouse =40, Description = "Casa en ciudad"});

            foreach(var item in houses)
            {
                Console.WriteLine($"{item.IdHouse} - {item.Description}");
            }
            
        }
    }
}
