using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Car
    {
        public Car(string model, int engineSpeed, int enginePower, int cargoWeight,
            string cargoType, double[] tiresSpecifications)
        {
            this.Model = model;
            this.Engine = new Engine(engineSpeed, enginePower);
            this.Cargo = new Cargo(cargoType, cargoWeight);
            this.Tires = new Tire[4]
            {
                new Tire(tiresSpecifications[0], (int)tiresSpecifications[1]),
                new Tire(tiresSpecifications[2], (int)tiresSpecifications[3]),
                new Tire(tiresSpecifications[4], (int)tiresSpecifications[5]),
                new Tire(tiresSpecifications[6], (int)tiresSpecifications[7]),
            };
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tire[] Tires { get; set; }
    }
}
