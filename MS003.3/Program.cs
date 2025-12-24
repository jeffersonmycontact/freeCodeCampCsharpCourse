using System;

class Program {
    static void Main() 
    {
        int version = 11;
        string updateText = "Update to Windows";
        string message = $"{updateText} {version}";
        
        Console.WriteLine(message);
    }
}