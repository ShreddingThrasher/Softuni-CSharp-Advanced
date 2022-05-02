using System;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                int[] temp = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int j = 0; j < temp.Length; j++)
                {
                    matrix[i, j] = temp[j];
                }
            }

            int firstSum = 0;
            int secondSum = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(i == j)
                    {
                        firstSum += matrix[i, j];
                    }

                    if(i + j == n - 1)
                    {
                        secondSum += matrix[i, j];
                    }
                }
            }

            Console.WriteLine(Math.Abs(firstSum - secondSum));
        }
    }
}
