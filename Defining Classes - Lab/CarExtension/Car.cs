using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;

        public string Make { get => this.make; set => this.make = value; }
        public string Model { get => this.model; set => this.model = value; }
        public int Year { get => this.year; set => this.year = value; }
        public double FuelQuantity { get => this.fuelQuantity; set => this.fuelQuantity = value; }
        public double FuelConsumption { get => this.fuelConsumption; set => this.fuelConsumption = value; }
        public void Drive(double distance)
        {
            if((this.fuelQuantity - this.fuelConsumption * distance) >= 0)
            {
                this.fuelQuantity -= this.fuelConsumption * distance;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }
        public string WhoAmI()
        {
            return $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelQuantity:F2}";
        }
    }
}
