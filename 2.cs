//Create a class called "Person" with properties such as "name", "age", and "gender" and a method that prints out the person's information.

using System;

class Program
{
    static void Main(string[] args)
    {
        //creating a list of people
        List<Person> people = new List<Person>();
        people.Add(new Person("Man", 69, "male"));
        people.Add(new Person("Woman", 96, "female"));
        people.Add(new Person("Not Woman Nor Man", 6969, "bi"));

        foreach (Person person in people)
        {
            person.printInfo();
            Console.WriteLine(); //adding some space           
        }
        Console.ReadLine();
    }
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }

    public Person(string name, int age, string gender)
    {
        Name = name;
        Age = age;
        Gender = gender;
    }

    public void printInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Gender: {Gender}");
    }
}
