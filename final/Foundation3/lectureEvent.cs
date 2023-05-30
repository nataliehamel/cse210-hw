using System;

public class lectureEvent : Event
{
    public string _speaker;
    public int _limitedCapacity;

    public lectureEvent(string title, string description, DateTime date, TimeSpan time, address address, string speaker, int limitedCapacity): base(title, description, date, time, address)
    {
        _speaker = speaker;
        _limitedCapacity = limitedCapacity;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}Speaker: {_speaker}\nLimited Capacity: {_limitedCapacity}";
    }
}