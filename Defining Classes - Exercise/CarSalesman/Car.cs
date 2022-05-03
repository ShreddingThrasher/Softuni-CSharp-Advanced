using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Car
    {
        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
        }
        public Car(string model, Engine engine, int weight)
            : this(model, engine)
        {
            this.Weight = weight;
        }
        public Car(string model, Engine engine, string color)
            : this(model, engine)
        {
            this.Color = color;
        }
        public Car(string model, Engine engine, int weight, string color)
            : this(model, engine, weight)
        {
            this.Color = color;
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; } = "n/a";
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            string weight = this.Weight != 0 ? this.Weight.ToString() : "n/a"; 

            sb.AppendLine($"{this.Model}:");
            sb.AppendLine($"  {this.Engine.ToString()}");
            sb.AppendLine($"  Weight: {weight}");
            sb.AppendLine($"  Color: {this.Color}");

            return sb.ToString().TrimEnd();
        }
    }
}
