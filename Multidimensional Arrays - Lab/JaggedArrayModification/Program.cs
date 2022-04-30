using System;
using System.Linq;

namespace JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[][] matrix = new int[size][];

            for (int i = 0; i < size; i++)
            {
                matrix[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }

            string input;

            while((input = Console.ReadLine()) != "END")
            {
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int value = int.Parse(command[3]);

                if(row < 0 || row >= size || col < 0 || col >= size)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                switch (command[0])
                {
                    case "Add":
                        matrix[row][col] += value;
                        break;
                    case "Subtract":
                        matrix[row][col] -= value;
                        break;
                }
            }

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(string.Join(' ', matrix[i]));
            }
        }
    }
}
