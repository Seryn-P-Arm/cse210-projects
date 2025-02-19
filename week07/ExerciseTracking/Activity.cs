using System;

// Base class
public abstract class Activity
{
    private DateTime _date;
    private int _durationInMinutes;

    public Activity(DateTime date, int durationInMinutes)
    {
        this._date = date;
        this._durationInMinutes = durationInMinutes;
    }

    public int GetDuration()
    {
        return _durationInMinutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {this.GetType().Name} ({_durationInMinutes} min) - Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
    }
}
