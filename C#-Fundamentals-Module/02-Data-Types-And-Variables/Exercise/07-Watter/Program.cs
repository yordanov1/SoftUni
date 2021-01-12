using System;

namespace EXER_07.Water
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int freeSpace = 255;
            int fill = 0;
            

            for (int i = 1; i <= n; i++)
            {
                int pour = int.Parse(Console.ReadLine());
                
                if((freeSpace - pour) >= 0)
                {
                    freeSpace = freeSpace - pour;
                    fill = fill + pour;                    
                }
                else if((freeSpace - pour) < 0)
                {
                    Console.WriteLine("Insufficient capacity!");
                } 
            }

            Console.WriteLine(fill);
        }
    }
}
