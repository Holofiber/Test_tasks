using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    class BookShelf
    {
        List<Book> books = new List<Book>();
        public BookShelf()
        {
            
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void RemoveBook(string name)
        {
            Book bookfind = FindBook(name);

            books.Remove(bookfind);
        }

        public bool IsBookPresent(string name)
        {
            Book bookfind = FindBook(name);
            if (bookfind != null)
            {
               // Console.WriteLine("We have this book");
                return true;
            }
            else
            {
              //  Console.WriteLine("Sorry, we don't have it");
                return false;
            }
            
        }

        private Book FindBook(string name )
        {
            return books.Find(book => book.Name == name);
        }

        public Book GetBook(string name)
        {
            var getbook = FindBook(name);
            books.Remove(getbook);
            return getbook;
        }


    }
}
