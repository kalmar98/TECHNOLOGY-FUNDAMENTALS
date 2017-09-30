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
            ulong n = ulong.Parse(Console.ReadLine());

            Console.WriteLine(IsPrime(n));

        }
        static bool IsPrime(ulong n)
        {
            ulong sqrtN = (ulong)Math.Sqrt(n);
            if (n <= 1)
            {
                return false;
            }
            else if (n >= 2)
            {
                for (ulong i = 2; i <= sqrtN; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        
       
    }   
}
