using System;

class Person
{
    public string Name {get;set;}

    public Person(string N)
    {
        Name = N;
    }

    public void Info()
    {
        Console.WriteLine($"Name:{this.Name}");
    }

}

class Student : Person
{
    public int Grade {get;set;}

    public Student(string N,int G) : base(N)
    {
        Grade = G;
    }

    public void Info_St()
    {
        Console.WriteLine($"Name:{this.Name} Grade:{this.Grade}");
    }
}

class Program
{
    static void Main()
    {
        Student myStudent = new Student("S",12);

        myStudent.Info();
        myStudent.Info_St();
    }
}