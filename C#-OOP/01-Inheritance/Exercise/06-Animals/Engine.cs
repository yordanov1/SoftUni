using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animals
{
    public class Engine
    {
        private const string END_OF_INPUT_COMMAND = "Beast!";

        private readonly List<Animal> animals;

        public Engine()
        {
            this.animals = new List<Animal>();
        }

        public void Run()
        {
            string type;

            while ((type = Console.ReadLine()) != END_OF_INPUT_COMMAND)
            {
                string[] animalArgs = Console.ReadLine().Split(' ').ToArray();

                string name = animalArgs[0];
                int age = int.Parse(animalArgs[1]);
                string gender = null;

                if (animalArgs.Length >= 3)
                {
                    gender = animalArgs[2];
                }

                Animal animal;

                try
                {
                    animal = GetAnimal(type, animalArgs);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
               
                this.animals.Add(animal);

            }

            foreach (Animal animal in this.animals)
            {
                Console.WriteLine(animal);
            }
        }

        private Animal GetAnimal(string type, string[] animalArgs)
        {
            string name = animalArgs[0];
            int age = int.Parse(animalArgs[1]);
            string gender = null;

            if (animalArgs.Length >= 3)
            {
                gender = animalArgs[2];
            }

            Animal animal = null;

            if (type == "Dog")
            {
                animal = new Dog(name, age, animalArgs[2]);
            }
            else if (type == "Cat")
            {
                animal = new Cat(name, age, animalArgs[2]);
            }
            else if (type == "Frog")
            {
                animal = new Frog(name, age, animalArgs[2]);
            }
            else if (type == "Kittens")
            {
                animal = new Kitten(name, age);
            }
            else if (type == "Tomcat")
            {
                animal = new Tomcat(name, age);
            }
            else
            {
                throw new ArgumentException("Ivalid input");
            }
            return animal;
        }        
    }
}
