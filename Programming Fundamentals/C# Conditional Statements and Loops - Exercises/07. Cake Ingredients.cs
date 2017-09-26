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
            string input = Console.ReadLine();
            byte counter = 0;
            while (input != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {input}.");
                counter++;
                input = Console.ReadLine();
            }
            Console.WriteLine($"Preparing cake with {counter} ingredients.");

        }
    }     
}
