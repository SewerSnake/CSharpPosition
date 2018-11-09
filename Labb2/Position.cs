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

        public Position Clone()
        {
            return new Position(X, Y);
        }

        // OVERLOADING OPERATORS
        public static double operator %(Position p1, Position p2)
        {
            double distance =
                Math.Sqrt(
                    Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2)
                );
            // Om vi vill avrunda till 2 decimaler
            // return Math.Round(distance, 2);
            return distance;
        }

        public static bool operator >(Position p1, Position p2)
        {
            throw new NotImplementedException();
            /*if (p1.Length() == p2.Length())
            {
                return p1.X > p2.X;
            }

            return p1.Length() > p2.Length();*/
        }

        public static bool operator <(Position p1, Position p2)
        {
            throw new NotImplementedException();
            /*if (p1.Length() == p2.Length())
            {
                return p2.X > p1.X;
            }

            return p2.Length() > p1.Length();*/
        }
    }
}
