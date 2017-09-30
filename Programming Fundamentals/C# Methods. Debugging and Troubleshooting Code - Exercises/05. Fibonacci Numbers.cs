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
            int n = int.Parse(Console.ReadLine());

            int first = 1;
            int second = 1;

            var listOfNumbers = new List<int>();
            listOfNumbers.Add(first);
            listOfNumbers.Add(second);

            for (int i = 0; i < n; i++)
            {
                if (i > 0)
                {
                    int next = listOfNumbers[i] + listOfNumbers[i - 1];
                    listOfNumbers.Add(next);
                }
                
            }
            Console.WriteLine(listOfNumbers.LastOrDefault());

        }

        
       
    }   
}
