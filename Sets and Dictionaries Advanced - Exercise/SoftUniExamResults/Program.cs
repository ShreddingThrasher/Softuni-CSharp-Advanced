using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> submissions = new Dictionary<string, int>();
            Dictionary<string, int> contestants = new Dictionary<string, int>();

            string input;

            while((input = Console.ReadLine()) != "exam finished")
            {
                string[] command = input.Split('-');

                string contestant = command[0];
                string contest = command[1];

                if(contest == "banned")
                {
                    contestants.Remove(contestant);
                    continue;
                }

                int points = int.Parse(command[2]);

                if (!submissions.ContainsKey(contest))
                {
                    submissions.Add(contest, 0);
                }

                submissions[contest]++;

                if (!contestants.ContainsKey(contestant))
                {
                    contestants.Add(contestant, points);
                }
                else if(contestants[contestant] < points)
                {
                    contestants[contestant] = points;
                }
            }

            Console.WriteLine("Results:");

            foreach (var item in contestants.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }

            Console.WriteLine("Submissions:");

            foreach (var item in submissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
