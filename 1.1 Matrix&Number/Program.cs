using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1_Matrix_Number
{
    internal class Program
    {
        // Задание 1.
        // Воспользовавшись решением задания 3 четвертого модуля
        // 1.1. Создать метод, принимающий число и матрицу, возвращающий матрицу умноженную на число
        // 1.2. Создать метод, принимающий две матрицы, возвращающий их сумму
        // 1.3. Создать метод, принимающий две матрицы, возвращающий их произведение

        /// <summary>
        /// Метод, умножающий матрицу на число.
        /// </summary>
        /// <param name="matrix">Матрица чисел.</param>
        /// <param name="multiplier">Мультипликатор.</param>
        /// <returns>Матрица умноженная на число.</returns>
        static void MatrixMultiplier(int[,] matrix, int multiplier)
        {

            for (int i = 0; i < matrix.GetLength(0); i++) 
            { 
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] *= multiplier;
                }
            }
            MatrixPrint(matrix);
        }

        /// <summary>
        /// Метод, создаюший матрицу заданного размера.
        /// </summary>
        /// <returns>Матрица случайных чисел.</returns>
        static void MatrixCreator()
        {
            Console.WriteLine("Привет, давайте создадим матрицу и взглянем на неё...");
            Console.Write("Введите количество строк: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int col = int.Parse(Console.ReadLine());
            int[,] matrix = new int[row, col];

            Random r = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = r.Next(10);
                }
            }
            MatrixPrint(matrix);

            Console.Write("А теперь введите число, на которое следует умножить матрицу: ");
            int multiplier = int.Parse(Console.ReadLine());
            Console.WriteLine("И вот результат:");
            MatrixMultiplier(matrix, multiplier);
        }

        /// <summary>
        /// Метод, печатающий матрицу.
        /// </summary>
        /// <param name="matrix">Заданная матрица.</param>
        static void MatrixPrint(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j], 3} ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            MatrixCreator();
            Console.ReadKey();
        }
    }
}
