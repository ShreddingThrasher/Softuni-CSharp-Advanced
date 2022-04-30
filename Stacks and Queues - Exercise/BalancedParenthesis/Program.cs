using System;
using System.Collections.Generic;
using System.Linq;

namespace BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> s = new Stack<char>();

            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (s.Any())
                {
                    char c = s.Peek();

                    if (c == '(' && input[i] == ')')
                    {
                        s.Pop();
                        continue;
                    }
                    else if (c == '[' && input[i] == ']')
                    {
                        s.Pop();
                        continue;
                    }
                    else if (c == '{' && input[i] == '}')
                    {
                        s.Pop();
                        continue;
                    }
                }
                s.Push(input[i]);
            }

            if (s.Any())
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
