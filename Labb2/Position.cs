using System;

namespace Labb2
{
    public class Position
    {
        private int x;

        private int y;

        public int X 
        { 
            get 
            {
                return x;
            }
            set 
            {
                if (value >= 0)
                {
                    x = value;
                } 
                else 
                {
                    x = 0;
                }
            }
        }

        public int Y 
        {
            get 
            {
                return y;
            }
            set
            {
                if (value >= 0)
                {
                    y = value;
                } 
                else 
                {
                    y = 0;
                }
            }
        }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public bool Equals(Position p)
        {
            return (p.X == X) && (p.Y == Y);
        }
    }
}
