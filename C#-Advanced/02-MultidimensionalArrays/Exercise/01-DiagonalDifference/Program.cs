using System;
using System.Linq;

namespace Exer_01.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            int sumD1 = 0;
            int sumD2 = 0;

            int[,] matrix = FillMatrix(a, a);

            for (int i = 0; i < a; i++)
            {
                sumD1 += matrix[i, i];
                sumD2 += matrix[i, matrix.GetLength(0)- 1 - i];
            }

            Console.WriteLine(Math.Abs(sumD1 - sumD2));
        }

        static int[,] FillMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var rowData = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
            return matrix;
        }
    }
}
