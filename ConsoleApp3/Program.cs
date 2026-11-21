using System;
using System.Text;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {




            #region Question 1
            string title = "clean code";
            string upperTitle = title.ToUpper();
            Console.WriteLine(title);
            Console.WriteLine(upperTitle);
            #endregion


            #region Question 2
            string s1 = "Clean Code";
            string s2 = "Clean Code";
            Console.WriteLine(ReferenceEquals(s1, s2));
            #endregion




            #region Question 3
            StringBuilder sb = new StringBuilder();
            sb.Append("Book List");
            sb.Append(" - Updated");
            Console.WriteLine(sb);
            #endregion


            #region Question 4
            sb.Replace("Book List", "Library");
            Console.WriteLine(sb);
            #endregion


            #region Question 5
            string bookTitle = "Clean Code";
            int pages = 464;
            string sentence1 = "Book: " + bookTitle + ", Pages: " + pages;
            Console.WriteLine(sentence1);
            #endregion


            #region Question 6
            string sentence2 = $"Book: {bookTitle}, Pages: {pages}";
            Console.WriteLine(sentence2);
            #endregion



            #region Question 7
            string sentence3 = string.Format("Book: {0}, Pages: {1}", bookTitle, pages);
            Console.WriteLine(sentence3);
            #endregion


            #region Question 8
            if (pages > 300)
            {
                Console.WriteLine("Long Book");
            }
            else
            {
                Console.WriteLine("Short Book");
            }
            #endregion


            #region Question 9
            bool isAvailable = true;
            if (pages > 300 && isAvailable)
            {
                Console.WriteLine("You can borrow this book");
            }
            #endregion


            #region Question 10
            string bookName = "Refactoring";
            switch (bookName)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;
                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;
                default:
                    Console.WriteLine("Never heard of it");
                    break;
            }
            #endregion


            #region Question 11
            string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
            Console.WriteLine(sizeLabel);
            #endregion


            #region Question 12
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {books[i]}");
            }
            #endregion



            #region Question 13
            int w = 0;
            while (w < books.Length)
            {
                Console.WriteLine(books[w]);
                w++;
            }
            #endregion


            #region Question 14
            int count = 0;
            do
            {
                Console.WriteLine("Checking book...");
                count++;
            } while (count < 3);
            #endregion


            #region Question 15
            foreach (string book in books)
            {
                Console.WriteLine(book);
            }
            #endregion


            #region Question 16
            foreach (string book in books)
            {
                if (book == "Refactoring")
                {
                    break;
                }
                Console.WriteLine(book);
            }
            #endregion



            #region Question 17
            foreach (string book in books)
            {
                if (book == "The Pragmatic Programmer")
                {
                    continue;
                }
                Console.WriteLine(book);
            }
            #endregion


            #region Question 18
            PrintFirstBook();

            void PrintFirstBook()
            {
                if (books.Length == 0)
                {
                    return;
                }
                Console.WriteLine(books[0]);
            }
            #endregion
        }
    }
}