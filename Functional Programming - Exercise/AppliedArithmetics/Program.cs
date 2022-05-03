using System;
using System.Collections.Generic;
using System.Linq;

namespace AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Action<int[]> add = x =>
            {
                for (int i = 0; i < x.Length; i++)
                {
                    x[i]++;
                }
            };

            Action<int[]> multiply = x =>
            {
                for (int i = 0; i < x.Length; i++)
                {
                    x[i] *= 2;
                }
            };

            Action<int[]> subtract = x =>
            {
                for (int i = 0; i < x.Length; i++)
                {
                    x[i]--;
                }
            };

            Action<int[]> print = (x) => Console.WriteLine(string.Join(' ', x));

            string input;

            while((input = Console.ReadLine()) != "end")
            {
                switch (input)
                {
                    case "add":
                        add(numbers);
                        break;
                    case "multiply":
                        multiply(numbers);
                        break;
                    case "subtract":
                        subtract(numbers);
                        break;
                    case "print":
                        print(numbers);
                        break;
                }
            }
        }
    }
}
