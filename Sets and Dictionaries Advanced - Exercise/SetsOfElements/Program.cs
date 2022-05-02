using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> first = new HashSet<int>();
            HashSet<int> second = new HashSet<int>();

            string[] sizeInput = Console.ReadLine().Split(' ');

            int n = int.Parse(sizeInput[0]);
            int m = int.Parse(sizeInput[1]);

            for (int i = 0; i < n; i++)
            {
                first.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < m; i++)
            {
                second.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine(string.Join(' ', first.Where(x => second.Contains(x))));
        }
    }
}
