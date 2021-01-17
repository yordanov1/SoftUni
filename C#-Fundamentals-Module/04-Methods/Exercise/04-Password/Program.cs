using System;
using System.Linq;
using System.Threading;

namespace EXER_04.Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool one = true;
            int count = 0;
            int countTwo = 0;

            LenghtFinder(password, one);
            LettersAndNumbersWeHave(password, countTwo, one);
            TwoNumbersWeHave(password, count, one);

            if (one == true)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static void LenghtFinder(string password, bool one)
        {
            if (password.Length < 6 || password.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                one = false;
            }

        }

        static void LettersAndNumbersWeHave(string password , int countTwo , bool one)
        {
            

            foreach (char item in password)
            {
                if (!char.IsLetterOrDigit(item))
                {
                    countTwo++;
                }
            }
            if (countTwo > 0)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                one = false;
            }
        }

        static void TwoNumbersWeHave(string password , int count , bool one)
        {
            foreach (char item in password)
            {
                if (char.IsDigit(item))
                {
                    count++;
                }
            }
            if (count < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                one = false;
            }

            

        }




    }
}
