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

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (Math.Abs(a - b) < 5)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int first = a; first <= b; first++)
                {
                    for (int second = a; second <= b; second++)
                    {
                        for (int third = a; third <= b; third++)
                        {
                            for (int forth = a; forth <= b; forth++)
                            {
                                for (int fifth = a; fifth <= b; fifth++)
                                {
                                    if (second <= first || third <= second || forth <= third || fifth <= forth) continue;

                                    else
                                    {
                                        Console.Write(first + " ");
                                        Console.Write(second + " ");
                                        Console.Write(third + " ");
                                        Console.Write(forth + " ");
                                        Console.WriteLine(fifth);
                                    }
                                }
                            }
                        }
                    }
                }


            }        
    }     
}
}
