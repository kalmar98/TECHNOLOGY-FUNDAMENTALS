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
            var namesEmails = new Dictionary<string, string>();
            var input = Console.ReadLine();
            while (input != "stop")
            {
                var name = input;
                var email = Console.ReadLine();

                namesEmails[name] = email;

                input = Console.ReadLine();
            }

            var fixedEmails = namesEmails
                .Where(keyValuePair => !(keyValuePair.Value.EndsWith("us") || keyValuePair.Value.EndsWith("uk")))
                .ToDictionary(kvp=>kvp.Key,kvp=>kvp.Value);
            foreach (var nameEmail in fixedEmails)
            {

                var name = nameEmail.Key;
                var email = nameEmail.Value;
                Console.WriteLine($"{name} -> {email}");
            }
            

        }
    }
}