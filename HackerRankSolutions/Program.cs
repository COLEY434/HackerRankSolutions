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

            //Console.WriteLine(JsonConvert.SerializeObject(Sorting.BigSorting(new List<string> { "5", "4", "3", "2", "1", "345", "34", "18", "12", "90", "634", "11"})));
            Console.WriteLine(FindMaxConsecutiveOnes(new int[] { 1, 1, 0, 1, 1, 1 }));
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

        static int FindMaxConsecutiveOnes(int[] nums)
        {
            var newWindowStarted = false;
            var count = 0;
            var list = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1 && newWindowStarted == false)
                {
                    newWindowStarted = true;
                }

                if (nums[i] == 1)
                {
                    count++;
                }
                else
                {
                    if (newWindowStarted == true)
                    {
                        newWindowStarted = false;
                        list.Add(count);
                        count = 0;
                    }
                }
            }

            if(count != 0)
            {
                list.Add(count);
                count = 0;
            }

            int currentVal = 0;
            foreach (var num in list)
            {
                if (num > currentVal)
                {
                    currentVal = num;
                }
            }

            return currentVal;
        }

        //Console.WriteLine(JsonConvert.SerializeObject(Sorting.SelectionSort(new List<int> { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1})));
    }
}
