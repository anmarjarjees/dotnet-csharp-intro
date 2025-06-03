/*
File: ListsDemo.cs
Topic: C# Collections - List<T>

This file demonstrates how to use the generic List<T> class in C#.
A List allows us to store a collection of elements that can grow or shrink dynamically.

Link: https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1
*/

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Collections.Generic;

namespace Part02ControlFlowAndCollections
{
    internal class ListsDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** Lists Demo **");
            /*
             * Arrays vs Lists in C#:
             * **********************
             * > Array:
             *   - Fixed size (defined when created)
             *   - Fast access with index
             *   - Best when the number of elements is known and doesn't change
             *   - Syntax: string[] names = new string[5];
             *
             * > List<T>:
             *   - Dynamic size (can grow/shrink)
             *   - Provides useful methods like .Add(), .Remove(), .Count(), etc.
             *   - More flexible for modern applications
             *   - Syntax: List<string> names = new List<string>();
             *
             * Summary:
             * - Use arrays for fixed-size data collections
             * - Use List<T> when we need to add or remove elements dynamically
             */


            // Declaring and initializing a list of strings

            // Using the original standard way :-)
            // List<string> studentNames = new List<string>(); 
            // VS IDE will give us a warning

            /*
               * The following uses C# 9+ feature: target-typed 'new()' expression.
               * The compiler infers the type (List<string>) from the left-hand side.
               * 
               * This modern syntax makes the code shorter and cleaner:
               * > List<string> studentNames = new();  
               * 
               * A warning like: "IDE0090: Simplify new expression"
               * - This is just a style suggestion, not an error.
               * - Both versions work exactly the same.
               *
               * Link: https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/style-rules/ide0090
               * Link: https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/style-rules/ide0028
             */


            // Using modern, simplified syntax (Suggested simplified version (C# 9+):
            List<string> studentNames = new();
            // VS IDE will also give us a warning
            /*
             * This warning (IDE0028) suggests using a collection initializer 
             * instead of calling .Add() repeatedly.
             *
             * Collection initializer syntax:
             * List<string> names = new() { "Alice", "Bob", "Charlie" };
             *
             * It makes the code shorter and more readable if all items are known at declaration.
             *
             * Docs: https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/style-rules/ide0028
             */

            // Adding elements using .Add()
            studentNames.Add("Alex Chow");
            studentNames.Add("Martin Smith");
            studentNames.Add("Sam Simpson");
            studentNames.Add("Sarah Grandson");
            studentNames.Add("Kate Wilson");
            studentNames.Add("Elena Chow");

            // Display the total number of students using .Count
            Console.WriteLine($"\nTotal students: {studentNames.Count}");

            // Display all students using foreach loop
            Console.WriteLine("\nList of students (using foreach):");
            foreach (string name in studentNames)
            {
                Console.WriteLine($"- {name}");
            }

            // Remove a student using .Remove()
            Console.WriteLine("\nRemoving 'Sam Simpson' from the list...");
            studentNames.Remove("Sam Simpson");

            // Display updated list
            Console.WriteLine("\nUpdated student list:");
            foreach (string name in studentNames)
            {
                Console.WriteLine($"- {name}");
            }

            // Adding more students
            studentNames.Add("James Carter");
            studentNames.Add("Leila Thomas");

            // Display with for loop
            Console.WriteLine("\nStudent list (using for loop):");
            for (int i = 0; i < studentNames.Count; i++)
            {
                Console.WriteLine($"Index {i}: {studentNames[i]}");
            }

            // Example with a List of integers
            Console.WriteLine("\nList of Lucky Numbers:");

            List<int> luckyNumbers = new List<int> { 9, 3, 10, 25, 30 };

            Console.WriteLine($"Count of lucky numbers: {luckyNumbers.Count}");

            Console.WriteLine("Lucky Numbers:");
            foreach (int number in luckyNumbers)
            {
                Console.WriteLine($"- {number}");
            }

            // Adding and removing numbers
            luckyNumbers.Add(7); // adding a new lucky number
            luckyNumbers.Remove(10); // removing 10

            Console.WriteLine("\nUpdated Lucky Numbers:");
            foreach (int number in luckyNumbers)
            {
                Console.WriteLine($"- {number}");
            }

            Console.WriteLine("\nLists demo complete.");
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        } // Main
    } // class
} // namespace
/*
Summary:
> List<T> is part of System.Collections.Generic and allows dynamic collections.
> .Add(item) — Adds an element to the list.
> .Remove(item) — Removes the first occurrence of an element.
> .Count — Returns the total number of elements.
> We can use both foreach and for loops to iterate over lists.
> Lists are more flexible than arrays when size changes are needed.

Link: https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1
*/

