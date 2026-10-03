using System;

class Shape
{
    public int Height {get;set;}
    public int Width {get;set;}

    public Shape(int H,int W)
    {
        Height = H;
        Width = W;
    }

    public void Info()
    {
        Console.WriteLine($"Height:{this.Height} Width:{this.Width}");
    }
}

class Rectangle : Shape
{
    public int area {get;set;}
    public Rectangle(int H, int W) : base(H, W) { }

    public void Info_Rect()
    {
        Console.WriteLine($"Height:{this.Height} Width:{this.Width} Area:{this.Width * this.Height}");
    }
}

class Program
{
    public static void Main()
    {
        Rectangle myRectangle = new Rectangle(10,10);

        myRectangle.Info();
        myRectangle.Info_Rect();
    }
}