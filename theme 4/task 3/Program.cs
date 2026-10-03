using System;

class Animal
{

    public void MakeSound()
    {
        Console.WriteLine("Звук тварини");
    }
}

class Dog : Animal
{
    public void Dog_sound()
    {
        Console.WriteLine("собака гавкає");
    }
}

class Program
{
    static void Main()
    {
        Dog myDog = new Dog();
        
        myDog.MakeSound(); 
        
        myDog.Dog_sound(); 
    }
}