using System;

/*
    File: Program.cs
    Project: Part04ObjectOrientedBasics
  
    This is the entry point of the program.
    It demonstrates:
    - Demonstrates object creation:
        > Creating objects from the Person class
    - Setting and getting properties:
        > Encapsulation with private fields
    - Constructors:
        > Using both default and parameterized constructors
    - Method calls:
        > Accessing and calling public methods

    Topics Covered:
    - Object instantiation using default and parameterized constructors
    - Accessing public properties
    - Using methods defined in the class
    - Encapsulation: interacting with private fields via properties

    Microsoft Docs References:
    - Please check the links in "Person.cs" file
*/

namespace Part04ObjectOrientedBasics
{
    internal class Program
    {
        // Entry point for the C# console application
        static void Main(string[] args)
        {
            Console.WriteLine("= C# OOP Basics: Classes and Objects =");
            /*
             * We can create as many Person objects as needed,
             * each with different data but using the same "Class Blueprint"
             */

            // Object 1: Created using the default constructor
            // -----------------------------------------------
            Person person1 = new Person(); // uses default values
            Console.WriteLine("\n[Person 1 - Default Constructor]");
            
            // Calling the public method(s):
            person1.PrintPersonInfo();
            // OR:
            person1.DisplayPersonInfo();

            // Updating properties manually using public setters
            person1.Name = "Alex Chow";
            person1.Age = 25;
            person1.Email = "alex@example.com";

            Console.WriteLine("\n[Person 1 - After Updating Properties]");
            // Calling the public method(s):
            person1.PrintPersonInfo();
            // OR:
            person1.DisplayPersonInfo();

            // Object 2: Created using the parameterized constructor
            // -----------------------------------------------------
            Person person2 = new Person("Sarah Grandson", 30, "sarah@example.com");
            Console.WriteLine("\n[Person 2 - Parameterized Constructor]");
            // Calling the public method(s):
            person1.PrintPersonInfo();
            // OR:
            person1.DisplayPersonInfo();

            // Object 3: Using GetPersonInfo() to store result
            // -----------------------------------------------
            Person person3 = new Person("Martin Smith", 42, "Martin@company.com");
            Console.WriteLine("\n[Person 3 - Using GetPersonInfo()]");
            string info = person3.GetPersonInfo(); // capturing returned value
            Console.WriteLine(info);

            // Demonstrating property validation logic
            // ---------------------------------------
            Console.WriteLine("\n[Person 3 - Trying to assign invalid age]");
            person3.Age = -10; // Should show warning and NOT change the age
            person3.DisplayPersonInfo(); // Will still show age as 42 (previous valid value)

            // Summary:
            Console.WriteLine("\n= OOP Basics Demonstration Complete =");
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
/*
Summary of Key OOP Concepts in C#:
**********************************
Class:
   - Blueprint for creating objects (Person)

Object:
   - An instance of a class created using the "new" keyword
   - Each object has its own copy of fields and properties

Fields:
   - Private variables inside a class, e.g., name, age

Properties:
   - Public accessors to control get/set of fields

Constructor:
   - Special method to initialize object
   - Can be default or parameterized (overloaded)

"this" Keyword:
   - Refers to the current instance of the class (used to distinguish class fields from parameters)

Encapsulation:
   - Hiding fields (private) and exposing through controlled properties (public)

Full References:
***************
- Object-Oriented Programming Overview: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/
- Classes and Objects: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/classes-objects
- Objects: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/objects
- Constructors: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/constructors
- this Keyword: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/using-this
- Access Modifiers: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers
- C# Coding Conventions: https://learn.microsoft.com/en-us/dotnet/fundamentals/coding-style/coding-conventions
*/
