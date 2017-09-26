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
            double a = (double.Parse(Console.ReadLine()));
            double b = (double.Parse(Console.ReadLine()));
            bool equal = Math.Abs(a - b) < 0.000001;
            Console.WriteLine(equal);


        }
    }   
}
