using System;
using System.Linq;

namespace Lab_06.Jagged_ArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] matrix = new int[rows][];

            int lenght = matrix.Length;

            for (int row = 0; row < matrix.Length; row++)
            {
                int[] rowData = Console.ReadLine().Split()
                                        .Select(int.Parse)
                                        .ToArray();

                matrix[row] = new int[rowData.Length];

                for (int col = 0; col < rowData.Length; col++)
                {
                    matrix[row][col] = rowData[col];
                }
            }
            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] command = input.Split().ToArray();

                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int value = int.Parse(command[3]);

                if (command[0] == "Add")
                {
                    if (matrix.Length <= row || row < 0)
                    {
                        Console.WriteLine("Invalid coordinates");
                        input = Console.ReadLine();
                        continue;
                    }
                    if (matrix[row].Length <= col || col < 0)
                    {
                        Console.WriteLine("Invalid coordinates");
                        input = Console.ReadLine();
                        continue;
                    }                    
                    else
                    {
                        matrix[row][col] += value;
                    }
                }
                else if (command[0] == "Subtract")
                {
                    if (matrix.Length <= row || row < 0)
                    {
                        Console.WriteLine("Invalid coordinates");
                        input = Console.ReadLine();
                        continue;
                    }
                    if (matrix[row].Length <= col || col < 0)
                    {
                        Console.WriteLine("Invalid coordinates");
                        input = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        matrix[row][col] -= value;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
