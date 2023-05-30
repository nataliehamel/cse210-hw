using System;

public class receptionEvent : Event
{
    public string _RSVP;

    public receptionEvent(string title, string description, DateTime date, TimeSpan time, address address, string RSVP): base(title, description, date, time, address)
    {
        _RSVP = RSVP;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}RSVP: {_RSVP}";
    }
}