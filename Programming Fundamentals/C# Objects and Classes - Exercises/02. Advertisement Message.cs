using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Globalization;


namespace loopsTut_For
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            var Phrases = new List<string>() {"Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            var Events = new List<string>() { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            var Authors = new List<string>() { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            var Cities = new List<string>() { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random random = new Random();

            for (int i = 0; i < N; i++)
            {
                var PhraseIndex = Phrases[random.Next(0, Phrases.Count)];
                var EventIndex = Events[random.Next(0, Events.Count)];
                var AuthorIndex = Authors[random.Next(0, Authors.Count)];
                var CityIndex = Cities[random.Next(0, Cities.Count)];

                Console.WriteLine($"{PhraseIndex} {EventIndex} {AuthorIndex} - {CityIndex} ");
            }


        }

        
    }
    

}