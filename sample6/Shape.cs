namespace sample6
{
    public abstract class Shape
    {
        public int Sides {
            get; private set;
        }

        public Shape(int sides)
        {
            this.Sides = sides;
        }

        public abstract double GetArea();

    }
}