using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Exer_06.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputSongs = Console.ReadLine()
                                         .Split(", ")
                                         .ToArray<string>();
            Queue<string> songs = new Queue<string>(inputSongs);

            while (songs.Count > 0)
            {
                List<string> commands = Console.ReadLine()
                                               .Split("Add ",StringSplitOptions.RemoveEmptyEntries)
                                               .ToList();
                string command = commands[0];

                if (command.Contains("Play"))
                {
                    songs.Dequeue();
                }
                else if (!(command.Contains("Play")) && !(command.Contains("Show")))
                {
                    string song = command;

                    if (!songs.Contains(song))
                    {
                        songs.Enqueue(song);
                    }
                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                }
                else if (command.Contains("Show"))
                {
                    Console.WriteLine(string.Join(", ",songs));
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
