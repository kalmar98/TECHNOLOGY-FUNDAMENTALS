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
            CalculateAre(Console.ReadLine());
      
           
        }

        static void CalculateAre(string input)
        {
            switch (input)
            {
                case "triangle":
                    Console.WriteLine($"{Triangle(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())):f2}");
                    break;
                case "square":
                    Console.WriteLine($"{Square(double.Parse(Console.ReadLine())):f2}");
                    break;
                case "rectangle":
                    Console.WriteLine($"{Rectangle(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())):f2}");
                    break;
                case "circle":
                    Console.WriteLine($"{Circle(double.Parse(Console.ReadLine())):f2}");
                    break;
            }
        }
        static double Triangle(double side, double height)
        {
            double output = 0.5 * side * height;
            return output;
        }
        static double Square(double side)
        {
            double output = side * side;
            return output;
        }
        static double Rectangle(double width, double height)
        {
            double output = width * height;
            return output;
        }
        static double Circle(double radius)
        {
            double output = Math.PI * radius * radius;
            return output;
        }

    }
}
