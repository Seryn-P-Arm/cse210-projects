using System;

// Swimming class
public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int durationInMinutes, int laps)
        : base(date, durationInMinutes)
    {
        this._laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50) / 1000.0; // 50 meters per lap, converted to km
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetDuration()) * 60;
    }

    public override double GetPace()
    {
        return GetDuration() / GetDistance();
    }
}
