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
            for (int i = 0; i < input.Count; i++)
            {

                if (LeftSumMethod(input, i) == RightSumMethod(input, i))
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine("no");
        }
        static int LeftSumMethod(List<int> input, int i)
        {
            int leftSum = 0;
            for (int y = 0; y < i; y++)
            {
                leftSum += input[y];
            }
            return leftSum;
        }
        static int RightSumMethod(List<int> input, int i)
        {
            int rightSum = 0;
            for (int y = i + 1; y < input.Count; y++)
            {
                rightSum += input[y];
            }
            return rightSum;
        }
    }
}
