using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                stack.Push(numbers[i]);
            }

            string input;

            while((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                switch (command[0].ToLower())
                {
                    case "add":
                        stack.Push(int.Parse(command[1]));
                        stack.Push(int.Parse(command[2]));
                        break;
                    case "remove":
                        int removeCount = int.Parse(command[1]);

                        if(removeCount > stack.Count)
                        {
                            continue;
                        }

                        for (int i = 0; i < removeCount; i++)
                        {
                            stack.Pop();
                        }
                        break;
                }
            }

            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
