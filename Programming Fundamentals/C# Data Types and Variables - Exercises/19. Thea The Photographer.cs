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
            //Bring Me The Horizon - Empire 
            ulong amountPictures = ulong.Parse(Console.ReadLine());
            ulong filterTimePerPicture = ulong.Parse(Console.ReadLine());
            double filterFactor = double.Parse(Console.ReadLine())/100;
            ulong uploadTimePerPicture = ulong.Parse(Console.ReadLine());

            ulong filteredPictures = (ulong)(Math.Ceiling(amountPictures * filterFactor));
            ulong totalTimeInSeconds = (amountPictures * filterTimePerPicture) + (filteredPictures * uploadTimePerPicture);
            

            TimeSpan wholeTime = TimeSpan.FromSeconds(totalTimeInSeconds);

            Console.WriteLine($"{wholeTime.Days}:{wholeTime.Hours:d2}:{wholeTime.Minutes:d2}:{wholeTime.Seconds:d2}");
        }
    }   
}
