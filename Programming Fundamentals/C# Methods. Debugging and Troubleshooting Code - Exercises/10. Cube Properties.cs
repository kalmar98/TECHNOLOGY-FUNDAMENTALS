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
            double a = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double output = 0;
            switch (input)
            {

                case "face":
                    output = Math.Sqrt(2*Math.Pow(a,2));
                    break;
                case "space":
                    output = Math.Sqrt(3 * Math.Pow(a, 2));
                    break;
                case "volume":
                    output = Math.Pow(a, 3);
                    break;
                case "area":
                    output = 6 * Math.Pow(a, 2);
                    break;
            }
            Console.WriteLine($"{output:f2}");
      
           
        }

       
    }
}
