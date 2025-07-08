/*
File: MethodsDemo.cs
Topics: C# Methods, Parameters, Return Types, Static vs Non-static, and Variable Scopes

This file demonstrates how to define and call methods in C#:
- Method writing
- Parameters (value types, reference types)
- Return types
- Static and non-static methods
- Variable scopes (local and global)

Link: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods
*/

using System;

namespace Part03MethodsAndScopes
{
    internal class MethodsDemo
    {
        // Main method: Entry point for the application
        static void Main(string[] args)
        {
            Console.WriteLine("** Methods Demo **");

            // Declare variables
            int x = 10;
            double y = 70;
            string name = "Sam";
            int age = 25;

            // Call methods
            // Passing the arguments: 90 and 92
            double avg1 = GetAverage(90, 92);  // Calculate average
            Console.WriteLine($"Average 1: {avg1}");

            // Passing the arguments: 80 and 82
            double avg2 = GetAverage(80, 82);
            Console.WriteLine($"Average 2: {avg2}");

            // Calling method with void return type (doesn't return anything)
            SayHello(name);  // Print greeting message

            // Call static method with a return type (get area of a circle)
            double area = GetCircleArea(7);
            Console.WriteLine($"Circle Area: {area}");

            // Calling overloaded method (same method name, different parameter count)
            double avg3 = GetAverage(90, 92, 85);
            Console.WriteLine($"Average 3 (with three values): {avg3}");

            // Example: Passing reference types (arrays) to methods
            string[] studentNames = { "Steve", "Martin", "Kate", "Sam" };
            PrintNames(studentNames);  // Prints array of names

            // Example: Method with different parameter types (string, int, bool)
            PrintStudentInfo("Alex", 20, true);  // Prints student's info
        }
        /*
         * Parameters Vs Methods:
         * **********************
         * Methods take parameters (which are placeholders) 
         * and use arguments (values) when called.
         * 
         * 
         * Static vs Non-static Methods: 
         * *****************************
         * Static methods belong to the class itself, 
         * while non-static methods require an instance of the class to be called.
         * 
         * Variable Scope: 
         * ***************
         * Local variables exist within a method, 
         * while global variables are accessible throughout the class.
         */

        /*
         * This method calculates the average of two numbers
         * and returns the result as a double.
         * Parameters:
         * - num1: First number (double)
         * - num2: Second number (double)
         * 
         * Return:
         * - The average of num1 and num2 (double)
         */
        public static double GetAverage(double num1, double num2)
        {
            // Calculate average and return the result
            double average = (num1 + num2) / 2;
            return average;
        }

        /*
         * This method prints a greeting message to the user
         * with the name passed as a parameter.
         * 
         * Parameters:
         * - name: The name to be greeted (string)
         */
        public static void SayHello(string name)
        {
            // Print a greeting message
            Console.WriteLine($"Hello {name}!");
        }

        /*
         * This method calculates the area of a circle.
         * Formula: Area = Pi * radius^2
         * 
         * Parameters:
         * - radius: The radius of the circle (double)
         * 
         * Return:
         * - The area of the circle (double)
         */
        public static double GetCircleArea(double radius)
        {
            // Calculate area using Pi value and return it
            double area = Math.PI * Math.Pow(radius, 2);  // Using Math.PI for precision
            return area;
        }

        /*
         * Method Overloading: 
         * *******************
         * We can have multiple methods with the same name but different parameter:
         * - Different Set Of Parameters
         * - Different Data Types
         */

        /*
         * Overloaded "GetAverage" method to calculate the average of three numbers.
         * This demonstrates method overloading (same method name, but different parameters).
         * 
         * Parameters:
         * - num1: First number (double)
         * - num2: Second number (double)
         * - num3: Third number (double)
         * 
         * Return:
         * - The average of num1, num2, and num3 (double)
         */
        public static double GetAverage(double num1, double num2, double num3)
        {
            // Calculate average for three numbers and return the result
            double average = (num1 + num2 + num3) / 3;
            return average;
        }

        /*
         * Method that accepts an array (reference type) and prints each name.
         * Demonstrates passing reference types (arrays) to methods.
         * 
         * Parameters:
         * - names: An array of strings representing students' names.
         */
        public static void PrintNames(string[] names)
        {
            Console.WriteLine("\nList of Student Names:");
            foreach (string name in names)
            {
                Console.WriteLine($"- {name}");
            }
        }

        /*
         * Method that prints student's information (name, age, and enrollment status).
         * This demonstrates method with different parameter types.
         * 
         * Parameters:
         * - name: Student's name (string)
         * - age: Student's age (int)
         * - isEnrolled: Enrollment status (bool)
         */
        public static void PrintStudentInfo(string name, int age, bool isEnrolled)
        {
            Console.WriteLine("\nStudent Info:");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Enrolled: {isEnrolled}");
        }

        /*
         * Recap:
         * 
         * Explanation of Key Concepts:
         * *******************************
         * 
         * 1. Method Declaration:
         * - In C#, methods are defined with:
         *   > a return type (example: double, void, etc.),
         *   > a method name
         *   > and parameters inside parentheses (0 or x number of parameters).
         * 
         * 2. Calling Methods:
         * - Methods are called by passing arguments that correspond to the parameters 
         * defined in the method.
         * - The return value from the method can be stored in a variable or printed directly.
         * 
         * 3. Return Types:
         * - Methods can return values of any type (double, int, string, etc.).
         * - Methods that do not return anything are defined with a "void" return type.
         * 
         * 4. Parameters and Arguments:
         * - Parameters are used to pass data to methods, and they can be of any data type.
         * - Arguments are the values passed to the method when it's called.
         * 
         * 5. Static vs Non-static Methods:
         * - Static Methods: Can be called on the class itself without creating an instance.
         *   These methods cannot access instance variables or methods directly.
         * - Non-static Methods: Require an instance of the class to be called.
         *   They can access both static and instance variables and methods.
         * 
         * 6. Method Overloading:
         * - We can define multiple methods with the same name, 
         * but they must differ in their parameter types or the number of parameters.
         * 
         * 7. Variable Scope:
         * - Local Variables: Declared inside methods and only accessible within the method.
         * - Global Variables (Fields): Declared outside methods but inside the class. 
         * They are accessible throughout the class.
         */
    } // End of MethodsDemo class
} // End of namespace
