﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< Updated upstream
            Console.WriteLine(new Position(2, 4) + new Position(1, 2) + "\n");
            Console.WriteLine(new Position(2, 4) - new Position(1, 2) + "\n");
            Console.WriteLine(new Position(1, 2) - new Position(3, 6) + "\n");
            Console.WriteLine(new Position(3, 5) % new Position(1, 3) + "\n");
=======
            //Console.WriteLine(new Position(2, 4) + new Position(1, 2) + "\n");
            //Console.WriteLine(new Position(2, 4) - new Position(1, 2) + "\n");
            //Console.WriteLine(new Position(1, 2) - new Position(3, 6) + "\n");
            //Console.WriteLine(new Position(3, 5) % new Position(1, 3) + "\n");
>>>>>>> Stashed changes

            SortedPosList list1 = new SortedPosList();
            // SortedPosList list2 = new SortedPosList();
            list1.Add(new Position(3, 7));
            list1.Add(new Position(1, 4));
            list1.Add(new Position(2, 6));
            list1.Add(new Position(2, 3));
            Console.WriteLine(list1 + "\n");
            Console.WriteLine(list1[2]);
            list1.Remove(new Position(2, 6));
            Console.WriteLine(list1 + "\n");

<<<<<<< Updated upstream
            list2.Add(new Position(3, 7));
            list2.Add(new Position(1, 2));
            list2.Add(new Position(3, 6));
            list2.Add(new Position(2, 3));
            //Console.WriteLine((list2 + list1) + "\n");

            SortedPosList circleList = new SortedPosList();
            circleList.Add(new Position(1, 1));
            circleList.Add(new Position(2, 2));
            circleList.Add(new Position(3, 3));
=======
            //list2.Add(new Position(3, 7));
            //list2.Add(new Position(1, 2));
            //list2.Add(new Position(3, 6));
            //list2.Add(new Position(2, 3));
            //Console.WriteLine((list2 + list1) + "\n");

            //SortedPosList circleList = new SortedPosList();
            //circleList.Add(new Position(1, 1));
            //circleList.Add(new Position(2, 2));
            //circleList.Add(new Position(3, 3));
>>>>>>> Stashed changes
            //Console.WriteLine(circleList.CircleContent(new Position(5, 5), 4) + "\n");
        }
    }
}
