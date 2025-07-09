using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _targetAmount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetAmount, int bonusPoints) : base(name, description, points)
    {
        _amountCompleted = 0;
        _targetAmount = targetAmount;
        _bonusPoints = bonusPoints;
    }

    public ChecklistGoal(string name, string description, int points, int amountCompleted, int targetAmount, int bonusPoints) : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _targetAmount = targetAmount;
        _bonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        if (IsComplete())
        {
            Console.WriteLine($"You've already completed '{_shortName}' the target {_targetAmount} times. No additional points from regular events.");
            return 0;
        }

        _amountCompleted++;
        int pointsEarned = _points;
        Console.WriteLine($"You have recorded progress for '{_shortName}' and earned {_points} points!");

        if (_amountCompleted == _targetAmount)
        {
            pointsEarned += _bonusPoints;
            Console.WriteLine($"Congratulations! You have completed '{_shortName}' {_targetAmount} times and earned a bonus of {_bonusPoints} points!");
        }
        return pointsEarned;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _targetAmount;
    }

    public override string GetDetailsString()
    {
        string checkbox = IsComplete() ? "[X]" : "[ ]";
        return $"{checkbox} {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_targetAmount}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_amountCompleted},{_targetAmount},{_bonusPoints}";
    }
}