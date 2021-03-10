using System;
using System.Linq;

namespace Exer_07.KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] chessBoard = FillMatrix(n, n);            

            int counterReplace = 0;
            int rowKiller = 0;
            int colKiller = 0;

            while (true)
            {
                int maxAttacks = 0;

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        char currentSymbol = chessBoard[row, col];
                        int countAttacks = 0;
                        if (currentSymbol == 'K')
                        {
                            countAttacks = GetAttacks(chessBoard, row, col, countAttacks);

                            if (countAttacks > maxAttacks)
                            {
                                maxAttacks = countAttacks;
                                rowKiller = row;
                                colKiller = col;
                            }
                        }
                    }
                }

                if (maxAttacks > 0)
                {
                    chessBoard[rowKiller, colKiller] = '0';
                    counterReplace++;
                }              
                else 
                {
                    Console.WriteLine(counterReplace);
                    break;
                }
            }
        }

        private static int GetAttacks(char[,] chessBoard, int row, int col, int countAttacks)
        {
            if (IsInside(chessBoard, row - 2, col + 1) &&
                         chessBoard[row - 2, col + 1] == 'K')
            {
                countAttacks++;
            }
            if (IsInside(chessBoard, row - 2, col - 1) &&
                         chessBoard[row - 2, col - 1] == 'K')
            {
                countAttacks++;
            }
            if (IsInside(chessBoard, row + 1, col + 2) &&
                         chessBoard[row + 1, col + 2] == 'K')
            {
                countAttacks++;
            }
            if (IsInside(chessBoard, row + 1, col - 2) &&
                         chessBoard[row + 1, col - 2] == 'K')
            {
                countAttacks++;
            }
            if (IsInside(chessBoard, row - 1, col + 2) &&
                         chessBoard[row - 1, col + 2] == 'K')
            {
                countAttacks++;
            }
            if (IsInside(chessBoard, row - 1, col - 2) &&
                         chessBoard[row - 1, col - 2] == 'K')
            {
                countAttacks++;
            }
            if (IsInside(chessBoard, row + 2, col - 1) &&
                         chessBoard[row + 2, col - 1] == 'K')
            {
                countAttacks++;
            }
            if (IsInside(chessBoard, row + 2, col + 1) &&
                         chessBoard[row + 2, col + 1] == 'K')
            {
                countAttacks++;
            }

            return countAttacks;
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

        private static bool IsInside(char[,] chessBoard, int targetRow, int targetCol)
        {
            return targetRow >= 0 && targetRow < chessBoard.GetLength(0)
                && targetCol >= 0 && targetCol < chessBoard.GetLength(1);
        }
    }
}
