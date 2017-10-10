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
            var names_Ips_Durations = new SortedDictionary<string, SortedDictionary<string, int>>();

            var numberOfInputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfInputs; i++)
            {
                var singleInput = Console.ReadLine();

                var tokens = singleInput.Split();

                var name = tokens[1];
                var ip = tokens[0];
                var duration = int.Parse(tokens[2]);

                if (!names_Ips_Durations.ContainsKey(name))
                {
                    names_Ips_Durations[name] = new SortedDictionary<string, int>();
                }
                if (!names_Ips_Durations[name].ContainsKey(ip))
                {
                    names_Ips_Durations[name][ip] = 0;
                }
                names_Ips_Durations[name][ip] +=duration;

            }
            foreach (var nameIPsDurations in names_Ips_Durations)
            {
                var name = nameIPsDurations.Key;
                var IPsDurations = nameIPsDurations.Value;

                var totalDuration = IPsDurations.Sum(a => a.Value);
                var ips = IPsDurations.Keys;

                Console.WriteLine($"{name}: {totalDuration} [{string.Join(", ",ips)}]");
            }
        }
    }
}