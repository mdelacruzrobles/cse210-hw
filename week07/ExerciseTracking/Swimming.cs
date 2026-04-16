public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, double minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50) / 1000;
    }

    public override double GetSpeed()
    {
        double _distance = GetDistance();
        return (_distance / _minutes) * 60;
    }
    public override double GetPace()
    {
        double _distance = GetDistance();
        return _minutes / _distance;
    }

    public override string GetSummary()
    {
        return $"{_date:dd MMM yyyy} Swimming ({_minutes} min) - " +
           $"Distance {GetDistance():0.0}, " +
           $"Speed {GetSpeed():0.0}, " +
           $"Pace {GetPace():0.0}";
    }
}