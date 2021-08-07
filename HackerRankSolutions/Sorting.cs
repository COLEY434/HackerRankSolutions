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

    }
}
