/*
 * File:        Classes.cs
 * Folder:      Basics
 * Topic:       Classes & Objects
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
 */

namespace CSharpConsolePlayground.Basics;

public class Classes
{
    public static void Run()
    {
        Console.WriteLine("Classes");
    }
}