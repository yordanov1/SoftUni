﻿using System;
using System.IO;

namespace EXER_02.Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(", ");

            Article article = new Article(tokens[0], tokens[1], tokens[2]);

            int n = int.Parse(Console.ReadLine()); 

            for (int i = 0; i < n; i++)
            {
                string[] cmdArg = Console.ReadLine().Split(": ");
                string command = cmdArg[0];
                string argument = cmdArg[1];

                switch (command)
                {
                    case "Edit":
                        article.Edit(argument);
                        break;

                    case "ChangeAuthor":
                        article.ChangeAuthor(argument);
                        break;
                    case "Rename":
                        article.Rename(argument);
                        break;
                }
            }

            Console.WriteLine(article.ToString());
        }

        class Article
        {
            public Article(string title, string content, string author)
            {
                Title = title;
                Content = content;
                Author = author;
            }

            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public void Edit(string content)
            {
                Content = content; 
            }

            public void ChangeAuthor(string author)
            {
                Author = author;
            }

            public void Rename(string title) 
            {
                Title = title;
            }

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}"; 
            }

        }
    }
}
