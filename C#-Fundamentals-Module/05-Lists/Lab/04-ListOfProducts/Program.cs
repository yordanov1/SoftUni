using System;
using System.Collections.Generic;

namespace LAB_04.ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> listAZ = new List<string>();

            for (int i = 0; i < n; i++)
            {
                listAZ.Add(Console.ReadLine());
            }

            listAZ.Sort();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i + 1}.{listAZ[i]}");
            }

        }
    }
}
