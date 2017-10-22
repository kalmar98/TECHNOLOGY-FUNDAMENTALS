using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Numerics;
using System.Globalization;
using System.IO;



namespace training
{
    class Training
    {
        static void Main()
        {
            var input = File.ReadAllLines("input.txt");

            var namesEmails = new Dictionary<string, string>();
            int counter = 0;
            while (input[counter] != "stop")
            {
                var name = input[counter];
                var email = input[counter + 1];

                namesEmails[name] = email;

                counter += 2;
            }

            var fixedEmails = namesEmails
                .Where(a => !(a.Value.EndsWith("us") || a.Value.EndsWith("uk")))
                .ToDictionary(a => a.Key, a => a.Value);
            var output = new List<string>();
            foreach (var nameEmail in fixedEmails)
            {

                var name = nameEmail.Key;
                var email = nameEmail.Value;
                output.Add($"{name} -> {email}");
            }
            File.WriteAllLines("output.txt", output.ToArray());

        }
        
    }
}
