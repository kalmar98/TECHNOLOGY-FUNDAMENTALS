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

            char[] firstArray = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] secondArray = Console.ReadLine().Split().Select(char.Parse).ToArray();

            var list = new List<string>();

            string firstString = new string(firstArray);
            string secondString = new string(secondArray);

            if (firstString == secondString)
            {
                Console.WriteLine(firstString);
                Console.WriteLine(firstString);
                return;
            }

            


            //anna
            //an

            if (firstArray[0] == secondArray[0])
            {
                int minimum = Math.Min(firstArray.Length, secondArray.Length);
                int counter = 0;
                for (int i = 0; i <minimum; i++) 
                {

                    if (firstArray[i] == secondArray[i])
                    {
                        counter++;
                    }

                }

                if (counter == minimum)
                {
                    if (firstArray.Length < secondArray.Length)
                    {
                        Console.WriteLine(firstString);
                        Console.WriteLine(secondString);
                    }
                    else
                    {
                        Console.WriteLine(secondString);
                        Console.WriteLine(firstString);
                    }
                }
                else
                {
                    if (firstArray.Length < secondArray.Length)
                    {
                        Console.WriteLine(secondString);
                        Console.WriteLine(firstString);
                    }
                    else
                    {
                        Console.WriteLine(firstString);
                        Console.WriteLine(secondString);
                    }
                }
            }
            else
            {
                list.Add(firstString);
                list.Add(secondString);

                list = list.OrderBy(a => a).ToList();

                Console.WriteLine(list[0]);
                Console.WriteLine(list[1]);
            }
        }   
    }
}
