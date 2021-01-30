using System;
using System.Collections.Generic;
using System.Linq;

namespace EXER_02.ChangeTheList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> element = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split();

            while (command[0] != "end")
            {
                if (command[0] == "Delete")
                {
                    int elementToDel = int.Parse(command[1]);
                    
                    element.RemoveAll(i => i == elementToDel);
                }
                else if(command[0] == "Insert")
                {
                    int position = int.Parse(command[2]);
                    int numberToPut = int.Parse(command[1]);

                    element.Insert(position, numberToPut);
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ",element));
        }
    }
}
