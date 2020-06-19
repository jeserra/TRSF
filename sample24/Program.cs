using System;
using System.Linq;
using System.Collections.Generic;
namespace sample24
{
    class Program
    {
        
        public static List<Product> GetProductList() => Products.ProductList;
        static void Main(string[] args)
        {

            // OrderbyProperty();
            
             /*List<Product> products = GetProductList();

             var listproduct = from p in products
                                where p.Category == "Confections" || p.Category == "Beverages" 
                                orderby p.Category
                                select p.ProductName;


            foreach(var item in listproduct)
            Console.WriteLine( item); */
            //AllMatchedElements();

            Dictionary <int, string> Alumnos = new Dictionary<int, string>();
            Alumnos.Add(1, "Luis");
            Alumnos.Add(2, "Vicente");

            var whoisluis = (from a in Alumnos
                            where a.Value == "Luis"
                            select a.Value).FirstOrDefault();

            Console.WriteLine(whoisluis);
            

        }

        static void SelectSintaxis ()
        {
             #region select-syntax
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var numsPlusOne = from n in numbers 
                              select n + 1;

            Console.WriteLine("Numbers + 1:");
            foreach (var i in numsPlusOne)
            {
                Console.WriteLine(i);
            }
            
            #endregion
        }
        static void SelectProperty ()
        {
            #region select-property
            List<Product> products = GetProductList();

            var productNames = from p in products
                                
                               select p.ProductName;

            Console.WriteLine("Product Names:");
            foreach (var productName in productNames)
            {
                Console.WriteLine(productName);
            }
            #endregion
            return;
        }

        static int SelectWithWhere()
        {
            #region select-with-where
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var lowNums = from n in numbers
                          where n < 5
                          select  digits[n];

            Console.WriteLine("Numbers < 5:");
            foreach (var num in lowNums)
            {
                Console.WriteLine(num);
            }
            #endregion
            return 0;
        }

        public static  int OrderbySyntax()
        {
            #region orderby-syntax
            string[] words = { "cherry", "apple", "blueberry" };

            var sortedWords = from word in words
                              orderby word
                              select word;

            Console.WriteLine("The sorted list of words:");
            foreach (var w in sortedWords)
            {
                Console.WriteLine(w);
            }
            #endregion
            return 0;
        }

        public static int OrderbyProperty()
        {

            #region orderby-property
            string[] words = { "cherry", "apple", "blueberry" };

            var sortedWords = from word in words
                              orderby word.Length
                              select word;

            Console.WriteLine("The sorted list of words (by length):");
            foreach (var w in sortedWords)
            {
                Console.WriteLine(w);
            }
            #endregion
            return 0;
        }

        public static int AnyMatchingElements()
        {
            #region any-matches
            string[] words = { "believe", "relief", "receipt", "field" };

            bool iAfterE = words.Any(w => w.Contains("ei"));

            Console.WriteLine($"There is a word that contains in the list that contains 'ei': {iAfterE}");
            #endregion
            return 0;
        }

        public static int AllMatchedElements()
        {
            #region all-match
            int[] numbers = { 1, 11, 3, 19, 41, 65, 19 };

            bool onlyOdd = numbers.All(n => n % 2 == 1);

            Console.WriteLine($"The list contains only odd numbers: {onlyOdd}");
            #endregion
            return 0;
        }
    }
}
