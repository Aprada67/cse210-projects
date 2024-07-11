public class SimpleGoal : Goal 
{
    private bool _isComplete;

    public SimpleGoal(string shortName, string description, string points, bool isComplete) : base (shortName, description, points)
    {
        _isComplete = isComplete;
    }

    public SimpleGoal()
    {

    }

    public override void RecordEvent(GoalManager manager)
    {
        if (!_isComplete)
        {
            _isComplete = true;
            int points = int.Parse(GetPoints());
            manager.UpdateScore(points);
        }

        Console.WriteLine($"Congratulations you've earned {GetPoints()} poins!");
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"Simple Goal:,{_shortName},{_description},{_points},{_isComplete}";
    }

    public override string GetBasicStringRepresentation()
    {
        return $"Simple Goal: {base.GetDetailString()}";
    }
}