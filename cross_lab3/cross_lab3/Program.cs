using System;

abstract class Figure
{
    public abstract double GetPerimeter();
    public abstract double GetArea();
}

class Rectangle : Figure
{
    public float Width { get; set; }
    public float Height { get; set; }

    public override double GetPerimeter() => Width * 2 + Height * 2;
    public override double GetArea() => Width * Height;
}

class Circle : Figure
{
    public double Radius { get; set; }

    public override double GetPerimeter() => Radius * 2 * Math.PI;
    public override double GetArea() => Radius * Radius * Math.PI;
}

class Trapezium : Figure
{
    public double Greater { get; set; }
    public double Smaller { get; set; }
    public double Height { get; set; }

    public override double GetPerimeter() => Greater * 2 + Smaller * 2;
    public override double GetArea() => ((Greater + Smaller) / 2) * Height; 
}

class Program
{
    static void PrintFigure(Figure Figure)
    {
        Console.WriteLine($"{Figure}: \t  Perimeter: {Figure.GetPerimeter()} \t Area: {Figure.GetArea()}");
    }
    static void Main(string[] args)
    {

        var rectangle = new Rectangle { Width = 20, Height = 15 };
        var circle = new Circle { Radius = 250 };
        var trapezium = new Trapezium { Greater = 30, Smaller = 20, Height = 10 };

        PrintFigure(rectangle);
        PrintFigure(circle);
        PrintFigure(trapezium);

        Console.ReadKey();
    }
}

