using System.IO.Compression;

public abstract class Activity
{
    protected DateTime _date;
    protected double _minutes;
    public Activity(DateTime date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract string GetSummary();

}