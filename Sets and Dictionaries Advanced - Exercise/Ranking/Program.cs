using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> participants = new Dictionary<string, Dictionary<string, int>>();

            string input;

            while((input = Console.ReadLine()) != "end of contests")
            {
                string[] contestInfo = input.Split(':');

                string contest = contestInfo[0];
                string password = contestInfo[1];

                contests.Add(contest, password);
            }

            string input2;

            while((input2 = Console.ReadLine()) != "end of submissions")
            {
                string[] info = input2.Split("=>");

                string contest = info[0];
                string password = info[1];
                string username = info[2];
                int points = int.Parse(info[3]);

                if (!contests.ContainsKey(contest))
                {
                    continue;
                }
                else if(contests[contest] != password)
                {
                    continue;
                }

                if (!participants.ContainsKey(username))
                {
                    participants.Add(username, new Dictionary<string, int>());
                }

                if (participants[username].ContainsKey(contest))
                {
                    if(participants[username][contest] < points)
                    {
                        participants[username][contest] = points;
                        continue;
                    }
                }
                else if (!participants[username].ContainsKey(contest))
                {
                    participants[username].Add(contest, points);
                }

            }

            var bestCandidate = participants.OrderByDescending(x => x.Value.Values.Sum()).First();

            Console.WriteLine($"Best candidate is {bestCandidate.Key} with total {bestCandidate.Value.Values.Sum()} points.");
            Console.WriteLine("Ranking:");

            foreach (var contestant in participants.OrderBy(x => x.Key))
            {
                Console.WriteLine(contestant.Key);

                foreach (var contest in contestant.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
