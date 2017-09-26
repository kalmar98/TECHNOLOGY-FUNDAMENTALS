using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace training
{
    class Program
    {
        static void Main()
        {
           
            byte counter = 0;
            
            try
            {
                while (true)
                {
                    int input = int.Parse(Console.ReadLine());
                    counter++;
                }
                    
            }
            catch (Exception)
            {
                Console.WriteLine(counter);
            }
        }        
    }     
}
