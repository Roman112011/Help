using System;

class Animal
{

    public void Move()
    {
        Console.WriteLine("тварина рухається");
    }
}

class Bird : Animal
{
    public void Bird_Move()
    {
        Console.WriteLine("пташка летить");
    }
}

class Program
{
    static void Main()
    {
        Bird myBird = new Bird();
        
        myBird.Move(); 
        
        myBird.Bird_Move(); 
    }
}