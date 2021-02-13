using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace EXER_1_ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {            
            string[] words = Console.ReadLine().Split(", ").ToArray();

            List<string> filtered = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length >= 3 && words[i].Length <= 16)
                {
                    string currendWord = words[i];

                    bool flag = true;

                    for (int j = 0; j < words[i].Length; j++)
                    {
                        if (!(char.IsLetterOrDigit(currendWord[j]) || currendWord[j] == '_' || currendWord[j] == '-'))
                        {
                            flag = false;
                        }
                    }

                    if (flag)
                    {
                        filtered.Add(words[i]);
                    }
                }
            }
            foreach (var filt in filtered)
            {
                Console.WriteLine(filt);
            }            
        }
    }
}
