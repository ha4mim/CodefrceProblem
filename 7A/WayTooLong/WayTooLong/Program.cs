using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WayTooLong
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<number; i++)
            {
                string word = Console.ReadLine();
                if (word.Length > 10)
                {
                    Console.WriteLine($"{word[0]}{word.Length - 2}{word[word.Length - 1]}");
                }
                else
                {
                    Console.WriteLine(word);
                }
            }
            
        }
    }
}
