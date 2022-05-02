using System;
using System.Collections.Generic;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> carNumbers = new HashSet<string>();

            string input;

            while((input = Console.ReadLine()) != "END")
            {
                string[] command = input.Split(", ");

                string direction = command[0];
                string carNumber = command[1];

                switch (direction)
                {
                    case "IN":
                        carNumbers.Add(carNumber);
                        break;
                    case "OUT":
                        carNumbers.Remove(carNumber);
                        break;
                }
            }

            if(carNumbers.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, carNumbers));
            }
            else
            {
                Console.WriteLine($"Parking Lot is Empty");
            }
        }
    }
}
