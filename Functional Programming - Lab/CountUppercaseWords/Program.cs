using System;

namespace CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Action<string, bool> print = Print;

            for (int i = 0; i < text.Length; i++)
            {
                print(text[i], char.IsUpper(text[i][0]));
            }
        }

        static void Print(string word, bool isStartingWithUppercase)
        {
            if (isStartingWithUppercase)
            {
                Console.WriteLine(word);
            }
        }
    }
}
