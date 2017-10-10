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
            var _CountryCityPopulation = new Dictionary<string, Dictionary<string, uint>>();
            var input = Console.ReadLine();
            while (input!="report")
            {
                var line = input.Split('|');
                var Country = line[1];
                var City = line[0];
                var pplCount = uint.Parse(line[2]);

                if (!_CountryCityPopulation.ContainsKey(Country))
                {
                    _CountryCityPopulation[Country] = new Dictionary<string, uint>();
                }

                if (!_CountryCityPopulation[Country].ContainsKey(City))
                {
                    _CountryCityPopulation[Country][City] = 0;
                }

                _CountryCityPopulation[Country][City] += pplCount;

                _CountryCityPopulation[Country] = _CountryCityPopulation[Country].OrderByDescending(a => a.Value).ToDictionary(a => a.Key, a => a.Value);

               



                input = Console.ReadLine();
            }


            

            foreach (var pkv in _CountryCityPopulation.OrderByDescending(x => x.Value.Sum(y => y.Value))) 
            {
                var Country = pkv.Key;
                var CityAndPopulation = pkv.Value;
                var totalPopulation = _CountryCityPopulation[Country].Values.Sum(a=>a);
                Console.WriteLine($"{Country} (total population: {totalPopulation})");

                var city = _CountryCityPopulation[Country].Keys.ToArray();
                var cityPopulation = _CountryCityPopulation[Country].Values.ToArray();

                for (int i = 0; i < _CountryCityPopulation[Country].Count; i++)
                {
                    Console.WriteLine($"=>{city[i]}: {cityPopulation[i]}");
                }

            }


        }
    }
}