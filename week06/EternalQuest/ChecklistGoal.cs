using System;
public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int completed = 0) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override int RecordEvent()
    {
        if (!IsComplete())
        {
            _amountCompleted++;

            Console.WriteLine($"Checklist goal recorded: {_shortName} ({_amountCompleted}/{_target})");

            if (_amountCompleted == _target)
            {
                Console.WriteLine($"Bonus earned! +{_bonus} points");

                return _points + _bonus;
            }
            
            return _points;
        }
        
        else
        {
            Console.WriteLine($"Goal already completed: {_shortName}");
            return 0;
        }
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        string check = IsComplete() ? "[X]" : "[]";
        return $"{check} {_shortName} ({_description}) --Curently completed: {_amountCompleted}/{_target}";
        
    }

    public override string GetStringRepresentation()
    {
        
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_target}|{_amountCompleted}|{_bonus}";
    }
}