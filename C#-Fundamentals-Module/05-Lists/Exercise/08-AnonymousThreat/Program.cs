using System;
using System.Collections.Generic;
using System.Linq;

namespace EXER_08.AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();

            List<string> command = Console.ReadLine().Split().ToList();

            while (command[0] != "3:1")
            {
                if (command[0] == "merge")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    if (startIndex >= 0)
                    {
                        if (endIndex > names.Count - 1)
                        {
                            endIndex = names.Count - 1;
                        }
                        if (startIndex > names.Count - 1)
                        {
                            startIndex = names.Count - 1;
                        }

                        string united = string.Empty;

                        for (int i = startIndex; i <= endIndex - startIndex; i++)
                        {
                            united = united + names[i];
                        }

                        if (united == string.Empty)
                        {
                            command = Console.ReadLine().Split().ToList();
                            continue;
                        }

                        names.RemoveRange(startIndex, (endIndex - startIndex + 1));

                        names.Insert(startIndex, united);
                    }
                }
                else if (command[0] != "divide")
                {
                    int index = int.Parse(command[1]);
                    int parts = int.Parse(command[2]);

                    string separateWord = names[index];

                    separateWord.Substring(index, parts);

                    Console.WriteLine(separateWord);
                }

                command = Console.ReadLine().Split().ToList();
            }

            Console.WriteLine(string.Join(" ", names));
        }
    }
}
