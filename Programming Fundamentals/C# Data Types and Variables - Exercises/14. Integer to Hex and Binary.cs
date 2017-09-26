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
            var input = int.Parse(Console.ReadLine());

            Console.WriteLine(Convert.ToString(input,16).ToUpper());
            Console.WriteLine(Convert.ToString(input, 2));

        }     
    }   
}
