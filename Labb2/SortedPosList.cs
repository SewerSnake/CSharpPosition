﻿using System;
using System.Collections.Generic;

namespace Labb2
{
    public class SortedPosList
    {
        List<Position> sortedPosList = new List<Position>();

        private bool hasSynced;

        private const string FILEPATH = "./positions.txt";


        public SortedPosList()
        {
            hasSynced = false;
        }

        public SortedPosList(string filePath)
        {
            hasSynced = true;

            try
            {
                System.IO.File.ReadAllLines(filePath);
            }
            catch
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filePath))
                {
                    Console.WriteLine("File created!");
                };
            }
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

        public static SortedPosList operator -(SortedPosList list1, SortedPosList list2)
        {
            SortedPosList comboList = list1 + list2;
            // Console.WriteLine("List1: " + list1);
            // Console.WriteLine("\nList2: " + list2);
            SortedPosList result = list1.Clone();
            // Console.WriteLine("CombinedList: " + comboList);

            for (int i = 0; i+1 < comboList.Count(); i++)
            {
                if (comboList[i].Equals(comboList [i+1]))
                {
                    Console.WriteLine($"Found same values: {comboList[i]} and {comboList[i + 1]}");
                    result.Remove(comboList[i]);
                }
                else {
                    // Console.WriteLine($"Not The same: {comboList[i]} and {comboList[i + 1]}");
                }
            }
            Console.WriteLine($"Final result: {result}");

            return result;
        }

        // File related methods
        private void Load()
        {

        }

        private void Save()
        {

        }

        public Position ConvertStringToPosition(string posString)
        {
            posString.Replace("(", string.Empty);
            posString.Replace(")", string.Empty);

            string[] twoCoords = posString.Split(",");

            return new Position(int.Parse(twoCoords[0]), int.Parse(twoCoords[1]));
        }

    }
}
