using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? Round to the nearest whole number. ");
        string grade = Console.ReadLine();
        int percentGrade = int.Parse(grade);

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


        string sign = "";

        if (93 > percentGrade && percentGrade >= 60)
        {
            if (grade[1] >=7)
            {
                sign = "+";  
            }         
        
            else if (grade[1] < 3)
            {
                sign = "-";
            }

            else sign = "";
        }

        else
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");

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