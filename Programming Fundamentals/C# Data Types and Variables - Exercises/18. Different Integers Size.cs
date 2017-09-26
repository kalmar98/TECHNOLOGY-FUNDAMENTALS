using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Numerics;


namespace training
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            
            try
            {
                long N = long.Parse(input);
                var list = new List<string>();
                if (N >= sbyte.MinValue && N <= sbyte.MaxValue)
                {
                    list.Add("* sbyte");
                }
                if (N >= byte.MinValue && N <= byte.MaxValue)
                {
                    list.Add("* byte");
                }
                if (N >= short.MinValue && N <= short.MaxValue)
                {
                    list.Add("* short");
                }
                if (N >= ushort.MinValue && N <= ushort.MaxValue)
                {
                    list.Add("* ushort");
                }
                if (N >= int.MinValue && N <= int.MaxValue)
                {
                    list.Add("* int");
                }
                if (N >= uint.MinValue && N <= uint.MaxValue)
                {
                    list.Add("* uint");
                }
                if (N >= long.MinValue && N <= long.MaxValue)
                {
                    list.Add("* long");
                }
                Console.WriteLine($"{input} can fit in:");
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(list[i]);
                }

            }
            catch (Exception)
            {
                Console.WriteLine($"{input} can't fit in any type");
            }
        }
    }   
}
