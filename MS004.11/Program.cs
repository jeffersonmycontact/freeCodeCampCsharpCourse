using System;

class Program
{
    static void Main()
    {
        int fahrenheit = 94;
        double celsius = (fahrenheit - 32D) * (5D/9D);

        Console.WriteLine($"The temperature is {celsius.ToString("N1")} Celsius");
        // .ToString("N1") altera o número de casas decimais para 1
    }
}