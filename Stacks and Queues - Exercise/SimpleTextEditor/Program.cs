using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleTextEditor
{
    class Editor
    {
        static void Main(string[] args)
        {
            Stack<string> backup = new Stack<string>();

            string text = "";

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                switch (input[0])
                {
                    case "1":
                        backup.Push(text);
                        text += input[1];
                        break;
                    case "2":
                        int count = int.Parse(input[1]);
                        int index = (text.Length) - count;
                        backup.Push(text);
                        text = text.Remove(index);
                        break;
                    case "3":
                        int x = int.Parse(input[1]);
                        Console.WriteLine(text[x - 1]);
                        break;
                    case "4":
                        text = backup.Pop();
                        break;
                }
            }
        }
    }
}
