using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();

            string input;

            while((input = Console.ReadLine()) != "Revision")
            {
                string[] info = input.Split(", ");
                string shop = info[0];
                string product = info[1];
                double price = double.Parse(info[2]);

                if (!shops.ContainsKey(shop))
                {
                    shops.Add(shop, new Dictionary<string, double>());
                }

                shops[shop].Add(product, price);
            }

            foreach (var item in shops.OrderBy(s => s.Key))
            {
                Console.WriteLine($"{item.Key}->");

                foreach (var product in shops[item.Key])
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
