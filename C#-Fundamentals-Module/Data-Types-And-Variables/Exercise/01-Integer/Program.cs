using System;

namespace EXER_01.Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int three = int.Parse(Console.ReadLine());
            int four = int.Parse(Console.ReadLine());


            long addOneTwo = one + two;
            decimal divide = addOneTwo / three;
            decimal multiply = divide * four;

            Console.WriteLine(multiply);

            


        }
    }
}
