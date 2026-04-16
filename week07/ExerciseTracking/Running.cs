public class Running : Activity
{
    private double _distance;
    public Running(DateTime date, double minutes, double distance)
        : base(date, minutes)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return (_distance / _minutes)* 60;
    }
    public override double GetPace()
    {
        double _speed = GetSpeed();
        return (60 / _speed);
    }
    public override string GetSummary()
    {
        return $"{_date:dd MMM yyyy} Running ({_minutes} min) - " +
            $"Distance {GetDistance():0.0}, " +
            $"Speed {GetSpeed():0.0}, " +
            $"Pace {GetPace():0.0}";
    }
}