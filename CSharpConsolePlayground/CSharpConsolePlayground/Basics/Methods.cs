/*
 * File: Methods.cs
 * Folder: Basics
 * Topic: Methods
 *
 * TODO Description:
 * Demonstrates how to define and call methods in C#. Methods are reusable blocks
 * of code that perform a specific task. They help organize logic, reduce
 * repetition, and make code easier to read and maintain.
 *
 * TODO Concepts Covered:
 * - Method declaration and calling
 * - Parameters and arguments
 * - Return types (including void)
 * - Method overloading
 * - Optional and named parameters
 * - The static keyword and why Run() uses it
 *
 * TODO Task:
 * Build a small set of utility methods that perform calculations and formatting,
 * then call them from Run() to demonstrate each concept.
 *
 * TODO Requirements:
 * - Write a void method that takes parameters and prints a formatted greeting
 * - Write a method that takes two numbers and returns their sum
 * - Write a method that takes a person's name and age and returns a formatted string
 * - Overload one of your methods so it works with different parameter types or counts
 * - Use at least one optional parameter with a default value
 * - Call every method from Run() and print the results
 *
 * TODO Stretch Goal:
 * Write a method that takes a variable number of arguments (look up the params
 * keyword) and returns the average of all numbers passed to it.
 *
 * Method Anatomy in C#
 *  public static int Add(int a, int b)
 *  //  ^      ^    ^      ^
 *  //  |      |    |      parameters
 *  //  |      |    return type
 *  //  |      static keyword
 *  //  access modifier
 *  {
 *      return a + b;
 *  }
 */

namespace CSharpConsolePlayground.Basics;

public class Methods
{
    public static void Run()
    {
        Console.WriteLine("\nMethods");
        Greeting("Adam", 45, "Teacher");
        Console.WriteLine($"The Sum of two numbers: {SumOfTwoNumbers(1,2)}");
        Console.WriteLine(Average(1, 2, 3, 4));
    }
    
    //Stretch Goal Params
    public static double Average(params int[] numbers)
    {
        int averageNumber = 0; 
        
        foreach (var number in numbers)
        {
            averageNumber += number;
        }
        
        return (double) averageNumber / numbers.Length; 
    }
    
    // Helper Method takes a person's name and age and returns a formatted string
    public static string MessageFormatter(string name, int age)
    {
        return $"Welcome to the playground {name}!" +
               $"\nYou are {age} years old.";
    }
    
    // Overloaded Method MessageFormatter. 
    public static string MessageFormatter(string name, int age, string occupation = "student")
    {
        return $"Welcome to the playground {name}!" +
               $"\nYou are {age} years old." +
               $"\nYou are a {occupation}.";
    }

    //The sum of two integers 
    public static int SumOfTwoNumbers(int num1, int num2)
    {
        return num1 + num2; 
    }
    
    // Greeting Message 
    public static void Greeting(string name, int age, string occupation)
    {
        Console.WriteLine(MessageFormatter(name, age));
        Console.WriteLine("\n------------------\n");
        Console.WriteLine(MessageFormatter(name, age, occupation));
    }
}