using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace training
{
    class Program
    {
        static void Main()
        {
            byte n = byte.Parse(Console.ReadLine());

            for (byte i = 1; i <= n; i++)
            {
                for (byte y = 1; y <= i; y++)
                {
                    Console.Write("{0} ",i);
                }
                Console.WriteLine();
            }
        }        
    }     
}
