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
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var numbersToBeTaken = array[0];
            var numbersToBeDeleted = array[1];
            var numberToBeSearched = array[2];

            var newList = list.Take(numbersToBeTaken).ToList();
            newList.RemoveRange(0, numbersToBeDeleted);
            if (newList.Contains(numberToBeSearched))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
        
    }
}