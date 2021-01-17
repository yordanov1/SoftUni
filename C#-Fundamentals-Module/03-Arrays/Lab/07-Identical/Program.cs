using System;
using System.Linq;

namespace LAB_07.Identical
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;
            
            int count2 = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                if(arr1[i] == arr2[i])
                {
                    sum += arr1[i];                    
                }
                else
                {                    
                    count2 += 1;
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
            }

            if(count2 == 0)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }      
            
        }
    }
}
