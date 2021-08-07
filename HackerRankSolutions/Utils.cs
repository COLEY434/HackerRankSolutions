using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions
{
    class Utils
    {
        public static List<Info> infos = new List<Info>();
        public static int SumAllNumbersInAFileAndItsSubFile(string filePath = null)
        {
            filePath = filePath ?? Path.GetFileName(@"C:\Users\ThinkPad T470s\Documents\Projects\dotnet\COLEY434\HackerRankSolutions\HackerRankSolutions\A.txt");
            
            int sum = 0;
            foreach (var value in File.ReadLines(filePath))
            {
                if (value.Contains(".txt"))
                {
                    sum = sum + SumAllNumbersInAFileAndItsSubFile(value);                  
                }
                else
                {
                    var val = int.Parse(value);
                    sum = sum + val;
                    
                }
            }
            var newInfo = new Info() { Filename = filePath, FileSum = sum };
            infos.Add(newInfo);
            return sum;
        }
    }
}
