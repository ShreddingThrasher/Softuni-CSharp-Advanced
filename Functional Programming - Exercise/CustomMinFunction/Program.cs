using System;
using System.Linq;

namespace CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> customMinFunction = CustomMin;

            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(customMinFunction(input));
        }

        static int CustomMin(int[] arr)
        {
            int min = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] < min)
                {
                    min = arr[i];
                }
            }

            return min;
        }
    }
}
