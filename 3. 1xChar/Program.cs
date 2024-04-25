using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1xChar
{
    internal class Program
    {
        // Задание 3. Создать метод, принимающий текст. 
        // Результатом работы метода должен быть новый текст, в котором
        // удалены все кратные рядом стоящие символы, оставив по одному 
        // Пример: ПППОООГГГООООДДДААА >>> ПОГОДА
        // Пример: Ххххоооорррооошшшиий деееннннь >>> хороший день

        /// <summary>
        /// Метод, удаляющий из строки повторяющиеся символы.
        /// </summary>
        /// <param name="text">Текст введённый пользователем.</param>
        /// <returns>Текст без повторяющихся символов.</returns>
        static string X1Char(string text)
        {
            text = text.ToLower();
            string textX1 = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (i == text.Length - 1)
                {
                    textX1 += text[i];
                }
                else if (text[i] == text[i + 1]) 
                {
                    continue;
                }
                else
                {
                    textX1 += text[i];
                }
            }
            return textX1;
        }

        static void Main(string[] args)
        {
            Console.Write("Удаление повторяющихся символов из строки. \nВведите предложение: ");
            Console.Write(X1Char(Console.ReadLine()));

            Console.ReadKey();
        }
    }
}
