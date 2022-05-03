using System;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Tire[] tires = new Tire[4]
            {
                new Tire(1, 1.25),
                new Tire(1, 1.25),
                new Tire(1, 1.25),
                new Tire(1, 1.25),
            };

            Engine engine = new Engine(560, 6300);

            Car car = new Car("Dodge", "Viper", 2010, 250, 15, engine, tires);
        }
    }
}
