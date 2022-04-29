using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();

            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                q.Enqueue(input[i]);
            }

            int count = q.Count;

            for (int i = 0; i < count; i++)
            {
                if(q.Peek() % 2 == 1)
                {
                    q.Dequeue();
                }
                else
                {
                    q.Enqueue(q.Dequeue());
                }
            }

            Console.WriteLine(string.Join(", ", q));
        }
    }
}
