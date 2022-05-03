using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];
                double[] tiresSpecifications = input.Skip(5).Select(double.Parse).ToArray();

                Car car = new Car(
                    model,
                    engineSpeed,
                    enginePower,
                    cargoWeight,
                    cargoType,
                    tiresSpecifications
                    );

                cars.Add(car);
            }

            string criteria = Console.ReadLine();

            if(criteria == "fragile")
            {
                Console.WriteLine(
                    string.Join(Environment.NewLine,
                           cars.Where(c => c.Cargo.Type == criteria && c.Tires.Any(t => t.Pressure < 1))
                               .Select(c => c.Model)));
            }
            else if(criteria == "flammable")
            {
                Console.WriteLine(
                    string.Join(Environment.NewLine,
                           cars.Where(c => c.Cargo.Type == criteria && c.Engine.Power > 250)
                               .Select(c => c.Model)));
            }
        }
    }
}
