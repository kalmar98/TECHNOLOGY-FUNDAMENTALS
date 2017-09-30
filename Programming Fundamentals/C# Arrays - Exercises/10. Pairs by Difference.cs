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
            var difference = int.Parse(Console.ReadLine());
            var amountOfPairs = 0;

            for (int i = 0; i < input.Count; i++)
            {
                for (int y = i; y < input.Count; y++)
                {
                    int check = Math.Abs(input[i] - input[y]);
                    if (check == difference)
                    {
                        amountOfPairs++;
                    }
                }
            }

         


            Console.WriteLine(amountOfPairs);


        }
    }
}
