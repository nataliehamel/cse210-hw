using System;

class cyclingActivity : activity
{
    private double _speed;
    private double _distance;

    public cyclingActivity(DateTime date, int length, double speed) : base(date, length)
    {
        _speed = speed;
        CalculateDistance();
    }

    private void CalculateDistance()
    {
        _distance = (_speed / 60.0) * _length;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60.0 / _speed;
    }

    public override string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} Cycling ({_length} min) - Distance: {GetDistance().ToString("0.00")} miles, Speed: {_speed.ToString("0.00")} mph, Pace: {GetPace().ToString("0.00")} min per mile";
    }
}