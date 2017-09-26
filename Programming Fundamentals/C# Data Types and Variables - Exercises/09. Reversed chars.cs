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
            char[] input = { Convert.ToChar(Console.ReadLine()), Convert.ToChar(Console.ReadLine()), Convert.ToChar(Console.ReadLine()) };
            input = input.Reverse().ToArray();
            Console.WriteLine(input);
        }
        
    }
    
}
