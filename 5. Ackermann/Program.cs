using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Ackermann
{
    internal class Program
    {
        // *Задание 5
        // Вычислить, используя рекурсию, функцию Аккермана:
        // A(2, 5), A(1, 2)
        // A(n, m) = m + 1, если n = 0,
        //         = A(n - 1, 1), если n <> 0, m = 0,
        //         = A(n - 1, A(n, m - 1)), если n> 0, m > 0.

        /// <summary>
        /// Метод, вычисляющий функцию Аккермана. В качестве параметров функции принимаются два целых неотрицательных числа.
        /// </summary>
        /// <param name="n">Первый параметр функции</param>
        /// <param name="m">Второй параметр функции</param>
        /// <returns>Значение функции при заданных параметрах.</returns>
        static int Ackermann(int n, int m)
        {
            while (n > 0)
            {
                if (m == 0)
                {
                    m = 1;
                }
                else
                {
                    m = Ackermann(n, m - 1);
                }
                n--;
            }
            return m + 1;
        }

        static void Main(string[] args)
        {
            Console.Write($"Вычисление функции Аккермана. \nA(2, 5): {Ackermann(2, 5)}.\n");
            Console.Write($"A(1, 2): {Ackermann(1, 2)}.\n\n");
            Console.ReadLine();
        }
    }
}
