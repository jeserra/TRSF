using System;

namespace sample_exercise_3 
{

    public class CenteredText : ScreenText
    {
        public CenteredText (int y, string text): base (0,y,text)
        {

        }

        public override void SetX (int x)
        {
                Console.WriteLine ("Hacer nada");
        }

        public override void Display()
        {

        }
    } 
}