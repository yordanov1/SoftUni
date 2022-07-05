namespace PathsInALabyrinth
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            var row = int.Parse(Console.ReadLine());
            var col = int.Parse(Console.ReadLine());

            var lab = new char[row, col];

            for (int r = 0; r < row; r++)
            {
                var colElements = Console.ReadLine();

                for (int c = 0; c < colElements.Length; c++)
                {
                    lab[r, c] = colElements[c];
                }
            }

            /*
            for (int i = 0; i < lab.GetLength(0); i++)
            {
                for (int j = 0; j < lab.GetLength(1); j++)
                {
                    Console.Write(lab[i, j]);
                }
                Console.WriteLine();
            }
            */

            FindPaths(lab, 0, 0, new List<string>(), String.Empty);

        }

        private static void FindPaths(char[,] lab, int row, int col, List<string> directions, string direction)
        {
            //Validate row and col
            if (row < 0 || row >= lab.GetLength(0) || col < 0 || col >= lab.GetLength(1))
            {
                return;
            }

            //Check for walls or already visited cell
            if (lab[row, col] == '*' || lab[row, col] == 'v')
            {
                return;
            }

            directions.Add(direction);

            //Check for end
            if (lab[row, col] == 'e')
            {
                Console.WriteLine(String.Join(String.Empty, directions));
                directions.RemoveAt(directions.Count - 1);
                return;
            }

            lab[row, col] = 'v';
            

            FindPaths(lab, row - 1, col, directions, "U");//Up
            FindPaths(lab, row + 1, col, directions, "D");//Down
            FindPaths(lab, row, col - 1, directions, "L");//Left
            FindPaths(lab, row, col + 1, directions, "R");//Right

            lab[row, col] = '-';
            directions.RemoveAt(directions.Count - 1);
        }
    }
}
