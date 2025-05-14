// NOTE: Code Formatting => CTRL + K, D

/*
File2: CastingDemo.cs
Topic: Type Casting and Conversion in C#
This example demonstrates "implicit" and "explicit" casting 
as well as type conversion methods.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// We are defining the namespace for this file. 
// A namespace helps organize classes logically and avoids name conflicts.
namespace Part01Basics
{
    // The main class where the code is executed.
    /*
     * The 'internal' modifier means this class is accessible within the same assembly (project) only.
     * In a real-world scenario, we would make classes 'public' if we want them to be accessible in other parts of the program or projects.
    */
    internal class CastingDemo
    {
        // Main method: The entry point where the program starts execution.
        static void CastingDemoMain(string[] args)
        {
            /*
             *  Implicit Casting (Automatic Type Conversion):
             *  *********************************************
             *  Implicit casting is handled automatically by the compiler 
             *  when converting a smaller data type to a larger one.
             *  
                Example: Converting 'int' to 'double'.
             *  This is considered safe because no data is lost in the process.
             *  
                This type of casting is safe and doesn't cause any data loss. 
             *  C# automatically converts an 'int' to a 'double', 
             *  because a double can hold all values an int can hold, 
             *  as well as more precise floating-point values.

             *  Link: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0266 
             */

            // Declare an integer variable and assign it a value of 100:
            int intVal = 100;

            // Implicitly converts the 'int' value to a 'double' (larger type):
            double doubleVal = intVal;

            // Print the result of the implicit cast:
            Console.WriteLine($"Implicit Casting: {intVal} ==> {doubleVal}");

            /*
             * Explanation: 
             * No need for explicit casting here, 
             * because the conversion from int (32-bit) to double (64-bit) is safe.
             * 'double' is capable of holding all values an 'int' can hold, 
             * as well as more precise floating-point values.
              this conversion does not result in any data loss.
             */

            /*
             * ====== Explicit Casting (Manual Type Conversion) ======
             * Explicit casting is needed when converting a larger data type 
             * to a smaller one.

             This may result in data loss (example: decimal truncation).
             *
             * Example: Converting 'double' to 'int'.

             * When converting from a larger data type (like double) 
             * to a smaller one (like int),

             * there's a risk of data loss (example: truncating decimals), 
             * and hence C# requires us to explicitly cast.
             * Link: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions
             */

            // Declare a double with a decimal value:
            double largeDouble = 123.45;

            // Explicitly casts the 'double' to an 'int' (this will lose the decimal part):
            int truncatedInt = (int)largeDouble;

            // Print the result of the explicit cast:
            Console.WriteLine($"Explicit Casting: {largeDouble} ==> {truncatedInt}");

            /*
             * Explanation: 
             Only the whole number part remains after casting.

             The decimal part of 'largeDouble' is discarded 
             when explicitly casting to 'int'. 

             123.45 becomes 123; the fractional part (.45) is discarded.

             * This is why the output will be 123, 
             * without the '.45' part of the original double.
             */

            /*
             * ====== Type Conversion Methods ======
             * C# provides built-in methods for safely converting between different types.
             * These methods are often more flexible and safer than direct casting,
             * especially when dealing with strings and other data types.
             * 
             * Link: https://learn.microsoft.com/en-us/dotnet/api/system.convert.toint32
             * Link: https://learn.microsoft.com/en-us/dotnet/api/system.int32.tryparse
             * 
             * Examples:
              - Convert.ToInt32() converts a string to an integer.
             * It handles null values and non-numeric strings 
             * by throwing exceptions or returning default values
               
               OR:
             * - int.TryParse()
             */

            // Declare a string with a numeric value:
            string strVal = "123";

            // Convert the string 'strVal' to an integer:
            int convertedInt = Convert.ToInt32(strVal);

            // Print the result of the conversion:
            Console.WriteLine($"Converted using Convert.ToInt32(): {strVal} ==> {convertedInt}");

            /*    
            Explanation: 
            The Convert method is useful when you need to convert other types 
            like strings or booleans into integers. 
            
            It can handle null or invalid formats by throwing exceptions 
            if the conversion is not valid.

            'Convert.ToInt32()' will throw an exception if the string is null or not numeric.
             * It's powerful but should be used with caution.
            */

            /*
           * Explanation:
           'int.TryParse()' attempts to convert a string to an integer. It returns a boolean indicating success or failure.
           * 'TryParse()' avoids exceptions by returning 'false' if the input is invalid.
           * It is a safer alternative when user input is unpredictable.
           */

            // This string cannot be converted to an integer:
            string invalidStr = "ABC";

            // Try to parse the string into an integer:
            bool isValid = int.TryParse(invalidStr, out int result);

            if (isValid)
            {
                // If the conversion is successful, this block will execute.
                // Print the result of the conversion:
                Console.WriteLine($"Converted using TryParse(): {invalidStr} ==> {result}");
            }
            else
            {
                // If the conversion fails, we handle the failure here.
                // Print error message:
                Console.WriteLine($"Failed to convert using TryParse(): {invalidStr} is not a valid integer.");
            }
            /*
            Explanation: 
            'TryParse' is a safer method for converting, as it avoids exceptions. 
            It checks whether the input is valid and returns a boolean result, 
            making it easier to handle conversion failures gracefully 
            without crashing the program.
            */

            /*
            * ====== Additional Examples: bool, float, and decimal ======
            * These show other simple and practical conversions.
            */

            // === Bool to String and Back ===
            bool isAvailable = true;
            string boolAsString = isAvailable.ToString(); // "True"
            bool parsedBool = Convert.ToBoolean(boolAsString); // true
            Console.WriteLine($"Bool to String and back: {isAvailable} ==> \"{boolAsString}\" ==> {parsedBool}");

            /*
             * Link: https://learn.microsoft.com/en-us/dotnet/api/system.convert.toboolean
             * Explanation: Convert.ToBoolean can convert "true"/"false" strings to bool values.
             */

            // === Float to Int (explicit cast) ===
            float floatVal = 9.99f;
            int intFromFloat = (int)floatVal; // Result will be 9 (decimal part lost)
            Console.WriteLine($"Float to Int (explicit): {floatVal} ==> {intFromFloat}");

            /*
             * Link: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types
             * Explanation: Just like double to int, this will truncate the decimal part.
             */

            // === Decimal to Double (implicit), and to Int (explicit) ===
            decimal money = 19.75m;
            double moneyAsDouble = (double)money; // Explicit for clarity
            int moneyAsInt = (int)money; // Truncates to 19
            Console.WriteLine($"Decimal to Double: {money} ==> {moneyAsDouble}");
            Console.WriteLine($"Decimal to Int: {money} ==> {moneyAsInt}");

            /*
             * Link: https://learn.microsoft.com/en-us/dotnet/api/system.decimal
             * Explanation: Decimal is useful for financial values. You can cast it explicitly to other types when needed.
             */

            // ====== End of Program ======
            // The following line is used to pause the program before closing, so that the console stays open until the user presses Enter.
            // This is useful when running the program from Visual Studio.
            Console.WriteLine("Press Enter to exit...");

            // Wait for the user to press Enter before the program ends.
            Console.ReadLine(); // Wait for user input.
        }
    }
}
/*
Summary:
--------
Implicit Casting:
    - Done automatically when converting smaller types to larger types (example: int to double).
    - Safe and no data is lost.

Explicit Casting:
    - Must be done manually when converting larger types to smaller types (example: double to int).
    - Risk of data loss (example: decimal truncation).

Type Conversion Methods:
    - Convert.ToInt32(): Converts strings to integers, but throws exceptions on failure.
    - TryParse(): Safely attempts conversion, returns false if the input is invalid.
*/

