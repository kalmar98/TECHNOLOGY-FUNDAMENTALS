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
            byte firstNumber = byte.Parse(Console.ReadLine());
            byte secondNumber = byte.Parse(Console.ReadLine());

            byte diff = Convert.ToByte(Math.Abs(firstNumber - secondNumber));

            if (firstNumber > secondNumber)
            {
                for (byte i = secondNumber; i <= firstNumber; i++)
                {
                    Console.WriteLine(i);
                } 
            }
            else
            {
                for(byte i = firstNumber; i <= secondNumber; i++)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }     
}
