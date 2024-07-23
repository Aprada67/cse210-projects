using System;
using System.Collections.Generic;
using System.Globalization;

public abstract class Activity
{
    private string _date;
    private double _length;

    public Activity()
    {

    }

    public Activity(string date, double length)
    {
        _date = date;
        _length = length;
    }

    public string GetDate()
    {
        return _date;
    }

    public void SetDate()
    {
        DateTime date = DateTime.Now;
        _date = date.ToString("dd MMM yyyy", CultureInfo.CreateSpecificCulture("en-US"));
    }

    public double GetLength()
    {
        return _length;
    }

    public void SetLength(double length)
    {
        _length = length;
    }

    public abstract double CalculateDistance();

    public abstract double CalculateSpeed();

    public abstract double CalculatePace();

    public abstract string DisplaySummary();
}