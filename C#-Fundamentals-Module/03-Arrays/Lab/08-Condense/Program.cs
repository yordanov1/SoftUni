using System;
using System.Linq;

namespace LAB_08.Condence
{
    class Program
    {
        static void Main(string[] args)
        {

            ;


            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //var inputLine = Console.ReadLine();
            //string[] a = inputLine.Split();
            //int[] arr = a.Select(int.Parse).ToArray();

            if (arr.Length == 1)
            {
                Console.WriteLine($"{arr[0]}");
            }
            else
            {
            






            int count = 0;



            while (arr[1] != 0 || arr[2] != 0)
            {
                count = count + 1;



                for (int i = 0; i < arr.Length - count; i++)
                {
                    arr[i] = arr[i] + arr[i + 1];


                }



                arr[arr.Length - count] = 0;



            }

            Console.WriteLine(arr[0]);
        }
        }
    }
}
