using System;
using System.Linq;
using System.Collections.Generic;

namespace FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string criteria = Console.ReadLine();

            List<int> numbers = new List<int>();
            
            Predicate<int> find = null;

            switch (criteria)
            {
                case "odd":
                    find = (x) => x % 2 != 0;
                    break;
                case "even":
                    find = (x) => x % 2 == 0;
                    break;
            }

            int lowerBound = input[0];
            int upperBound = input[1];

            for (int i = lowerBound; i <= upperBound; i++)
            {
                numbers.Add(i);
            }

            Console.WriteLine(string.Join(' ', numbers.FindAll(x => find(x))));
        }
    }
}
