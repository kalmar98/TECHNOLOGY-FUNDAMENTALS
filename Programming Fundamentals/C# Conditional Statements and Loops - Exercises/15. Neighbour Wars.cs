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
            //Pesho VS Gosho
            //
            int peshoHealth = 100;
            int goshoHealth = 100;

            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());

            //Pesho ODD
            //Gosho EVEN

            uint turns = 0;

            while (true)
            {
                



                turns++;

                if (turns % 2 == 0)
                {
                    peshoHealth -= goshoDamage;
                    if (peshoHealth <= 0 || goshoHealth <= 0)
                    {
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");


                }
                else
                {
                    goshoHealth -= peshoDamage;
                    if (peshoHealth <= 0 || goshoHealth <= 0)
                    {
                        break;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                }
                if (turns % 3 == 0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }
                

            }

            if (peshoHealth > 0)
            {
                Console.WriteLine($"Pesho won in {turns}th round.");
            }
            else
            {
                Console.WriteLine($"Gosho won in {turns}th round.");
            }
            
        }
    }
}
