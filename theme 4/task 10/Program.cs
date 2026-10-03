using System;

class Product
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public void Info()
    {
        Console.WriteLine($"Name: {Name}, Price: {Price} грн");
    }
}

class Book : Product
{
    public string Author { get; set; }

    public Book(string name, double price, string author) : base(name, price)
    {
        Author = author;
    }

    public void Info_Book()
    {
        Console.WriteLine($"Name: {Name}, Author: {Author}, Price: {Price} грн");
    }
}

class Program
{
    public static void Main()
    {
        Book myBook = new Book("The silver eyes", 350, "Scott Cowton");

        myBook.Info();       
        myBook.Info_Book();  
    }
}