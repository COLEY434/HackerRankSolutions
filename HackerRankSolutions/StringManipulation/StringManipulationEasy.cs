using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.StringManipulation
{
    public class StringManipulationEasy
    {
       // https://www.hackerrank.com/challenges/camelcase/problem
        public static int CamelCase(string s)
        {
            int count = 1;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s[i]))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
