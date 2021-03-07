using System;
using System.Linq;

namespace Lab_05._SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = FillMatrix(size[0], size[1]);

            int maxSum = int.MinValue;
            int max1= int.MinValue;
            int max2= int.MinValue;
            int max3= int.MinValue;
            int max4= int.MinValue;


            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int sum = matrix[row, col] + 
                             matrix[row, col + 1] + 
                             matrix[row + 1, col] + 
                             matrix[row + 1, col + 1];

                    if (maxSum < sum)
                    {
                        maxSum = sum;
                        max1 = matrix[row, col];
                        max2 = matrix[row, col + 1];
                        max3 = matrix[row + 1, col];
                        max4 = matrix[row + 1, col + 1];
                    }
                }
            }

            Console.Write(max1 + " ");
            Console.WriteLine(max2);
            Console.Write(max3 + " ");
            Console.WriteLine(max4);
            Console.WriteLine(maxSum);
        }

        static int[,] FillMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var rowData = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
            return matrix;
        }
    }
}
