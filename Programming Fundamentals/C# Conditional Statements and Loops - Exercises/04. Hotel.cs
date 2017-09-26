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
            var month = Console.ReadLine();
            byte night = byte.Parse(Console.ReadLine());

            double studioPrice = 0;
            double doublePrice = 0;
            double suitePrice = 0;
            

            if (month=="May" || month == "October")
            {
                if (night > 7)
                {
                    if(month == "October")
                    {
                        studioPrice = (night - 1) * 0.95 * 50;
                    }
                    else
                    {
                        studioPrice = night * 0.95 * 50;
                    }
                    
                }
                else
                {
                    studioPrice = night  * 50;
                }
                doublePrice = night * 65;

                
                suitePrice = night * 75;
                
                
            }
            else if (month=="June" || month=="September")
            {
                if (night > 14)
                {
                    doublePrice = night * 72 * 0.90;
                }
                else
                {
                    doublePrice = night * 72;
                }
                if (month == "September")
                {
                    studioPrice = (night-1) * 60;
                }
                else
                {
                    studioPrice = night * 60;
                }
                suitePrice = night * 82;
                

            }
            else if(month=="July" || month=="December" || month == "August")
            {
                if (night > 14)
                {
                    suitePrice = night * 89 * 0.85;
                }
                else
                {
                    suitePrice = night * 89;
                }
                studioPrice = night * 68;
                doublePrice = night * 77;
            }

            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
            Console.WriteLine($"Double: {doublePrice:f2} lv.");
            Console.WriteLine($"Suite: {suitePrice:f2} lv.");
        }
    }     
}
