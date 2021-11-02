using HackerRankSolutions.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.StringManipulation
{
    public class StringManipulationMedium
    {
        //https://www.hackerrank.com/challenges/sherlock-and-valid-string/problem
        public static string SherlockValidSubstring(string str)
        {
            var charCount = new Dictionary<char, int>();

            for(int i = 0; i < str.Length; i++)
            {
                char nexChar = str[i];
                if (!charCount.ContainsKey(nexChar))
                {
                    charCount.Add(nexChar, 1);
                }
                else
                {
                    charCount[nexChar] += 1; 
                }
            }

            bool isItemCountTheSame = StringManipulationMediumUtils.CheckIfCountOfItemsAreTheSame(charCount);


            if (isItemCountTheSame)
            {
                return "YES";
            }
            else
            {
                isItemCountTheSame = StringManipulationMediumUtils.RemoveAnItemAndCheckIfCountOfItemsAreTheSame(charCount);
                if (isItemCountTheSame)
                {
                    return "YES";
                }
                else
                {
                    return "NO";
                }
            }
        }
    }
}
