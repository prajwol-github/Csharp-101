using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello Mr/Ms.{name}!");
        Console.WriteLine("Hello {0}", name);
        Console.WriteLine("Hi " + name);
    }
}