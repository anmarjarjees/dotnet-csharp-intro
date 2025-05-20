// NOTE: Code Formatting => CTRL + K, D

/*
File1: Program.cs
Topic: Basic Variable Declarations and Input/Output in C#
This example demonstrates basic syntax, variable types, input/output, 
and arithmetic operations.
*/

/*
With C# version  C# 9.0 and .NET 5+, we can use the "top-level statement" syntax
This means we can write code directly without needing to define a class 
or Main method explicitly.

This example uses the traditional Main method instead of the newer "top-level statements"
introduced in C# 9.0 and .NET 5+. 
For clarity and structure, we keep the classic format here.

Link: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/program-structure/top-level-statements
*/

/*
Optional Note:
"Console" is a class in the System namespace used for input/output
We include it with the "using" directive, similar to Java's import :-)
using System; // But no need since version 8
System namespace includes essential base classes like Console, Math, String, etc.
*/
// This is the main namespace of our project.
// Namespaces group related classes and avoid naming conflicts.
namespace Part01Basics
{
  /*
  * C# Class and File Naming Rules:
  * > In C#, file name and class name do not have to match.
  * > We can have a file named 01Program.cs with a class called Program01, MainClass,
  * or anything else (as long as it's a valid identifier).
  * > C# compiles the entire project together, so it's flexible in this regard.
  * 
  * In Java:
  * > If a class is public, its name must exactly match the file name.
  * > So a file named Student.java must contain: public class Student { }
  *
  * 1. If a class is declared as public, 
  * the file name must exactly match the class name (case-sensitive).
  * Example:
  *      File Name: Student.cs
  *      public class Student { ... }
  *
  * 2. A .cs file can have multiple classes, but only one can be public, 
  * and that public class must match the file name.
  *
  * 3. If the public class name does not match the file name, 
  * a compilation error (CS0106) will occur.
  *
  * 4. For non-public classes, the file name does not have to match the class name, 
  * but it is a best practice to name them the same for clarity.
  *
  * Best Practice: Even when the class is not public, 
  * it's still a good idea to name the file after the class for consistency.
  */

  // The 'Program' class is where the execution of the program begins.
  // 'internal' means this class is accessible only within this assembly (project).
  internal class Program
  {
    /*
     * By convention, the main entry point of a C# application 
     * is typically named Program.
     * This is the default name and helps indicate 
     * the starting point of the application.
     */
    /*
      - The "Main" method is the entry point of a C# console application:
      - The "Main" method is the starting point where execution begins
        > 'static' means it belongs to the class itself and not to a specific object.
        > 'void' means it does not return a value.
        > 'string[] args' can hold any command-line arguments 
           (not used in this example).
           NOTE:
           This parameter "args", which is meant to capture command-line arguments,
           if we do NOT use it in our program, 
           Visual Studio (or the compiler) may show a warning like:
           "Remove unused parameter 'args'".

           Three Solutions:
           **************** 
           > We can ignore this warning
           > Or Remove the parameter if you're not using it: static void Main()
           > Suppress the warning (advanced)
      */

    /*
      IMPORTANT NOTE:
      ***************
      Every C# project must contain exactly one Main() method
      Otherwise, the compiler will throw:
      error CS0017: Program has more than one entry point defined.

      Link: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/main-and-command-args
    */

