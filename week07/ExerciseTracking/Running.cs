using System;

// Running class
public class Running : Activity
{
    private double _distance; // in km

    public Running(DateTime date, int durationInMinutes, double distance)
        : base(date, durationInMinutes)
    {
        this._distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / GetDuration()) * 60;
    }

    public override double GetPace()
    {
        return GetDuration() / _distance;
    }
}