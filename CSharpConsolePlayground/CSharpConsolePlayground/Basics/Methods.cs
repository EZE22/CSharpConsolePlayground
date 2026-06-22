/*
 * File: Methods.cs
 * Folder: Basics
 * Topic: Methods
 *
 * Description:
 * Demonstrates how to define and call methods in C#. Methods are reusable blocks
 * of code that perform a specific task. They help organize logic, reduce
 * repetition, and make code easier to read and maintain.
 *
 * Concepts Covered:
 * - Method declaration and calling
 * - Parameters and arguments
 * - Return types (including void)
 * - Method overloading
 * - Optional and named parameters
 * - The static keyword and why Run() uses it
 *
 * Task:
 * Build a small set of utility methods that perform calculations and formatting,
 * then call them from Run() to demonstrate each concept.
 *
 * Requirements:
 * - Write a void method that takes parameters and prints a formatted greeting
 * - Write a method that takes two numbers and returns their sum
 * - Write a method that takes a person's name and age and returns a formatted string
 * - Overload one of your methods so it works with different parameter types or counts
 * - Use at least one optional parameter with a default value
 * - Call every method from Run() and print the results
 *
 * Stretch Goal:
 * Write a method that takes a variable number of arguments (look up the params
 * keyword) and returns the average of all numbers passed to it.
 */

namespace CSharpConsolePlayground.Basics;

public class Methods
{
    public static void Run()
    {
        Console.WriteLine("\nMethods");
    }
}