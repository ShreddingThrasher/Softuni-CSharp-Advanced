using System;
using System.Collections.Generic;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Stack<string> stack = new Stack<string>();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                stack.Push(input[i]);
            }

            int result = int.Parse(stack.Pop());

            while(stack.Count > 0)
            {
                string operation = stack.Pop();
                int number = int.Parse(stack.Pop());

                switch (operation)
                {
                    case "+":
                        result += number;
                        break;
                    case "-":
                        result -= number;
                        break;
                    case "*":
                        result *= number;
                        break;
                    case "/":
                        result /= number;
                        break;
                }
            }

            Console.WriteLine(result);
        }
    }
}
