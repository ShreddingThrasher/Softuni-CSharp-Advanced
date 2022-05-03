using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            List<Predicate<int>> predicates = new List<Predicate<int>>();

            foreach (int divider in dividers)
            {
                Predicate<int> predicate = (x) => x % divider == 0;
                predicates.Add(predicate);
            }

            List<int> numbers = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                numbers.Add(i);
            }

            Predicate<int> CheckAllItems = (x) =>
            {
                bool isDivisible = true;

                for (int i = 0; i < predicates.Count; i++)
                {
                    if (!predicates[i](x))
                    {
                        isDivisible = false;
                    }
                }

                return isDivisible;
            };

            Console.WriteLine(string.Join(' ', numbers.Where(x => CheckAllItems(x))));
        }
    }
}
