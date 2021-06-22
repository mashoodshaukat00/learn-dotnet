using System;

namespace OopConcepts.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Human baby = new Human(); // object initialization concepts

            baby.Id = 1;
            baby.FullName = "My baby";

            //getter, setter, default values
            //constructor, private fields, and public properties
            // Reference types and value types
            // Interfaces
            // Polymorphisim
            // Inheritance
            // scope of field, class, namespace
            // .net app entry points
            // project types in .net 
            // general syntax
            // datatype, loops, conditions, switches, assignments, construction, destruction, libraries, their usage, their documentation,
            // how to write documentation in .net project files.

            var myOtherBaby = new Human(); // object mutation, object copy, deep copy, shallow copy, copy by reference, copy by value
            myOtherBaby = baby;
            
            Console.WriteLine($"Created a baby with ID : {baby.Id} of name : {baby.FullName}");
            Console.WriteLine($"Created a baby with ID : {myOtherBaby.Id} of name : {myOtherBaby.FullName}");

            Console.WriteLine($"MyBaby and MyOtherBaby are equal ? {(baby==myOtherBaby)}");
        }
    }
    
}
