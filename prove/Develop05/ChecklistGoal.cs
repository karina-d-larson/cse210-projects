using System;

public class ChecklistGoal : Goal
{
    private int _completeNum;
    private int _maxNum;
    private int _bonusPoints;

    public ChecklistGoal(string name, string desc, int points, int maxNum, int bonus)
        : base(name, desc, points)
    {
        _completeNum = 0;
        _maxNum = maxNum;
        _bonusPoints = bonus;
    }

    public override void CompleteGoal()
    {
        _completeNum++;

        if (_completeNum >= _maxNum)
        {
            _isComplete = true;
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override void DisplayGoal()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {_goalName} ({_description}) -- Completed {_completeNum}/{_maxNum} times");
    }

    public override string Delimited()
    {
        return $"Checklist:{_goalName},{_description},{_pointValue},{_completeNum},{_maxNum},{_bonusPoints}";
    }
}