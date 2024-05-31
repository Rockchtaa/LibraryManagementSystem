using Library_management_system;
using System;
using System.Diagnostics;

Console.WriteLine("Welcome to the Library System");
Console.WriteLine("are you Librarien or regular user L/R ?");
char UserType = Console.ReadLine().ToUpper()[0];

Library library = new Library();

if (UserType == 'L')

{
    Console.WriteLine("please enter your name");

    string libraryName = Console.ReadLine();

    Librarien librarien = new Librarien(libraryName);

    Console.WriteLine($"Welcome to the library {librarien.Name}");

    while (true)
    {
        Console.WriteLine("please choose (A) to Add books, (R) to remove books and (D) to Display books ");

        char choice = Console.ReadLine().ToUpper()[0];
  
        switch (choice)
        {
            case 'A':
                Console.WriteLine("enter book details");

                Console.WriteLine(" bookName :");

                string bookName = Console.ReadLine();
                Console.WriteLine(" bookAuthor :");

                string bookAuthor = Console.ReadLine();
                Console.WriteLine(" bookYear :");

                int bookYear = Convert.ToInt32(Console.ReadLine());

                Book book = new Book()
                {
                    Title = bookName,
                    Author = bookAuthor,
                    Year = bookYear,

                };

                librarien.AddBook(book, library);
                break;


            case 'B':
                Console.WriteLine("enter book details");
                Console.WriteLine(" bookName :");

                bookName = Console.ReadLine();
                Console.WriteLine(" bookAuthor :");

                bookAuthor = Console.ReadLine();
                Console.WriteLine(" bookYear :");

                bookYear = Convert.ToInt32(Console.ReadLine());

                 book = new Book()
                {
                    Title = bookName,
                    Author = bookAuthor,
                    Year = bookYear,

                };

                librarien.RemoveBook(book, library);
                break;


            case 'D':
                Console.WriteLine("the book list :");
                librarien.DisplayBooks(library);
                break;
            default:
                Environment.Exit(0);
                break;
        }
    }
    


}
        else if (UserType == 'R')
        {
            Console.WriteLine("please enter your name");

            string LibraryUserName = Console.ReadLine();

            LibraryUser librarienBorrow = new LibraryUser(LibraryUserName);

            Console.WriteLine($"Welcome to the library {librarienBorrow.Name}");


            Console.WriteLine("please choose (D) to Display books, (B) to borrow books ");

            char choice = Console.ReadLine().ToUpper()[0];
            while (true)
            {
                switch (choice)
                {
                    case 'D':
                        Console.WriteLine("the book list :");
                         librarienBorrow.DisplayBooks(library);
                        break;


                case 'B':
                    Console.WriteLine("enter the book to borrow");

                    Console.WriteLine(" bookName :");

                    string bookName = Console.ReadLine();
                    Console.WriteLine(" bookAuthor :");

                    string bookAuthor = Console.ReadLine();
                    Console.WriteLine(" bookYear :");

                    int bookYear = Convert.ToInt32(Console.ReadLine());

                    Book book = new Book()
                    {
                        Title = bookName,
                        Author = bookAuthor,
                        Year = bookYear,

                    };

                      librarienBorrow.BorrowBooks(book, library);
                    break;



            default:
                        Environment.Exit(0);
                        break;
                }
            }
}
        else
        { Console.WriteLine("please enter correct Values R or L"); };
