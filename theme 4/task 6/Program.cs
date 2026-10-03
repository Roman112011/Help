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

class Employee : Person
{
    public int EmployeeID {get;set;}

    public Employee(string N,int ID) : base(N)
    {
        EmployeeID = ID;
    }

    public void Info_employeed()
    {
        Console.WriteLine($"Name:{this.Name} ID:{this.EmployeeID}");
    }
}


class Program
{
    static void Main()
    {
        Employee myEmployee = new Employee("S",2710);

        myEmployee.Info();
        myEmployee.Info_employeed();
    }
}