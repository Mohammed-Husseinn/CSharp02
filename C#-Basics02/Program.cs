// Question 1 
using System;

class Book
{
    public string Title { get; set; }
    public int Pages { get; set; }
}

class Program
{
    static void Main()
    {
        Book book = new Book
        {
            Title = "C# Programming",
            Pages = 464
        };

        object obj = book;

        Console.WriteLine(obj);

    }
}

// Question 2 
Book book = new Book { Title = "C# Fundamentals", Pages = 464 };

Console.WriteLine(book.ToString());
Console.WriteLine(book.Equals(book));
Console.WriteLine(book.GetHashCode());
Console.WriteLine(book.GetType());


// Question 3

int pages = 464;
Console.WriteLine(pages);