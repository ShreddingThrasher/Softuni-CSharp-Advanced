using System;
using System.Collections.Generic;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>();
            int passed = 0;

            string input;

            while((input = Console.ReadLine()) != "end")
            {
                if(input != "green")
                {
                    queue.Enqueue(input);
                    continue;
                }

                for (int i = 0; i < n; i++)
                {
                    if(queue.Count == 0)
                    {
                        break;
                    }

                    Console.WriteLine($"{queue.Dequeue()} passed!");
                    passed++;
                }
            }

            Console.WriteLine($"{passed} cars passed the crossroads.");
        }
    }
}
