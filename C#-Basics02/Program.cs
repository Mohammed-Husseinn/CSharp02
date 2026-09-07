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