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
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int magicalNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            List<string> combinations = new List<string>();
            for (int i = a; i <= b; i++)
            {
                for (int x = a; x <= b; x++)
                {
                    if(i+x==magicalNumber)
                    {
                        string y = $"{i} + {x} = {magicalNumber}";
                        combinations.Add(y);
                    }

                    counter++;
                }
            }

            if (combinations.Count > 0)
            {
                Console.WriteLine($"Number found! {combinations[combinations.Count-1]}");
                
            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicalNumber}");
            }

        }
    }
}
