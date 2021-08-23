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
            Console.WriteLine("Welcome");
            //var sum = Utils.SumAllNumbersInAFileAndItsSubFile();
            //int len = Utils.infos.Count;
            //for (int i = len - 1; i >= 0 ; i--)
            //    Console.WriteLine($"{Utils.infos[i].Filename} - {Utils.infos[i].FileSum}");

            Console.WriteLine(JsonConvert.SerializeObject(Sorting.QuickSort(new List<int> { 5, 4, 3, 2, 1, 345, 34, 18, 12, 90, 634, 11 })));
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

        //Console.WriteLine(JsonConvert.SerializeObject(Sorting.SelectionSort(new List<int> { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1})));
    }
}
