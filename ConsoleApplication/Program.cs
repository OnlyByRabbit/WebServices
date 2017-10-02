using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication.BooksServiceReference;
using ConsoleApplication.AuthorsServiceReference;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ShowMenu();

                var choice = int.Parse(Console.ReadLine());


                Console.WriteLine(choice);

                switch (choice)
                {
                    case 1:
                        ShowBooksList();
                        break;
                    case 2:
                        ShowAuthorsList();
                        break;
                    case 3:
                        AddBook();
                        break;
                    case 4:
                        AddAuthor();
                        break;

                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
            }

        }

        static private void ShowMenu()
        {
            Console.WriteLine("1 - Show books list");
            Console.WriteLine("2 - Show authors list");
            Console.WriteLine("3 - Add book");
            Console.WriteLine("4 - Add author");
           
        }

        static private void ShowBooksList()
        {
            BookServiceClient client = new BookServiceClient();

            var list = client.getBooksList();

            foreach (Book book in list)
            {
                Console.WriteLine(book.title + " " + book.authorName);
            }

        }

        static private void ShowAuthorsList()
        {
            AuthorServiceClient client = new AuthorServiceClient();

            var list = client.getAuthorsList();

            foreach (Author author in list)
            {
                Console.WriteLine(author.name);
            }
        }

        static private void AddBook()
        {
            Console.Clear();
            Console.WriteLine("Enter book title");
            var booktitle = Console.ReadLine();
            Console.WriteLine("Enter book author");
            var authorName = Console.ReadLine();
            Console.WriteLine("Enter book genre");
            var genre = Console.ReadLine();
            Console.WriteLine("Enter year");
            var year = Console.ReadLine();

            BookServiceClient client = new BookServiceClient();
            Book book = new Book();
            book.title = booktitle;
            book.year = year;
            book.genre = genre;
            book.authorName = authorName;

            client.addBook(book);
            client.Close();
        }

        static private void AddAuthor()
        {
            Console.Clear();
            Console.WriteLine("Enter author name");
            var authorName = Console.ReadLine();

            AuthorServiceClient client = new AuthorServiceClient();
            Author author = new Author();
            author.name = authorName;

            client.addAuthor(author);

            client.Close();
        }
        
    }
}
