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
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            var sum = 0;
            foreach (var element in list)
            {
                var arrayOfCurrentElement = int.Parse(new string(element.ToString().ToArray().Reverse().ToArray()));
                sum += arrayOfCurrentElement;
            }
            Console.WriteLine(sum);
        }
        
    }
}