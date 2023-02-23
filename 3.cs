//3. Create a class called "Rectangle" with properties such as "width" and "height" and methods to calculate its area and perimeter.
using System;
class Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }

    public double calculateArea() { return Width * Height; }

    public double calculatePerimeter() { return (Width + Height) * 2; }
}

class Program 
{ 
    static void Main (string[] args)
    {
        Rectangle rec = new Rectangle();

        Console.WriteLine("Please enter the Width of the Rectangle: ");
        rec.Width = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the Height of the Rectangle: ");
        rec.Height = int.Parse(Console.ReadLine());

        double area = rec.calculateArea();
        double perimeter = rec.calculatePerimeter();

        Console.WriteLine($"Rectangle's Area: {rec.Width} x {rec.Height} = {area}");
        Console.WriteLine($"Rectangle's Perimeter: ({rec.Width} + {rec.Height}) x 2 = {perimeter}");
    }
}
