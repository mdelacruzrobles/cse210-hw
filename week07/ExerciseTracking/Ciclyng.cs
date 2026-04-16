public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, double minutes, double speed)
        : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * _minutes) / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        return $"{_date:dd MMM yyyy} Cycling ({_minutes} min) - " +
           $"Distance {GetDistance():0.0}, " +
           $"Speed {GetSpeed():0.0}, " +
           $"Pace {GetPace():0.0}";
    }
}