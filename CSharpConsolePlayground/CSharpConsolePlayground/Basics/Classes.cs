/*
 * File: Classes.cs
 * Folder: Basics
 * Topic: Classes & Objects
 *
 * Description:
 * Demonstrates how to define classes and create objects (instances) in C#.
 * A class is a blueprint that defines the data (fields/properties) and behavior
 * (methods) of a type. An object is a concrete instance of that class created
 * with the new keyword.
 *
 * Concepts Covered:
 * - Class definition
 * - Fields vs properties
 * - Auto-implemented properties (get; set;)
 * - Constructors
 * - Instance methods vs static methods
 * - The this keyword
 * - Creating objects with new
 *
 * Task:
 * Build a Person class that models a real person with data and behavior, then
 * create instances of it in Run() and interact with them.
 *
 * Requirements:
 * - Define a Person class with at least three properties (e.g. Name, Age, City)
 * - Add a constructor that initializes those properties
 * - Add at least one instance method that uses the object's own data
 * - Create at least two different Person objects in Run()
 * - Print each person's details by calling their instance method
 *
 * Stretch Goal:
 * Add a second constructor (overloaded) that allows creating a Person with only
 * some of the data, providing sensible defaults for the rest. Then add a static
 * property or method that tracks how many Person objects have been created.
 *
 * PascalCase (UpperCamelCase) — anything that's a "member" or a type:
   
   Class names: Person, Methods
   Properties: Name, Age, City
   Methods: Greeting(), Run()
   Constants: MaxValue
   
   camelCase (lowerCamelCase) — local stuff inside a method:
   
   Local variables: lindsay, adam, counter
   Method parameters: string name, int age
 *
 * 
 */

namespace CSharpConsolePlayground.Basics;

public class Classes
{
    public static void Run()
    {
        Console.WriteLine("Classes");
        Person lindsay = new Person("Lindsay", 40, "Temple");
        Person adam = new Person("Adam", 45, "Temple");
        Person ellie = new Person("Ellie");
        Console.WriteLine(lindsay.Greeting());
        Console.WriteLine(adam.Greeting());
        Console.WriteLine(ellie.Greeting());
        Console.WriteLine($"Total people created: {Person.Count}");
    }
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get; set; }
    public static int Count { get; set; }

    public Person(string name, int age, string city)
    {
        this.Name = name;
        this.Age = age;
        this.City = city;
        Count++;
    }

    public Person(string name)
    {
        this.Name = name;
        Count++;
    }

    public String Greeting()
    {
        return $"Welcome to the database! {this.Name} you have been \n" +
               $"chosen to lead first because you are {this.Age} years old." +
               $"Since you live in {this.City} you are required to do you work now.";
    }
    
    
    
}