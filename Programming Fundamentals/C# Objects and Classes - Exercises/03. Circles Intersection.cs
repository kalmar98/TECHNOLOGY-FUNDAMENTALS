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
            Circle circle1 = ReadCircle(),circle2 = ReadCircle();
            double deltaX = circle1.Center.x - circle2.Center.x;
            double deltaY = circle1.Center.y - circle2.Center.y;
            double d = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            if (d > circle1.Radius + circle2.Radius)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }
        }

        static Circle ReadCircle()
        {
            var data = Console.ReadLine().Split().Select(double.Parse).ToArray();

            return new Circle
            {
                Center = new Point
                {
                    x = data[0],
                    y = data[1]

                },
                Radius = data[2],
            };
        }
    }

    class Point
    {
        public double x { get; set; }
        public double y { get; set; }
        
    }

    class Circle
    {
        public Point Center { get;set; }
        public double Radius { get; set; }

        

    }

}