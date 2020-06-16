using System;

namespace sample15
{
    class Program
    {
        static void Main(string[] args)
        {
            MyGenericClass<int> intGenericClass = new MyGenericClass<int>(10); 
            int val = intGenericClass.genericMethod(200); 

            MyGenericClass<string> strGenericClass = new MyGenericClass<string>("Hello Generic World"); 
            strGenericClass.genericProperty = "This is a generic property example."; 
            string result = strGenericClass.genericMethod("Generic Parameter"); 

        }
    }
}
