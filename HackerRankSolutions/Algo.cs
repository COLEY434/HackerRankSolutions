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
    }
}
