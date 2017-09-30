using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Numerics;


namespace training
{
    class Program
    {
        static void Main()
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            
            int start = 0;
            int len = 1;

            int bestStart = start;
            int bestLen = len;

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] > list[i - 1])
                {
                    len++;
                    if (len > bestLen)
                    {
                        bestLen = len;
                        bestStart = start;
                    }
                }
                else
                {
                    start = i;
                    len = 1;
                }
            }
            for (int i = bestStart; i < bestStart + bestLen; i++)
            {
                Console.Write("{0} ", list[i]);
            }
                

        }   
    }
}
