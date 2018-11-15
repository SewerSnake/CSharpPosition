using System;
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
            Console.WriteLine(new Position(2, 4) + new Position(1, 2) + "\n");
            Console.WriteLine(new Position(2, 4) - new Position(1, 2) + "\n");
            Console.WriteLine(new Position(1, 2) - new Position(3, 6) + "\n");
            Console.WriteLine(new Position(3, 5) % new Position(1, 3) + "\n");

            SortedPosList list1 = new SortedPosList();
            SortedPosList list2 = new SortedPosList();
            list1.Add(new Position(3, 7));
            list1.Add(new Position(1, 4));
            list1.Add(new Position(2, 6));
            list1.Add(new Position(2, 3));
            Console.WriteLine(list1 + "\n");
            Console.WriteLine(list1[2]);
            list1.Remove(new Position(2, 6));
            Console.WriteLine(list1 + "\n");

            Console.WriteLine("TESTING CLONE");
            SortedPosList c1 = list1.Clone();
            Console.WriteLine("List one:\n" + list1);
            Console.WriteLine("Cloned list:\n" + c1);
            list1.Remove(new Position(2, 3));
            Console.WriteLine("List one after one position removed:\n" + list1);
            Console.WriteLine("Cloned list:\n" + c1);

            Console.WriteLine("TEST: VALUES W/IN CIRCLE");
            SortedPosList list3 = new SortedPosList();
            list3.Add(new Position(1, 1));
            list3.Add(new Position(2, 2));
            list3.Add(new Position(3, 3));
            list3.CircleContent(new Position(5, 5), 4);

            Console.WriteLine("SUBTRACT LISTS");
            SortedPosList test1 = new SortedPosList();
            test1.Add(new Position(3, 7));
            test1.Add(new Position(1, 4));
            test1.Add(new Position(2, 6));
            test1.Add(new Position(2, 3));

            SortedPosList test2 = new SortedPosList();
            test2.Add(new Position(3, 7));
            test2.Add(new Position(1, 2));
            test2.Add(new Position(3, 6));
            test2.Add(new Position(2, 3));

            SortedPosList test3 = test2 - test1;

            list2.Add(new Position(3, 7));
            list2.Add(new Position(1, 2));
            list2.Add(new Position(3, 6));
            list2.Add(new Position(2, 3));
            Console.WriteLine((list2 + list1) + "\n");

            SortedPosList circleList = new SortedPosList();
            circleList.Add(new Position(1, 1));
            circleList.Add(new Position(2, 2));
            circleList.Add(new Position(3, 3));
            Console.WriteLine(circleList.CircleContent(new Position(5, 5), 4) + "\n");

            SortedPosList fileTest = new SortedPosList("positions.txt");
        }
    }
}
