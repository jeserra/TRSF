using System;

namespace sample22
{
    class Program
    {
        static void Main(string[] args)
        {
            string teststring = "Soy la rosa que marchito el olvido";

            Console.WriteLine(teststring.Length);
            Console.WriteLine("Primera R --- ");
            Console.WriteLine(teststring.IndexOf("r"));
            Console.WriteLine(teststring.Contains("rosa"));

            string clonstring = (String) teststring.Clone();
            Console.WriteLine(clonstring) ;

            Console.WriteLine( teststring.Remove(28, 6));
            Console.WriteLine(teststring.Insert(4, "juana, "));
            Console.WriteLine( teststring);

            Console.WriteLine(teststring.LastIndexOf("e"));
            Console.WriteLine(teststring.ToUpper());
            Console.WriteLine(teststring.ToLower());
            Console.WriteLine (teststring.Replace("rosa", "tuna"));

            Console.WriteLine(teststring.Substring(1, 20));
            var listacaracteres = teststring.Split("r");
            foreach(var item in listacaracteres)
                Console.WriteLine(item);



        }
    }
}
