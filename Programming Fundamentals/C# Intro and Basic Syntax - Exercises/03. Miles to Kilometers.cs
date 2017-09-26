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
            decimal a = decimal.Parse(Console.ReadLine());
            decimal aMileInKM = 1.60934m;





            Console.WriteLine("{0:f2}",a*aMileInKM);
           
        }
    }
}