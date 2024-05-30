using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Library_management_system
{
    internal class Library
    {

        private Book[] books = new Book[100];
        private int currentBooks = 0;
        private Book[] BorrowedBooks = new Book[50];
        private int currentborrowedBooks = 0;

        public void Display()
        {
            foreach (var book in books)
            {
                Console.WriteLine(book);

            }
        }
        public void Add(Book book)
        {

            if (currentBooks < books.Length)
            {
                books[currentBooks] = book;
                currentBooks++;
                Console.WriteLine("book added successfly ");
            }
            else
            {
              Console.WriteLine("Library is full, can not add a new book ");
            }

        }
        public void Remove(Book book)
        {
            int index = Array.IndexOf(books,book);
            books[index] = null; 
            currentBooks--;
            Console.WriteLine("book deleted successfly");

        }
    }
}
