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
            var input = File.ReadAllText("input.txt").Split().Select(short.Parse).ToList();
            var counter = new Dictionary<short, short>();
            
            foreach (var number in input)
            {
                if (!counter.ContainsKey(number))
                {
                    counter[number] = 1;
                }
                else
                {
                    counter[number]++;
                }
                    
                          
            }
            File.WriteAllText("output.txt", counter.Keys.First().ToString());


        }
    }
}
