using System;

namespace MORE_02.LEftRight
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();

                int one = int.Parse(first);
                int two = int.Parse(second);

                int sum = 0;
                if (one > two)
                {
                    for (int j = 0; j < first.Length; j++)
                    {
                        int currentNumber = (int)Char.GetNumericValue(first[j]);
                        sum += currentNumber;
                    }
                }
                else if (one < two)
                {
                    for (int j = 0; j < second.Length; j++)
                    {
                        int currentNumber = (int)Char.GetNumericValue(second[j]);
                        sum += currentNumber;
                    }
                }

                Console.WriteLine(sum);            
            }
        }
    }
}
