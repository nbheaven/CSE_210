using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string FirstName = Console.ReadLine();

        Console.Write("What is your last Name? ");
        string LastName = Console.ReadLine();

        Console.WriteLine($"Your name is {FirstName} {LastName}");
    }
}