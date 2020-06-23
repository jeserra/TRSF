using System;

namespace sample_exercise_3
{
    public class ScreenText 
    {

        protected int x;
        protected int y;
        protected string text;

        public ScreenText (int x, int y, string text)
        {
            this.x = x;
            this.y = y;
            this.text = text;
        }

        public virtual void SetX (int x) 
        {
            this.x = x;
        }

        public void SetY (int y) => this.y = y;

        public  void SetText (string text) 
        { 
            this.text = text;
        }

        public virtual void Display ()
        {

        }

    }
}
