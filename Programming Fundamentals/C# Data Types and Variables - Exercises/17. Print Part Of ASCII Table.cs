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
            var listChar = new List<char>();
            for (char i = (char)a; i <= b; i++)
            {
                listChar.Add(i);
            }
            Console.WriteLine(string.Join(" ",listChar));
        }
    }   
}
