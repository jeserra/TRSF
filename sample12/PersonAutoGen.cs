using System;

namespace sample12 
{

    public partial class Person 
    {
        public void Present ()
        {
            Console.WriteLine ($"I am {FullName}");
            ScreamText();
        }

        /*partial void ScreamText ()
        {
            Console.WriteLine("Gritar");
        }*/


    }
}