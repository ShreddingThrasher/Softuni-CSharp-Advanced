using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Engine> engines = new List<Engine>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] engineInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = engineInput[0];
                int power = int.Parse(engineInput[1]);

                Engine engine;

                switch (engineInput.Length)
                {
                    case 3:

                        int displacement;

                        if(int.TryParse(engineInput[2], out displacement))
                        {
                            engine = new Engine(model, power, displacement);
                        }
                        else
                        {
                            engine = new Engine(model, power, engineInput[2]);
                        }

                        break;
                    case 4:
                        engine = new Engine(model, power, int.Parse(engineInput[2]), engineInput[3]);
                        break;
                    default:
                        engine = new Engine(model, power);
                        break;
                }

                engines.Add(engine);
            }

            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                string[] carInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = carInput[0];
                string engineModel = carInput[1];

                Engine engine = engines.First(e => e.Model == engineModel);
                Car car;

                switch (carInput.Length)
                {
                    case 3:

                        int weight;

                        if(int.TryParse(carInput[2],out weight))
                        {
                            car = new Car(model, engine, weight);
                        }
                        else
                        {
                            car = new Car(model, engine, carInput[2]);
                        }

                        break;
                    case 4:
                        car = new Car(model, engine, int.Parse(carInput[2]), carInput[3]);
                        break;
                    default:
                        car = new Car(model, engine);
                        break;
                }

                cars.Add(car);
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
