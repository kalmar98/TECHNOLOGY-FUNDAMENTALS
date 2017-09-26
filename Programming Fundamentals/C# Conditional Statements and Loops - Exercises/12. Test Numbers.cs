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
            byte a = byte.Parse(Console.ReadLine());
            byte b = byte.Parse(Console.ReadLine());

            uint end = uint.Parse(Console.ReadLine());
            uint sum = 0;
            uint counter = 0;
            for (int i = a; i >= 1; i--)
            {
                for (int y = 1; y <=b; y++)
                {
                    string combination = i.ToString() + y.ToString();
                    uint combinationInInt = uint.Parse(combination);
                    
                    sum += (uint)(y * i * 3);
                    counter++;
                    if (sum >= end)
                    {

                        Console.WriteLine($"{counter} combinations");
                        Console.WriteLine($"Sum: {sum} >= {end}");

                        break;
                    }
                    


                }
                if (sum >= end)
                    return;
            }
            if (sum >= end)
                return;
            Console.WriteLine($"{counter} combinations");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
