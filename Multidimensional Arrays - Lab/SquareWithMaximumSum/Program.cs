using System;
using System.Linq;

namespace SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int j = 0; j < input.Length; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            int biggestRow = -1;
            int biggestCol = -1;
            int biggestSum = 0;

            for (int i = 0; i < rows - 1; i++)
            {
                int currSum = 0;

                for (int j = 0; j < cols - 1; j++)
                {
                    currSum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];

                    if (currSum > biggestSum)
                    {
                        biggestSum = currSum;
                        biggestRow = i;
                        biggestCol = j;
                    }
                }
            }

            //print biggest square and the sum of its elements

            Console.WriteLine($"{matrix[biggestRow, biggestCol]} {matrix[biggestRow, biggestCol + 1]}");
            Console.WriteLine($"{matrix[biggestRow + 1, biggestCol]} {matrix[biggestRow + 1, biggestCol + 1]}");
            Console.WriteLine(biggestSum);
        }
    }
}
