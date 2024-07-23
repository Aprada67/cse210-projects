using System.Security.Claims;

public class Swimming : Activity
{
    private int _laps;
    private const double LapDistance = 0.05; // meters

    public Swimming()
    {

    }

    public Swimming(string date, double length, int laps) : base(date, length)
    {
        _laps = laps;
    }

    public void SetLaps(int laps)
    {
        _laps = laps;
    }

    public override double CalculateDistance()
    {
        return _laps * LapDistance;
    }

    public override double CalculatePace()
    {
        return GetLength() / CalculateDistance();
    }

    public override double CalculateSpeed()
    {
        return CalculateDistance() / (GetLength() / 60);
    }

    public override string DisplaySummary()
    {
        return $"{GetDate()} Swimming ({GetLength()} min): Distance {CalculateDistance():F2} km, Speed: {CalculateSpeed():F2} kph, Pace: {CalculatePace():F2} min per km";
    }
}