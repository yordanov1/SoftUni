using System;

namespace Exer_07.Tuple
{
    public class Program
    {
        static void Main(string[] args)
        {

            var personInfo = Console.ReadLine().Split();
            string fullName = $"{personInfo[0]} {personInfo[1]}";
            string address = $"{personInfo[2]}";

            var nameAndBeer = Console.ReadLine().Split();
            string name = nameAndBeer[0];
            int beerAmount = int.Parse(nameAndBeer[1]);

            var thirdInput = Console.ReadLine().Split();
            var firstArgument = int.Parse(thirdInput[0]);
            var secondArgument = double.Parse(thirdInput[1]);

            Tuple<string, string> firsTuple = new Tuple<string, string>(fullName, address);
            Tuple<string, int> secondTuple = new Tuple<string, int>(name, beerAmount);
            Tuple<int, double> thirdTuple = new Tuple<int, double>(firstArgument, secondArgument);

            Console.WriteLine(firsTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);
        }
    }
}
