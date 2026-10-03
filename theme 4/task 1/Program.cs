using System;

class Shape
{

    public void Draw()
    {
        Console.WriteLine("малюємо фігуру");
    }
}

class Circle : Shape
{
    public void Draw_circle()
    {
        Console.WriteLine("малюємо коло");
    }
}

class Program
{
    static void Main()
    {
        Circle myCircle = new Circle();

        myCircle.Draw();    
        myCircle.Draw_circle();
    }
}