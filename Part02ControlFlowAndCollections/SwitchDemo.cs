// NOTE: Code Formatting => CTRL + K, D

/*
File: SwitchDemo.cs
Topic: C# Control Structures - switch statement
This file demonstrates the use of the switch-case statement in C#.

Switch statements are a type of conditional logic useful for checking
one variable against multiple values (cases).

Link: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/switch
*/

// Namespace groups related code into one logical unit
namespace Part02ControlStructures
{
    /*
     * Class: SwitchDemo
     * This class contains a simple demonstration of switch-case usage in C#.
     * It's internal by default (accessible only in this assembly/project).
     */
    internal class SwitchDemo
    {
        /*
         * Method: Main
         * This is the entry point of the application.
         * We'll prompt the user to enter a number (1-5) and display a message
         * using the switch-case structure.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("** SWITCH Statement Demo **\n");
            // NOTE: \n to add a new line

            // Prompt the user to enter a number between 1 and 5
            Console.Write("Enter a number from 1 to 5: ");

            // Read user input from the console and convert it to integer
            /*
             * NOTE TO REVIEW:
             * > Console.ReadLine() might return null if the user just presses Enter.
             * > The ?? "" (null-coalescing operator) replaces null with an empty string.
             * > This ensures that the variable "input" is always a non-null string.
             */
            // Review: we must always specify the data type for any new variable:
            // Using the same technique as before (making sure that input will never be null):
            string input = Console.ReadLine() ?? "";

            // Or using the following way (less safe):
            // The input could be null => no warning or error message at compile time.
            // Nullable in case the user presses Enter without typing:
            // string? input = Console.ReadLine();


            // OPTION 1: Simple conversion using int.Parse:
            /*
             * "int.Parse()" is the simplest way to convert a string to an integer.
             * But if the user enters something that is NOT a number, 
             * the program will crash with an error.
             * We will try a better (safer) ways also
             *
             * Link: https://learn.microsoft.com/en-us/dotnet/api/system.int32.parse
             */

            // int number = int.Parse(input);
            // Console.WriteLine("You entered the number: " + number);

            /*
             * NOTICE: 
             * The above lines are commented out to avoid crashing the program.
             * You can uncomment them to test the crash behavior if the input is not a number.
             */


            // OPTION 2: Safer conversion using int.TryParse()
            /*
             * TryParse is a safer way to convert a string to an integer.
             * It tries to do the conversion, and tells us if it worked (true) or failed (false)
             * 
             * In other word:
             * TryParse() is a safer method to convert a string to a number.
             * It does not crash => it returns true if conversion worked or false otherwise
             * 
             * Link: https://learn.microsoft.com/en-us/dotnet/api/system.int32.tryparse
             */

            // Step 1: Declare a variable to hold the result
            int number; // declare the variable to store the result

            // Step 2: Try converting the input string to an integer
            bool isValidInt = int.TryParse(input, out number);
            /*
            * Syntax: bool isValidInt = int.TryParse(input, out int number);
            * - isValidInt: true if successful, false if not
            * - out number: this tells C# where to store the result if the conversion works
            */

            // Step 3: Use an if-statement to check if it worked
            if (isValidInt)
            {
                // Conversion successful => input was a valid number
                // To Review: Different ways to print output with a variable:
                // 1. Concatenation using +
                Console.WriteLine("You entered the number: " + number);

                // 2. String.Format style
                Console.WriteLine("You entered the number: {0}", number);

                // 3. String interpolation
                Console.WriteLine($"You entered the number: {number}");
            }
            else
            {
                // Conversion failed => input was not a valid number
                Console.WriteLine("That wasn't a valid number.");
                return; // Exit the program early since the input was invalid
                /*
                 * IMPORTANT NOTE ABOUT "return":
                 * ******************************
                 * - This keyword is used inside methods. 
                 * Since our code is inside the "Main" method, we can use "return" here safely
                 * - It has two main purposes:
                 *   > To return a value (if the method expects one when needed)
                 *   > To terminate/stop the method => will end the "Main" method
                 * 
                 * You'll see and use "return" more often when we learn about methods later :-)
                 */
            }

            /*
             * switch-case in C#:
             * - Used to compare a single variable to multiple constant values.
             * - Each "case" block represents a possible match.
             * - In C#, "break" is REQUIRED after each case unless:
             *     > we use "return" to exit the method, or
             *     > we use "goto" to jump to another case (advanced usage)
             * - Unlike languages like C, C++, PHP, Java, or JavaScript, 
             * C# does NOT allow case fall-through.
             * (We cannot have two cases in a row without code or a goto.)
             * - The "default" case is optional and runs if no other case matches.
             * 
             * To recap:
             * In C# (and some other languages like Java), 
             * we cannot have two consecutive case labels 
             * without any code or a goto statement between them.
             * This is a restriction to prevent unintentional "fall-through" behavior,
             * 
             * Code Example:
             switch (x)
                {
                    case 1:
                        goto case 2;  // Jumps to the "case 2" block
                    case 2:
                        Console.WriteLine("Valid case");
                        break;
                }
             */
            switch (number)
            {
                case 1:
                    Console.WriteLine("You entered ONE.");
                    // every case must have break:
                    break; // to stop the switch statement

                case 2:
                    Console.WriteLine("You entered TWO.");
                    break;

                case 3:
                    Console.WriteLine("You entered THREE.");
                    break;

                case 4:
                    Console.WriteLine("You entered FOUR.");
                    break;

                case 5:
                    Console.WriteLine("You entered FIVE.");
                    break;

                default:
                    Console.WriteLine("You entered a number outside the 1-5 range.");
                    break;
            }

            /*
             * Reminder: "break" is required to avoid "fall-through" behavior.
             * In C#, each case must end with "break" or "return"
             * Unlike C or JavaScript, C# does NOT allow case fall-through unless using goto.
             *
             * Link: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/switch
             */

            // Switch Another Example :-)
            double avg = 50;
            /*
             * if the avg is greater than or equal to 80 => Well Done
             * - avg >= 80 => Well Done
             * - avg >= 70 => Good Job
             * - else less than 70 => "Never give up! You can try again" 
             */

            Console.WriteLine("IF-ELSE Example:\n");
            if (avg >= 80)
            {
                // type cw then tab...
                // NOTE: No need for "System" as it's already in use (using/imported)
                System.Console.WriteLine("Well Done!");
            }
            else if (avg >= 70)
            {
                Console.WriteLine("Good Job!");
            }
            else
            {
                Console.WriteLine("Never give up! You can try again");
            }

            Console.WriteLine("\nSWITCH Example:\n");
            // Switch:
            switch (avg)
            {
                case < 50:
                    Console.WriteLine($"Your average {avg}, too low.");
                    break;
                case > 80.0:
                    Console.WriteLine($"Your average {avg}, too high.");
                    break;
                case > 70:
                    Console.WriteLine($"Your average {avg}, good.");
                    break;
                case >= 60:
                    Console.WriteLine($"Your average {avg}, Not bad.");
                    break;
                case >= 50:
                    Console.WriteLine($"Your average {avg}, Just Passing.");
                    break;
                default:
                    Console.WriteLine($"Invalid {avg} value!");
                    break;
            }

            Console.WriteLine("Switch statement demo complete.");
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine(); // Keep window open till pressing "Enter"
        } // Main
    } // class
} // namespace

