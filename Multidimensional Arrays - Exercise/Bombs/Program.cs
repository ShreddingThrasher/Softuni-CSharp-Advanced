using System;
using System.Linq;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[][] matrix = new int[size][];

            for (int i = 0; i < size; i++)
            {
                matrix[i] = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < input.Length; i++)
            {
                int[] bombCoordinates = input[i].Split(',').Select(int.Parse).ToArray();

                int row = bombCoordinates[0];
                int col = bombCoordinates[1];
                int bombPower = matrix[row][col];

                if(bombPower <= 0)
                {
                    continue;
                }

                matrix[row][col] -= bombPower;

                if(IsInsideAndAlive(row - 1, col - 1, matrix))
                {
                    matrix[row - 1][col - 1] -= bombPower;
                }
                if(IsInsideAndAlive(row - 1, col, matrix))
                {
                    matrix[row - 1][col] -= bombPower;
                }
                if(IsInsideAndAlive(row - 1, col + 1, matrix))
                {
                    matrix[row - 1][col + 1] -= bombPower;
                }
                if(IsInsideAndAlive(row, col + 1, matrix))
                {
                    matrix[row][col + 1] -= bombPower;
                }
                if(IsInsideAndAlive(row + 1, col + 1, matrix))
                {
                    matrix[row + 1][col + 1] -= bombPower;
                }
                if(IsInsideAndAlive(row + 1, col, matrix))
                {
                    matrix[row + 1][col] -= bombPower;
                }
                if(IsInsideAndAlive(row + 1, col - 1, matrix))
                {
                    matrix[row + 1][col - 1] -= bombPower;
                }
                if(IsInsideAndAlive(row, col - 1, matrix))
                {
                    matrix[row][col - 1] -= bombPower;
                }
            }

            int sum = 0;
            int aliveCount = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                sum += matrix[i].Where(x => x > 0).Sum();
                aliveCount += matrix[i].Where(x => x > 0).Count();
            }

            Console.WriteLine($"Alive cells: {aliveCount}");
            Console.WriteLine($"Sum: {sum}");

            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine(string.Join(' ', matrix[i]));
            }
        }

        static bool IsInsideAndAlive(int x, int y, int[][] matrix)
        {
            if(x < 0 || x >= matrix.Length || y < 0 || y >= matrix.Length)
            {
                return false;
            }
            else if(matrix[x][y] <= 0)
            {
                return false;
            }

            return true;
        }
    }
}
