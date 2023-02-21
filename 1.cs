//1. Create a class called "Car" with properties such as "make", "model", and "year" and a method that prints out the car's information.


using System;

class Programm
{
    static void Main(string[] args)
    {
        Car auto = new Car();

        auto.Hersteller = "Mercedes";
        auto.Model = "W13";
        auto.Jahr = 2023;

        auto.PrintInfo();
    }
}

class Car
{
    public string Hersteller { get; set; }
    public string Model { get; set; }
    public int Jahr { get; set; }

    public void PrintInfo()
    {
        Console.WriteLine($"Hersteller: {Hersteller}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Jahr: {Jahr}");
        Console.Read();
    }
}
