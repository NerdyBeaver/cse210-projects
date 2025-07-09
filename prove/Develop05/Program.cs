using System;
using System.Collections.Generic;
using System.IO;
//You level up as you get higher scores. For every 1000 points earned, your level increases by one.
class Program
{
    private static List<Goal> _goals = new List<Goal>();
    private static int _currentScore = 0;
    private const string _fileName = "goals.txt";

    private static int GetCurrentLevel()
    {
        return (_currentScore / 1000) + 1;
    }

    static void Main(string[] args)
    {
        LoadGoals();

        bool running = true;
        while (running)
        {
            Console.WriteLine($"\n--- Eternal Quest Program ---");
            Console.WriteLine($"Current Score: {_currentScore} | Level: {GetCurrentLevel()}");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals"); 
            Console.WriteLine("  3. Record Event");
            Console.WriteLine("  4. Save Goals");
            Console.WriteLine("  5. Load Goals");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":  
                    ListGoals();
                    break;
                case "3":
                    RecordGoalEvent();
                    break;
                case "4":
                    SaveGoals();
                    break;
                case "5":
                    LoadGoals();
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
        Console.WriteLine("Thank you for using the Eternal Quest program. Keep striving!");
    }

    static void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalType = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        switch (goalType)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type selected. Goal not created.");
                break;
        }
    }

    static void ListGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("\nNo goals to display. Create some goals first!");
            return;
        }

        Console.WriteLine("\nThe Goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    static void RecordGoalEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("\nNo goals to record an event for. Create some goals first!");
            return;
        }

        Console.WriteLine("\nThe Goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }

        Console.Write("Which goal did you accomplish? ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= _goals.Count)
        {
            Goal selectedGoal = _goals[index - 1];
            
            int pointsEarned = selectedGoal.RecordEvent(); 
            _currentScore += pointsEarned;
            
            Console.WriteLine($"You now have {_currentScore} points!");
        }
        else
        {
            Console.WriteLine("Invalid goal number provided.");
        }
    }

    static void SaveGoals()
    {
        try
        {
            using (StreamWriter outputFile = new StreamWriter(_fileName))
            {
                outputFile.WriteLine(_currentScore);
                foreach (Goal goal in _goals)
                {
                    outputFile.WriteLine(goal.GetStringRepresentation());
                }
            }
            Console.WriteLine($"Goals and score saved to {_fileName}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }

    static void LoadGoals()
    {
        if (!File.Exists(_fileName))
        {
            Console.WriteLine("\nNo saved goals found. Starting with an empty list.");
            _goals.Clear();
            _currentScore = 0;
            return;
        }

        try
        {
            _goals.Clear();
            string[] lines = File.ReadAllLines(_fileName);

            if (lines.Length > 0 && int.TryParse(lines[0], out int loadedScore))
            {
                _currentScore = loadedScore;
            }
            else
            {
                _currentScore = 0;
            }

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] parts = line.Split(':');
                string goalType = parts[0];
                string[] data = parts[1].Split(',');

                switch (goalType)
                {
                    case "SimpleGoal":
                        _goals.Add(new SimpleGoal(data[0], data[1], int.Parse(data[2]), bool.Parse(data[3])));
                        break;
                    case "EternalGoal":
                        _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
                        break;
                    case "ChecklistGoal":
                        _goals.Add(new ChecklistGoal(data[0], data[1], int.Parse(data[2]), int.Parse(data[3]), int.Parse(data[4]), int.Parse(data[5])));
                        break;
                    default:
                        Console.WriteLine($"Unknown goal type '{goalType}' found in file. Skipping line.");
                        break;
                }
            }
            Console.WriteLine($"Goals and score loaded from {_fileName}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
            _goals.Clear();
            _currentScore = 0;
        }
    }
}