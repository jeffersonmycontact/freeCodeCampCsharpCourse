using System;

class Program
{
    static void Main()
    {
        string greeting = "Hello";
        string firstName =  "Bob";        

        // string message = greeting + " " + firstName + "!";
        string message = $"{greeting} {firstName}!";
        
        Console.WriteLine(message);
    }
}