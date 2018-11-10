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

        // Denna kod kan säkert modifieras. 
        // OBS Har inte testkört eftersom att > operatorn ej ännu är tillgänglig. :)
        public void Add(Position pos)
        {
            sortedPosList.Add(pos);

            for (int i = 0; i < sortedPosList.Count; i++)
            {
                for (int j = i + 1; j < sortedPosList.Count; j++)
                {
                    if (sortedPosList[i] > sortedPosList[j])
                    {
                        Position holder = sortedPosList[i];
                        sortedPosList[i] = sortedPosList[j];
                        sortedPosList[j] = holder;
                    }
                }
            }
        }

        public bool Remove(Position position)
        {
            foreach (Position posInList in sortedPosList)
            {
                if (position.Equals(posInList))
                {
                    sortedPosList.Remove(posInList);
                    return true;
                }
            }
            return false;
        }
    }
}
