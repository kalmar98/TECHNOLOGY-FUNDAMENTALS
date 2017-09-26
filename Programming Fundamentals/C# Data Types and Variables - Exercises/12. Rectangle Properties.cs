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
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            double P = 2 * width + 2 * height;
            double S = width * height;
            double d = Math.Sqrt(Math.Pow(width,2) + Math.Pow(height,2));
            Console.WriteLine(P);
            Console.WriteLine(S);
            Console.WriteLine(d);


        }
        
    }
    
}
