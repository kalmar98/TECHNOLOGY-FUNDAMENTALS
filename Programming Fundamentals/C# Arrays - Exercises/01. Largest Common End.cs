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
    
            var first = Console.ReadLine().Split().ToList();
            var second = Console.ReadLine().Split().ToList();
            LargestCommonEnd(first, second);
  
        }
        static void LargestCommonEnd(List<string> first, List<string> second)
        {
            int left = 0;
            int right = 0;
            for (int i = 0; i < Math.Min(first.Count, second.Count); i++)
            {
                if (first[i] == second[i])
                {
                    left++;
                }
                if (first[first.Count - 1 - i] == second[second.Count - 1 - i])
                {
                    right++;
                }        
            }
            Print(left, right);
        }
        static void Print(int left,int right)
        {

            if (left > right)
            {
                Console.WriteLine(left);
            }
            else
            {
                Console.WriteLine(right);
            }
        }
        
    
    }
}
