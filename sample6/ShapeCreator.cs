namespace sample6
{
    public class ShapeCreator
    { 

        public static Shape GetShape (int sides )
        {
            if(sides == 3)
                return GetTriangle();
            if(sides == 4)
                return GetSquare();
            else
                return null;

        }
        public static Shape  GetTriangle ()
        {
            return new Triangle(); 
        }

        public static Shape GetSquare ()
        {
            return new Square();   
        }
    }
}