using System;
using System.Linq;
using System.Collections.Generic;

namespace FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tuple<string, int>> people = new List<Tuple<string, int>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ");

                string name = input[0];
                int age = int.Parse(input[1]);

                people.Add(new Tuple<string, int>(name, age));
            }

            string condition = Console.ReadLine();
            int ageCriteria = int.Parse(Console.ReadLine());
            string printCriteria = Console.ReadLine();

            Func<int, int, bool> ageFilter = null;
            Action<Tuple<string, int>> printByCriteria = null;

            switch (condition)
            {
                case "younger":
                    ageFilter = (age, ageCriteria) => age < ageCriteria;
                    break;
                case "older":
                    ageFilter = (age, ageCriteria) => age >= ageCriteria;
                    break;
            }

            switch (printCriteria)
            {
                case "name":
                    printByCriteria = (x) => Console.WriteLine(x.Item1);
                    break;
                case "age":
                    printByCriteria = (x) => Console.WriteLine(x.Item2);
                    break;
                case "name age":
                    printByCriteria = (x) => Console.WriteLine($"{x.Item1} - {x.Item2}");
                    break;

            }

            people.Where(x => ageFilter(x.Item2, ageCriteria)).ToList().ForEach(x => printByCriteria(x));
        }

    }
}
