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
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 2; i <= n; i++)
            {
                bool isPrime = true;
                for (int y = 2; y <= Math.Sqrt(i); y++)
                {
                    if (i % y == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write(i + " ");
                }
                

            }
        }
     

    }


}
