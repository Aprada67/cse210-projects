public class Cycling : Activity
{
    private double _speed;

    public Cycling()
    {

    }

    public Cycling(string date, double length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public void SetSpeed(double speed)
    {
        _speed = speed;
    }

    public override double CalculateDistance()
    {
        return _speed * (GetLength() / 60);
    }

    public override double CalculatePace()
    {
        return GetLength() / CalculateDistance();
    }

    public override double CalculateSpeed()
    {
        return _speed;
    }

    public override string DisplaySummary()
    {
        return $"{GetDate()} Cycling ({GetLength()} min): Distance {CalculateDistance():F2} km, Speed: {CalculateSpeed():F2} kph, Pace: {CalculatePace():F2} min per km";
    }
}