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
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            
            Console.WriteLine(GetMax(a, b, c));

        }
        static int GetMax(int a,int b,int c)
        {
            //1 20 30
            if(a >= b && a >= c)
            {
                return a;
            }
            else if (c >= a && c >= b)
            {
                return c;
            }
            else if (b >= a && b >= c)
            {
                return b;
            }
            else
            {
                return 0;
            }

        }
       
    }   
}
