using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopsTut_For
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            var Phonebook = new SortedDictionary<string, string>();
            while (input[0] != "END")
            {
                if (input[0] == "A")
                {
                    string name = input[1];
                    string number = input[2];
                    if (Phonebook.ContainsKey(name))
                    {
                        Phonebook[name] = number;
                    }
                    else
                    {
                        Phonebook.Add(name, number);
                    }
                }
                else if (input[0] == "S")
                {
                    string searchedName = input[1];
                    if (Phonebook.ContainsKey(searchedName))
                    {
                        Console.WriteLine($"{searchedName} -> {Phonebook[searchedName]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {searchedName} does not exist.");
                    }
                }
                else
                {
                    foreach (var pair in Phonebook)
                    {
                        string name = pair.Key;
                        string number = pair.Value;
                        Console.WriteLine($"{name} -> {number}");
                    }
                }


                input = Console.ReadLine().Split();
            }
        }
    }
}