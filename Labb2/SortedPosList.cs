using System;
using System.Collections.Generic;

namespace Labb2
{
    public class SortedPosList
    {
        List<Position> sortedPosList = new List<Position>();

        public SortedPosList()
        {
        }

        public int Count()
        {
            return sortedPosList.Count;
        }

        public override string ToString()
        {
            return String.Join(",", sortedPosList);
        }
    }
}
