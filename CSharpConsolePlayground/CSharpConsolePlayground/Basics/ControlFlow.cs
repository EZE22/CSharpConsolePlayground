/*
 * File:        ControlFlow.cs
 * Folder:      Basics
 * Topic:       Control Flow
 *
 * TODO Description:
 * Demonstrates how C# controls the flow of program execution using conditional
 * statements and loops. Control flow determines which code runs, when it runs,
 * and how many times it runs.
 *
 * TODO Concepts Covered:
 * - if / else if / else
 * - switch statements
 * - for loop
 * - while loop
 * - do while loop
 * - foreach loop
 *
 * TODO Task:
 * Build a simple grade evaluator and a countdown timer using control flow.
 * Use each loop type and conditional type at least once.
 *
 * TODO Requirements:
 * - Use if/else if/else to evaluate a numeric score and print a letter grade
 * - Use a switch statement to print a description based on that grade
 * - Use a for loop to count up from 1 to 5
 * - Use a while loop to count down from 5 to 1
 * - Use a foreach loop to iterate over a list of names and print each one
 *
 * TODO Stretch Goal:
 * Add a do/while loop that keeps asking the user to enter a number greater
 * than 10 until they actually do. Look up Console.ReadLine() to get user input.
 */

namespace CSharpConsolePlayground.Basics;

public class ControlFlow
{
    public static void Run()
    {
        int grade; 
        char letterGrade = 'A';
        
        List<string> names = new () {"Adam", "Lindsay", "Kelley", "Venkat"};
        Console.Write("\nStudent Names:\n");
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
        
        Console.Write("\nFor Loop COUNT DOW!\n");
        for (int index = 1; index < 6; index++)
        {
            Console.WriteLine(index);
        }
        
        Console.Write("\nEnter a grade: ");
        bool success = int.TryParse(Console.ReadLine(), out grade); 
        if (!success)
        {
            Console.WriteLine("Invalid input.");
            return;
        }
        
        if (grade <= 60)
        {
            letterGrade = 'F';
        } else if (grade < 70)
        {
            letterGrade = 'D';
        } else if (grade < 80)
        {
            letterGrade = 'C';
        } else if (grade < 90)
        {
            letterGrade = 'B';
        } else 
        {
            letterGrade = 'A';
        }
        
        Console.WriteLine("\nWhile Loop COUNTER");
        int counter = 1;
        while (counter < 6)
        {
            Console.WriteLine(counter);
            counter++;
        }

        switch (letterGrade)
        {
            case 'A':
                Console.Write("\nYour grade is A.\n");
                break;
            case 'B':
                Console.Write("\nYour grade is B.\n");
                break;
            case 'C':
                Console.Write("\nYour grade is C.\n");
                break;
            case 'D':
                Console.Write("\nYour grade is D.\n");
                break;
            case 'F':
                Console.Write("\nThe grade is F.\n");
                break;
        }
        
        Console.WriteLine("Do While Loop Counter:");
        int input = 0;
        do
        {
            Console.WriteLine("Enter a number greater than 10: ");
            bool temp = int.TryParse(Console.ReadLine(), out input);
            if (!temp)
            {
                Console.WriteLine("Invalid input.");
                return;
            }
        } while (input <= 10);


    }
    
}