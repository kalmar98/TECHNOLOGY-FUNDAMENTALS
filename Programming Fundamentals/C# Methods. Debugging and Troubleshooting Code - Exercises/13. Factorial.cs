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
            for (int i = 1; i <= n; i++)
            {
               factorial *= i;
            }
            Console.WriteLine(factorial);
        }
        

    }
}
