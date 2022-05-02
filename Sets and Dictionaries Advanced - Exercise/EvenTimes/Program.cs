using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> numbers = new Dictionary<int, int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int curr = int.Parse(Console.ReadLine());

                if (!numbers.ContainsKey(curr))
                {
                    numbers.Add(curr, 0);
                }

                numbers[curr]++;
            }

            Console.WriteLine(numbers.First(x => x.Value % 2 == 0).Key);
        }
    }
}
