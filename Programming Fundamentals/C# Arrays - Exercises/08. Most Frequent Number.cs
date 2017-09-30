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
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            var dict = new Dictionary<int, int>(); //number, frequency

            foreach (var element in input)
            {
                if (!dict.ContainsKey(element))
                {
                    dict[element] = 0;
                }
                dict[element]++;
            }
            dict = dict.OrderByDescending(a => a.Value).ToDictionary(a => a.Key, a => a.Value);
            Console.WriteLine(dict.ElementAt(0).Key);
            

        }   
    }
}
