using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EXER_7_StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder newText = new StringBuilder();

            int bomb = 0; 

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '>')
                {
                    bomb = bomb + int.Parse((text[i + 1]).ToString());
                    newText.Append(text[i]);
                    continue;
                }
                else if (text[i] != '>' && bomb == 0)
                {                    
                    newText.Append(text[i]);
                    continue;
                }
                else if (text[i] != '>' && bomb > 0)
                {
                    bomb--;
                }
            }

            string ended = newText.ToString();

            Console.WriteLine(ended);
        }
    }
}
