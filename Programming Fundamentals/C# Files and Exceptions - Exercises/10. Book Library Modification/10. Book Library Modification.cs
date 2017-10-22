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
            
            var library = new Library()
            {
                Name = "SoftUni's Library",
                Books = new List<Book>()
            };
            for (int i =1; i <= int.Parse(input[0]); i++)
            {
                var data = input[i].Split();

                var title = data[0];

                var releaseDate = DateTime.ParseExact(data[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);


                var book = new Book(title, releaseDate);

                library.Books.Add(book);
            }

            var inputDate = DateTime.ParseExact(input.Last(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            var booksAfterInputDate = library.Books.Where(a => a.ReleaseDate > inputDate).Distinct().ToList();
            var output = new List<string>();
            foreach (var book in booksAfterInputDate.OrderBy(a => a.ReleaseDate).ThenBy(a => a.Title))
            {
                var onlyDate = book.ReleaseDate.ToString("dd.MM.yyyy");

                output.Add($"{book.Title} -> {onlyDate}");
            }
            File.WriteAllLines("output.txt", output.ToArray());
        }
            

        
        
    }

    class Book
    {

        public Book(string title, DateTime releaseDate)
        {
            Title = title;

            ReleaseDate = releaseDate;

        }

        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }

    }

    class Library
    {
        public string Name { get; set; }

        public List<Book> Books { get; set; }
    }
}
