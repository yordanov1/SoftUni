using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Exer_03.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string textDirectory = "../../../text.txt";
            string wordsDirectory = "../../../words.txt";

            var textLines = File.ReadAllLines(textDirectory);
            var words = File.ReadAllLines(wordsDirectory);

            var wordsCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string lowercaseWord = word.ToLower();

                if (!wordsCount.ContainsKey(lowercaseWord))
                {
                    wordsCount.Add(lowercaseWord, 0);
                }
            }

            foreach (var line in textLines)
            {
                var currentLine = line.ToLower()
                                      .Split(new char[] { ' ', '-', ',', '!', '?', '.', '\'' });

                foreach (var currentWord in currentLine)
                {
                    if (wordsCount.ContainsKey(currentWord))
                    {
                        wordsCount[currentWord]++;
                    }
                }
            }

            string actualResultPath = "../../../actualResult.txt";
            string expectedResultPath = "../../../expectedResult.txt";

            foreach (var kvp in wordsCount)
            {
                File.AppendAllText(actualResultPath, $"{kvp.Key} - {kvp.Value}{Environment.NewLine}");
            }

            foreach (var kvp in wordsCount.OrderByDescending(x => x.Value))
            {
                File.AppendAllText(expectedResultPath, $"{kvp.Key} - {kvp.Value}{Environment.NewLine}");
            }
        }
    }
}
