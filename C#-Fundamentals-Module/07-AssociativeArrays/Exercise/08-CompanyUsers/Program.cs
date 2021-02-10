using System;
using System.Collections.Generic;
using System.Linq;


namespace EXER_8_CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> companyAndId = Console.ReadLine().Split(" -> ").ToList();

            SortedDictionary<string, List<string>> dictionary = new SortedDictionary<string, List<string>>();

            while (companyAndId[0] != "End")
            {
                string company = companyAndId[0];
                string id = companyAndId[1];

                if (!dictionary.ContainsKey(company))
                {
                    dictionary.Add(company, new List<string>());
                    dictionary[company].Add(id);
                }
                else 
                {
                    if (!dictionary[company].Contains(id))
                    {
                        dictionary[company].Add(id);
                    }
                }

                companyAndId = Console.ReadLine().Split(" -> ").ToList();
            }

            foreach (var comp in dictionary)
            {
                Console.WriteLine($"{comp.Key}");

                foreach (var aid in comp.Value)
                {
                    Console.WriteLine($"-- {aid}");
                }
            }

        }
    }
}
