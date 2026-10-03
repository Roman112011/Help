using System;

class Vehicle
{
    public string Make { get; set; }
    public string Model {get; set;}

    public Vehicle(string MK,string MO)
    {
        Make = MK;
        Model = MO;
    }

    public void Info()
    {
        Console.WriteLine($"Model:{this.Model} Make:{this.Make}");
    }
}

class Car : Vehicle
{
    public int Year {get;set;}

    public Car(string MK, string MO, int Y) : base(MK, MO)    {
        Year = Y;
    }
    public void Car_Info()
    {
        Console.WriteLine($"Model:{this.Model} Make:{this.Make} Year:{this.Year}");
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car("mitsubishi galant","Japan", 2008);

        myCar.Info();    
        myCar.Car_Info();
    }
}