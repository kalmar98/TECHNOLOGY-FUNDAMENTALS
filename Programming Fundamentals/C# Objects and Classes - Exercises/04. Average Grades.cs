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
            int n = int.Parse(Console.ReadLine());
            var students = new List<Student>();
            
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var everyStudent = new Student()
                {
                    name = input[0],
                    grades = input.Skip(1).Select(double.Parse).ToList()
                };
                
                
                students.Add(everyStudent);

            }

            
            

            foreach (var student in students.Where(a => a.averageGrade >= 5.00).OrderBy(a => a.name).ThenByDescending(a=>a.averageGrade))
            {
                Console.WriteLine($"{student.name} -> {student.averageGrade:f2}");
            }

        }

        
    }

    class Student
    {
        public string name { get; set; }
        public List<double> grades { get; set; }
        public double averageGrade => this.grades.Average();
        
    }

}