using System;
using System.Linq;

namespace PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int j = 0; j < input.Length; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            int primaryDiagonalSum = 0;

            for (int i = 0; i < size; i++)
            {
                primaryDiagonalSum += matrix[i, i];
            }

            Console.WriteLine(primaryDiagonalSum);
        }
    }
}
