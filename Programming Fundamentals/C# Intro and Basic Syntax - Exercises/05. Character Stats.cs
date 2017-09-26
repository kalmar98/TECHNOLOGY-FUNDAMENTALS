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
            int currentHP = int.Parse(Console.ReadLine());
            int maxHP = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name} ");
            Console.WriteLine($"Health: |{new string('|',currentHP)}{new string('.',maxHP-currentHP)}|");
            Console.WriteLine($"Energy: |{new string('|', currentEnergy)}{new string('.', maxEnergy - currentEnergy)}|");


        }
    }
}