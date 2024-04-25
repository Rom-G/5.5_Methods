using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Pogression
{
    internal class Program
    {
        // Задание 4. Написать метод принимающий некоторое количесво чисел, выяснить
        // является заданная последовательность элементами арифметической или геометрической прогрессии

        /// <summary>
        /// Метод, определяющий является ли введёная последовательность чисел арифметической или геометрической прогрессией.
        /// </summary>
        /// <param name="text">Последовательность чисел введёная пользователем.</param>
        static void Progression(string text)
        {
            char[] traps = new char[] { ' ', ',', '.' };
            string[] textNumbers = text.Split(traps, StringSplitOptions.RemoveEmptyEntries);
            double[] numbers = new double[textNumbers.Length];
            bool arith = true;
            bool geom = true;
            double stepArith = 0;
            double stepGeom = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = double.Parse(textNumbers[i]);
                if (i == 1 && numbers[0] != 0)
                {
                    stepArith = numbers[1] - numbers[0];
                    stepGeom = numbers[1] / numbers[0];
                }
                else if (numbers[0] == 0)
                {
                    stepArith = numbers[1] - numbers[0];
                }
                if ((numbers[i] == 0) || (i > 1 && stepGeom != numbers[i] / numbers[i - 1]))
                {
                    geom = false;
                }
                if (i > 1 && stepArith != numbers[i] - numbers[i - 1])
                {
                    arith = false;
                }
            }

            if (geom && arith)
            {
                Console.Write("Указанная последовательность чисел является стационарной (постоянной).");
            }
            else if (!geom && !arith)
            {
                Console.Write("Указанная последовательность чисел не является ни геометрической ни арифметической прогрессией.");
            }
            else if (geom)
            {
                Console.Write("Указанная последовательность чисел является геометрической прогрессией.");
            }
            else if (arith)
            {
                Console.Write("Указанная последовательность чисел является арифметической прогрессией.");
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательность чисел разделённых запятыми, пробелами или точками.");
            Progression(Console.ReadLine());
            Console.ReadKey();
        }
    }
}