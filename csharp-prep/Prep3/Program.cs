using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
        int convertedGuess;

        do
        {
        Console.Write("What is your guess ");
        string guess = Console.ReadLine();
        convertedGuess = int.Parse(guess);
        } while (convertedGuess != number);

        if (number == convertedGuess){
            Console.WriteLine("Correct!");
        }
    }
}