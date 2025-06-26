using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Greg", "History");
        Console.WriteLine(assignment1.GetSummary());
    }
}