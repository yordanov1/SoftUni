using System;
using System.Collections.Generic;
using System.Linq;

namespace Exer_09.PokemonTrainer
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Trainer> listTrainers = new List<Trainer>();

            string command = Console.ReadLine();

            while (command != "Tournament")
            {
                string[] input = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string trainerName = input[0];
                string pokemonName = input[1];
                string pokemonElement = input[2];
                int pokemonHealth = int.Parse(input[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                Trainer trainer = new Trainer(trainerName, 0, new List<Pokemon>());

                trainer.Pokemon.Add(pokemon);

                bool flag = false;

                foreach (var item in listTrainers)
                {
                    if (item.Name == trainerName)
                    {
                        item.Pokemon.Add(pokemon);
                        flag = true;
                    }
                }

                if (flag == false)
                {
                    listTrainers.Add(trainer);
                }                                                      

                command = Console.ReadLine();
            }

            string command2 = Console.ReadLine();
            
            while (command2 != "End")
            {
                foreach (var trainer in listTrainers)
                {
                    bool flag2 = false;
                    
                    foreach (var element in trainer.Pokemon)
                    {                        
                        if (element.Element == command2)
                        {
                            trainer.NumberOfBadges += 1;
                            flag2= true;
                            break;
                        }
                    }

                    if (flag2 == false)
                    {
                        for (int i = 0; i < trainer.Pokemon.Count; i++)
                        {
                            trainer.Pokemon[i].Health -= 10;

                            if (trainer.Pokemon[i].Health <= 0 )
                            {
                                trainer.Pokemon.RemoveAt(i);
                            }
                        } 
                    }
                }

                command2 = Console.ReadLine();
            }

            listTrainers = listTrainers.OrderByDescending(x => x.NumberOfBadges).ToList();

            foreach (var trainer in listTrainers)
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemon.Count}");
            }
        }
    }
}
