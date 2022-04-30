using System;
using System.Collections.Generic;
using System.Linq;

namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songsRaw = Console.ReadLine().Split(", ");

            Queue<string> songs = new Queue<string>();

            for (int i = 0; i < songsRaw.Length; i++)
            {
                songs.Enqueue(songsRaw[i]);
            }


            while(songs.Count > 0)
            {
                string input = Console.ReadLine();

                if (input.Contains("Add"))
                {
                    string song = input.Substring(4, input.Length - 4);

                    if (!songs.Contains(song))
                    {
                        songs.Enqueue(song);
                        continue;
                    }

                    Console.WriteLine($"{song} is already contained!");
                }
                else if(input == "Play")
                {
                    songs.Dequeue();
                }
                else if(input == "Show")
                {
                    Console.WriteLine(string.Join(", ", songs));
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
