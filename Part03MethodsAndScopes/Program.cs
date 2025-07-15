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
        /*
         * Working with Methods:
         *  - Method => A function that belongs to a class in C#
         *  - Function => A general programming term for a block of reusable code
         *  functions do actions :-)
         * 
         * Example of Methods (Reviewing) => Main():
         * *****************************************
         * > The "Main()" method => The Entry point for any C# application
         * > Main() Method => provided by the C# runtime as the program's entry point
         * > Main() must be static because it runs before any object is created
         * > Has to be: static void Main(string[] args)
        */
        static void Main(string[] args)
        {
            Console.WriteLine("** Methods Demo **");
            // Declare variables
            int x = 10;
            double y = 70;
            string name = "Sam";
            int age = 25;

            // Calling our methods (inside the Main method):     
            // arguments => what we pass to the methods when we call/invoke them:   

            // Calling method with void return type (doesn't return anything)
            // Passing the argument: name
            SayHello(name);  // Print greeting message

            // Call static method with a return type (get area of a circle)
            double area = GetCircleArea(7);
            Console.WriteLine($"Circle Area: {area}");

            bool passed = IsPassingGrade(66.5);
            Console.WriteLine($"Did the student pass? {passed}");

            double exam1 = 78.67;
            double exam2 = 81.56;
            // Passing the arguments: exam1 and exam2
            double avg1 = GetAverage(exam1, exam2);  // Calculate average
            Console.WriteLine("Average of the 2 exams: " + avg1);
            // OR:
            Console.WriteLine($"Average of the 2 exams: {avg1}");

            // Passing the arguments: 80 and 82
            double avg2 = GetAverage(80, 82);
            Console.WriteLine($"Average 2 (of two exams): {avg2}");

            // Calling overloaded method (same method name, different parameter count)
            double avg3 = GetAverage(90, 92, 85);
            Console.WriteLine($"Average 3 (with three values): {avg3}");

            double average2 = GetAverage(80, 75, 68.5, 90);
            Console.WriteLine("The average of 4 quizzes is " + average2);

            // Example: Passing reference types (arrays) to methods
            string[] studentNames = { "Steve", "Martin", "Kate", "Sam" };
            PrintNames(studentNames);  // Prints array of names

            // Example: Method with different parameter types (string, int, bool)
            PrintStudentInfo("Alex", 20, true);  // Prints student's info

            // Finally calling our non-static method "ShowDemoMessage()":
            /*
             * Non-static methods:
             * *******************
             * > require object creation (instance of the class)
             * > is opposite of static methods which can be called directly from the class
             */
            // 1) Create an "object" to call non-static method
            MethodsDemo demo = new MethodsDemo();
            // 2) Calling the non-static method through the object:
            demo.ShowDemoMessage();
        } // end Main()

        // adding more methods :-)
        /*
         * Parameters Vs Arguments:
         * ************************
         * Methods take parameters (which are placeholders) 
         * and use arguments (values) when called.
         * 
         * 
         * Static vs Non-static Methods: 
         * *****************************
         * Static methods belong to the "class" itself, 
         * while non-static methods require an "instance" of the class to be called.
         * 
         * Variable Scope: 
         * ***************
         * Local variables exist within a method, 
         * while global variables are accessible throughout the class.
         */

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

        // Example of returning a boolean data type:
        public static bool IsPassingGrade(double grade)
        {
            return grade >= 50;
        }

        /*
         * Problem:
         * ********
         * Average for 2 numeric values:
         * This method calculates the average of any two numeric values
         * and returns the result as a "double" data type.
         * 
         * Parameters:
         * ***********
         * This method accepts two parameters:
         * - num1: First number (double)
         * - num2: Second number (double)
         * 
         * Return:
         * - The average of num1 and num2 
         * - the average (return data type) will be "double"
         */

        // Example:
        // This method can be used for our two exams: midterm and final
        // Or for our two assignments: midterm and final
        public static double GetAverage(double num1, double num2)
        {
            // We can output the result (not recommended)
            // The method name is "GetAverage" not "PrintAverage"!
            // Console.WriteLine((num1 + num2) / 2);

            // Calculate average and return the result
            double average = (num1 + num2) / 2;
            return average;
        }

        /*
         * A PIE :-)
         * A => Abstraction
         * P => Polymorphism (Method Overloading & Method Overriding)
         * I => Inheritance
         * E => Encapsulation 
         * 
         * Polymorphism: 
         * Has Two types:
         * - Method Overloading (in our current example)
         * - Method Overriding (next...)
         */

        /*
         * Method Overloading: 
         * *******************
         * We can have multiple methods with the same name but different parameter lists:
         * - Different number of parameters
         * - Different data types
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

        // We need a similar method but for our 4 quizzes!
        // instead of having 2 "parameters", we need 4 "parameters"
        public static double GetAverage(double num1, double num2, double num3, double num4)
        {
            return (num1 + num2 + num3 + num4) / 4;
        } // end GetAverage()

        /*
         * Method that accepts an array (reference type) and prints each name.
         * Demonstrates passing reference types (arrays) to methods.
         * "Arrays" are reference types, 
         * so changes inside the method can affect the original data.
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

        // Finally: "Non-static" method (and how to call it):
        public void ShowDemoMessage()
        {
            Console.WriteLine("This is a non-static method.");
        }

    } // End of MethodsDemo class
} // End of namespace

/*
 * Recap:
 * 
 * Explanation of Key Concepts:
 * *******************************
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
