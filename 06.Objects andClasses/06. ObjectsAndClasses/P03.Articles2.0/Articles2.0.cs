using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.Articles2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberArticles = int.Parse(Console.ReadLine());
            List<Article> articleList = new List<Article>();

            for (int i = 0; i < numberArticles; i++)
            {
                List<string> articlesInput = Console.ReadLine().
                    Split(", ")
                    .ToList();
                Article article = new Article
                {
                    Title = articlesInput[0],
                    Content = articlesInput[1],
                    Author = articlesInput[2]
                };

                articleList.Add(article);
            }


            string orderCriteria = Console.ReadLine();

            if (orderCriteria == "title")
            {
                articleList = articleList.OrderBy(x => x.Title).ToList();
            }
            else if (orderCriteria == "content")
            {
                articleList = articleList.OrderBy(y => y.Content).ToList();
            }
            else if (orderCriteria == "author")
            {
                articleList = articleList.OrderBy(z => z.Author).ToList();
            }

            Console.WriteLine(string.Join(Environment.NewLine, articleList));
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

        public Article()
        {
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
