using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Lab_07.HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] children = Console.ReadLine().Split().ToArray();
            int potatoMoves = int.Parse(Console.ReadLine());

            Queue<string> childernRotation = new Queue<string>(children);

            while (childernRotation.Count > 1)
            {
                for (int i = 1; i < potatoMoves; i++)
                {
                    childernRotation.Enqueue(childernRotation.Dequeue());
                }
                Console.WriteLine($"Removed {childernRotation.Dequeue()}");
            }

            Console.WriteLine($"Last is {childernRotation.Dequeue()}");
        }
    }
}
