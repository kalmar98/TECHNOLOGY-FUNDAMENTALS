using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Numerics;


namespace training
{
    class Training
    {
        static void Main()
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            var bombAndPower = Console.ReadLine().Split().Select(int.Parse).ToList();
            var bombNumber = bombAndPower[0];
            var bombPower = bombAndPower[1];


            for (int i = 0; i < list.Count; i++)
            {
                var find = list.FindIndex(a => a == bombNumber);

                if (find == -1)
                {
                    break;
                }


                if (list[find] == bombNumber)
                {
                    //left
                    for (int y = 1; y <= bombPower; y++)
                    {
                        try
                        {

                            list.RemoveAt(find-y);


                        }
                        catch (Exception)
                        {
                            break;
                        }
                    }

                    //right
                    for (int y = 1; y <= bombPower; y++)
                    {
                        try
                        {
                            list.RemoveAt(list.FindIndex(a=>a==bombNumber) + 1);
                        }
                        catch (Exception)
                        {
                            break;
                        }
                    }


                    list.Remove(bombNumber);
                }
            }

            Console.WriteLine(list.Sum());
        }

    }
}