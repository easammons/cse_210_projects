
// Running Activity
public class Running : Activity
{
    private double distanceMiles;

    public Running(DateTime date, int minutes, double distanceMiles)
        : base(date, minutes)
    {
        this.distanceMiles = distanceMiles;
    }

    public override double GetDistance() => distanceMiles;

    public override double GetSpeed()
    {
        return (distanceMiles / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / distanceMiles;
    }

    public override string GetSummary()
    {
        return $"{GetDate():dd MMM yyyy} Running ({GetMinutes()} min) - Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}