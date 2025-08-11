public class Cycling : Activity
{
    private double _speedKph;

    public Cycling(string date, int minute, double speedKph) : base(date, minute)
    {
        _speedKph = speedKph;
    }

    public override double GetSpeed() => _speedKph;
    public override double GetDistance() => (_speedKph * Minutes) / 60;
    public override double GetPace() => 60 / GetDistance();
}