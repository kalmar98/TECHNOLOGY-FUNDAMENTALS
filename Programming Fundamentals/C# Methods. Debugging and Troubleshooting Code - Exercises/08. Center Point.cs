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
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            CenterPodouble(x1, y1, x2, y2);
        }
        static void CenterPodouble(double x1,double y1,double x2,double y2)
        {
            double d1 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double d2 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));
            
            if (d1 <= d2)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }


        }
     

        
  



    }
}
