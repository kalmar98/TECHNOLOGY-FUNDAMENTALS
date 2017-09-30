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
            var input = Console.ReadLine().ToLower().ToCharArray();
            foreach (var _char in input)
            {
                Console.WriteLine($"{_char} -> {Convert.ToInt32(_char)-97}");
            }         
        }   
    }
}
