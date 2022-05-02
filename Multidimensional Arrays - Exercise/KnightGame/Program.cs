using System;
using System.Collections.Generic;
using System.Linq;

namespace KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] board = new char[size, size];

            for (int i = 0; i < size; i++)
            {
                string row = Console.ReadLine();

                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = row[j];
                }
            }

            int removed = 0;

            while (true)
            {
                int maxAttacks = 0;
                int knightRow = 0;
                int knightCol = 0;

                for (int row = 0; row < board.GetLength(0); row++)
                {
                    for (int col = 0; col < board.GetLength(1); col++)
                    {
                        int currAttacks = 0;

                        if (board[row, col] != 'K')
                        {
                            continue;
                        }

                        if (IsInside(board, row - 2, col + 1) && board[row - 2, col + 1] == 'K')
                        {
                            currAttacks++;
                        }
                        if (IsInside(board, row - 1, col + 2) && board[row - 1, col + 2] == 'K')
                        {
                            currAttacks++;
                        }
                        if (IsInside(board, row + 1, col + 2) && board[row + 1, col + 2] == 'K')
                        {
                            currAttacks++;
                        }
                        if (IsInside(board, row + 2, col + 1) && board[row + 2, col + 1] == 'K')
                        {
                            currAttacks++;
                        }
                        if (IsInside(board, row + 2, col - 1) && board[row + 2, col - 1] == 'K')
                        {
                            currAttacks++;
                        }
                        if (IsInside(board, row + 1, col - 2) && board[row + 1, col - 2] == 'K')
                        {
                            currAttacks++;
                        }
                        if (IsInside(board, row - 1, col - 2) && board[row - 1, col - 2] == 'K')
                        {
                            currAttacks++;
                        }
                        if (IsInside(board, row - 2, col - 1) && board[row - 2, col - 1] == 'K')
                        {
                            currAttacks++;
                        }

                        if (currAttacks > maxAttacks)
                        {
                            maxAttacks = currAttacks;
                            knightRow = row;
                            knightCol = col;
                        }
                    }
                }

                if (maxAttacks == 0)
                {
                    Console.WriteLine(removed);
                    break;
                }
                else
                {
                    board[knightRow, knightCol] = '0';
                    removed++;
                }
            }
        }

        private static bool IsInside(char[,] board, int row, int col)
        {
            if (row < 0 || row >= board.GetLength(0) || col < 0 || col >= board.GetLength(1))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
