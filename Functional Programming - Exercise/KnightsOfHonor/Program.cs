using System;
using System.Linq;

namespace KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> giveEmHonor = (knight) => Console.WriteLine($"Sir {knight}");

            Console.ReadLine().Split(' ').ToList().ForEach(x => giveEmHonor(x));
        }
    }
}
