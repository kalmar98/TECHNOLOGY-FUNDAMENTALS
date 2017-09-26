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
            var smallHallprice = 2500;
            var smallHallcapacity = 50;

            var terracePrice = 5000;
            var terraceCapacity = 100;

            var greatHallprice = 7500;
            var greatHallcapacity = 120;

            var normalDiscount = 0.95;
            var normalPrice = 500;

            var goldDiscount = 0.90;
            var goldPrice = 750;

            var platinumDiscount = 0.85;
            var platinumPrice = 1000;

            uint groupSize = uint.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            double totalPrice = 0;
            double pricePerPerson = 0;

            if (groupSize <= smallHallcapacity)
            {
                if(package == "Normal")
                {
                    totalPrice = (smallHallprice + normalPrice)*normalDiscount;
                }
                else if(package == "Gold")
                {
                    totalPrice = (smallHallprice + goldPrice)*goldDiscount;
                }
                else if(package == "Platinum")
                {
                    totalPrice = (smallHallprice + platinumPrice)*platinumDiscount;
                }
                pricePerPerson = totalPrice / groupSize;
                Console.WriteLine("We can offer you the Small Hall");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }
            else if (groupSize<=terraceCapacity && groupSize>smallHallcapacity)
            {
                if (package == "Normal")
                {
                    totalPrice = (terracePrice + normalPrice)*normalDiscount;
                }
                else if (package == "Gold")
                {
                    totalPrice = (terracePrice + goldPrice) * goldDiscount ;
                }
                else if (package == "Platinum")
                {
                    totalPrice = (terracePrice + platinumPrice)*platinumDiscount;
                }
                pricePerPerson = totalPrice / groupSize;
                Console.WriteLine("We can offer you the Terrace");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }
            else if(groupSize<=greatHallcapacity && groupSize > terraceCapacity)
            {
                if (package == "Normal")
                {
                    totalPrice = (greatHallprice + normalPrice)*normalDiscount;
                }
                else if (package == "Gold")
                {
                    totalPrice = (greatHallprice + goldPrice)*goldDiscount;
                }
                else if (package == "Platinum")
                {
                    totalPrice = (greatHallprice + platinumPrice)*platinumDiscount;
                }
                pricePerPerson = totalPrice / groupSize;
                Console.WriteLine("We can offer you the Great Hall");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");

            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }

        }
    }  
    
}
