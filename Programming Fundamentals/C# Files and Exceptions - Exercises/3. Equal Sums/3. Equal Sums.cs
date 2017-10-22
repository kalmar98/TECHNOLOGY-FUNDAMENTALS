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
            var input = File.ReadAllText("input.txt").Split().Select(int.Parse).ToArray();
            for (int i = 0; i < input.Length; i++)
            {

                if (LeftSumMethod(input, i) == RightSumMethod(input, i))
                {
                    File.WriteAllText("output.txt",i.ToString());
                    return;
                }
            }

            File.WriteAllText("output.txt", "no");
        }
        static int LeftSumMethod(int[] input, int i)
        {
            int leftSum = 0;
            for (int y = 0; y < i; y++)
            {
                leftSum += input[y];
            }
            return leftSum;
        }
        static int RightSumMethod(int[] input, int i)
        {
            int rightSum = 0;
            for (int y = i + 1; y < input.Length; y++)
            {
                rightSum += input[y];
            }
            return rightSum;
        }
    }
}
