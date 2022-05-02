using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> symbolsCount = new Dictionary<char, int>();

            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                if (!symbolsCount.ContainsKey(c))
                {
                    symbolsCount.Add(c, 0);
                }

                symbolsCount[c]++;
            }

            foreach (var symbol in symbolsCount.OrderBy(s => s.Key))
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}
