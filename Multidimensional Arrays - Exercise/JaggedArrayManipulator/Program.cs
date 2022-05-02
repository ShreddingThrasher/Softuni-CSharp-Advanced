using System;
using System.Linq;

namespace JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            double[][] jagged = new double[rows][];

            for (int i = 0; i < rows; i++)
            {
                jagged[i] = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray(); 
            }

            for (int i = 0; i < rows - 1; i++)
            {
                if(jagged[i].Length == jagged[i + 1].Length)
                {
                    for (int j = 0; j < jagged[i].Length; j++)
                    {
                        jagged[i][j] *= 2;
                        jagged[i + 1][j] *= 2;
                    }
                }
                else
                {
                    for (int j = 0; j < jagged[i].Length; j++)
                    {
                        jagged[i][j] /= 2;
                    }

                    for (int j = 0; j < jagged[i + 1].Length; j++)
                    {
                        jagged[i + 1][j] /= 2;
                    }
                }
            }

            string input;

            while((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                double value = double.Parse(command[3]);

                if(row < 0 || row >= jagged.Length)
                {
                    continue;
                }
                else if(col < 0 || col >= jagged[row].Length)
                {
                    continue;
                }

                switch (command[0])
                {
                    case "Add":
                        jagged[row][col] += value;
                        break;
                    case "Subtract":
                        jagged[row][col] -= value;
                        break;
                }
            }

            for (int i = 0; i < jagged.Length; i++)
            {
                Console.WriteLine(string.Join(' ', jagged[i]));
            }
        }
    }
}
