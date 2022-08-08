using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace AdventOfCode2021
{
    class Program
    {
        public static void Main()
        {
            var D1P1 = new SonarSweep().PartOne();
            Console.WriteLine("The Answer for Day 1.1 is: " + D1P1);
            Debug.Assert(D1P1 == 1655);

            var D1P2 = new SonarSweep().PartTwo();
            Console.WriteLine("The Answer for Day 1.2 is: " + D1P2);
            Debug.Assert(D1P2 == 1683);
        }
    }
}
