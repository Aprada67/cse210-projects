using System.ComponentModel;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string shortName, string description, string points, int ammountCompleted, int target, int bonus) : base (shortName, description, points)
    {
        _amountCompleted = ammountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public ChecklistGoal()
    {}

    public override void RecordEvent(GoalManager manager)
    {
        _amountCompleted ++;
        Console.WriteLine($"Congratulations you've earned {GetPoints()} poins!");
        int points = int.Parse(GetPoints());
        manager.UpdateScore(points);

        if (_amountCompleted >= _target)
        {
            Console.WriteLine($"Congratulations you've earned a bonus of {_bonus} poins!");
            manager.UpdateScore(_bonus);
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailString()
    {
        return GetBasicStringRepresentation();
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist Goal:,{_shortName},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
    }

    public override string GetBasicStringRepresentation()
    {
        return $"{base.GetDetailString()} -- Currently completed: {_amountCompleted}/{_target}";
    }
}