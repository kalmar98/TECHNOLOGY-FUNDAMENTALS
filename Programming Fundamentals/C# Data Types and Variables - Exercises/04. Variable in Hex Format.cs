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
            string hexadecimalFormat = Console.ReadLine();

            int decimalFormat = Convert.ToInt32(hexadecimalFormat, 16);

            Console.WriteLine(decimalFormat);

        }
    }
}
