using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    class Sorting
    {
        public static List<int> SelectionSort(List<int> nums)
        {
            var newList = new List<int>();
            int count = nums.Count;

            for (int i = 0; i < count; i++)
            {               
                int smallest = GetSmallestIndex(nums);
                newList.Add(nums[smallest]);
                nums.RemoveAt(smallest);              
            }

            return newList;
        }
        
        public static int GetSmallestIndex(List<int> nums)
        {
            int smallest = nums[0];
            int smallestIndex = 0;

            for (int i = 0; i < nums.Count; i++)
            {
                int current = nums[i];
                if (current < smallest)
                {
                    smallest = current;
                    smallestIndex = i;
                }
            }
            return smallestIndex;       
        }
        public static List<int> QuickSort(List<int> arr)
        {
            if(arr.Count < 2)
            {
                return arr;
            }
            else
            {
                int pivot = arr[0];
                //List<int> less = GetSubArrayLesserThanPivot(arr, pivot).ToList();
                //List<int> greater = GetSubArrayGreaterThanPivot(arr, pivot).ToList();

                var sortedLess = QuickSort(GetSubArrayLesserThanPivot(arr, pivot).ToList());
                var sortedGreater = QuickSort(GetSubArrayGreaterThanPivot(arr, pivot).ToList());

                sortedLess.Add(pivot);
                sortedLess.AddRange(sortedGreater);

                return sortedLess;
            }
        }

        private static IEnumerable<int> GetSubArrayLesserThanPivot(List<int> arr, int pivot)
        {
            foreach(var item in arr)
            {
                if (item < pivot)
                    yield return item;
            }
        }
        private static IEnumerable<int> GetSubArrayGreaterThanPivot(List<int> arr, int pivot)
        {
            foreach (var item in arr)
            {
                if (item > pivot)
                    yield return item;
            }
        }
    }
}
