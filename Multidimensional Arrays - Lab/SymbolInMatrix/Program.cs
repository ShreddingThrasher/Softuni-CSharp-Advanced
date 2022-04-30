using System;

namespace SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[][] matrix = new char[n][];

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                matrix[i] = input.ToCharArray();
            }

            char symbol = char.Parse(Console.ReadLine());

            int row = -1;
            int col = -1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(matrix[i][j] == symbol)
                    {
                        row = i;
                        col = j;

                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{symbol} does not occur in the matrix");
        }
    }
}
