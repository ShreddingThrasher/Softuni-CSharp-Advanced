using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");

                string color = input[0];
                string[] clothes = input[1].Split(',');

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                foreach (string cloth in clothes)
                {
                    if (!wardrobe[color].ContainsKey(cloth))
                    {
                        wardrobe[color].Add(cloth, 0);
                    }

                    wardrobe[color][cloth]++;
                }
            }

            string[] search = Console.ReadLine().Split(' ');

            string colorCriteria = search[0];
            string dressCriteria = search[1];

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var dress in color.Value)
                {
                    string found = "";

                    if(color.Key == colorCriteria && dress.Key == dressCriteria)
                    {
                        found = " (found!)";
                    }

                    Console.WriteLine($"* {dress.Key} - {dress.Value}{found}");
                }
            }
        }
    }
}
