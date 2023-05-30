using System;

public class outdoorGatheringEvent : Event
{
    public string _weather;

    public outdoorGatheringEvent(string title, string description, DateTime date, TimeSpan time, address address, string weather): base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}Weather: {_weather}";
    }
}