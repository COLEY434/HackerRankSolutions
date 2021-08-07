using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    class Easy
    {
       
        public static int DiagonalDifference(List<List<int>> arr)
        {
            int leftToRightSum = 0;
            int rightToLeftSum = 0;
            int decrement = 1;

            for (int i = 0; i < arr.Count; i++)
            {
                int len = arr[i].Count - decrement;
                leftToRightSum += arr[i][i];
                rightToLeftSum += arr[i][len];

                decrement++;
            }

            return Math.Abs(leftToRightSum - rightToLeftSum);
        }

        //https://www.hackerrank.com/challenges/plus-minus/problem
        public static void PlusMinus(List<int> numList)
        {
            int postIntCount = 0;
            int negIntCount = 0;
            int zeroCount = 0;
            double divisor = numList.Count + .00;

            for(int i = 0; i < numList.Count; i++)
            {
                if(numList[i] > 0)
                {
                    postIntCount += 1;
                }
                else if (numList[i] == 0) 
                {
                    zeroCount += 1;
                }
                else if(numList[i] < 0)
                {
                    negIntCount += 1;
                }
            }

            Console.WriteLine(string.Format("{0:N6}", postIntCount / divisor));
            Console.WriteLine(string.Format("{0:N6}", negIntCount / divisor));
            Console.WriteLine(string.Format("{0:N6}", zeroCount / divisor));
        }
    }
}
