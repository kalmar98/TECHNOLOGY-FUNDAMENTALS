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
            var _nameAndStudentObject = new Dictionary<string, Student>();

            while (true)
            {
                var input = Console.ReadLine();
                if(input=="end of dates")
                {
                    break;
                }
                var data = input.Split(' ',',');
                var name = data[0];

                if (!_nameAndStudentObject.ContainsKey(name))
                {
                    
                    _nameAndStudentObject[name] = new Student { Comments = new List<string>(), Attendance = new List<DateTime>() };


                    for (int i = 1; i < data.Length; i++)
                    {
                        _nameAndStudentObject[name].Attendance.Add(DateTime.ParseExact(data[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                    }
                }
                else
                {
                    for (int i = 1; i < data.Length; i++)
                    {
                        _nameAndStudentObject[name].Attendance.Add(DateTime.ParseExact(data[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                    }
                }

            }

            while (true)
            {
                var input = Console.ReadLine();
                if(input=="end of comments")
                {
                    break;
                }
                var data = input.Split('-');
                if (_nameAndStudentObject.ContainsKey(data[0]))
                {
                    _nameAndStudentObject[data[0]].Comments.Add(data[1]);

                }

            }

            _nameAndStudentObject = _nameAndStudentObject.OrderBy(a => a.Key).ToDictionary(a => a.Key, a => a.Value);

            foreach (var nameStudent in _nameAndStudentObject)
            {
                var name = nameStudent.Key;
                var student = nameStudent.Value;
                Console.WriteLine(name);
                Console.WriteLine("Comments:");
                foreach (var comment in student.Comments)
                {
                    Console.WriteLine("- " + comment);
                }
                Console.WriteLine("Dates attended:");
                foreach (var date in student.Attendance.OrderBy(a=>a))
                {
                    Console.WriteLine("-- "+ date.ToString("dd/MM/yyyy",CultureInfo.GetCultureInfo("en-US")));
                }

            }




        }
    }
    class Student
    {
        public List<string> Comments { get; set; }
        public List<DateTime> Attendance { get; set; }
    }
}
