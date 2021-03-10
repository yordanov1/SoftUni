using System;
using System.Linq;

namespace Exer_02._2X2Squares
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string[,] matrix = FillMatrix(sizes[0], sizes[1]);

            int numberOfSquare = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    string currentSymbol = matrix[row, col];
                    if (currentSymbol == matrix[row + 1, col] && 
                        currentSymbol == matrix[row, col + 1] && 
                        currentSymbol == matrix[row + 1, col + 1])
                    {
                        numberOfSquare++;
                    }
                }
            }

            Console.WriteLine(numberOfSquare);
        }

        static string[,] FillMatrix(int rows, int cols)
        {
            string[,] matrix = new string[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var rowData = Console.ReadLine().Split().ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
            return matrix;
        }
    }
}
