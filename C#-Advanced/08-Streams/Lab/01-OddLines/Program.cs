using System;
using System.IO;

namespace Lab_01.OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader(@"C:\Users\Yordanov\source\repos\Streams\Lab_01.OddLines\input.txt"))
            {
                string currentRow = reader.ReadLine();
                int row = 0;

                using (StreamWriter writer = new StreamWriter("../../../output.txt"))
                {
                    while (currentRow != null)
                    {
                        if (row % 2 == 1)
                        {
                            writer.WriteLine(currentRow);
                        }

                        currentRow = reader.ReadLine();
                        row++;
                    }
                }                                
            }
        }
    }
}
