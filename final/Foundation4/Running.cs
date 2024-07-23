public class Running : Activity
{
    private double _distance;

    public Running()
    {

    }

    public Running(string date, double length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public void SetDistance(double distance)
    {
        _distance = distance;
    }

    public override double CalculateDistance()
    {
        return _distance;
    }

    public override double CalculatePace()
    {
        return GetLength() / _distance;
    }

    public override double CalculateSpeed()
    {
        return _distance / (GetLength() / 60);
    }

    public override string DisplaySummary()
    {
        return $"{GetDate()} Running ({GetLength()} min): Distance {CalculateDistance():F2} km, Speed: {CalculateSpeed():F2} kph, Pace: {CalculatePace():F2} min per km";
    }
}