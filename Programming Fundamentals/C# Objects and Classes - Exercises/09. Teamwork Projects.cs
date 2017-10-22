using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Numerics;
using System.Globalization;


namespace training
{
    class Training
    {
        static void Main()
        {
            var countOfTeams = int.Parse(Console.ReadLine());

            var Teams = new Dictionary<string, Team>();

            var existingPeople = new List<string>();

            for (int i = 0; i < countOfTeams; i++)
            {
                var input = Console.ReadLine().Split('-');

                if (Teams.ContainsKey(input[1]))
                {
                    Console.WriteLine($"Team {input[1]} was already created!");
                    goto end;
                }


                if (!Teams.ContainsKey(input[1]) && !existingPeople.Contains(input[0]))
                {
                    Teams[input[1]] = new Team { Creator = input[0], NameOfTeam = input[1], Members = new List<string>() };

                    existingPeople.Add(input[0]);


                    Console.WriteLine($"Team {input[1]} has been created by {input[0]}!");
                }
                else
                {
                    Console.WriteLine($"{input[0]} cannot create another team!");
                    goto end;
                }

                end:;
            }

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end of assignment")
                {
                    break;
                }

                var data = input.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                if (!Teams.ContainsKey(data[1]))
                {
                    Console.WriteLine($"Team {data[1]} does not exist!");
                    goto end;
                }
                else
                {
                    if (existingPeople.Contains(data[0]))
                    {
                        Console.WriteLine($"Member {data[0]} cannot join team {data[1]}!");
                    }
                    else
                    {
                        Teams[data[1]].Members.Add(data[0]);
                        existingPeople.Add(data[0]);
                    }
                }

                end:;
            }

            


            foreach (var kvp in Teams.Where(a=>a.Value.Members.Count>0).OrderByDescending(a=>a.Value.Members.Count).ThenBy(a=>a.Value.NameOfTeam))
            {
                Console.WriteLine(kvp.Key);
                Console.WriteLine($"- {kvp.Value.Creator}");
                foreach (var member in kvp.Value.Members.OrderBy(a=>a))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (var kvp in Teams.Where(a=>a.Value.Members.Count==0).OrderBy(a=>a.Value.NameOfTeam))
            {
                Console.WriteLine(kvp.Key);
            }


        }
    }
    class Team
    {        
        public string Creator { get; set; }
        public string NameOfTeam { get; set; }
        public List<string> Members { get; set; }
    }
    
}
