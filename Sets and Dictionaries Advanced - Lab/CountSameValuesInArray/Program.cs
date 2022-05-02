using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> count = new Dictionary<double, int>();

            double[] input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                if (!count.ContainsKey(input[i]))
                {
                    count.Add(input[i], 0);
                }

                count[input[i]]++;
            }

            foreach (var item in count)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
