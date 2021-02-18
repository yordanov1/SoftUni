using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace EXER_3_SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            List<string> product = new List<string>();
            List<double> price = new List<double>();            

            string patern = @"%(?<costuer>[A-Z][a-z]+)%[^\|\$\%\.]*<(?<product>\w+)>[^\|\$\%\.]*\|(?<count>[0-9]+)\|[^\|\$\%\.]*(?<![0-9])(?<price>[0-9]+\.?[0-9]*)\$";
            Regex regex = new Regex(patern);

            string input = Console.ReadLine();

            while (input != "end of shift")
            {
                var sucsess = regex.Match(input);

                if (sucsess.Success)
                {
                    names.Add(sucsess.Groups["costuer"].Value);
                    product.Add(sucsess.Groups["product"].Value);
                    price.Add((double.Parse(sucsess.Groups["count"].Value)) * (double.Parse(sucsess.Groups["price"].Value)));
                }

                input = Console.ReadLine();
            }

            double priceAll = price.Sum();

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"{names[i]}: {product[i]} - {price[i]:f}");
            }

            Console.WriteLine($"Total income: {priceAll:f2}");
        }
    }
}
