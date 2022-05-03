using System;
using System.Linq;

namespace DateModifier
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] input2 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int firstYear = int.Parse(input1[0]);
            int firstMonth = int.Parse(input1[1].TrimStart('0'));
            int firstday = int.Parse(input1[2].TrimStart('0'));

            int secondYear = int.Parse(input2[0]);
            int secondMonth = int.Parse(input2[1].TrimStart('0'));
            int secondDay = int.Parse(input2[2].TrimStart('0'));

            DateTime first = new DateTime(firstYear, firstMonth, firstday);
            DateTime second = new DateTime(secondYear, secondMonth, secondDay);

            Console.WriteLine(DateModifier.GetDifferenceInDays(first, second));
        }
    }
}
