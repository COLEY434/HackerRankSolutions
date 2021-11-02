using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.Helper
{
    public class StringManipulationMediumUtils
    {
        public static bool CheckIfCountOfItemsAreTheSame(Dictionary<char, int> charCount)
        {
            var checkPoint = 0;
            bool itemCountIstheSame = true;
            foreach(var item in charCount)
            {
                if (checkPoint == 0)
                    checkPoint = item.Value;

                if (item.Value != checkPoint)
                {
                    itemCountIstheSame = false;
                    break;
                }                
            }

            return itemCountIstheSame;
        }

        public static bool RemoveAnItemAndCheckIfCountOfItemsAreTheSame(Dictionary<char, int> charCount)
        {
            var charsNotTheSame = new List<int>();
            var checkPoint = 0;

            foreach (var item in charCount)
            {
                if (checkPoint == 0)
                    checkPoint = item.Value;

                if (item.Value != checkPoint)
                {
                    charsNotTheSame.Add(item.Value);
                }
            }

            if(charsNotTheSame.Count > 1)
            {
                return false;
            }

            int max = charsNotTheSame[0];
            int min = checkPoint;
            int diff = max - min;

            if(diff > 1)
            {
                return false;
            }

            return true;
        }
    }
}
