using System;
using System.Collections.Generic;

public class Library
{
    private List<Book> books;

    public Library()
    {
        books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void ViewAllBooks()
    {
        Console.WriteLine("All Books in the Library:");
        foreach (var book in books)
        {
            Console.WriteLine($"Book ID: {book.BookId}, Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Available: {book.IsAvailable}");
        }
    }

    public Book SearchBookById(int bookId)
    {
        return books.Find(b => b.BookId == bookId);
    }

    public Book SearchBookByTitle(string title)
    {
        return books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
    }
}