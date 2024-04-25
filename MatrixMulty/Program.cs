using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixMulty
{
    internal class Program
    {
        // 1.3. Создать метод, принимающий две матрицы, возвращающий их произведение

        /// <summary>
        /// Метод, умножающий две матрицы.
        /// </summary>
        /// <param name="matrix1">Первая матрица.</param>
        /// <param name="matrix2">Вторая матрица.</param>
        /// <returns>Произведение двух матриц.</returns>
        static int[,] MatrixMulty(int[,] matrix1, int[,] matrix2)
        {
            int[,] matrixMulty = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

            for (int r = 0; r < matrix1.GetLength(1); r++)
            {
                for (int i = 0; i < matrix1.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix2.GetLength(1); j++) 
                    {
                        matrixMulty[i, j] += matrix1[i, r] * matrix2[r, j];
                    }
                }
            }
            return matrixMulty;
        }

        /// <summary>
        /// Метод, создаюший матрицу заданного размера.
        /// </summary>
        /// <param name="row">Число строк.</param>
        /// <param name="col">Число столбцов.</param>
        /// <returns>Матрица случайных чисел.</returns>
        static int[,] MatrixCreator(int row, int col)
        {
            int[,] matrix = new int[row, col];
            Random r = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = r.Next(10);
                }
            }
            return matrix;
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
                    Console.Write($"{matrix[i, j],3} ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Метод, взаимодействующий с пользователем.
        /// </summary>
        static void Dialogue()
        {
            Console.WriteLine("Давайте создадим две согласованные матрицы...");
            Console.Write("Введите количество строк первой матрицы: ");
            int row1 = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов первой матрицы (строк второй матрицы): ");
            int col1row2 = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов второй матрицы: ");
            int col2 = int.Parse(Console.ReadLine());

            int[,] matrix1 = MatrixCreator(row1, col1row2);
            Console.WriteLine("Матрица 1:");
            MatrixPrint(matrix1);
            Console.ReadKey();

            int[,] matrix2 = MatrixCreator(col1row2, col2);
            Console.WriteLine("Матрица 2:");
            MatrixPrint(matrix2);
            Console.ReadKey();

            int[,] matrixMulty = MatrixMulty(matrix1, matrix2);
            Console.WriteLine("\nИ найдём их произведение:");
            MatrixPrint(matrixMulty);
        }

        static void Main(string[] args)
        {
            Dialogue();
            Console.ReadKey();
        }
    }
}
