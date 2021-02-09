using System;
using System.Collections.Generic;
using System.Linq;

namespace EXER_4_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = Console.ReadLine().Split().ToList();

            Dictionary<string, List<double>> book = new Dictionary<string, List<double>>();

            while (products[0] != "buy")
            {
                string product = products[0];
                double price = double.Parse(products[1]);
                double quantity = double.Parse(products[2]);

                if (!book.ContainsKey(product))
                {
                    book.Add(product, new List<double> { price , quantity});
                }
                else
                {
                    book[product][0] = price;
                    book[product][1] += quantity;                   
                }

                products = Console.ReadLine().Split().ToList();
            }

            foreach (var bookche in book)
            {               
                double multiplyed = bookche.Value[0] * bookche.Value[1];

                Console.WriteLine($"{ bookche.Key} -> {multiplyed:f2}");
            }
        }
    }
}
