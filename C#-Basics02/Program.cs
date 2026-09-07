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


// Question 7
string pagesText = "464";
int pages = Convert.ToInt32(pagesText);

Console.WriteLine(pages);

// Question 8

string yearText = "2023";
int year = int.Parse(yearText);

string badText = "abc";
if (int.TryParse(badText, out int parsedValue))
{
    Console.WriteLine(parsedValue);
}
else
{
    Console.WriteLine("Invalid number");
}

// Question 9
int pages = 464;
string pagesText = pages.ToString();

Console.WriteLine(pagesText);
Console.WriteLine(pagesText.GetType());


// Question 10 

int copies = 100;
object boxedCopies = copies;
int unboxedCopies = (int)boxedCopies;

Console.WriteLine(boxedCopies);
Console.WriteLine(unboxedCopies);


// Question 11
int? year = null;
Console.WriteLine(year.HasValue);

year = 2023;
Console.WriteLine(year.Value);

// Question 12
string? reviewer = null;
Console.WriteLine(reviewer is null);

// Question 13

Book? book = null;
string? title = book?.Title;
Console.WriteLine(title is null ? "null" : title);

// Question 14 
Book? book = null;
string? title = book?.Title;

Console.WriteLine(title ?? "Untitled");
title ??= "Untitled";
Console.WriteLine(title);