using System;
using System.Collections.Generic;
using System.Linq;

namespace TheVLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> vloggers = new Dictionary<string, List<string>>();

            string input;

            while((input = Console.ReadLine()) != "Statistics")
            {
                string[] command = input.Split(' ');

                string vlogger = command[0];

                if(command[1] == "joined")
                {
                    if (!vloggers.ContainsKey(vlogger))
                    {
                        vloggers.Add(vlogger, new List<string>());
                    }
                }
                else
                {
                    string followed = command[2];

                    if(!vloggers.ContainsKey(vlogger) || !vloggers.ContainsKey(followed))
                    {
                        continue;
                    }
                    else if(vlogger == followed)
                    {
                        continue;
                    }
                    else if (vloggers[followed].Contains(vlogger))
                    {
                        continue;
                    }

                    vloggers[followed].Add(vlogger);
                }
            }

            var mostFamousVLogger = vloggers.OrderByDescending(x => x.Value.Count).First();
            int mostFamousVLoggerFollowing = vloggers.Where(x => x.Value.Contains(mostFamousVLogger.Key)).Count();

            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");
            Console.WriteLine($"1. {mostFamousVLogger.Key} : {mostFamousVLogger.Value.Count} followers, {mostFamousVLoggerFollowing} following");

            foreach (string follower in mostFamousVLogger.Value.OrderBy(x => x))
            {
                Console.WriteLine($"*  {follower}");
            }

            int n = 2;

            var sorted = vloggers.OrderByDescending(x => x.Value.Count)
                                 .ThenBy(x => vloggers.Where(v => v.Value.Contains(x.Key)).Count());

            foreach (var vlogger in sorted)
            {
                if(mostFamousVLogger.Key == vlogger.Key)
                {
                    continue;
                }

                int currFollowing = vloggers.Where(x => x.Value.Contains(vlogger.Key)).Count();
                Console.WriteLine($"{n}. {vlogger.Key} : {vlogger.Value.Count} followers, {currFollowing} following");
                n++;
            }
        }
    }
}
