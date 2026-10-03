using System;

class Food
{
    public string Name {get;set;}

    public Food(string N)
    {
        Name = N;
    }


    public void Info()
    {
        Console.WriteLine($"Name:{this.Name}");
    }
}

class Fruit : Food
{
    public string Taste {get;set;}

    public Fruit(string N,string T) : base(N)
    {
        Taste = T;
    }

    public void Info_fruit()
    {
        Console.WriteLine($"Name:{this.Name} Taste:{this.Taste}");
    }
}

class Program
{
     static void Main()
     {
        Fruit myFruit = new Fruit("banana","солодке");
        
        myFruit.Info();
        myFruit.Info_fruit();
     }
}