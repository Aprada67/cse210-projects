public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, string points) : base (shortName, description, points) 
    {

    }

    public EternalGoal()
    {

    }

    public override void RecordEvent(GoalManager manager)
    {
        Console.WriteLine($"Congratulations you've earned {GetPoints()} points!");
        int points = int.Parse(GetPoints());
        manager.UpdateScore(points);
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"Eternal Goal:,{_shortName},{_description},{_points}";
    }

    public override string GetBasicStringRepresentation()
    {
        return $"Eternal Goal: {base.GetDetailString()}";
    }
}