using System;

namespace Labb2
{
    class Program
    {
        static void Main(string[] args)
        {
            Position position1 = new Position(1, 9);
            Position position2 = new Position(2, 7);

            Console.WriteLine(position1.Equals(position2));
        }
    }
}
