using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(input);

            Console.WriteLine(queue.Max());

            while(queue.Count > 0)
            {
                int currOrder = queue.Peek();

                if(food >= currOrder)
                {
                    food -= currOrder;
                    queue.Dequeue();

                    continue;
                }

                break;
            }

            if(queue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(' ', queue)}");
            }
        }
    }
}
