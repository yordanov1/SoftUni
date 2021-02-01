using System;
using System.Collections.Generic;
using System.Linq;

namespace EXER_07.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {         
            List<string> list = Console.ReadLine().Split("|").ToList();

            for (int i = 0; i < list.Count; i++)
            {
                string word = list[i];
                string newWord = string.Empty;

                for (int j = 0; j < word.Length; j++)
                {                    
                    if (word[j] != ' ')
                    {
                        newWord +=  word[j];
                        newWord += ' ';
                    }
                }
                
                list.Insert(i, newWord);
                list.RemoveAt((i + 1));
            }

            list.Reverse();
            Console.WriteLine(string.Join("", list));
        }
    }
}
