using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Numerics;


namespace training
{
    class Training
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            var command = Console.ReadLine();

            while (command!="print")
            {
                var data = command.Split();

                switch (data[0])
                {
                    case "add":
                        input.Insert(int.Parse(data[1]), int.Parse(data[2]));
                        break;
                    case "addMany":
                        int[] rangeOfNumbers = data.Skip(2).Select(int.Parse).ToArray();
                        input.InsertRange(int.Parse(data[1]), rangeOfNumbers);
                        break;
                    case "contains":
                        if (input.Contains(int.Parse(data[1])))
                            Console.WriteLine(input.IndexOf(int.Parse(data[1])));
                        else
                            Console.WriteLine("-1");
                        break;
                    case "remove":
                        input.RemoveAt(int.Parse(data[1]));
                        break;
                    case "shift":
                        for (int i = 0; i < int.Parse(data[1]); i++)
                        {
                            input.Insert(input.Count, input.First());
                            input.RemoveAt(0);
                        }
                       
                        break;
                    case "sumPairs":
                        var newList = new List<int>();
                        if (input.Count % 2 == 0)
                        {    
                            for (int i = 0; i < input.Count; i++)
                            {
                                var currentNumber = input[i] + input[i + 1];
                                
                                newList.Add(currentNumber);
                                i++;
                            }
                        }
                        else
                        {
                            //1 2 3 4 5               4
                            for (int i = 0; i < input.Count-1; i++)
                            {
                                var currentNumber = input[i] + input[i + 1];

                                newList.Add(currentNumber);
                                i++;
                            }
                            newList.Add(input.Last());
                        }
                        input = newList;
                        break;

                }

                command = Console.ReadLine();
            }
            Console.Write("[");
            Console.Write(string.Join(", ",input));
            Console.Write("]");
        }
        
    }
}