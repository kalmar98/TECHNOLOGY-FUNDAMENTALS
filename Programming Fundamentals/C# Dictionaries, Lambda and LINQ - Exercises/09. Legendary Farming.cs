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
            var input = Console.ReadLine();
            var _LegendaryMaterialQuantity = new SortedDictionary<string, uint>();
            var _JunkMaterialQuantity = new SortedDictionary<string, uint>();
            bool isLegendaryReached = false;
            string LegendaryItem = " ";
            string shards = "shards";
            string fragments = "fragments";
            string motes = "motes";
            bool reduceShards = false;
            bool reduceFragments = false;
            bool reduceMotes = false;
            bool skip = false;
            _LegendaryMaterialQuantity[shards] = 0;
            _LegendaryMaterialQuantity[fragments] = 0;
            _LegendaryMaterialQuantity[motes] = 0;
            while (!isLegendaryReached)
            {   
                    uint CounterQuantity = 0;
                    uint CounterMaterial = 1;
                    var line = input.ToLower().Split();
                for (ushort i = 0; i < line.Length / 2; i++)
                {
                    var quantity = uint.Parse(line[CounterQuantity]);
                    var material = line[CounterMaterial];
                    if (!skip)
                    {
                        if (material == shards || material == fragments || material == motes)
                        {
                            _LegendaryMaterialQuantity[material] += quantity;
                            if (_LegendaryMaterialQuantity[material] > 249)
                            {
                                skip = true;
                            }
                        }
                        else
                        {
                            if (!_JunkMaterialQuantity.ContainsKey(material))
                            {
                                _JunkMaterialQuantity[material] = 0;
                            }
                            _JunkMaterialQuantity[material] += quantity;
                        }
                        CounterQuantity += 2;
                        CounterMaterial += 2;
                    }
                }
                foreach (var pkv in _LegendaryMaterialQuantity)
                {
                    var legendaryMaterial = pkv.Key;
                    var legendaryQuantitiy = pkv.Value;
                    if (legendaryQuantitiy > 249)
                    {
                        if (legendaryMaterial == shards)
                        {
                            LegendaryItem = "Shadowmourne";
                            reduceShards = true;
                            isLegendaryReached = true;
                        }
                        if (legendaryMaterial == fragments)
                        {
                            LegendaryItem = "Valanyr";
                            reduceFragments = true;
                            isLegendaryReached = true;
                        }
                        if (legendaryMaterial == motes)
                        {
                            LegendaryItem = "Dragonwrath";
                            reduceMotes = true;
                            isLegendaryReached = true;
                        }
                    }
                }
                if (isLegendaryReached)
                {
                    if (reduceShards)
                    {
                        _LegendaryMaterialQuantity[shards] -= 250;
                    }
                    if (reduceFragments)
                    {
                        _LegendaryMaterialQuantity[fragments] -= 250;
                    }
                    if (reduceMotes)
                    {
                        _LegendaryMaterialQuantity[motes] -= 250;
                    }
                }
                if (!isLegendaryReached)
                {
                    input = Console.ReadLine();
                }
            }
            Console.WriteLine($"{LegendaryItem} obtained!");
            foreach (var pkv in _LegendaryMaterialQuantity.OrderByDescending(a => a.Value).ToDictionary(a => a.Key, a => a.Value))
            {
                var material = pkv.Key;
                var quantity = pkv.Value;
                Console.WriteLine($"{material}: {quantity}");
            }
            foreach (var pkv in _JunkMaterialQuantity)
            {
               var material = pkv.Key;
               var quantity = pkv.Value;
               Console.WriteLine($"{material}: {quantity}");
            }
        }
    }
}