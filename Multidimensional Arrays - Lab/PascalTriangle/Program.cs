using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long[][] result = new long[n][];

            for (int i = 0; i < n; i++)
            {
                result[i] = new long[i + 1];

                for (int j = 0; j < i + 1; j++)
                {
                    if(j > 0 && j < result[i].Length - 1)
                    {
                        result[i][j] = result[i - 1][j - 1] + result[i - 1][j];
                    }
                    else
                    {
                        result[i][j] = 1;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(string.Join(' ', result[i]));
            }
        }
    }
}
