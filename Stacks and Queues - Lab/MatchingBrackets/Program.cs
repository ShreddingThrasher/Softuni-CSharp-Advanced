using System;
using System.Collections.Generic;

namespace MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if(input[i] == '(')
                {
                    stack.Push(i);
                }
                else if(input[i] == ')')
                {
                    int openingBracketIndex = stack.Pop();

                    Console.WriteLine(input.Substring(openingBracketIndex, (i - openingBracketIndex) + 1));
                }
            }
        }
    }
}
