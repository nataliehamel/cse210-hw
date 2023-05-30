using System;

public class Event
{
    public string _title;
    public string _description;
    public DateTime _date;
    public TimeSpan _time;
    public address _address;

    public Event(string title, string description, DateTime date, TimeSpan time, address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}";
    }

    public virtual string GetFullDetails()
    {
        return $"{GetStandardDetails()}\n";
    }

    public string GetShortDescription()
    {
        return $"Type: {GetType().Name}\nTitle: {_title}\nDate: {_date}";
    }

}