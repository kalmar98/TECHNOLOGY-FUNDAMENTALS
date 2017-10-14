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
            var resourcesAndQuantities = new Dictionary<string, int>();
            var input = Console.ReadLine();
            while (input != "stop")
            {
                var resource = input;
                var quantity = int.Parse(Console.ReadLine());

                if(!resourcesAndQuantities.ContainsKey(resource))
                {
                    resourcesAndQuantities[resource] = 0;
                }
                resourcesAndQuantities[resource] += quantity;

                input = Console.ReadLine();
            }

            foreach (var resQuantity in resourcesAndQuantities)
            {
                var resource = resQuantity.Key;
                var quantity = resQuantity.Value;

                Console.WriteLine($"{resource} -> {quantity}");
            }

        }
    }
}
  
