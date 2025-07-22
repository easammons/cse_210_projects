using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop05 World!");

        // int run = 1;

        // while (run == 1)
        // {
        //     Console.WriteLine("Menu Options:");
        //     Console.WriteLine(" 1. Create New Goal");
        //     Console.WriteLine(" 2. List Goals");
        //     Console.WriteLine(" 3. Save Goals");
        //     Console.WriteLine(" 4. Load Goals");
        //     Console.WriteLine(" 5. Record Event");
        //     Console.WriteLine(" 6. Quit");
        //     Console.WriteLine("Select a choice from the menu:");

        //     int choice = int.Parse(Console.ReadLine());

        //     switch (choice)
        //     {
        //         case 1:
        //             Console.WriteLine("The types of goals are: ");
        //             Console.WriteLine("1. Simple Goal");
        //             Console.WriteLine("2. Eternal Goal");
        //             Console.WriteLine("3. Checklist Goal");
        //             Console.WriteLine("Which type of goal would you like to create?");
        //             int goalChoice = int.Parse(Console.ReadLine());

        //             switch (goalChoice)
        //             {
        //                 case 1:
        //                     Console.WriteLine("You chose a simple goal!");
        //                     break;
        //                 case 2:
        //                     Console.WriteLine("You chose an eternal goal!");
        //                     break;
        //                 case 3:
        //                     Console.WriteLine("You chose a checklist goal!");
        //                     break;
        //             }

        //             break;
        //         case 2:
        //             Console.WriteLine("You chose to list your goals!");
        //             break;
        //         case 3:
        //             Console.WriteLine("You chose to save your goals!");
        //             break;
        //         case 4:
        //             Console.WriteLine("You chose to load your goals!");
        //             break;
        //         case 5:
        //             Console.WriteLine("You chose to record the event!");
        //             break;
        //         case 6:
        //             Console.WriteLine("Goodbye!");
        //             run = 0;
        //             break;

        //     }
        // }

        GoalManager manager = new();
        string fileName = "goals.txt";

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Choose: ");
            string input = Console.ReadLine();
            

            switch (input)
            {
                case "1": manager.CreateGoal(); manager.ShowScore(); break;
                case "2": manager.ShowGoals(); manager.ShowScore(); break;
                case "3": manager.Save(fileName); manager.ShowScore(); break;
                case "4": manager.Load(fileName); manager.ShowScore(); break;
                case "5": manager.RecordEvent(); manager.ShowScore(); break;
                case "6": return;
                
                default: Console.WriteLine("Invalid option."); break;
            }
        }

    }
}