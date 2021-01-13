using System;

namespace EXER_07.MaxElement2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] traveler = Console.ReadLine().Split();
            int count = 0;
            int index = 0;

            for (int i = 0; i < traveler.Length; i++)
            {
                string current = traveler[i];
                int curCounter = 1;

                for (int j = i + 1; j < traveler.Length; j++)
                {
                    if(current == traveler[j])
                    {
                        curCounter++;
                    }
                    else
                    {
                        break;
                    }
                }

                if(curCounter > count)
                {
                    count = curCounter;
                    index = i;
                }
            }

            for (int i = 0; i < count; i++)
            {
                Console.Write(traveler[index] + " ");
            }
        }
    }
}
