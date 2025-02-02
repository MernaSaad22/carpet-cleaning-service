using System.Transactions;

namespace LibrarySystem
{
    class Book
    {
        public Book(string title="none", string author = "none", string iSBN="0"   , bool availability=true)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
            Availability = availability;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool Availability { get; set; }
    }
    class Library
    {
        public List<Book> Books { get; set; }
        public Library()
        {
            Books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
            Console.WriteLine($"{book.Title} is added to system");
        }
        public bool SearchBook(string bookTitle)
        {
            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].Title == bookTitle)
                { 
                    Console.WriteLine("this book is  in the library");
                    return true;
                }
                    
            }
            Console.WriteLine("this book is not in the library");
           
            return false;
        }
        public bool BorrowBook(string bookTitle)
        {
            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].Title == bookTitle&&Books[i].Availability == true)
                {
                    Console.WriteLine("this book is  in the library and you can borrow it");
                    Books[i].Availability = false;
                    return false;
                }
                    
            }
           Console.WriteLine("Sorry this book is not in the library");
           
            return true ;
        }
        public bool ReturnBook(string bookTitle)
        {
            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].Title == bookTitle&&Books[i].Availability == false)
                {
                    Books[i].Availability = true;
                   
                    Console.WriteLine($"{Books[i].Title} has been borrowed and returned successfully ");
                    return Books[i].Availability;
                }
            }
            Console.WriteLine("Sorry this book was not borrowed");
            return false ;
        }

      
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Library library = new Library();

        // Adding books to the library
        library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565"));
        library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084"));
        library.AddBook(new Book("1984", "George Orwell", "9780451524935"));

        // Searching and borrowing books
        Console.WriteLine("Searching and borrowing books...");
        library.SearchBook("To Kill a Mockingbird");
            library.SearchBook("Gatsby");
        library.BorrowBook("Gatsby");
        library.BorrowBook("1984");
        library.BorrowBook("Harry Potter"); // This book is not in the library

        // Returning books
        Console.WriteLine("\nReturning books...");
        library.ReturnBook("Gatsby");
        library.ReturnBook("1984");
        library.ReturnBook("Harry Potter"); // This book is not borrowed

        Console.ReadLine();
        }
    }
}
