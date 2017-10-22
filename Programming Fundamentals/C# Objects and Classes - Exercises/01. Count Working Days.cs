using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Globalization;


namespace loopsTut_For
{
    class Program
    {
        static void Main()
        {
            var firstDate = Console.ReadLine();
            var secondDate = Console.ReadLine();
            var StartDate = DateTime.ParseExact(firstDate, "d-M-yyyy", CultureInfo.InvariantCulture);
            var EndDate = DateTime.ParseExact(secondDate, "d-M-yyyy", CultureInfo.InvariantCulture);
            DateTime[] Holidays = new DateTime[]
            {
                new DateTime(4,01,01),
                new DateTime(4,03,03),
                new DateTime(4, 05, 01),
                new DateTime(4, 05, 06),
                new DateTime(4, 05, 24),
                new DateTime(4, 09, 06),
                new DateTime(4, 09, 22),
                new DateTime(4, 11, 01),
                new DateTime(4, 12, 24),
                new DateTime(4, 12, 25),
                new DateTime(4, 12, 26),
            };

            uint workinDayz = 0;

            for (DateTime i = StartDate; i <=EndDate; i=i.AddDays(1))
            {
                DayOfWeek day = i.DayOfWeek;
                DateTime check = new DateTime(4, i.Month, i.Day);

                if (!Holidays.Contains(check) && (!day.Equals(DayOfWeek.Saturday) && !day.Equals(DayOfWeek.Sunday)))
                {
                    workinDayz++;
                }

            }
            Console.WriteLine(workinDayz);

        }
    }

}