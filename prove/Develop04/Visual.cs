

public class Visualization : Activity
{
    private List<string> _visualizationPrompts = new List<string>
    {
        "Imagine you are walking through a quiet forest. The trees are tall, and the sunlight filters through the leaves.",
        "Picture yourself lying on a warm beach. You hear the waves gently crashing and feel the sun on your skin.",
        "Visualize yourself achieving a goal you've worked hard for. Feel the pride -you have earned it.",
        "Imagine sitting beside a calm lake. The water is still, and you can hear birds singing nearby."
    };

    private List<string> _guidedSteps = new List<string>
    {
        "Take a deep breath and settle into the scene...",
        "Focus on the sounds around you...",
        "Feel the texture of the ground or surface beneath you...",
        "Notice how your body feels as you relax...",
        "Let any distractions drift away as you stay present...",
        "Picture the scene growing more vivid in your mind...",
        "Hold onto the peaceful feeling this place gives you...",
        "Count 3 things that you could touch in this scene... what are the textures?",
        "Can you smell anything?",
        "Can you hear anything?"
    };

    public Visualization(string name, string description, int seconds)
        : base(name, description, seconds)
    {
        _greeting = "Welcome to the Visualization Activity!";
        _desc = "This activity will help you relax by guiding you through a peaceful mental journey.";
        _end = "You have completed the visualization activity. Good job.";
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

        ShowVisualization();
        RunGuidedSteps();
        Console.WriteLine();
        DisplayEnding();
    }

    private void ShowVisualization()
    {
        Random rand = new Random();
        string prompt = _visualizationPrompts[rand.Next(_visualizationPrompts.Count)];

        Console.Clear();
        Console.WriteLine("Visualize the following scene in your mind:\n");
        Console.WriteLine($"> {prompt}");
        Console.WriteLine("\nClose your eyes if you'd like. But you wont be able to read..... We'll begin shortly...");
        Thread.Sleep(4000);
    }

    private void RunGuidedSteps()
    {
        int elapsed = 0;
        int stepDelay = 5; // seconds per guided message
        Random rand = new Random();

        while (elapsed + stepDelay <= _duration)
        {
            string step = _guidedSteps[rand.Next(_guidedSteps.Count)];
            Console.WriteLine($"\n{step}");
            ShowSpinner(stepDelay);
            elapsed += stepDelay;
        }
    }

    private void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        int spinnerIndex = 0;
        int delay = 250;
        int totalLoops = (seconds * 1000) / delay;

        for (int i = 0; i < totalLoops; i++)
        {
            Console.Write(spinner[spinnerIndex]);
            Thread.Sleep(delay);
            Console.Write("\b");
            spinnerIndex = (spinnerIndex + 1) % spinner.Length;
        }
    }
}
