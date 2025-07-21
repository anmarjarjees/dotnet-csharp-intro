// All these class library will be given to us by C# (Unused - Not Needed) 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
File: BankAccount.cs
Project: Part05EncapsulationAccessModifiers
Topic: Encapsulation and Access Modifiers in C#

This file defines the BankAccount class with the following topics:
- Encapsulation using private fields
- Controlled access using public properties
- Access modifiers (public, private, protected, internal)
- Input validation within public methods
- Summary table of naming conventions and modifiers

References:
- https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers
- https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/fields

C# Naming Conventions (Reviewing Again):
----------------------------------------
- Class, Struct, Enum => PascalCase 
    like: Person, Book => Public
- Method, Property, Event => PascalCase
    like: Deposit(), Balance => Public
- Field (private/internal only)  => camelCase or _camelCase 
    like: _balance => Private
- Parameter, Local Variable => camelCase
    like: amount, userInput => Internal

Access Modifiers Summary:
--------------------------
- public => Accessible from anywhere
- private => Accessible only within the same class
- protected => Accessible in the same class and derived classes
- internal => Accessible within the same assembly
*/

namespace Part05EncapsulationAccessModifiers
{
    public class BankAccount
    {
        /*
         * A PIE:
         * "Abstraction" => hiding complex implementation details 
         * and exposing only the necessary features of an object or system. 
         * It allows users to interact with an object without needing to understand
         * how it works internally.
         * 
         * Real-world analogy:
         * -------------------
         * A TV remote control. We press a button to change the channel 
         * or adjust the volume, 
         * but we don't need to know how the remote communicates with the TV 
         * or processes the signal.
         * 
         * In C#, abstraction is typically implemented using:
         *  > "abstract" classes 
         *  > or "interfaces".
         *  (To be discussed later...)
         *  
         * "Encapsulation" => hiding the internal state (data) of an object 
         * and only allowing access through public methods or properties. 
         * This helps protect the data from unwanted changes.
         * 
         * Real-world analogy:
         * -------------------
         * Think of a Bank Account. You can't directly take money from the account's
         * internal balance (private field); 
         * instead, you must go through methods like Deposit() or Withdraw().
         * 
         * This ensures normal bank rules like "overdraft" are enforced
         * 
         * Clarification:
         * - Encapsulation = hiding data => like not accessing _balance directly
         * - Abstraction = hiding complexity => like using a TV remote without knowing how it sends infrared signals.
         * 
         * In this example:
         * ****************
         * "_balance" is private "field", 
         * and access is provided via a public Balance property or method.
         */

        // Private "field" for encapsulation
        private decimal _balance;

        // Public property for AccountNumber (read-only after initialization)
        public string AccountNumber { get; private set; }
        /*
         * Explanations: public string AccountNumber { get; private set; }
         * >> It's also called "Auto-implemented property"
         * public "get" => Anyone can read the AccountNumber.
         * private "set" => Only code inside the class 
         * (like constructors or methods) can assign a value to AccountNumber.
         */

        // Public property for AccountHolderName
        public string AccountHolderName { get; set; }
        /*
         * Explanation: public string AccountHolderName { get; set; }
         * >> It's also called "Auto-implemented property"
         * public "get" => Anyone can read the AccountHolderName.
         * public "set" => Anyone can also assign/change the AccountHolderName.
         * This means both reading and writing are allowed from outside the class.
         */

        // Public property for accessing the balance in a read-only way
        public decimal Balance
        {
            get { return _balance; }
        }

        /*
         * Manually implemented property with private field:
         * *************************************************
         * - This is also valid and sometimes could be necessary!
         * - Using this approach/way only when we need extra logic 
         * in the getter or setter, such as logging, validation, transformation, etc..
         * 
         * Example of a fully implemented property using a "private" backing field.
         * This style is used when we need to add logic inside get/set later.
         * 
         * In the example below:
         * - "_branchName" is a "private" field that stores the actual value
         * - The "public" property "BranchName" allows controlled access to it
         * - The same functionally as auto-property, but gives more flexibility
         * 
         * Tip: If we don't need extra logic, prefer using auto-properties (cleaner).
         */

