using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        float percentGrade = float.Parse(grade);

        string letter = "";

        if (percentGrade >= 90)
        {
            letter = "A";
        }
        else if (percentGrade >= 80)
        {
            letter = "B";
        }
        else if (percentGrade >= 70)
        {
            letter = "C";
        }
        else if (percentGrade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (percentGrade > 70)
        {
            Console.WriteLine("Congratulations! You passed the course!");
        }

        else
        {
            Console.WriteLine("No worries! You'll ace it next time!");
        }
    }
}