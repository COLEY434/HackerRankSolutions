using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    class Algo
    {
        public static int DiagonalDifference(List<List<int>> arr)
        {
            int leftToRightSum = 0;
            int rightToLeftSum = 0;
            int decrement = 1;

            for(int i = 0; i < arr.Count; i++)
            {
                int len = arr[i].Count - decrement;
                leftToRightSum += arr[i][i];
                rightToLeftSum += arr[i][len];

                decrement++;
            }

            return Math.Abs(leftToRightSum - rightToLeftSum);
        }

        //These algorithm accepts two integer arrays, checks which numbers from the second array are missing from the first array and returns the missing number if found in ascending order
        public static List<int> FindingMissingNumbers(int[] first, int[] second)
        {
            
            Array.Sort(second);

            List<int> missingNumbers = new List<int>();

            foreach(var num in second)
            {
                missingNumbers.Add(num);
            }

            for(int idx = 0; idx < second.Length; idx++)
            {
                for (int idx2 = 0; idx2 < first.Length; idx2++)
                {
                    int misNum = first[idx2];
                    if(second[idx] == misNum)
                    {                   
                        missingNumbers.Remove(misNum);
                    }
                }
            }

            return missingNumbers;
        }
    }
}
