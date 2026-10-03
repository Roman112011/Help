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

class Motorcycle : Vehicle
{
    public int EngineSize {get;set;}

    public Motorcycle(string MK, string MO, int E) : base(MK, MO)    {
        EngineSize = E;
    }
    public void Motorcycle_Info()
    {
        Console.WriteLine($"Model:{this.Model} Make:{this.Make} EngineSize:{this.EngineSize}");
    }
}

class Program
{
    static void Main()
    {
        Motorcycle myMotorcycle = new Motorcycle("mitsubishi galant","Japan", 2008);

        myMotorcycle.Info();    
        myMotorcycle.Motorcycle_Info();
    }
}