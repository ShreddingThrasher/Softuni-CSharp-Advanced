using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(input[i]);
            }

            int racks = 1;

            int sum = 0;

            while(stack.Count > 0)
            {
                sum += stack.Peek();

                if(sum <= rackCapacity)
                {
                    stack.Pop();
                }
                else
                {
                    racks++;
                    sum = 0;
                }
            }

            Console.WriteLine(racks);
        }
    }
}
