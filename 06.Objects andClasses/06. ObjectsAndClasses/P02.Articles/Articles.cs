using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> article = Console.ReadLine().Split(", ").ToList();
            int commandsAmmount = int.Parse(Console.ReadLine());
            Article theArticle = new Article(article[0], article[1], article[2]);

            for (int i = 0; i < commandsAmmount; i++)
            {
                List<string> command = Console.ReadLine().Split(": ").ToList();

                if (command[0] == "Edit")
                {
                    theArticle.Edit(command[1]);
                }
                else if (command[0] == "ChangeAuthor")
                {
                    theArticle.ChangeAuthor(command[1]);
                }
                else if (command[0] == "Rename")
                {
                    theArticle.Rename(command[1]);
                }

            }

            Console.WriteLine(theArticle.ToString());
        }
    }

    class Article
    {
        public string Title;
        public string Content;
        public string Author;

        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public void Edit(string newContent)
        {
            Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }
        public void Rename(string newTitle)
        {
            Title = newTitle;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
