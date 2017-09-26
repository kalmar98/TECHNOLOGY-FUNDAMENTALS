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
            var profession = Console.ReadLine();
            var quantity = uint.Parse(Console.ReadLine());
            var drink = "";
            var price = 0.0;
            if(profession == "Athlete")
            {
                drink = "Water";
                price = 0.70;
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                drink = "Coffee";
                price = 1.00;
            }
            else if (profession == "SoftUni Student")
            {
                drink = "Beer";
                price = 1.70;
            }
            else
            {
                drink = "Tea";
                price = 1.20;
            }
            double payment = price * quantity;
            Console.WriteLine($"The {profession} has to pay {payment:f2}.");

        }
    }  
}
