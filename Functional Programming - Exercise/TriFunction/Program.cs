using System;
using System.Collections.Generic;
using System.Linq;

namespace TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine()
                .Split(' ').ToList();

            Func<string, int, bool> basicLogic = IsCharSumEqualOrGreater;

            Console.WriteLine(MainFunction(names, n, basicLogic));
        }

        private static bool IsCharSumEqualOrGreater(string name, int n)
        {
            int sum = 0;

            for (int i = 0; i < name.Length; i++)
            {
                sum += (int)name[i];
            }

            if (sum >= n)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static string MainFunction(IEnumerable<string> names, int n, Func<string, int, bool> func)
        {
            string result = "";

            foreach (string name in names)
            {
                if (func(name, n))
                {
                    result = name;
                    break;
                }
            }

            return result;
        }
    }
}
