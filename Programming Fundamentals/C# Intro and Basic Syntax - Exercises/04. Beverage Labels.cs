using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopsTut_For
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();
            double volumeML = double.Parse(Console.ReadLine());
            double energy100ml = double.Parse(Console.ReadLine());
            double sugar100ml = double.Parse(Console.ReadLine());
            Console.WriteLine($"{volumeML}ml {name}: ");
            Console.WriteLine($"{energy100ml*volumeML/100.0}kcal, {sugar100ml*volumeML/100.0}g sugars");

        }
    }
}