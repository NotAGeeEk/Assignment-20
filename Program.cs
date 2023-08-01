using System;

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();

        while (true)
        {
            Console.WriteLine("\nLibrary Management System Menu:");
            Console.WriteLine("1. Add a Book");
            Console.WriteLine("2. View All Books");
            Console.WriteLine("3. Search by Book ID");
            Console.WriteLine("4. Search by Book Title");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice (1-5): ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter Book Details:");
                    Book newBook = new Book();
                    Console.Write("Book ID: ");
                    newBook.BookId = int.Parse(Console.ReadLine());
                    Console.Write("Title: ");
                    newBook.Title = Console.ReadLine();
                    Console.Write("Author: ");
                    newBook.Author = Console.ReadLine();
                    Console.Write("Genre: ");
                    newBook.Genre = Console.ReadLine();
                    newBook.IsAvailable = true;

                    library.AddBook(newBook);
                    Console.WriteLine("Book added successfully!");
                    break;
                case 2:
                    library.ViewAllBooks();
                    break;
                case 3:
                    Console.Write("Enter Book ID to search: ");
                    int searchBookId = int.Parse(Console.ReadLine());
                    Book searchedBookById = library.SearchBookById(searchBookId);
                    if (searchedBookById != null)
                    {
                        Console.WriteLine("Book Details:");
                        Console.WriteLine($"Book ID: {searchedBookById.BookId}, Title: {searchedBookById.Title}, Author: {searchedBookById.Author}, Genre: {searchedBookById.Genre}, Available: {searchedBookById.IsAvailable}");
                    }
                    else
                    {
                        Console.WriteLine("Book not found with the given ID.");
                    }
                    break;
                case 4:
                    Console.Write("Enter Book Title to search: ");
                    string searchBookTitle = Console.ReadLine();
                    Book searchedBookByTitle = library.SearchBookByTitle(searchBookTitle);
                    if (searchedBookByTitle != null)
                    {
                        Console.WriteLine("Book Details:");
                        Console.WriteLine($"Book ID: {searchedBookByTitle.BookId}, Title: {searchedBookByTitle.Title}, Author: {searchedBookByTitle.Author}, Genre: {searchedBookByTitle.Genre}, Available: {searchedBookByTitle.IsAvailable}");
                    }
                    else
                    {
                        Console.WriteLine("Book not found with the given title.");
                    }
                    break;
                case 5:
                    Console.WriteLine("Exiting the program.");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}