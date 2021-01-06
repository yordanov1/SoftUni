using System;

namespace MORE_01.DataType
{
    class Program
    {
        static void Main(string[] args)
        {

            string dataType = Console.ReadLine(); //

            while(dataType != "END")
            {
                bool isBool = bool.TryParse(dataType, out bool boolValue); 
                bool isChar = char.TryParse(dataType, out char charValue);
                bool isInt = int.TryParse(dataType, out int intValue);
                bool isDouble = double.TryParse(dataType, out double doubleValue);
                
                
                if (isInt)
                {
                    Console.WriteLine($"{dataType} is integer type");
                }
                else if (isDouble)
                {
                    Console.WriteLine($"{dataType} is floating point type");
                }
                else if (isBool)
                {
                    Console.WriteLine($"{dataType} is boolean type");
                }
                else if (isChar)
                {
                    Console.WriteLine($"{dataType} is character type");
                }
                else 
                {
                    Console.WriteLine($"{dataType} is string type");
                }

                dataType = Console.ReadLine();
            }

        }
    }
}
