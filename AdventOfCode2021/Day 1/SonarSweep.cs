using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace AdventOfCode2021
{
    public class SonarSweep
    {
        private List<int> depths = File.ReadAllLines(@"C:\Users\Logan\source\repos\AdventOfCode2021\AdventOfCode2021\Day 1\Depths.txt").Select(int.Parse).ToList();

        public int PartOne()
        {
            int result = 0;
            for (int i = 1; i < depths.Count(); i++)
            {
                if (depths[i] > depths[i-1]) { result++; }
            }
            return result;
        }

        public int PartTwo()
        {
            int result = 0;
            for (int i = 1; i < depths.Count()-2; i++)
            {
                if ((depths[i] + depths[i + 1] + depths[i + 2]) > (depths[i - 1] + depths[i] + depths[i + 1])) { result++; }
            }
            return result;
        }
    }

}
