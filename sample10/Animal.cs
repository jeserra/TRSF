using System;

namespace sample10 
{
    public class Animal : IComparable 
    {
        public string Name { get; set; }
        public int Legs { get; set; }

        public int CompareTo (object obj) {
           if (this.Legs > ((Animal) obj).Legs)
                return 1;
            else 
                return 0;
        }
    }
}