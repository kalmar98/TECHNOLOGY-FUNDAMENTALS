using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Numerics;
using System.Globalization;
using System.IO;



namespace training
{
    class Training
    {
        static void Main()
        {
            var input = File.ReadAllText("input.txt").Split().Select(int.Parse).ToList();

            int start = 0;
            int len = 1;

            var dict = new Dictionary<int, int>();
            for (int i = 1; i <= input.Count - 1; i++)
            {
                int left = input[i - 1];
                int current = input[i];
                if (left == current)
                {
                    len++;
                }
                else
                {
                    start = i;
                    len = 1;
                }

                if (!dict.ContainsKey(start))
                {
                    dict[start] = len;
                }
                else
                {
                    dict[start] = len;
                }

            }
            dict = dict.OrderByDescending(a => a.Value).ToDictionary(a => a.Key, a => a.Value);

            foreach (var kvp in dict)
            {
                var _bestStart = kvp.Key;
                var _bestLen = kvp.Value;

                var preOutput = input.Skip(_bestStart).Take(_bestLen).ToList() ;
                var output = string.Join(" ", preOutput);
                File.WriteAllText("output.txt", output);

                break;
            }
            
        }
        
    }
}
