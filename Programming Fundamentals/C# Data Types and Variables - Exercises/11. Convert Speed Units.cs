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
            var distance = float.Parse(Console.ReadLine());
            var hours = float.Parse(Console.ReadLine());
            var minutes = float.Parse(Console.ReadLine());
            var seconds = float.Parse(Console.ReadLine());

            float metersSecond = distance / (hours*60*60+minutes*60+seconds);
            float kilometersHour = (distance / 1000) / (hours + minutes / 60 + seconds / 3600);
            float milesHour = (distance/1609)/ (hours + minutes / 60 + seconds / 3600);

            Console.WriteLine(metersSecond);
            Console.WriteLine(kilometersHour);
            Console.WriteLine(milesHour);

        }
        
    }
    
}
