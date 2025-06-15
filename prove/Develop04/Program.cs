using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        int run = 1;

        while (run == 1)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start Breathing Activity");
            Console.WriteLine(" 2. Start Reflecting Activity");
            Console.WriteLine(" 3. Start Listing Activity");
            Console.WriteLine(" 4. Start Visualization Activity");
            Console.WriteLine(" 5. Quit");
            Console.WriteLine("Select a choice from the menu:");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Breathe breathe = new Breathe("Breathe", "Helps you relax", 0);
                    breathe.StartActivity();
                    break;
                case 2:
                    Reflect reflect = new Reflect("Reflect", "Relax bruh", 0);
                    reflect.StartActivity();
                    break;
                case 3:
                    List list = new List("List", "Focus on gratitude", 0);
                    list.StartActivity();
                    break;
                case 4:
                    Visualization visual = new Visualization("Visualize", "Guided mental imagery", 0);
                    visual.StartActivity();
                    break;
                case 5:
                    Console.WriteLine("Goodbye!");
                    run = 0;
                    break;
                
            }
        }
        



    }
}