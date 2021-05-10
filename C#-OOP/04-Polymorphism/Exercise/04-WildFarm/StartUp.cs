using Exer_04.WildFarm.Animals;
using Exer_04.WildFarm.Animals.Birds;
using Exer_04.WildFarm.Animals.Mammals;
using Exer_04.WildFarm.Animals.Mammals.Felines;
using Exer_04.WildFarm.Foods;
using System;
using System.Collections.Generic;

namespace Exer_04.WildFarm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string[] animalParts = line.Split();

                Animal animal = CreateAnimal(animalParts);

                animals.Add(animal);

                string[] foodParts = Console.ReadLine().Split();

                Food food = CreateFood(foodParts);

                Console.WriteLine(animal.ProduceSound());


                try
                {
                    animal.Eat(food);
                }
                catch (InvalidOperationException ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }

        private static Food CreateFood(string[] foodParts)
        {
            string type = foodParts[0];
            int quantity = int.Parse(foodParts[1]);

            Food food = null;

            if (type == nameof(Meat))
            {
                food = new Meat(quantity);
            }
            else if (type == nameof(Vegetable))
            {
                food = new Vegetable(quantity);
            }

            if (type == nameof(Fruit))
            {
                food = new Fruit(quantity);
            }

            if (type == nameof(Seeds))
            {
                food = new Seeds(quantity);
            }

            return food;
        }

        private static Animal CreateAnimal(string[] parts)
        {
            string type = parts[0];

            Animal animal = null;

            string name = parts[1];

            double weight = double.Parse(parts[2]);

            if (type == nameof(Hen))
            {
                double wingSize = double.Parse(parts[3]);
                animal = new Hen(name, weight, wingSize);
            }
            else if (type == nameof(Owl))
            {
                double wingSize = double.Parse(parts[3]);
                animal = new Owl(name, weight, wingSize);
            }
            else if (type == nameof(Mouse))
            {
                string livinRegion = parts[3];
                animal = new Mouse(name, weight, livinRegion);
            }
            else if (type == nameof(Dog))
            {
                string livinRegion = parts[3];
                animal = new Dog(name, weight, livinRegion);
            }
            else if (type == nameof(Cat))
            {
                string livinRegion = parts[3];
                string breed = parts[4];
                animal = new Cat(name, weight, livinRegion, breed);
            }
            else if (type == nameof(Tiger))
            {
                string livinRegion = parts[3];
                string breed = parts[4];
                animal = new Tiger(name, weight, livinRegion, breed);
            }

            return animal;
        }
    }
}
