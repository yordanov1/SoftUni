using System;
using System.IO;
using System.Linq;

namespace Exer_02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string textDirectory = "../../../text.txt";
            string returnDirectory = "../../../return.txt";

            var textLines = File.ReadAllLines(textDirectory);

            int lineCounter = 1;

            foreach (var line in textLines)
            {
                int lettersCount = line.Count(char.IsLetter);
                int marksCount = line.Count(char.IsPunctuation);

                File.AppendAllText(returnDirectory, $"Line {lineCounter}: {line} ({lettersCount})({marksCount}){Environment.NewLine}");

                lineCounter++;
            }
        }
    }
}
