using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class BookCatalog
    {
        private List<Book> books;

        public BookCatalog()
        {
            books = new List<Book>();
        }

        public void AddBook(Book aBook)
        {
            if (LookupBook(aBook.GetISBN()) != null)
            {
                Console.WriteLine($"ISBN {aBook.GetISBN()} er allerede i brug!");
            }
            else
            {
                books.Add(aBook);
                Console.WriteLine($"Bogen {aBook.GetISBN()} er tilføjet!");
            }
            books.Add(aBook); // Add code that can add the given Book object to the list
           
        }

        public void PrintAllBooks()
        {
            foreach (Book book in books)
            {
                Console.WriteLine(book.GetAllInformation());
            }
            // Add code that can print all books in the list
            // Hint: You will need a repetition statement
        }

        public Book LookupBook(string isbn)
        {
            Book matchingBook = null;

            foreach (var book in books)
            {
                if (isbn == book.GetISBN())
                {
                    matchingBook = book;
                }
            }
           
            // Add code that will find a book (if any) in the list
            // which has a matching ISBN number. The variable matchingBook
            // should be set to this book
            // Hint: You will need a repetition statement

            return matchingBook;
        }
    }
}
