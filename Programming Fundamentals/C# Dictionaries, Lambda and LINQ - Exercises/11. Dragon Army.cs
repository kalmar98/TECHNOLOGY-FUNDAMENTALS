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
            int limit =int.Parse(Console.ReadLine());
            var _typeNameStats = new Dictionary<string, SortedDictionary<string, List<int>>>();
            var MaxStatsPerType = new Dictionary<string, List<double>>();
            byte defaultDMG = 45;
            byte defaultHP = 250;
            byte defaultArmour = 10;
            for (int i = 0; i < limit; i++)
            {
                var input = Console.ReadLine();
                var data = input.Split();
                var type = data[0];
                var name = data[1];
                int damage = 0;
                int health = 0;
                int armour = 0;


                if (data[2] == "null")
                {
                    damage = defaultDMG;
                }
                else
                {
                    damage = int.Parse(data[2]);
                }
                if (data[3] == "null")
                {
                    health = defaultHP;
                }
                else
                {
                    health = int.Parse(data[3]);
                }
                if (data[4] == "null")
                {
                    armour = defaultArmour;
                }
                else
                {
                    armour = int.Parse(data[4]);
                }

                if (!MaxStatsPerType.ContainsKey(type))
                {
                    MaxStatsPerType[type] = new List<double>();
                    MaxStatsPerType[type].Add(0);
                    MaxStatsPerType[type].Add(0);
                    MaxStatsPerType[type].Add(0);

                }


                if (!_typeNameStats.ContainsKey(type))
                {
                    _typeNameStats[type] = new SortedDictionary<string, List<int>>();
                    
                }

                if (!_typeNameStats[type].ContainsKey(name))
                {
                    _typeNameStats[type][name] = new List<int>();
                    _typeNameStats[type][name].Add(0);
                    _typeNameStats[type][name].Add(1);
                    _typeNameStats[type][name].Add(2);
                    MaxStatsPerType[type][0] += damage;
                    MaxStatsPerType[type][1] += health;
                    MaxStatsPerType[type][2] += armour;

                }
                else
                {
                    MaxStatsPerType[type][0] += damage - _typeNameStats[type][name][0];
                    MaxStatsPerType[type][1] += health - _typeNameStats[type][name][1];
                    MaxStatsPerType[type][2] += armour - _typeNameStats[type][name][2];
                }
                _typeNameStats[type][name][0] = damage;
                _typeNameStats[type][name][1] = health;
                _typeNameStats[type][name][2] = armour;
                
            }
            foreach (var pkv in _typeNameStats)
            {
                var type = pkv.Key;
                var nameStats = pkv.Value;
                var names = nameStats.Keys.ToArray();
                var allStats = nameStats.Values.ToArray();
                //#podredenKod
                Console.WriteLine($"{type}::({MaxStatsPerType[type][0]/_typeNameStats[type].Count:f2}/{MaxStatsPerType[type][1] / _typeNameStats[type].Count:f2}/{MaxStatsPerType[type][2] / _typeNameStats[type].Count:f2}) ");
                for (ushort i = 0; i < _typeNameStats[type].Count; i++)
                {
                    Console.WriteLine($"-{names[i]} -> damage: {allStats[i][0]}, health: {allStats[i][1]}, armor: {allStats[i][2]} ");
                }


            }
        }
    }
}