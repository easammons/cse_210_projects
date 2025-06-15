
public class List : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public List(string name, string description, int seconds)
        : base(name, description, seconds)
    {
        _greeting = "Welcome to the Listing Activity!";
        _desc = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _end = "Great job! You've completed the listing activity.";
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

        ShowPrompt();
        BeginListing();
        Console.WriteLine();
        DisplayEnding();
    }

    private void ShowPrompt()
    {
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"> {prompt}");
        Console.WriteLine("\nYou have a few seconds to think...");
        ShowCountdown(5);
    }

    private void BeginListing()
    {
        Console.WriteLine("\nStart listing now! Press Enter after each item:");

        List<string> userItems = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            if (Console.KeyAvailable)
            {
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    userItems.Add(input.Trim());
                }
            }
            else
            {
                Thread.Sleep(100); // prevent tight loop
            }
        }

        Console.WriteLine($"\nYou listed {userItems.Count} item(s)!");
    }

    private void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}