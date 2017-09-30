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
            int sizeOfArray = int.Parse(Console.ReadLine());
            char[] ArgumentsDelimiter = { ' ' };
            long[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();

            string command = Console.ReadLine();

            while (!command.Equals("stop"))
            {
                string[] line = command.Split();
                int[] arrayINT = new int[2];

                if (line[0]=="add" || line[0]=="subtract" || line[0]=="multiply" )
                {
                    
                    arrayINT[0] = int.Parse(line[1]);
                    arrayINT[1] = int.Parse(line[2]);

                    PerformAction(array, line[0], arrayINT);
                }

                if (line[0] == "lshift" || line[0] == "rshift")
                {
                    PerformAction(array, line[0], arrayINT);
                }

                PrintArray(array);
                

                command = Console.ReadLine();
            }
        }

        static void PerformAction(long[] arr, string action, int[] args)
        {
            
            int pos = args[0]-1;
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    arr[pos] *= value;
                    break;
                case "add":
                    arr[pos] += value;
                    break;
                case "subtract":
                    arr[pos] -= value;
                    break;
                case "lshift":
                    ArrayShiftLeft(arr);
                    break;
                case "rshift":
                    ArrayShiftRight(arr);
                    break;
            }
        }

        private static void ArrayShiftRight(long[] array)
        {
            long remake = array[array.Length - 1];
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (i > 0)
                {
                    array[i] = array[i - 1];
                }
                if (i == 0)
                {
                    array[i] = remake;
                }
               
                
                
            }
        }

        private static void ArrayShiftLeft(long[] array)
        {
            long remake = array[0];
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (i < array.Length - 1)
                {
                    array[i] = array[i + 1];
                }
                if (i == array.Length - 1)
                {
                    array[i] = remake;
                }
            }
        }

        private static void PrintArray(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    
    }
}
