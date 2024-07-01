using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your letter grade?");
        string Grade = Console.ReadLine();
        int NumberGrade = int.Parse(Grade);

        if (NumberGrade > 89)
        {
        Console.WriteLine("You have an A");
        }

        else if (NumberGrade > 79)
        {
        Console.WriteLine("You have a B");
        }

        else if (NumberGrade > 69)
        {
        Console.WriteLine("You have a C");
        }

        else if (NumberGrade > 59)
        {
        Console.WriteLine("You have a D");
        }

        else if (NumberGrade < 60)
        {
        Console.WriteLine("You have an F");
        }
    }
}