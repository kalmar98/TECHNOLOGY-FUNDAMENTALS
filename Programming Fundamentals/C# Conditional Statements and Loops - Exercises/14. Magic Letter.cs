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
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char magicalLetter = char.Parse(Console.ReadLine());
            List<string> combinations = new List<string>();

            for (char i = first; i <=second; i++)
            {
                for (char y =first; y <=second; y++)
                {
                    for (char h = first; h <=second; h++)
                    {
                        if (i != magicalLetter && y != magicalLetter && h != magicalLetter)
                        {
                            string data = i.ToString() + y.ToString() + h.ToString();
                            combinations.Add(data);
                        }

                    }
                }
            }
            foreach (var combination in combinations)
            {
                Console.Write($"{combination} ");
            }
        }
    }
}
