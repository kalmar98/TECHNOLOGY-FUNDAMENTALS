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
            for (int i = 1; i <= int.Parse(input[0]); i++)
            {
                var data = input[i].Split();

                var title = data[0];
                var author = data[1];
                var publisher = data[2];
                var releaseDate = DateTime.ParseExact(data[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                var isbn = data[4];
                var price = decimal.Parse(data[5]);

                var book = new Book(title, author, publisher, releaseDate, isbn, price);

                library.Books.Add(book);
            }

            var authors = library.Books.Select(a => a.Author).Distinct().ToList();

            var authorSales = new List<AuthorInfo>();

            foreach (var author in authors)
            {
                var authorBooks = library.Books.Where(a => a.Author == author).Sum(a => a.Price);
                var authorinfo = new AuthorInfo
                {
                    Author = author,
                    Sales = authorBooks,
                };
                authorSales.Add(authorinfo);
            }

            authorSales = authorSales.OrderByDescending(a => a.Sales).ThenBy(a => a.Author).ToList();
            var output = new List<string>();
            foreach (var authorSale in authorSales)
            {
                output.Add($"{authorSale.Author} -> {authorSale.Sales:f2}");
            }
            File.WriteAllLines("output.txt", output.ToArray());
        }
            

        
        
    }
    class Book
    {

        public Book(string title, string author, string publisher, DateTime releaseDate, string isbn, decimal price)
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