        // Private backing field for BranchName (just for demonstration)
        private string _branchName;

        // Public property with full implementation (get and set)
        public string BranchName
        {
            get { return _branchName; }
            set { _branchName = value; }
        }

        /*
         * As Conclusion:
         * It is recommended to use "Auto-implemented property":
         * - We don't need any custom logic in the get or set
         * - It automatically creates a private backing field behind the scenes
         * - Easier to read and maintain
         * - Still supports encapsulation (like: read-only from outside).
         */

        // Constructor:
        /*
         * - The string data type parameters: 
         *      > 'accountNumber'
         *      > 'accountHolderName' 
         *   are "non-nullable" by default
         *   so they are "non-nullable reference types"
         * - "non-nullable" means they can NOT accept null values 
         *        
         * It's a safety feature in newer versions of C# 
         * to prevent null reference errors 
         * and that it's something they can explore later 
         * when they dive deeper into the language.
         * 
         * C# Compiler will give us warning based on the links below:
         * Link: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings
         * 
         * Link: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings?f1url=%3FappId%3Droslyn%26k%3Dk(CS8618)#nonnullable-reference-not-initialized
         */
        public BankAccount(string accountNumber, string accountHolderName, decimal initialDeposit)
        {
            /*
             * NOTE:
             * *****
             * Below, we are assigning a value to the "AccountNumber" property 
             * using its private "set" accessor, 
             * which is perfectly valid inside the class itself
             */
            AccountNumber = accountNumber; // Valid: we're inside the class
            AccountHolderName = accountHolderName;
            Deposit(initialDeposit); // Use method to ensure validation
        }

        // Method to deposit money with validation
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be greater than zero.");
                return;
            }

            _balance += amount;
            Console.WriteLine($"Deposit successful. New balance: ${_balance}");
        }

        // Method to withdraw money with validation
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be greater than zero.");
                return;
            }

            if (amount > _balance)
            {
                Console.WriteLine("Insufficient funds.");
                return;
            }

            _balance -= amount;
            Console.WriteLine($"Withdrawal successful. New balance: ${_balance}");
        }

        /*
         * Overriding:
         * **********
         * Override of the ToString() method (from the base Object class).
         * This lets us define what should be shown when we print the object.
         * 
         * Instead of showing the class name (default), we display useful info:
         * - Account number
         * - Account holder name
         * - Branch name
         * - Current balance
         * 
         * So calling account1.ToString() or just Console.WriteLine(account1)
         * will now show all this nicely formatted data.
         * 
         * Important Note: 
         * ***************
         * This "ToString()" method is an example of method overriding,
         * which is one form (type) of polymorphism in object-oriented programming.
         * More details on Overriding vs Overloading will be covered later :-)
         * 
         * FYI :-)
         * *******
         * Polymorphism: allows objects to take many forms. 
         * There are two main types:
         * - Overloading => Timing: Compile-time
         *  > Same method name, different signatures
         * - Overriding => Timing: Runtime 
         *  > Same method signature, different behavior in subclass
        */

        // Overriding the ToString method to display account information (details)
        public override string ToString()
        {
            return $"Account Number: {AccountNumber}\n" +
                   $"Account Holder: {AccountHolderName}\n" +
                   $"Branch Name: {BranchName}\n" +
                   $"Balance: ${_balance}";
        }
    } // class
} // namespace

/*
 * Important Notes And Summaries To Take :-)
 * *****************************************
 * - In "Object-Oriented Programming", fields are typically "private" or "protected"
 * - Fields should be "private" or "protected" to ensure "Encapsulation"
 * - Public fields are technically allowed, but not recommended in production code
 * - We can use public fields mainly for demos or quick prototypes, 
 * but we should switch to properties when designing for real applications
 * 
 * TIP:
 * ****
 * Avoid using "public" fields in real-world applications because:
 * - they break the principles of "Encapsulation" 
 * - may lead to uncontrolled access to the data
 * 
 * With "private" fields, we can control how the field is accessed or modified 
 * through properties and methods. 
 * For our Bank example, we can add validation or logic when setting the value 
 * (like ensuring a balance isn't set to a negative value)
 */ 