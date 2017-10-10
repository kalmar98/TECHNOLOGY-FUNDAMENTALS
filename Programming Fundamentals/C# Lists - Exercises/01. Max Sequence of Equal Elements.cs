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
            //3 4 4 5 5 5 2 2
            for (int i = 0; i < list.Count-1; i++)
            {
                if (list[i] == list[i+1])
                {
                    if (len == 1)
                    {
                        start = i;
                    }
                    len++;
                    if (len > bestLen)
                    {
                        bestLen = len;
                        bestStart = start;
                    }
                }
                else
                {    
                    len = 1;
                }
                
            }
            var output = list.Skip(bestStart).Take(bestLen).ToList();
            Console.WriteLine(string.Join(" ",output));
        }
        
    }
}