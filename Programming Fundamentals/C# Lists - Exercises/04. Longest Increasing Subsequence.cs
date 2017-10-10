using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Numerics;


namespace training
{
    class Training
    {
        static void Main()
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var n = list.Length;
           
            int[] len = new int[n];
            int[] prev = new int[n];

            int lastIndex = -1;
            int bestLen = 0;

            for (int i = 0; i < n; i++)
            {
                len[i] = 1;
                prev[i] = -1;

                var anchorNum = list[i];
                for (int y = 0; y < i; y++)
                {
                    //kur
                    var currNum = list[y];
                    if (currNum < anchorNum && len[y] + 1 > len[i])
                    {
                        len[i] = len[y] + 1;
                        prev[i] = y;
                    }
                }

                if (len[i] > bestLen)
                {
                    bestLen = len[i];
                    lastIndex = i;
                }

            }
            var output = new List<int>();

            while (lastIndex != -1)
            {
                output.Add(list[lastIndex]);
                lastIndex = prev[lastIndex];
            }
            output.Reverse();

            Console.WriteLine(string.Join(" ",output));
            


        }
        
    }
}