using System;

public abstract class Goal
{
    protected string _goalName;
    protected string _description;
    protected int _pointValue;
    protected bool _isComplete;

    public Goal(string name, string desc, int points)
    {
        _goalName = name;
        _description = desc;
        _pointValue = points;
        _isComplete = false;
    }

    public abstract void CompleteGoal();

    public abstract bool IsComplete();

    public virtual void DisplayGoal()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {_goalName} ({_description})");
    }

    public int GetPoints()
    {
        return _pointValue;
    }

    public virtual string Delimited()
    {
        return $"{_goalName},{_description},{_pointValue},{_isComplete}";
    }
}