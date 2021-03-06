using System;
using System.Linq;

namespace Lab_03.PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            int sum = 0;

            int[,] matrix = FillMatrix(a, a);

            for (int i = 0; i < a; i++)
            {
                sum += matrix[i, i];
            }

            Console.WriteLine(sum);
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
