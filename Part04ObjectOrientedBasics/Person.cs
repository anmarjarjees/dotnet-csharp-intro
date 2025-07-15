// NOTE: All these are unused libraries/classes (You can delete them all)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    File: Person.cs
    Project: Part04ObjectOrientedBasics
    Topic: Defining a Basic Class in C# (OOP Fundamentals)

    This file defines a simple class "Person" to demonstrate:
    - Classes and Objects
    - Encapsulation (fields and properties)
    - Constructors (default and parameterized)
    - this keyword
    - Method definition
    - C# naming conventions (Please Review the Summary at the end of the file)

    Microsoft Docs References:
    - Object-Oriented Fundamentals: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/
    - Classes and Objects: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/classes-objects
    - Constructors: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/constructors
    - this Keyword: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/using-this
    - C# Coding Conventions: https://learn.microsoft.com/en-us/dotnet/fundamentals/coding-style/coding-conventions

    For more references, check the comment at the end of Program.cs file :-)
*/

/*
 * IMPORTANT NOTE TO REVIEW: "Assembly":
 * *************************************
 * > The word "assembly" comes from the idea of "assembling" all the parts
 * > Our program (code, resources, metadata) is assembled into one compiled unit
 * > It's like packing everything needed to run your program into a box
 * > This one complied unit is usually a .DLL or .EXE file
 * > In C#, an "assembly" is a compiled file (like .exe or .dll)
 * > This assembly file contains our code and all the project resources
 * > Assembly is the basic building block of any .NET application
 * 
 * Example: 
 * When we build a C# project, it gets compiled into an assembly (.exe or .dll)
 * 
 * Assembly = the compiled output of a C# project (like: .exe or .dll)
 */

/*
 * NOTE TO REVIEW: ".exe and .dll" Types of File:
 * **********************************************
 * .exe:
 *      > Stands for "executable" file
 *      > It is a program we can run directly (like double-clicking to open)
 *      > Example: A desktop app you built in C#
 *      
 * .dll:
 *      > Stands for "Dynamic Link Library"
 *      > It contains code (like classes and methods) that other programs can use
 *      > We cannot run it directly — it's meant to be reused or shared
 *      > Example: A library project with helper functions or business logic
 */
namespace Part04ObjectOrientedBasics
/*
    Class: Person
    Represents a real-world person with essential attributes.
    Follows C# OOP principles and naming conventions.
*/
{
    public class Person
    {
        /*
            Access Modifier(s):
            *******************
            In general, most programming languages support 3 main "Access Modifiers"
            or "Visibility Modifiers":
                - public => Accessible from anywhere (any package/namespace or class)
                - private => Accessible only within the same class
                  (even if other classes are in the same .cs file, they cannot access it)
                - protected => Accessible within the same class 
                  and any class that inherits from it

            In C#, we have (6) "Access Modifiers": 
            (To be discussed in details in other project)
                1. public => Accessible from any other class or assembly.
                2. private => Accessible only within the same class.
                3. protected => Accessible within the same class and by derived classes.
                4. internal => Accessible only within the same assembly.
                5. protected internal => Accessible within the same assembly OR by derived classes.
                6. private protected => Accessible within the same class OR derived classes in the same assembly (C# 7.2+).

            In this example:
            - The class is declared as "public"
                > it can be accessed from other files or projects.
            - The fields (_name, _age, _email) are "private"
                > they are hidden from outside the class, supporting encapsulation.

            Naming Convention:
                > PascalCase for class names and public members
                > camelCase for method parameters or local variables
                > _camelCase for private fields.
        */

        // Encapsulated Fields (private)
        // Fields (private): internal data not exposed directly
        // Naming: _camelCase for private fields (with underscore prefix)
        private string _name;
        private int _age;
        private string _email;
        /*
         * The underscore prefix (_) for private fields:
         * Recommended by Microsoft
         * Widely followed in professional C# codebases
         * Helps avoid ambiguity with method parameters
         * Improves clarity and maintainability
         */

        /*
            Properties: 
            Public members to safely access private fields.
            > "get" returns the value
            > "set" assigns the value
            
            Link: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/using-properties
        */

        /*
        * Properties (public): 
        * controlled access to private fields:
        *   > get => read the value
        *   > set => write/assign a value
        * This is called encapsulation.
        * Link: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/objects
        */
        public string Name
        {
            get { return _name; }
            set { _name = value; } // We could add validation here if needed
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value >= 0)
                    _age = value;
                else
                    Console.WriteLine("Invalid age! Must be non-negative value.");
            }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        /*
            Default Constructor:
            ********************
            Initializes with default values.
            Called when object is created with no arguments.

            Link: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/constructors
        */
        public Person()
        {
            _name = "Unknown";
            _age = 0;
            _email = "unknown@example.com";
        }

        /*
            Parameterized Constructor:
            Initializes an object with real values at time of creation.
            
            - Demonstrates use of "this" keyword to refer to the current object's field.
            - Avoids naming confusion between parameters and class fields.

            Link: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/using-this
        */
        public Person(string name, int age, string email)
        {
            /*
             * "this" refers to the current object's field 
             * (helps avoid conflict with parameter names)
            */
            this._name = name;
            this._age = age;
            this._email = email;
        }

        /*
            Method: GetPersonInfo
            Returns formatted details about the person.

            Best practice: 
            use methods to encapsulate functionality inside a class.
        */
        public string GetPersonInfo()
        {
            string details = $"Name: {_name}\nAge: {_age}\nEmail: {_email}";
            return details;
        }

        /*
            Method: DisplayPersonInfo
            Prints the person's info to the console.
            Demonstrates void method (no return type).
        */
        public void DisplayPersonInfo()
        {
            Console.WriteLine("= Person Details =");
            Console.WriteLine(GetPersonInfo());
        }
    }
}
/*
    C# Naming Conventions Summary:
    ------------------------------
    Consider the naming conventions for the following coding elements:
    - Class, Struct, Enum => PascalCase like: Person, Book => Public
    - Public Property/Method => PascalCase like: GetInfo(), Name => Public
    - Parameter, Local Variable => camelCase like: name, age => Local Scope
    - Private Field => _camelCase like: _name, _email => Private
    - Private Static Field => s_camelCase like: s_counter => Private Static (advanced)
    - Thread Static Field => t_camelCase like: t_buffer => Thread Static (advanced)
    - Interface => IPascalCase like: IPerson, IDrive => Public
    
    Links:
    - C# Coding Conventions: https://learn.microsoft.com/en-us/dotnet/fundamentals/coding-style/coding-conventions
    - General Naming Conventions: https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/general-naming-conventions
*/