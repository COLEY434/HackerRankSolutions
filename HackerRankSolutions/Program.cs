using System;
using System.Collections.Generic;

namespace HackerRankSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Easy.PlusMinus(new List<int> { -4, 3, -9, 0, 4, 1 });

            Console.ReadLine();
        }

        static void DiagonalDifference()
        {
            int res = Easy.DiagonalDifference(new List<List<int>>
            {
                new List<int>{ 3, 4, 7, 5 },
                new List<int>{ 4, 6, 4 , 7},
                new List<int>{ 2, 4, 6, 6 },
                new List<int>{ 2, 4, 6, 6 }
            });

            Console.WriteLine(res);
        }
    }
}
