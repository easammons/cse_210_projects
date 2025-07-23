public class Cycling : Activity
{
    private double speedMph;

    public Cycling(DateTime date, int minutes, double speedMph)
        : base(date, minutes)
    {
        this.speedMph = speedMph;
    }

    public override double GetSpeed() => speedMph;

    public override double GetDistance()
    {
        return (speedMph * GetMinutes()) / 60;
    }

    public override double GetPace()
    {
        return 60 / speedMph;
    }

    public override string GetSummary()
    {
        return $"{GetDate():dd MMM yyyy} Cycling ({GetMinutes()} min) - Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}