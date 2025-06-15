

public class Activity
{

    private string _name;
    private string _description;
    protected int _duration;

    protected string _greeting;
    protected string _desc;
    protected string _end;

    public Activity(string name, string description, int seconds)
    {
        _name = name;
        _description = description;
        _duration = seconds;
    }

    public void DisplayGreeting()
    {
        Console.WriteLine(_greeting);
    }

    public void DisplayDescription()
    {
        Console.WriteLine(_desc);
    }

    public void DisplayEnding()
    {
        Console.WriteLine(_end);
    }

    protected void PauseWithCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000); // 1 second
            Console.Write("\b");
        }
        Console.WriteLine();
    }


}