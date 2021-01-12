using System;

namespace MORE_05.Messeges
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());          
            string text = String.Empty;


            for (int i = 1; i <= number; i++)
            {
                string dailing = Console.ReadLine();

                if (dailing == "2")
                {
                    text = text + "a";
                }
                else if (dailing == "22")
                {
                    text = text + "b";
                }
                else if(dailing == "222")
                {
                    text = text + "c";
                }
                else if(dailing == "3")
                {
                    text = text + "d";
                }
                else if (dailing == "33")
                {
                    text = text + "e";
                }
                else if (dailing == "333")
                {
                    text = text + "f";
                }
                else if (dailing == "4")
                {
                    text = text + "g";
                }
                else if (dailing == "44")
                {
                    text = text + "h";
                }
                else if (dailing == "444")
                {
                    text = text + "i";
                }
                else if (dailing == "5")
                {
                    text = text + "j";
                }
                else if (dailing == "55")
                {
                    text = text + "k";
                }
                else if (dailing == "555")
                {
                    text = text + "l";
                }
                else if (dailing == "6")
                {
                    text = text + "m";
                }
                else if (dailing == "66")
                {
                    text = text + "n";
                }
                else if (dailing == "666")
                {
                    text = text + "o";
                }
                else if (dailing == "7")
                {
                    text = text + "p";
                }
                else if (dailing == "77")
                {
                    text = text + "q";
                }
                else if (dailing == "777")
                {
                    text = text + "r";
                }
                else if (dailing == "7777")
                {
                    text = text + "s";
                }
                else if (dailing == "8")
                {
                    text = text + "t";
                }
                else if (dailing == "88")
                {
                    text = text + "u";
                }
                else if (dailing == "888")
                {
                    text = text + "v";
                }
                else if (dailing == "9")
                {
                    text = text + "w";
                }
                else if (dailing == "99")
                {
                    text = text + "x";
                }
                else if (dailing == "999")
                {
                    text = text + "y";
                }
                else if (dailing == "9999")
                {
                    text = text + "z";
                }
                else if (dailing == "0")
                {
                    text = text + " ";
                }

            }

            Console.WriteLine(text);

        }
    }
}

//	2 abc 3 def 4 ghi 5 jkl 6 mno 7 pqrs 8 tuv 9 wxyz 0 space

