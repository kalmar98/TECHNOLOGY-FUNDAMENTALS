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

            var resourcesAndQuantities = new Dictionary<string, int>();
            int counter = 0;
            while (input[counter] != "stop")
            {
                var resource = input[counter];
                var quantity = int.Parse(input[counter+1]);

                if (!resourcesAndQuantities.ContainsKey(resource))
                {
                    resourcesAndQuantities[resource] = 0;
                }
                resourcesAndQuantities[resource] += quantity;

                counter+=2;
            }
            var output = new List<string>();
            foreach (var resQuantity in resourcesAndQuantities)
            {
                var resource = resQuantity.Key;
                var quantity = resQuantity.Value;

                output.Add($"{resource} -> {quantity}");
            }
            File.WriteAllLines("output.txt", output.ToArray());

        }
        
    }
}
