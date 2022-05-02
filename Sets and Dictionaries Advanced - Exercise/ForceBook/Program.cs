using System;
using System.Collections.Generic;
using System.Linq;

namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> sides = new Dictionary<string, List<string>>();

            string input;

            while((input = Console.ReadLine()) != "Lumpawaroo")
            {
                if(input.Contains('|'))
                {
                    string[] command = input.Split(" | ");

                    string side = command[0];
                    string user = command[1];

                    if (!sides.ContainsKey(side))
                    {
                        sides.Add(side, new List<string>());
                    }

                    if (!sides[side].Contains(user))
                    {
                        sides[side].Add(user);
                    }
                }
                else
                {
                    string[] command = input.Split(" -> ");

                    string side = command[1];
                    string user = command[0];

                    if (!sides.ContainsKey(side))
                    {
                        sides.Add(side, new List<string>());
                    }

                    if(!sides.Any(x => x.Value.Contains(user)))
                    {
                        sides[side].Add(user);
                    }
                    else
                    {
                        sides.First(s => s.Value.Contains(user)).Value.Remove(user);
                        sides[side].Add(user);
                    }

                    Console.WriteLine($"{user} joins the {side} side!");
                }
            }

            foreach (var side in sides.Where(x => x.Value.Count > 0).OrderByDescending(s => s.Value.Count).ThenBy(s => s.Key))
            {
                Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");

                foreach (var user in side.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }
    }
}
