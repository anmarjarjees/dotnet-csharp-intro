// NOTE: Code Formatting => CTRL + K, D

/*
File: ArraysDemo.cs
Topic: C# Control Structures - Arrays
This file demonstrates how to declare and initialize arrays in C#.

Arrays allow us to store multiple values in a single variable of the same data type.
They are fixed in size and indexed from 0.

Link: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part02ControlFlowAndCollections
{
    /*
     * Class: ArraysDemo
     * Demonstrates how to declare, initialize, and access arrays.
     */
    internal class ArraysDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** ARRAYS Demo **\n");

            // PART 1: Using multiple variables (not recommended for many values)
            int myLuckyNumber = 7; // if I want to use one number

           /*
            * Notice the warning: 
            * The variable 'variable' is assigned but its value is never used
            */

            // But what if I have 5 lucky numbers?
            int myLuckyNumber1 = 9;
            int myLuckyNumber2 = 3;
            int myLuckyNumber3 = 10;
            int myLuckyNumber4 = 25;
            int myLuckyNumber5 = 30;

            // The problem: we can't process them easily. Too many variables.
            // A better way is to use a single array variable.

            // PART 2: Creating an array to hold multiple lucky numbers
            /*
             * Using arrays: A single variable to hold multiple values!
             * Arrays in C# (like Java) require:
             * - All elements must be of the same data type
             * - Fixed number of elements (size is defined at creation)
             */

            // Declare and initialize an array of 5 integers:
            int[] luckyNumbers = { 9, 3, 10, 25, 30 };

            // Accessing individual elements using index:

            // Index starts at 0:
            Console.WriteLine("My first lucky number is: " + luckyNumbers[0]);

            // Last element at index 4:
            Console.WriteLine("My last lucky number is: " + luckyNumbers[4]);

            // PART 3: Array of student names
            // Declare an array to store names of 6 students
            // Create array with size 6 (6 elements):
            string[] students = new string[6];

            // Manually assign names to each element (index 0 to 5)
            students[0] = "Alex Chow";
            students[1] = "Martin Smith";
            students[2] = "Sam Simpson";
            students[3] = "Sarah Grandson";
            students[4] = "Kate Wilson";
            students[5] = "Elena Chow";

            // Accessing a student name by index
            Console.WriteLine("The third student is: " + students[2]); // Sam Simpson

            // PART 4: Initializing an array in one line
            // Subjects offered in a course
            string[] subjects = { "HTML", "CSS", "Bootstrap", "JavaScript", "jQuery", "Python", "C#" };

            Console.WriteLine("First subject is: " + subjects[0]);   // HTML
            Console.WriteLine("Last subject is: " + subjects[6]);    // C#

            // PART 5: 2D Arrays (Matrix-style: rows and columns)
            /*
                * 2D Array syntax in C#:
                * - Declared using a comma [,]
                * - We can visualize it like a table with rows and columns.
                * - Think of countriesAndCapitals[0,1] as row 0, column 1
                * 
                * Link: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/multidimensional-arrays
             */
            string[,] countriesAndCapitals = {
                { "Canada", "Ottawa" },
                { "USA", "Washington" },
                { "UK", "London" },
                { "Japan", "Tokyo" }
            };

            // Accessing values from the 2D array

            Console.WriteLine("The capital of USA is: " + countriesAndCapitals[1, 1]); // Washington
            Console.WriteLine("The capital of Japan is: " + countriesAndCapitals[3, 1]); // Tokyo

            Console.WriteLine("Arrays demo complete.");
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine(); // Wait for user input before closing
        } // Main
    } // class
} // namespace

