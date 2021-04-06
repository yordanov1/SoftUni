using System;
using System.IO;
using System.Linq;

namespace Exer_01.EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "../../../text.txt";

            int count = 0;

            using (var reader = new StreamReader(filePath))
            {
                string currentLine = reader.ReadLine();

                while (currentLine != null)
                {
                    if (count % 2 == 0)
                    {
                        string newLine = currentLine.Replace("-", "@").Replace(",", "@")
                                                    .Replace(".", "@").Replace("!", "@")
                                                    .Replace("?", "@");

                        var reversedLine = newLine.Split().Reverse().ToArray();

                        Console.WriteLine(string.Join(" ", reversedLine));
                    }

                    count++;

                    currentLine = reader.ReadLine();
                }
            }
        }     
    }
}
