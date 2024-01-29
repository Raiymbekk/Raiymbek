using System;
using System.Collections.Generic;

class Bookshelf
{
    private List<string> books;

    public Bookshelf()
    {
        books = new List<string>();
    }

    public void AddBook(string bookTitle)
    {
        books.Add(bookTitle);
    }

    public void DisplayBooks()
    {
        Console.WriteLine("Books on the Bookshelf:");
        foreach (var book in books)
        {
            Console.WriteLine("- " + book);
        }
    }
}

class Zadacha4
{
    static void Main()
    {
        // Пример использования класса Bookshelf
        Bookshelf bookshelf = new Bookshelf();
        bookshelf.AddBook("Book 1");
        bookshelf.AddBook("Book 2");
        bookshelf.AddBook("Book 3");

        bookshelf.DisplayBooks();
    }
}
