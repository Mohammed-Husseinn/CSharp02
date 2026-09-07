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

// Question 4
try
{
    int numerator = 10;
    int denominator = 0;
    int result = numerator / denominator;
}
catch (DivideByZeroException)
{
    Console.WriteLine("Cannot divide by zero");
}
finally
{
    Console.WriteLine("Done");
}


// Question 5
int pages = 300;
double doublePages = pages;

Console.WriteLine(doublePages);


// Question 6
double price = 49.99;
int intPrice = (int)price;

Console.WriteLine(intPrice);