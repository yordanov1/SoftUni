using System;

namespace LAB_03.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {            
            string option = Console.ReadLine();
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());

            OptionCalcularion(option, numOne, numTwo);
        }

        private static void OptionCalcularion(string option, int numOne, int numTwo)
        {
            if (option == "add")
            {
                Console.WriteLine(numOne + numTwo);
            }
            else if (option == "multiply")
            {
                Console.WriteLine(numOne * numTwo);
            }
            else if (option == "subtract")
            {
                Console.WriteLine(numOne - numTwo);
            }
            else if (option == "divide")
            {
                Console.WriteLine(numOne / numTwo);
            }


        }
    }
}
