using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type O when finished.");

        List<float> numbers = new List<float>();

        float answer = -1;

        float average = 0;

        float total = 0;

        float largest = 0;

        while (answer != 0)
        {
            Console.Write("Enter number: ");

            answer = float.Parse(Console.ReadLine());

            numbers.Add(answer);
        }

        foreach (float number in numbers)
        {
            total += number;

            if (number > largest)
            {
                largest = number;
            }
        }

        average = total / numbers.Count;

        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}