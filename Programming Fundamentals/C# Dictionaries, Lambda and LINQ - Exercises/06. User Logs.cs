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
            var input = Console.ReadLine();
            var IPsMessagesUsers = new SortedDictionary<string, Dictionary<string, byte>>();

            while (input != "end")
            {
                string[] line = input.Split(' ','=');
                string ip = line[1];
                
                string user = line[5];

                if (!IPsMessagesUsers.ContainsKey(user))
                {
                    IPsMessagesUsers[user] = new Dictionary<string, byte>();

                }
                if (!IPsMessagesUsers[user].ContainsKey(ip))
                {
                    IPsMessagesUsers[user][ip] = 0;
                }
               IPsMessagesUsers[user][ip]++;


                input = Console.ReadLine(); ;
            }

            foreach (var pkv in IPsMessagesUsers)
            {
                var user = pkv.Key;
                var IPsAndMessages = pkv.Value;
                var IPs = IPsAndMessages.Keys.ToArray();
                var Messages = IPsAndMessages.Values.ToArray();

                Console.WriteLine($"{user}:");
                for(int i = 0; i < IPsAndMessages.Count; i++)
                {
                    Console.Write($"{IPs[i]} => {Messages[i]}");
                    if(i == IPsAndMessages.Count - 1)
                    {
                        Console.Write('.');
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write(", ");
                    }
                    
                    
                }


            }
            
        }
    }
}