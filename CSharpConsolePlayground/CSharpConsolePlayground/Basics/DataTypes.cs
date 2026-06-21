/*
 * File:        DataTypes.cs
 * Folder:      Basics
 * Topic:       Variables & Data Types
 *
 * TODO Description:
   Demonstrates C# value types, reference types, and type inference with var.
   Value types store data directly on the stack.
   Reference types store a reference to data on the heap.
 * TODO Personal Profile Console Output
   Build out the Run() method in DataTypes.cs so it prints a structured personal 
   profile to the console using what you've learned about value types, reference 
   types, and var. 
 * TODO Requirements:
   Declare at least one of each: int, double, bool, char, string, and var
   The variables should represent something meaningful about a person 
   (you, a made up person, whatever) Use string interpolation for all output
   Output should be formatted and labeled cleanly, not just raw values dumped 
   to the screen At least one variable should be null and you should handle 
   printing it gracefully so it doesn't just show a blank
 * Stretch goal:
   Figure out how to print the actual type of a variable to the console. 
   C# has a built in way to do this at runtime. See if you can find it.
   Give it a shot and show me what you come up with.
 */

namespace CSharpConsolePlayground.Basics;

public class DataTypes
{
    public static void Run()
    { 
      // int, double, bool, char, string, and var
      int age = 0;
      double height = 0.0f;
      char letter = 'A';
      string name = null;
      var gender = "gender";
      
      Console.WriteLine("Welcome to the profile reporter!");

      if (name != null)
      {
        Console.WriteLine($"Welcome, {name}");
      }
      else
      {
        Console.WriteLine("Name is Null!");
      }
      
      Console.WriteLine($"The age is {age}");
      Console.WriteLine($"The height is {height}");
      Console.WriteLine($"The letter is {letter}");
      Console.WriteLine($"The gender is {gender}");
      
    }
}