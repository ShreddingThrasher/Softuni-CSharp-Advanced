using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            Action<int[]> reverse = x =>
            {
                for (int j = 0; j < x.Length / 2; j++)
                {
                    int temp = x[j];
                    x[j] = x[x.Length - 1 - j];
                    x[x.Length - 1 - j] = temp;
                }
            };

            Predicate<int> condition = x => x % n != 0;

            reverse(input);

            Console.WriteLine(string.Join(' ', input.ToList().FindAll(condition)));
        }
    }
}
