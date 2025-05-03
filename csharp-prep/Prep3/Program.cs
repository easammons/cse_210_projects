using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("What is your magic number? ");
        // string input1 = Console.ReadLine();
        // int magic = int.Parse(input1);
        Random random = new Random();

        int magic = random.Next(100);
        
        int going = 1;

        while(going == 1)
        {

            Console.WriteLine("What is your guess? ");
            string input2 = Console.ReadLine();
            int guess = int.Parse(input2);


            if (guess == magic)
            {
                Console.WriteLine("You guessed it!");
                break;
            }
            else if(guess > magic)
            {
                Console.WriteLine("Lower");
            }
            else if(guess < magic)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Please enter a number");
            }
        }
    }
}