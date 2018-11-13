﻿using System;
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

        public void Add(Position pos)
        {
            sortedPosList.Add(pos);

            for (int i = 0; i < Count(); i++)
            {
                for (int j = i + 1; j < Count(); j++)
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

        // OVERLOADING OPERATORS

        // Returns a new sorted list containing all positions of the two provided lists 
        // sp1 - the first sorted list of Positions
        // sp2 - the second sorted list of Positions
        public static SortedPosList operator +(SortedPosList sp1, SortedPosList sp2)
        {
            SortedPosList combinedList = new SortedPosList();

            for (int i = 0; i < sp1.Count(); i++) 
            {
                combinedList.Add(sp1[i]);
            }

            for (int i = 0; i < sp2.Count(); i++)
            {
                combinedList.Add(sp2[i]);
            }

            return combinedList;
        }

        public Position this[int index]
        {
            // GET - Returns Position at given index
            get { return sortedPosList[index]; }
        }

        public SortedPosList Clone()
        {
            SortedPosList clonedList = new SortedPosList();

            foreach (Position pos in sortedPosList)
            {
                clonedList.Add(pos.Clone());
            }
            return clonedList;
        }

        // Returns a list containing all positions within the given circle
        // centerPos - center of the circle
        public SortedPosList CircleContent(Position centerPos, double radius)
        {
            SortedPosList posWithinCircle = new SortedPosList();

            foreach (Position pos in sortedPosList)
            {
                if (Math.Pow(pos.X - centerPos.X, 2) + Math.Pow(pos.Y - centerPos.Y, 2) < Math.Pow(radius, 2))
                {
                    posWithinCircle.Add(pos);
                    //Console.WriteLine(pos);
                }
            }
            return posWithinCircle;
        }


    }
}
