// NOTE: Code Formatting Shortcut in Visual Studio => CTRL + K, D

/*
File3: ControlFlow.cs
Topic: Decision Making (Control Flow) using if, else if, and else in C#
This file demonstrates basic conditional statements and logical operators for beginners.

Useful Links:
- Control Flow in C#: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements
- if-else Statement: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements#if-else-statement
- Logical Operators (&&, ||, !): https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/boolean-logical-operators
- Parsing Strings to Integers: https://learn.microsoft.com/en-us/dotnet/api/system.int32.parse
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part01Basics
{
    internal class ControlFlow
    {
        static void ControlFlowMain(string[] args)
        {
            Console.WriteLine("=== Control Flow in C# ===");

            // Example 1: Simple Age Check
            Console.WriteLine("Enter your age:");
            string inputAge = Console.ReadLine() ?? "0"; // Null-coalescing to prevent exception

            // Convert string to int:
            // Consider the issue with line below:
            int age = int.Parse(inputAge);
            /* 
            Alternative Safer Solution:
            ***************************
            int.Parse() will throw an exception if the user inputs a non-numeric value.
            Instead of using int.Parse, 
            we should consider this more fault-tolerant version for both age and grade inputs:
           
            int.TryParse() is safer:            
            */
            /*
            if (!int.TryParse(inputAge, out int age))
            {
                Console.WriteLine("Invalid input for age. Please enter a number.");
                return;
            }
            */

            // Basic if-else logic (conditional branching):
            if (age >= 18)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are underage.");
            }

            // Link: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements#if-else-statement

            // Example 2: Grade Classification
            Console.WriteLine("\nEnter your average grade (0-100):");
            string inputGrade = Console.ReadLine() ?? "0";
            int grade = int.Parse(inputGrade);

            /*
             Multi-branch conditions using else-if ladder.
             Used when we need to compare a value against multiple ranges.
            */
            if (grade >= 90)
            {
                Console.WriteLine("Grade: A (Excellent)");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("Grade: B (Very Good)");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("Grade: C (Good)");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("Grade: D (Pass)");
            }
            else
            {
                Console.WriteLine("Grade: F (Fail)");
            }

            // Link: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements#if-else-statement

            // Example 3: Nested Condition for Login
            Console.WriteLine("\nEnter your username:");
            string username = Console.ReadLine() ?? "";

            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine() ?? "";

            /*
             Demonstrates nested if statements:
             - Outer if checks username
             - Inner if checks password
            */
            if (username == "admin")
            {
                if (password == "1234")
                {
                    Console.WriteLine("Login successful!");
                }
                else
                {
                    Console.WriteLine("Wrong password.");
                }
            }
            else
            {
                Console.WriteLine("Username not recognized.");
            }

            // Link: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements#if-else-statement

            // Example 4: Toronto Public Library Access
            /*
             * Rule:
             * If you live OR work OR study in Toronto, library card is FREE
             * Otherwise, you must pay a membership fee.
             * This example shows how to use logical OR (||) to combine conditions.
             */

            Console.WriteLine("\n=== Toronto Public Library Card Eligibility ===");

            Console.WriteLine("Do you live in Toronto? (yes/no):");
            // Simple Standard Way:
            // string live = Console.ReadLine()?.ToLower() ?? "no";

            // OR: To avoid issues like "Yes " or " YES", use .Trim():
            string live = Console.ReadLine()?.Trim().ToLower() ?? "no";
            /*
 Method Chaining Explained:
 ==========================
 Method chaining allows us to call multiple methods in a single line of code,
 one after another, on the same object. 
 Each method returns a value (often the same object or a modified version),
 allowing the next method to be called.

 Example:
 --------
 Console.ReadLine()?.Trim().ToLower()

 Here's how this works step-by-step:
 1. Console.ReadLine() - reads user input as a string.
 2. ?. (null-conditional operator) - ensures the program doesn't crash if input is null.
 3. Trim() - removes any leading/trailing spaces from the input.
 4. ToLower() - converts the cleaned input to lowercase.

 This makes the input handling more robust and consistent, especially
 when comparing string values like "Yes", " YES", or "yes".

 Also note:
 - This is an example of calling multiple string methods in sequence.
 - It's clean, readable, and preferred for simple transformations.

Link:
 https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/using-method-chaining
*/
            Console.WriteLine("Do you work in Toronto? (yes/no):");
            // Method Chaining (again): Reads input, removes extra spaces, and converts to lowercase.
            // Console.ReadLine() gets the input,
            // ?. prevents errors if input is null,
            // Trim() removes spaces,
            // ToLower() makes comparison easier (example: "YES" ==> "yes").
            string work = Console.ReadLine()?.Trim().ToLower() ?? "no";

            Console.WriteLine("Do you study in Toronto? (yes/no):");
            string study = Console.ReadLine()?.Trim().ToLower() ?? "no";

            // Logical OR (||): Only one of the conditions must be true
            if (live == "yes" || work == "yes" || study == "yes")
            {
                Console.WriteLine("You are eligible for a FREE Toronto Public Library card!");
            }
            else
            {
                Console.WriteLine("You need to pay a non-resident membership fee.");
            }

            // Link: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/boolean-logical-operators

            // ====== Comparison and Logical Operators Summary ======
            /*
             Comparison Operators:
             - ==  Equal to
             - !=  Not equal to
             - >   Greater than
             - <   Less than
             - >=  Greater than or equal to
             - <=  Less than or equal to

             Logical Operators:
             - &&  AND (both conditions must be true)
             - ||  OR (at least one condition must be true)
             - !   NOT (negates a condition)

             Link: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/boolean-logical-operators
            */

            /*
             * Switch Statement :
             * ******************
             * Switch Statement (Will be explained next time)
             * 
             * Example Preview: 
             switch (dayOfWeek)
             {
                 case "Monday":
                     Console.WriteLine("JavaScript Framework Lecture");
                     break;
                 case "Tuesday":
                     Console.WriteLine("C# and ASP.NET MVC Development Lecture");
                     break;
                 default:
                     Console.WriteLine("No Lecture");
                     break;
             }
            */

            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}
