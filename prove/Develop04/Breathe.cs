
public class Breathe : Activity
{
    public Breathe(string name, string description, int seconds)
        : base(name, description, seconds)
    {
        _greeting = "Welcome to the Breathing Activity!";
        _desc = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _end = $"You have completed another {_duration} seconds of the breathing activity.";
    }

    public void StartActivity()
    {
        Console.WriteLine();
        DisplayGreeting();
        DisplayDescription();
        Console.Write("\nEnter the duration in seconds: ");
        
        if (int.TryParse(Console.ReadLine(), out int userSeconds))
        {
            _duration = userSeconds;
        }
        else
        {
            Console.WriteLine("Invalid input. Defaulting to 30 seconds.");
            _duration = 30;
        }

        Console.Clear();
        Console.WriteLine("Get ready to begin...");
        Thread.Sleep(2000);

        int cycleDuration = 10; // 3 sec in + 3 sec out
        int elapsed = 0;

        while (elapsed + cycleDuration <= _duration)
        {
            Console.WriteLine("\nBreathe in...");
            PauseWithCountdown(4);

            Console.WriteLine("Hold...");
            PauseWithCountdown(2);

            Console.WriteLine("Now breathe out...");
            PauseWithCountdown(4);

            elapsed += cycleDuration;
        }

        Console.WriteLine();
        DisplayEnding();
    }
}