    // 'string[] args' is used for command-line arguments.
    // We're not using it in this beginner example,
    // so it's safe to remove it or ignore the warning:
    static void Main(string[] args)
    {
      // ====== Hello World ======
      // This line prints a basic message to the console window.
      // Displaying "Hello, World!" to the console window:
      Console.WriteLine("Hello, World!"); // Basic output
                                          // Link: https://learn.microsoft.com/en-us/dotnet/api/system.console.writeline

      // // Wait for the user to press Enter before moving:
      Console.ReadLine(); // Keeps the window open (Just pause here)
                          // Link: https://learn.microsoft.com/en-us/dotnet/api/system.console.readline

      // ====== Console Input and Output ======
      // Prompt the user to enter their subject name
      Console.WriteLine("Enter your subject:");

      // Read user input safely and assign to string
      // 'Console.ReadLine()' reads a line of input as a string from the user
      // Use null-coalescing to avoid null issues:
      string subject = Console.ReadLine() ?? ""; // Reads a line (safe against null)
                                                 // Link: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator
      /*
       * To recap:
       * *********
       * This line ==> "Console.ReadLine() ?? "";
       * reads user input and uses ?? to handle null values:
       * - If the user presses Enter without typing anything, 
       *  > Console.ReadLine() might return null.
       *  The ?? operator says: "If it's null, use an empty string instead."
       *  So this guarantees 'subject' always has a valid (non-null) value.
       *  
       *  In Java:
       *  ********
       *  In Java, Scanner.nextLine() usually returns an empty string 
       *  if the user presses Enter, not null!
       *  that's why Java developers don’t often face this problem :-)
       */

      /* 
      NOTE about Output in C#:
      We can use either from the following ways:
      - Output using "Concatenation"
      - Output using "Interpolation"
      */
      // Using the "+" for concatenating:
      Console.WriteLine("Your current subject is " + subject);

      // Prompt the user to enter their college name
      Console.WriteLine("Enter your college name:");
      string college = Console.ReadLine() ?? ""; // Also coalescing null
      Console.WriteLine("Your current college is " + college);

      // String interpolation: easier way to print multiple values together
      // String interpolation using $ syntax
      Console.WriteLine($"You are studying {subject} at {college}.");
      // Link: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated

      // ====== Variable Declarations and Data Types ======
      // Here we are defining and assigning values to different types of variables
      // Declare variables with various basic data types

      // Integer (whole number)
      int age = 21;

      // Double precision (decimal number - floating-point)
      double avg = 3.75;

      // Boolean (true or false)
      bool isGraduated = false;

      // Character (a single letter or symbol)
      char grade = 'A'; // with single quote

      // String (text)
      string studentName = "John"; // with double quotes 

      // More:
      // Single precision (use 'f' suffix - must end with f)
      float floatNum = 7.0f;

      /*
       * NOTE: 
       * We can ignore the warning:
       * "The variable 'variable' is assigned but its value is never used"
       * at least for the learning demonstration. 
       */

      // High-precision decimal (accurate for financial data, use 'm' suffix - must end with m)
      decimal decNum = 23.7m;

      /*
       * NOTE:
      double is the default for decimal numbers, but:
      - float uses less memory (7 digits precision), add 'f' suffix (example: 7.0f)
      - decimal is more accurate for money (28+ digits), add 'm' suffix (example: 23.7m)
       */

      // Implicitly typed variables using var (type inferred by compiler)
      var x = 10;
      var y = "Hello!";
      var z = false;

      // Display all the variables in a formatted sentence
      Console.WriteLine($"Student: {studentName}, Age: {age}, avg: {avg}, Grade: {grade}, Graduated: {isGraduated}");

      // ====== Arithmetic Operations ======
      // Now let's do some simple math with variables
      int a = 10;
      int b = 3;


      // Performing and displaying basic math operations
      // These are basic arithmetic operations in C#
      Console.WriteLine($"Addition: {a + b}"); // Adds a and b
      Console.WriteLine($"Subtraction: {a - b}"); // Subtracts b from a
      Console.WriteLine($"Multiplication: {a * b}"); // Multiplies a and b
      Console.WriteLine($"Division: {a / b}"); // Divides a by b (integer division)
      Console.WriteLine($"Modulus (Remainder): {a % b}"); // Gets the remainder of a divided by b

      // ====== End of Program ======
      // This is added to pause the program so the console stays open
      // until the user presses Enter. This is useful when running from Visual Studio.
      Console.WriteLine("Press Enter to exit...");

      // Wait for the user to press Enter before exiting:
      Console.ReadLine(); // Wait for user to press Enter
                          // Link: https://learn.microsoft.com/en-us/dotnet/api/system.console.readline
    }
  }
}

