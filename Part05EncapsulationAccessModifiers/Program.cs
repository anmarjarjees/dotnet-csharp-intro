/*
File: Program.cs
Project: Part05EncapsulationAccessModifiers
Topic: Encapsulation and Access Modifiers

This file contains the Main method to demonstrate:
- Creating instances of BankAccount
- Accessing fields and properties with correct access levels
- Performing deposits and withdrawals
- Attempting invalid actions to demonstrate encapsulation

Note: This file must reference BankAccount.cs and be in the same namespace.
*/

using System;

namespace Part05EncapsulationAccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("= Encapsulation and Access Modifiers Demo =\n");

            // Create a new bank account object "account1":
            BankAccount account1 = new BankAccount("Acc12345", "Alex Chow", 500);

            // Access public property
            Console.WriteLine(account1.ToString());
            Console.WriteLine();

            // Try accessing private field directly
            // Uncommenting this code below will cause error:
            // Console.WriteLine(account1._balance); 
            // Error: inaccessible due to its protection level

            // Deposit and Withdraw using public methods
            account1.Deposit(250); // Valid deposit
            account1.Withdraw(100); // Valid withdrawal
            account1.Withdraw(1000); // Invalid: exceeds balance
            account1.Deposit(-50); // Invalid: negative amount

            Console.WriteLine("\nFinal Account Summary:");
            Console.WriteLine(account1.ToString());

            // Create another account
            BankAccount account2 = new BankAccount("Acc56789", "Martin Smith", 1000);
            account2.Withdraw(200);
            account2.Deposit(300);

            Console.WriteLine("\nSecond Account Summary:");
            Console.WriteLine(account2.ToString());
        } // Main
    } // class
} // namespace

