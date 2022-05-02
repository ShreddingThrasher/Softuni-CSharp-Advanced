using System;
using System.Linq;

namespace MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            string[,] matrix = new string[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] row = Console.ReadLine().Split(' ');

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            string input;

            while((input = Console.ReadLine()) != "END")
            {
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if(command[0] != "swap")
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                else if(command.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                int firstRow = int.Parse(command[1]);
                int firstCol = int.Parse(command[2]);
                int secondRow = int.Parse(command[3]);
                int secondCol = int.Parse(command[4]);

                if(!IsValidCoordinate(firstRow, firstCol, rows, cols) || !IsValidCoordinate(secondRow, secondCol, rows, cols))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                string temp = matrix[firstRow, firstCol];
                matrix[firstRow, firstCol] = matrix[secondRow, secondCol];
                matrix[secondRow, secondCol] = temp;

                PrintMatrix(matrix);
            }
        }

        static void PrintMatrix(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }

                Console.WriteLine();
            }
        }

        static bool IsValidCoordinate(int x, int y, int rows, int cols)
        {
            if(x < 0 || x >= rows || y < 0 || y >= cols)
            {
                return false;
            }

            return true;
        }
    }
}
