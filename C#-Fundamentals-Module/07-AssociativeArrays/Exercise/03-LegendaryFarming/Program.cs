using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Reflection;

namespace EXER_3_LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> materials = new Dictionary<string, int>();

            SortedDictionary<string, int> junk = new SortedDictionary<string, int>();   

            int counter = 0;

            List<string> input = Console.ReadLine().ToLower().Split().ToList();

            materials.Add("shards", 0);
            materials.Add("fragments", 0);
            materials.Add("motes", 0);

            while (counter < 1)
            {
                bool z = false;

                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i+1] == "shards" || input[i+1] == "fragments" || input[i+1] == "motes")
                    {
                        if (materials.ContainsKey(input[i + 1]))
                        {
                            materials[input[i + 1]] += int.Parse(input[i]);
                        }
                        else
                        {
                            materials.Add(input[i + 1], int.Parse(input[i]));
                        }
                    }
                    else
                    {
                        if (junk.ContainsKey(input[i + 1]))
                        {
                            junk[input[i + 1]] += int.Parse(input[i]);
                        }
                        else
                        {
                            junk.Add(input[i + 1], int.Parse(input[i]));
                        }
                    }

                    i++;

                    if (materials.ContainsKey("shards"))
                    {
                        if (materials["shards"] >= 250)
                        {
                            counter++;
                            materials["shards"] -= 250;
                            Console.WriteLine("Shadowmourne obtained!");
                            z = true;
                            break;                            
                        }
                    }

                    if (materials.ContainsKey("fragments"))
                    {
                        if (materials["fragments"] >= 250)
                        {
                            counter++;
                            materials["fragments"] -= 250;
                            Console.WriteLine("Valanyr obtained!");
                            z = true;
                            break;                            
                        }
                    }
                    if (materials.ContainsKey("motes"))
                    {
                        if (materials["motes"] >= 250)
                        {
                            counter++;
                            materials["motes"] -= 250;
                            Console.WriteLine("Dragonwrath obtained!");
                            z = true;
                            break;                            
                        }
                    }
                }

                if (z == false)
                {
                    input = Console.ReadLine().ToLower().Split().ToList();
                }                
            }

            materials = materials.OrderByDescending(x => x.Value).ThenBy(y => y.Key).ToDictionary(a => a.Key, a => a.Value);

            foreach (var item in materials)
            {                
                    Console.WriteLine(item.Key + ": " + item.Value);               
            }

            foreach (var item2 in junk)
            {
                Console.WriteLine(item2.Key + ": " + item2.Value);
            }
        }
    }
}
