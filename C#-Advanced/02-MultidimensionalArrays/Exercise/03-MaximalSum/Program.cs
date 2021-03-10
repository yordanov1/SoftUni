using System;
using System.Linq;

namespace Exer_03.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
              int[] sizes = Console.ReadLine()
                                   .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToArray();
           
              int[,] matrix = FillMatrix(sizes[0], sizes[1]);
              int[,] biggestMatrix3x3 = new int[3, 3];
              int biggestSum = int.MinValue;

              for (int row = 0; row < matrix.GetLength(0) - 2; row++)
              {
                  for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                  {
                      int sum = matrix[row, col] 
                              + matrix[row, col + 1] 
                              + matrix[row, col + 2] 
                              + matrix[row + 1, col] 
                              + matrix[row + 1, col + 1] 
                              + matrix[row + 1, col + 2] 
                              + matrix[row + 2, col] 
                              + matrix[row + 2, col + 1] 
                              + matrix[row + 2, col + 2];

                      if (biggestSum < sum)
                      {
                          biggestSum = sum;

                          for (int i = 0; i < 3; i++)
                          {
                              for (int j = 0; j < 3; j++)
                              {
                                  biggestMatrix3x3[i, j] = matrix[row + i, col + j];
                              }
                          }
                      }
                  }
              }

              Console.WriteLine($"Sum = {biggestSum}");
              PrintMatrix(biggestMatrix3x3);           
        }

        static int[,] FillMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
            return matrix;
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
