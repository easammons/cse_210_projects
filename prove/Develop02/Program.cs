using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        while (choice != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Menu();
            Console.WriteLine("What would you like to do? ");
            choice = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine("You entered: " + choice);

            switch (choice)
            {
                case 1:
                    string q = Journal.Prompt();
                    Console.WriteLine(q);
                    string userInput = Console.ReadLine();
                    string[] entryArgs = userInput.Split(' ');
                    string entry = Journal.WriteEntry(entryArgs);
                    Entry.SaveEntry(q, entry);
                    break;
                case 2:
                    Entry.LoadEntries();
                    break;
                case 3:
                    Entry.LoadEntries();
                    break;
                case 4:
                    Entry.SaveToFile();
                    break;
                case 5:
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }


        //Entry myday = new Entry();

    }

    static void Menu()
    {
        Console.WriteLine("1.Write");
        Console.WriteLine("2.Display");
        Console.WriteLine("3.Load");
        Console.WriteLine("4.Save");
        Console.WriteLine("5.Quit");
    }

}

