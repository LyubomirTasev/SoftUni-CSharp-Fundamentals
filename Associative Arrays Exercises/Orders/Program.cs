using System;
using System.Collections.Generic;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> output = new Dictionary<string, List<double>>();

            string command = Console.ReadLine();

            while (command != "buy")
            {
                string[] currentProduct = command.Split();

                string productName = currentProduct[0];
                double productPrice = double.Parse(currentProduct[1]);
                int quantity = int.Parse(currentProduct[2]);

                //List<double> priceAndQuantity = new List<double> { productPrice, quantity };

                if (!output.ContainsKey(productName))
                {
                    //output.Add(productName, priceAndQuantity);
                    output.Add(productName, new List<double> { productPrice, quantity });
                }
                else
                {
                    output[productName][0] = productPrice;
                    output[productName][1] = output[productName][1] + quantity;
                }


                command = Console.ReadLine();
            }

            foreach (var item in output)
            {
                double totalPrice = item.Value[0] * item.Value[1];
                Console.WriteLine($"{item.Key} -> {totalPrice:f2}");
            }
        }
    }
}
