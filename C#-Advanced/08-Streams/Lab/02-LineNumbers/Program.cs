using System;
using System.IO;

namespace Lab_02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../input.txt"))
            {
                using (StreamWriter writer = new StreamWriter("../../../output.txt"))
                {
                    string line = reader.ReadLine();
                    int row = 1;
                    while (line != null)
                    {
                        writer.WriteLine($"{row}. {line}");
                        row++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
