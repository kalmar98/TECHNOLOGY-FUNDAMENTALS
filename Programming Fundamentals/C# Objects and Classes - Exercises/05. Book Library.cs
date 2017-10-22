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
                var author = input[1];
                var publisher = input[2];
                var releaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                var isbn = input[4];
                var price = decimal.Parse(input[5]);

                var book = new Book(title, author, publisher, releaseDate, isbn, price);

                library.Books.Add(book);
            }

            var authors = library.Books.Select(a => a.Author).Distinct().ToList();

            var authorSales = new List<AuthorInfo>();

            foreach (var author in authors)
            {
                var authorBooks = library.Books.Where(a => a.Author == author).Sum(a=>a.Price);
                var authorinfo = new AuthorInfo
                {
                    Author = author,
                    Sales = authorBooks,
                };
                authorSales.Add(authorinfo);
            }

            authorSales = authorSales.OrderByDescending(a => a.Sales).ThenBy(a => a.Author).ToList();

            foreach (var authorSale in authorSales)
            {
                Console.WriteLine($"{authorSale.Author} -> {authorSale.Sales:f2}");
            }
        }

        
    }

    class Book
    {

        public Book (string title,string author,string publisher,DateTime releaseDate,string isbn,decimal price)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            ReleaseDate = releaseDate;
            Isbn = isbn;
            Price = price;
        }


        
        public string Title { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public DateTime ReleaseDate { get; set; }  

        public string Isbn { get; set; }

        public decimal Price { get; set; } 
    }

    class Library
    {
        public string Name { get; set; }

        public List<Book> Books { get; set; }
    }

    class AuthorInfo
    {
        public string Author { get; set; }

        public decimal Sales { get; set; }
    }

}