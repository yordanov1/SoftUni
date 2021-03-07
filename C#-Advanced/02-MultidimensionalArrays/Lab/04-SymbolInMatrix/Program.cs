 using System;
using System.Linq;

namespace Lab_04.SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int sideA = int.Parse(Console.ReadLine());

            char[,] matrix = FillMatrix(sideA, sideA);

            char symbol = char.Parse(Console.ReadLine());

            FindSymbolInMatrixAndPrint(matrix, symbol);
        }

        static char[,] FillMatrix(int rows, int cols)
        {
            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var rowData = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
            return matrix;
        }
        static void FindSymbolInMatrixAndPrint(char[,] matrix, char symbol)
        {
            bool contains = false;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == symbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        contains = true;
                        break;
                    }                       
                    else
                    {
                        contains = false;
                    }                                     
                }
                if (contains == true)
                {
                    break;
                }
            }
            if (contains == false)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}
