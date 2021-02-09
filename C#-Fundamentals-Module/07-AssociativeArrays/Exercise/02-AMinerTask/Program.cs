using System;
using System.Collections.Generic;

namespace EXER_2_AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {

            string resources = Console.ReadLine();
            
            Dictionary<string, int> allInOne = new Dictionary<string, int>();

            while (resources != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (allInOne.ContainsKey(resources))
                {
                    allInOne[resources] += quantity; 
                }
                else
                {
                    allInOne.Add(resources, quantity);
                }

                resources = Console.ReadLine();                
            }            
            
            foreach (var resours in allInOne)
            {
                Console.WriteLine(resours.Key + " -> " + resours.Value);
            }            
        }
    }
}
