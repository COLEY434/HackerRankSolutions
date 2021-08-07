using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace HackerRankSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!...");

            //Console.WriteLine(JsonConvert.SerializeObject(Algo.FindingMissingNumbers(new int[6] { 7, 2, 5, 3, 5, 3 }, new int[8] { 7, 2, 5, 4, 6, 3, 5, 3 })));
            Console.WriteLine(JsonConvert.SerializeObject(Sorting.SelectionSort(new List<int> { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1})));

            Console.ReadLine();
        }

        static void DiagonalDifference()
        {
            int res = Algo.DiagonalDifference(new List<List<int>>
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
