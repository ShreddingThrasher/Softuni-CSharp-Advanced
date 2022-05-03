using System;
using System.Linq;

namespace PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(' ');

            Predicate<string> filterNamesByLength = (x) => x.Length <= n;

            Console.WriteLine(string.Join(Environment.NewLine, names.Where(x => filterNamesByLength(x))));
        }
    }
}
