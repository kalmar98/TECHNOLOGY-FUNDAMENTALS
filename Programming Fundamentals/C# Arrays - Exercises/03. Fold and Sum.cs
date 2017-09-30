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
            var arrayOfInt = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var k = arrayOfInt.Length / 4;
            int[] row1left = arrayOfInt.Take(k).Reverse().ToArray();


            int[] row1right = arrayOfInt.Reverse().Take(k).ToArray();


            int[] row1 = row1left.Concat(row1right).ToArray(); // 2 1 8 7


            int[] row2 = arrayOfInt.Skip(k).Take(2 * k).ToArray(); // 3 4 5 6


            var sumArr = row1.Select((x, index) => x + row2[index]).ToArray();


            Console.WriteLine(string.Join(" ", sumArr));
        } 
    
    }
}
