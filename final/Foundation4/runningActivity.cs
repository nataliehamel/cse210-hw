using System;

class runningActivity : activity
{
    private double _distance;

    public runningActivity(DateTime date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / (_length / 60.0);
    }

    public override double GetPace()
    {
        return _length / _distance;
    }

    public override string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} Running ({_length} min) - Distance: {_distance.ToString("0.00")} miles, Speed: {GetSpeed().ToString("0.00")} mph, Pace: {GetPace().ToString("0.00")} min per mile";
    }
}