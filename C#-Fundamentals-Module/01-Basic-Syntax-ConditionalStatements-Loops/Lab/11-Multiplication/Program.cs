using System;

namespace LAB_11.Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {

           
                int number = int.Parse(Console.ReadLine());
                int multplayer = int.Parse(Console.ReadLine());


                if (multplayer <= 10)
                {
                    for (int i = multplayer + 1; multplayer <= 10; multplayer++)
                    {
                        int sum = number * multplayer;

                        Console.WriteLine($"{number} X {multplayer} = {sum}");
                    }
                }
                else
                {
                    int sumOne = number * multplayer;

                    Console.WriteLine($"{number} X {multplayer} = {sumOne}");
                

            
        
    }

}
    }
}
