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
            

            var students = new List<Student>();

            for (int i = 1; i <= int.Parse(input[0]); i++)
            {
                var data = input[i].Split();
                var everyStudent = new Student()
                {
                    name = data[0],
                    grades = data.Skip(1).Select(double.Parse).ToList()
                };


                students.Add(everyStudent);

            }
            var output = new List<string>();
            foreach (var student in students.Where(a => a.averageGrade >= 5.00).OrderBy(a => a.name).ThenByDescending(a => a.averageGrade))
            {
                output.Add($"{student.name} -> {student.averageGrade:f2}");
            }
            File.WriteAllLines("output.txt", output.ToArray());
        }
            

        
        
    }
    class Student
    {
        public string name { get; set; }
        public List<double> grades { get; set; }
        public double averageGrade => this.grades.Average();

    }
}
