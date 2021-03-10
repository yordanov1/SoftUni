using System;
using System.Linq;

namespace Exer_06.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsCount = int.Parse(Console.ReadLine());

            decimal[][] matrix = new decimal[rowsCount][];

            for (int row = 0; row < matrix.Length; row++)
            {
                int[] rowData = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                matrix[row] = new decimal[rowData.Length];

                for (int col = 0; col < rowData.Length; col++)
                {
                    matrix[row][col] = rowData[col];
                }
            }

            for (int i = 0; i < rowsCount - 1; i++)
            {
                if (matrix[i].Length == matrix[i + 1].Length)
                {
                    for (int col = 0; col < matrix[i].Length; col++)
                    {
                        matrix[i][col] = matrix[i][col] * 2;
                        matrix[i + 1][col] = matrix[i + 1][col] * 2;
                    }
                }
                else
                {
                    for (int col = 0; col < matrix[i].Length; col++)
                    {
                        matrix[i][col] = matrix[i][col] / 2;
                        
                    }
                    for (int col2 = 0; col2 < matrix[i +1].Length; col2++)
                    {
                        matrix[i + 1][col2] = matrix[i + 1][col2] / 2;
                    }
                }
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commands = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string nameOfCommand = commands[0];
                int row = int.Parse(commands[1]);
                int col = int.Parse(commands[2]);
                int value = int.Parse(commands[3]);

                if (nameOfCommand == "Add")
                {
                    if (row < rowsCount && row >= 0)
                    {
                        if (col >= 0 && col < matrix[row].Length)
                        {
                            matrix[row][col] += value;
                        }
                    }
                }
                else if (nameOfCommand == "Subtract")
                {
                    if (row < rowsCount && row >= 0)
                    {
                        if (col >= 0 && col < matrix[row].Length)
                        {
                            matrix[row][col] -= value;
                        }
                    }
                }
                command = Console.ReadLine();
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ",row));
            }
        }
    }
}
