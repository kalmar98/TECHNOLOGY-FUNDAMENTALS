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
            var input = File.ReadAllText("input.txt");
            var charArray = input.ToCharArray();
            var output = new string[charArray.Length];
            for (int i = 0; i < charArray.Length; i++)
            {
               output[i] = $"{charArray[i]} -> {charArray[i] - 97}";
                
            }

            File.WriteAllLines("output.txt", output);


        }
    }
}
