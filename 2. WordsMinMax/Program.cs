using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.WordsMinMax
{
    internal class Program
    {
        // Задание 2.
        // 1. Создать метод, принимающий  текст и возвращающий слово, содержащее минимальное количество букв
        // 2.* Создать метод, принимающий  текст и возвращающий слово(слова) с максимальным количеством букв 
        // Примечание: слова в тексте могут быть разделены символами (пробелом, точкой, запятой) 
        // Пример: Текст: "A ББ ВВВ ГГГГ ДДДД  ДД ЕЕ ЖЖ ЗЗЗ"
        // 1. Ответ: А
        // 2. ГГГГ, ДДДД

        /// <summary>
        /// Метод, разделяющий текст на слова, и возвращающий самые короткие.
        /// </summary>
        /// <param name="text">Текст введённый пользователем.</param>
        /// <returns>Массив самых коротких слов из введённого текста.</returns>
        static string[] WordsMin(string text)
        {
            char[] traps = new char[] { ' ', ',', '.' };
            string[] words = text.Split(traps, StringSplitOptions.RemoveEmptyEntries);
            int length = words[0].Length;
            int numberOfWords = 0;

            foreach (string word in words)
            {
                if (word.Length < length)
                {
                    length = word.Length;
                    numberOfWords = 1;
                }
                else if (word.Length == length)
                {
                    numberOfWords++;
                }
            }

            string[] minWords = new string[numberOfWords];
            int j = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == length)
                {
                    minWords[j] = words[i];
                    j++;
                }
            }
            return minWords;
        }

        /// <summary>
        /// Метод, разделяющий текст на слова, и возвращающий самые длинные.
        /// </summary>
        /// <param name="text">Тект введённый пользователем.</param>
        /// <returns>Массив самых длинных слов из введённого текста.</returns>
        static string[] WordsMax(string text)
        {
            char[] traps = new char[] {' ', ',', '.'};
            string[] words = text.Split(traps, StringSplitOptions.RemoveEmptyEntries);
            int length = 0;
            int numberOfWords = 0;

            foreach (string word in words)
            {
                if (word.Length > length)
                {
                    length = word.Length;
                    numberOfWords = 1;
                }
                else if (word.Length == length)
                {
                    numberOfWords++;
                }
            }

            string[] maxWords = new string[numberOfWords];
            int j = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == length)
                {
                    maxWords[j] = words[i];
                    j++;
                }
            }
            return maxWords;
        }

        /// <summary>
        /// Метод, выводящий слова в консоль из массива.
        /// </summary>
        /// <param name="words">Массив слов.</param>
        static void PrintWords(string message, string[] words)
        {
            Console.Write($"\n{message} ");
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write($"{words[i]}");
                Console.Write((i < words.Length - 1) ? ", " : ".");
            }
        }

        /// <summary>
        /// Метод, взаимодействующий с пользователем.
        /// </summary>
        static void Dialogue()
        {
            Console.Write("Поиск: 1. самых длинных и 2. самых коротких слов. \nВведите предложение: ");
            string text = Console.ReadLine();

            PrintWords("1.", WordsMin(text));
            PrintWords("2.", WordsMax(text));
        }

        static void Main(string[] args)
        {
            Dialogue();
            Console.ReadKey();
        }
    }
}
