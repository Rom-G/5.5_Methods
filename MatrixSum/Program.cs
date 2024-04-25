using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixSum
{
    internal class Program
    {
        // 1.2. Создать метод, принимающий две матрицы, возвращающий их сумму

        /// <summary>
        /// Метод, складывающий две матрицы.
        /// </summary>
        /// <param name="matrix1">Первая матрица.</param>
        /// <param name="matrix2">Вторая матрица.</param>
        /// <returns>Сумма двух матриц.</returns>
        static int[,] MatrixSum(int[,] matrix1, int[,] matrix2)
        {
            int[,] matrixSum = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    matrixSum[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return matrixSum;
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
                    Console.Write($"{matrix[i, j], 3} ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Метод, взаимодействующий с пользователем.
        /// </summary>
        static void Dialogue() 
        {
            Console.WriteLine("Привет, давайте создадим две матрицы одного размера...");
            Console.Write("Введите количество строк: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int col = int.Parse(Console.ReadLine());

            int[,] matrix1 = MatrixCreator(row, col);
            Console.WriteLine("Матрица 1:");
            MatrixPrint(matrix1);

            int[,] matrix2 = MatrixCreator(row, col);
            Console.WriteLine("Матрица 2:");
            MatrixPrint(matrix2);

            int[,] matrixSum = MatrixSum(matrix1, matrix2);
            Console.WriteLine("И найдём их сумму:");
            MatrixPrint(matrixSum);
        }

        static void Main(string[] args)
        {
            Dialogue();
            Console.ReadKey();
        }
    }
}
