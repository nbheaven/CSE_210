using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int convertedAddition;
        int cumulativeNumber = 0;
        do
        {
            Console.WriteLine("Enter a number");
            string addition = Console.ReadLine();
            convertedAddition = int.Parse(addition);

            numbers.Add(convertedAddition);
        } while (convertedAddition != 0);

        foreach (int number in numbers)
        {
            cumulativeNumber += number;
        }
    }
}