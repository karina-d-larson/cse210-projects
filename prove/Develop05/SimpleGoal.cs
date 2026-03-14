using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string desc, int points)
        : base(name, desc, points)
    {
    }

    public override void CompleteGoal()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string Delimited()
    {
        return $"Simple:{_goalName},{_description},{_pointValue},{_isComplete}";
    }
}