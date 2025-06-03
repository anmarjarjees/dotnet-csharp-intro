// NOTE: Code Formatting => CTRL + K, D

/*
File: LoopsDemo.cs
Topic: C# Control Structures - Loops:
 - for
 - while
 - do-while
 - foreach
 - break & continue

This file demonstrates various looping techniques in C#.
Loops allow you to repeat a block of code multiple times.

Link: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/iteration-statements
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part02ControlFlowAndCollections
{
    /*
     * Class: LoopsDemo
     * This class demonstrates various loop structures available in C#.
     * It's internal by default (accessible only in this assembly/project).
     */
    internal class LoopsDemo
    {
        /*
         * Method: Main
         * This is the entry point of the application.
         * We'll demonstrate how to use the different loop types in C#.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("** Loops Demo **");

            // For loop: Used when we know how many times to loop            
            Console.WriteLine("For Loop:");
            // Iterate 5 times:
            for (int i = 1; i <= 5; i++)
            {
                // Output the text to the Console Window:
                // Show all 3 output styles for learning purposes:
                // String Concatenation using +
                Console.WriteLine("Using +: Iteration " + i);

                // String.Format syntax:
                Console.WriteLine("Using String.Format: Iteration {0}", i);

                // Interpolation using $
                Console.WriteLine($"Using $ Interpolation: Iteration {i}");
            }

            /*
             * To Review: Ways to print variables in C#:
             * - Console.WriteLine("Value: " + value);         // Concatenation
             * - Console.WriteLine("Value: {0}", value);       // String.Format style
             * - Console.WriteLine($"Value: {value}");         // Interpolated strings
             */


            // While loop: Keep running as long as the condition is true
            Console.WriteLine("\nWhile Loop:");
            // WHILE loop: Repeats while condition is true
            int counter = 1;
            while (counter <= 5)
            {
                Console.WriteLine("Iteration " + counter);
                counter++;
            }

            // Do-While loop: Similar to while but ensures at least one iteration
            Console.WriteLine("\nDo-While Loop:");
            // Runs at least once before checking the condition
            int doCounter = 1;
            do
            {
                Console.WriteLine("Iteration " + doCounter);
                doCounter++;
            } while (doCounter <= 5);

            // Foreach loop: Ideal for iterating over collections (arrays, lists)
            // Using the CMYK colors for printing:
            // Link: https://en.wikipedia.org/wiki/CMYK_color_model
            Console.WriteLine("\nForeach Loop:");
            string[] colorPrinting = { "Cyan", "Magenta", "Yellow", "Black" };
            // Best for arrays/collections:
            foreach (string color in colorPrinting)
            {
                Console.WriteLine("Color: " + color);
            }

            // Break statement: Breaks out of a loop prematurely
            Console.WriteLine("\nBreak in Loop:");
            // Break => Exit loop
            for (int i = 1; i <= 10; i++)
            {
                if (i == 6) break; // Exit loop when i is 6
                Console.WriteLine("Iteration " + i);
            }

            // Continue statement: Skips the current iteration and moves to the next one
            Console.WriteLine("\nContinue in Loop:");
            // continue => Skip an iteration
            for (int i = 1; i <= 5; i++)
            {
                if (i == 3) continue; // Skip iteration when i is 3
                Console.WriteLine("Iteration " + i);
            }

            // More Examples about looping through arrays (1D & 2D):
            // *****************************************************
            // PART 1: Looping through a 1D Array using for and foreach
            Console.WriteLine("\nLooping through a 1D array:");

            int[] luckyNumbers = { 7, 14, 21, 28, 35 };

            Console.WriteLine("Using for loop:");
            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine("Lucky Number [" + i + "] = " + luckyNumbers[i]);
            }

            Console.WriteLine("Using foreach loop:");
            foreach (int number in luckyNumbers)
            {
                Console.WriteLine("Lucky Number = " + number);
            }

             // PART 2: Looping through a 2D Array (Matrix)
            Console.WriteLine("\nLooping through a 2D array:");

            string[,] countriesAndCapitals = {
                { "Canada", "Ottawa" },
                { "France", "Paris" },
                { "Brazil", "Brasilia" },
                { "Japan", "Tokyo" }
            };

            // Loop through rows
            for (int row = 0; row < countriesAndCapitals.GetLength(0); row++)
            {
                // Loop through columns
                for (int col = 0; col < countriesAndCapitals.GetLength(1); col++)
                {
                    Console.Write(countriesAndCapitals[row, col] + "\t");
                }
                Console.WriteLine(); // New line after each row
            }


            Console.WriteLine("Loops demo complete.");
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine(); // Keep window open until pressing "Enter"
        } // Main
    } // class
} // namespace
/*
 * Notes To Recap:
 * ***************
 * > for loop: Used when the number of iterations is known beforehand
 * 
 * > while loop: Runs as long as the condition remains true, 
 * good for conditions where we don't know how many iterations will be needed.
 * 
 * > do-while loop: Similar to while, but it guarantees the loop runs at least once 
 * before checking the condition.
 * 
 * > foreach loop: Ideal for iterating over collections, 
 * such as arrays or lists, without needing to manage an index.
 * 
 * > break statement: Exits the loop early if a condition is met.
 * > continue statement: Skips the current iteration and proceeds with the next one.
 * 
 * > 1D array looping: Use for/foreach to access each element
 * > 2D array looping: Use nested loops for rows and columns
 */
