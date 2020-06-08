namespace sample6
{
    public class Square: Shape
    {
        public Square():
        base(4)
        {

        }

        public override double GetArea()
        { 
            return 9;
        }

    }
}