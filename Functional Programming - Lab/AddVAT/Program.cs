using System;
using System.Linq;
using System.Collections.Generic;

namespace AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine().Split(", ").Select(double.Parse).ToList();

            Action<double> addVAT = AddVAT;

            input.ForEach(x => addVAT(x));
        }

        static void AddVAT(double price)
        {
            Console.WriteLine($"{price * 1.20:F2}");
        }
    }
}
