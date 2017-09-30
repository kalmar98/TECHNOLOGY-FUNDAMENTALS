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
            ulong start = ulong.Parse(Console.ReadLine());
            ulong end = ulong.Parse(Console.ReadLine());


            Console.WriteLine(String.Join(", ",FindPrimesInRange(start,end)));
        }
        static bool IsPrime(ulong n)
        {
            ulong sqrtN = (ulong)Math.Sqrt(n);
            if (n <= 1)
            {
                return false;
            }
            else if (n >= 2)
            {
                for (ulong i = 2; i <= sqrtN; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static List<ulong> FindPrimesInRange(ulong startNum, ulong endNum)
        {
            var list = new List<ulong>();
            for (ulong i = startNum; i <= endNum; i++)
            {
                if (IsPrime(i))
                {
                    list.Add(i);
                }
            }
            return list;
        }
  



    }
}
