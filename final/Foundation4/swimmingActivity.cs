using System;

class swimmingActivity : activity
{
    private int _laps;

    public swimmingActivity(DateTime date, int length, int laps) : base(date, length)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50.0 / 1000 * 0.62;
    }

    public override double GetSpeed()
    {
        return GetDistance() / (_length / 60.0);
    }

    public override double GetPace()
    {
        return _length / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} Swimming ({_length} min) - Distance: {GetDistance().ToString("0.00")} miles, Speed: {GetSpeed().ToString("0.00")} mph, Pace: {GetPace().ToString("0.00")} min per mile";
    }
}

