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
            
            ushort n = ushort.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            var counter = 0;
            char zero = '0';
            for (int i = 1; i <= n; i++)
            {
               factorial *= i;
            }
            var Factorials = factorial.ToString().ToCharArray();
            for (int i = Factorials.Length-1; i>=0; i--)
            {
                var current = Factorials[i];
                if (current == zero)
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }
            
            Console.WriteLine(counter);

            
        }
    }
}
