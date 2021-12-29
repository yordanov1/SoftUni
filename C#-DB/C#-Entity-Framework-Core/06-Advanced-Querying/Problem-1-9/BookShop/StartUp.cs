namespace BookShop
{
    using BookShop.Models.Enums;
    using Data;
    using Initializer;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            using var db = new BookShopContext();

            DbInitializer.ResetDatabase(db);

            //Problem 2 
            //Console.WriteLine(GetBooksByAgeRestriction(db, "miNor"));

            //Problem 3 
            //Console.WriteLine(GetGoldenBooks(db));

            //Problem 4 
            //Console.WriteLine(GetBooksByPrice(db));

            //Problem 5 
            //Console.WriteLine(GetBooksNotReleasedIn(db, 2000));

            //Problem 6 
            //Console.WriteLine(GetBooksByCategory(db, "horror mystery drama"));

            //Problem 7 
            //Console.WriteLine(GetBooksReleasedBefore(db, "12-04-1992"));

            //Problem 8 
            //Console.WriteLine(GetAuthorNamesEndingIn(db, "e"));

            //Problem 9 
            Console.WriteLine(GetBookTitlesContaining(db, "sK"));
        }


        //Problem 2 
        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            var ageRestriction = Enum.Parse<AgeRestriction>(command, true);

            var books = context.Books
                .Where(x => x.AgeRestriction == ageRestriction)
                .Select(x => x.Title)
                .OrderBy(x => x)
                .ToList();

            var result = string.Join(Environment.NewLine, books);

            return result;
        }

        //Problem 3 
        public static string GetGoldenBooks(BookShopContext context)
        {
            var books = context.Books
                .Where(x => x.EditionType == EditionType.Gold && x.Copies < 5000)
                .Select(x => new
                {
                    Id = x.BookId,
                    Title = x.Title
                })
                .OrderBy(x => x.Id)
                .ToList();

            var sb = new StringBuilder();

            foreach (var book in books)
            {
                sb.AppendLine(book.Title);
            }

            var result = sb.ToString().TrimEnd();

            return result;
        }

        //Problem 4 
        public static string GetBooksByPrice(BookShopContext context)
        {
            var books = context.Books
                .Where(books => books.Price > 40)
                .Select(x => new
                {
                    Title = x.Title,
                    Price = x.Price
                })
                .OrderByDescending(x => x.Price)
                .ToList();


            var sb = new StringBuilder();


            foreach (var book in books)
            {
                sb.AppendLine($"{book.Title} - ${book.Price:f2}");
            }

            var result = sb.ToString().TrimEnd();

            return result;
        }

        //Problem 5 
        public static string GetBooksNotReleasedIn(BookShopContext context, int year)
        {
            var books = context.Books
                .Where(x => x.ReleaseDate.Value.Year != year && x.ReleaseDate.HasValue)
                .Select(x => new
                {
                    x.BookId,
                    x.Title
                })
                .OrderBy(x => x.BookId)
                .ToList();


            var sb = new StringBuilder();

            foreach (var book in books)
            {
                sb.AppendLine(book.Title);
            }

            var result = sb.ToString().TrimEnd();

            return result;
        }

        //Problem 6 
        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            List<string> categories = input.Split(" ").Select(c => c.ToLower()).ToList();

            List<string> booksTitles = new List<string>();

            foreach (var category in categories)
            {
                var book = context.Books
                      .Where(b => b.BookCategories
                                .Any(bc => bc.Category.Name
                                .ToLower() == category))
                      .Select(b => b.Title)
                      .ToList();

                booksTitles.AddRange(book);
            }

            var allBooks = booksTitles.OrderBy(b => b);

            return string.Join(Environment.NewLine, allBooks);
        }

        //Problem 7 
        public static string GetBooksReleasedBefore(BookShopContext context, string date)
        {

            var dateParse = DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            var books = context.Books
                .Where(x => x.ReleaseDate.Value < dateParse)
                .Select(x => new
                {
                    Title = x.Title,
                    Type = x.EditionType,
                    Price = x.Price,
                    Date = x.ReleaseDate
                })
                .OrderByDescending(x => x.Date)
                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var item in books)
            {
                sb.AppendLine($"{item.Title} - {item.Type} - ${item.Price:f2}");
            }

            return sb.ToString().Trim();
        }

        //Problem 8 
        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            var authors = context.Authors
                .Where(x => x.FirstName.EndsWith(input))
                .Select(x => x.FirstName + " " + x.LastName)
                .OrderBy(x => x)
                .ToList();

            var sb = new StringBuilder();

            foreach (var author in authors)
            {
                sb.AppendLine(author);
            }

            return sb.ToString().TrimEnd();
        }


        //Problem 9 
        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            var books = context.Books
                .Where(x => x.Title.ToLower()
                .Contains(input.ToLower()))
                .Select(x => x.Title)
                .OrderBy(x => x)
                .ToList();


            return string.Join(Environment.NewLine, books);
        }        
    }
}
