using System;
using System.Collections.Generic;
using System.Linq;

namespace EXWR_09.Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemon = Console.ReadLine().Split().Select(int.Parse).ToList();

            int removedElement = 0;

            while (pokemon.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    removedElement += pokemon[0];

                    for (int i = 0; i < pokemon.Count; i++)
                    {
                        if (pokemon[0] <= pokemon[i])
                        {
                            pokemon[i] = pokemon[i] - pokemon[0];
                        }
                        else
                        {
                            pokemon[i] = pokemon[i] + pokemon[0];
                        }                        
                    }
                    
                    pokemon.RemoveAt(0);
                    pokemon.Insert(0, pokemon[pokemon.Count - 1]);

                    continue;
                }
                if (index > (pokemon.Count-1))
                {
                    removedElement += pokemon[pokemon.Count - 1];

                    for (int i = 0; i < pokemon.Count; i++)
                    {
                        if ((pokemon[pokemon.Count-1])>pokemon[i])
                        {
                            pokemon[i] = pokemon[i] + pokemon[pokemon.Count - 1];
                        }
                        else
                        {
                            pokemon[i] = pokemon[i] - pokemon[pokemon.Count - 1];
                        }
                    }
                    
                    pokemon.RemoveAt(pokemon.Count - 1);
                    pokemon.Add(pokemon[0]);

                    continue;
                }

                for (int i = 0; i < pokemon.Count; i++)
                {
                    if (i != index)
                    {
                        if (pokemon[i] > pokemon[index])
                        {
                            pokemon[i] -= pokemon[index];
                        }
                        else if (pokemon[i] <= pokemon[index])
                        {
                            pokemon[i] += pokemon[index];
                        }
                    }                  
                }

                removedElement = removedElement + pokemon[index];

                pokemon.RemoveAt(index);
            }

            Console.WriteLine(removedElement);
        }
    }
}
