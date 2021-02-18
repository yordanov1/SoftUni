using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace EXER_1_Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>(?<furniture>[A-Za-z]+)<<(?<price>[0-9]+\.?[0-9]+)!(?<count>[0-9]{1,})";
            Regex regexxx = new Regex(pattern);
            double price = 0;

            string input = Console.ReadLine();

            List<string> AllInList = new List<string>();
           
            while (input != "Purchase")
            {                
                Match allIn = regexxx.Match(input);

                if (allIn.Success)
                {
                    AllInList.Add(allIn.Groups[1].Value);

                    price += double.Parse(allIn.Groups["price"].Value) * double.Parse(allIn.Groups["count"].Value);                    
                }

                input = Console.ReadLine();                
            }

            Console.WriteLine("Bought furniture:");

            foreach (var item in AllInList)
            {              
                Console.WriteLine(item);
            }

            if (AllInList.Count > 0)
            {
                Console.WriteLine($"Total money spend: {price:f2}");
            }
            else
            {
                Console.WriteLine("Total money spend: 0.00");
            }
        }
    }
}
