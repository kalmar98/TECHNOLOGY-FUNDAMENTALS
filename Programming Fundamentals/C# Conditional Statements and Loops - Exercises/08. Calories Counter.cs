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
            ushort Cheese = 500;
            ushort TomatoSauce = 150;
            ushort Salami = 600;
            ushort Pepper = 50;
            uint total = 0;
            string[] ingridients = { "Cheese","Tomato Sauce","Salami","Pepper" };

            for (int i = 0; i < n; i++)
            {
                var ingridient = Console.ReadLine();
                if (ingridient.Equals(ingridients[0], StringComparison.CurrentCultureIgnoreCase))
                {
                    total += Cheese;
                }
                if (ingridient.Equals(ingridients[1], StringComparison.CurrentCultureIgnoreCase))
                {
                    total += TomatoSauce;
                }
                if (ingridient.Equals(ingridients[2], StringComparison.CurrentCultureIgnoreCase))
                {
                    total += Salami;
                }
                if (ingridient.Equals(ingridients[3], StringComparison.CurrentCultureIgnoreCase))
                {
                    total += Pepper;
                }
            }
            Console.WriteLine($"Total calories: {total}");
        }
    }     
}
