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
            //Ako chetesh tova, ne go cheti! Grozno e! Pisah go na 99% zaspal! Ai mah sa!
            var listOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var amountOfRotations = uint.Parse(Console.ReadLine());
            int x = 0;
            var holdList = new List<int[]>();
         
            for (int i = 0; i < amountOfRotations; i++)
            {
                holdList.Add(new int[listOfNumbers.Count]);

                var currentList = new int[listOfNumbers.Count].ToList();
                var previousList = holdList[i-x];
                for (int y = 0; y < listOfNumbers.Count; y++)
                {

                    if (y == 0 && i==0)
                    {
                        currentList[y] = listOfNumbers.LastOrDefault();
                    }
                    else if(i==0)
                    {
                        currentList[y] = listOfNumbers[y-1];
                    }
                    if(y == 0 && i != 0)
                    {
                        currentList[y] = previousList.LastOrDefault();
                    }
                    else if (i != 0)
                    {
                        currentList[y] = previousList[y - 1];
                    }
                    if (y == listOfNumbers.Count - 1)
                    {
                        holdList[i] = currentList.ToArray();
                        x = 1;                                             
                    }                  
                }
            }
            int[] mnogoMiSeSpiIneMiDremeKvoPisha = new int[listOfNumbers.Count];
            foreach (var array in holdList)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    mnogoMiSeSpiIneMiDremeKvoPisha[i] += array[i];
                }
            }
            Console.WriteLine(string.Join(" ",mnogoMiSeSpiIneMiDremeKvoPisha));
        }
        
    
    }
}
