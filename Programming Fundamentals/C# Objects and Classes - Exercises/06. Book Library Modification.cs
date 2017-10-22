using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace loopsTut_For
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var library = new Library()
            {
                Name = "SoftUni's Library",
                Books = new List<Book>()
            };
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();

                var title = input[0];

                var releaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                

                var book = new Book(title, releaseDate);

                library.Books.Add(book);
            }

            var inputDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
         
            var booksAfterInputDate = library.Books.Where(a => a.ReleaseDate > inputDate).Distinct().ToList();

            foreach (var book in booksAfterInputDate.OrderBy(a=>a.ReleaseDate).ThenBy(a=>a.Title))
            {
                var onlyDate = book.ReleaseDate.ToString("dd.MM.yyyy");
                
                Console.WriteLine($"{book.Title} -> {onlyDate}");
            }
        }     
    }

    class Book
    {

        public Book (string title,DateTime releaseDate)
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