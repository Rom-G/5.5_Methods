using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string[] {"q", "ww", "e", "rrrr", "ttt"};
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine();
            Array.Sort(words);
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            Console.ReadKey();


            //char[] traps = new char[] { ' ', ',', '.' };
            //string[] words = text.Split(traps, StringSplitOptions.RemoveEmptyEntries);
            //int length = 0;
            //string[] maxWords = new string[words.Length];
            //for (int i = 0; i < words.Length; i++)
            //{
            //    if (words[i].Length > length)
            //    {
            //        length = words[i].Length;
            //    }
            //}

            //for (int i = 0; i < words.Length; i++)
            //{
            //    if (words[i].Length == length)
            //    {
            //        maxWords[i] = words[i];
            //    }
            //}
            //return words;
        }
    }
}
