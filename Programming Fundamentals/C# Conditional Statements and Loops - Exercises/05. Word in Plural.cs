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
            ///taq zadacha e mega tupa i nepravilna
            List<char> word = new List<char>();
            word = Console.ReadLine().ToList();
          
            char lastLetter = word[word.Count - 1];
            string lastLetters = word[word.Count - 2].ToString() + word[word.Count - 1].ToString();
            if(lastLetter == 'y')
            {
                word.RemoveAt(word.Count - 1);
                word.Add('i');
                word.Add('e');
                word.Add('s');
                
            }
            else if(lastLetter =='o'|| lastLetter == 'z' || lastLetter == 's' || lastLetter == 'x' || lastLetters =="sh"||lastLetters=="ch")
            {
                word.Add('e');
                word.Add('s');
                
            }
            else
            {
                word.Add('s');
                
            }
            var finalWord = word.ToArray();
            Console.WriteLine(finalWord);
        }
    }     
}
