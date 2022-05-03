using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tire[]> tiresList = new List<Tire[]>();
            List<Engine> engineList = new List<Engine>();
            List<Car> carList = new List<Car>();

            string tiresInput;

            while((tiresInput = Console.ReadLine()) != "No more tires")
            {
                double[] tiresInfo = tiresInput.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

                Tire[] tires = new Tire[4]
                {
                    new Tire((int)tiresInfo[0], tiresInfo[1]),
                    new Tire((int)tiresInfo[2], tiresInfo[3]),
                    new Tire((int)tiresInfo[4], tiresInfo[5]),
                    new Tire((int)tiresInfo[6], tiresInfo[7]),
                };

                tiresList.Add(tires);
            }

            string engineInput;

            while((engineInput = Console.ReadLine()) != "Engines done")
            {
                double[] engineInfo = engineInput.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

                Engine engine = new Engine((int)engineInfo[0], engineInfo[1]);

                engineList.Add(engine);
            }

            string carInput;

            while((carInput = Console.ReadLine()) != "Show special")
            {
                string[] carInfo = carInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string make = carInfo[0];
                string model = carInfo[1];
                int year = int.Parse(carInfo[2]);
                double fuelQuantity = double.Parse(carInfo[3]);
                double fuelConsumption = double.Parse(carInfo[4]);
                int engineIndex = int.Parse(carInfo[5]);
                int tiresIndex = int.Parse(carInfo[6]);

                Car car = new Car(
                    make,
                    model,
                    year,
                    fuelQuantity,
                    fuelConsumption,
                    engineList[engineIndex],
                    tiresList[tiresIndex]
                    );

                carList.Add(car);
            }

            Predicate<Car> isSpecial = (c) => c.Year >= 2017
                                           && c.Engine.HorsePower > 330
                                           && c.Tires.Sum(t => t.Pressure) >= 9
                                           && c.Tires.Sum(t => t.Pressure) <= 10;

            carList.Where(c => isSpecial(c)).ToList().ForEach(c => c.Drive(20));
            carList.Where(c => isSpecial(c)).ToList().ForEach(c => Console.WriteLine(c.WhoAmI()));
        }
    }
}
