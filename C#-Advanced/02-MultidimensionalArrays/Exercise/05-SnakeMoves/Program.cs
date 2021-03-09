using System;
using System.Linq;

namespace Exer_05.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                         .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                         .Select(int.Parse)
                         .ToArray();

            string snake = Console.ReadLine();

            char[,] matrix = new char[sizes[0], sizes[1]];

            int currentLetter = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {               
                if (row % 2 == 0 || row == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (currentLetter == snake.Length)
                        {
                            currentLetter = 0;
                        }

                        matrix[row, col] = snake[currentLetter];
                        currentLetter++;
                    }
                }
                else if(row % 1 == 0)
                {
                    for (int col = matrix.GetLength(1) -1; col >= 0; col--)
                    {
                        if (currentLetter == snake.Length)
                        {
                            currentLetter = 0;
                        }

                        matrix[row, col] = snake[currentLetter];
                        currentLetter++;
                    }
                }              
            }

            PrintMatrix(matrix);
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

        static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

    }
}
