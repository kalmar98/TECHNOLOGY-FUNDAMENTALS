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
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();


            while (true)
            {
                var command = Console.ReadLine().Split();
                
                if (command[0] == "Odd")
                {
                    list = list.Where(a => a % 2 != 0).ToList();
                    Console.WriteLine(string.Join(" ",list));
                    break;
                }
                else if(command[0] == "Even")
                {
                    list = list.Where(a => a % 2 == 0).ToList();
                    Console.WriteLine(string.Join(" ",list));
                    break;
                }
                else if(command[0] == "Delete")
                {
                    var element = int.Parse(command[1]);



                    list.RemoveAll(a => a == element);
                        
                    

                }
                else if(command[0] == "Insert")
                {
                    var element = int.Parse(command[1]);
                    var position = int.Parse(command[2]);
                    list.Insert(position, element);

                }
                



            }
        }
        
    }
}