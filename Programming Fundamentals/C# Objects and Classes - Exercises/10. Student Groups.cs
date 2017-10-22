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
            var input = Console.ReadLine();
            var towns = new List<Town>();
            var groupCounter = 0;
            var townCounter = -1;
            var TownAndGroups = new Dictionary<string, int>();
            while (true)
            {

                if (input == "End")
                {
                    break;
                }
                //ne e nai-umnata logika ama staa za sq ...
                var data = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (data[data.Length - 1] == "seats" || data[data.Length - 1] == "seat")  // slagam "seat" za vseki sluchai, kek
                {
                    var seats = data[data.Length - 2];
                    var townName = "";
                    for (int i = 0; i < data.Length - 3; i++)
                    {
                        if (i == 0)
                        {
                            townName = data[0];
                        }
                        else
                        {
                            townName += " ";
                            townName += data[i];
                        }
                    }
                    Town town = new Town { Name = townName, SeatsCount = int.Parse(seats), Students = new List<Student>() };
                    towns.Add(town);
                    townCounter++;

                    if (!TownAndGroups.ContainsKey(townName))
                    {
                        TownAndGroups[townName] = 0;
                    }



                }
                else
                {
                    var studentInfo = input.Split(new[] { '|', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    var name = studentInfo[0] + " " + studentInfo[1];
                    var email = studentInfo[2];
                    var regDate = DateTime.ParseExact(studentInfo[3], "d-MMM-yyyy", CultureInfo.InvariantCulture);
                    var student = new Student { Name = name, Email = email, RegistrationDate = regDate };
                    towns[townCounter].Students.Add(student);


                }

                input = Console.ReadLine();
            }

            foreach (var town in towns)
            {
                var counter = town.Students.Count;
                while (counter > 0)
                {
                    counter -= town.SeatsCount;
                    TownAndGroups[town.Name]++;
                }
            }
            groupCounter = TownAndGroups.Values.Sum();

            Console.Write($"Created {groupCounter} groups in {townCounter + 1} towns:");

            foreach (var town in towns.OrderBy(a => a.Name))
            {
                town.Students = town.Students.OrderBy(a => a.RegistrationDate).ThenBy(a => a.Name).ThenBy(a => a.Email).ToList();
                //6 count 5 seats

                int border = (int)Math.Ceiling(town.Students.Count / (double) town.SeatsCount);
                for (int i = 0; i < border; i++)
                {
                    Console.WriteLine();
                    Console.Write($"{town.Name} => ");
                    var list = town.Students.Take(town.SeatsCount).Select(a=>a.Email).ToList();
                    Console.Write(string.Join(", ",list));

                    if (town.Students.Count > town.SeatsCount)
                    {
                        town.Students.RemoveRange(0, town.SeatsCount);
                    }
                        
                    
                    
                    
                }
                

            }
            Console.WriteLine();



        }

    }
    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }

    }
    class Town
    {
        public string Name { get; set; }
        public int SeatsCount { get; set; }
        public List<Student> Students { get; set; }

    }

}
